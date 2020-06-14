using System;

namespace Algorytmy
{
    class QuickSort
    {
        private int[] tab;
        public TimeSpan iteration(int[] tab)
        {
            DateTime startTime = DateTime.Now;
            int dol = 0;
            int gora = tab.Length - 1;
            int[] stos = new int[gora - dol + 1];
            int top = -1;
            stos[++top] = dol;
            stos[++top] = gora;
            while (top >= 0)
            {
                gora = stos[top--];
                dol = stos[top--];
                int t = tab[gora];
                int i = (dol - 1);
                for (int j = dol; j <= gora - 1; j++)
                {
                    if (tab[j] <= t)
                    {
                        i++;
                        int tempp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = tempp;
                    }
                }
                int temp = tab[i + 1];
                tab[i + 1] = tab[gora];
                tab[gora] = temp;
                int p = i + 1;
                if (p - 1 > dol)
                {
                    stos[++top] = dol;
                    stos[++top] = p - 1;
                }
                if (p + 1 < gora)
                {
                    stos[++top] = p + 1;
                    stos[++top] = gora;
                }
            }
            DateTime stopTime = DateTime.Now;
            return stopTime - startTime;
        }

        public TimeSpan recursion(int[] tab1)
        {
            this.tab = tab1;
            DateTime startTime = DateTime.Now;
            quickSortR(0, tab.Length - 1);
            DateTime stopTime = DateTime.Now;
            return stopTime - startTime;
        }

        private void quickSortR(int dol, int gora)
        {
            int lewa = dol, prawa = gora;
            int p = tab[dol + (gora - dol) / 2];
            while (lewa <= prawa)
            {
                while (tab[lewa] < p)
                {
                    lewa++;
                }
                while (tab[prawa] > p)
                {
                    prawa--;
                }
                if (lewa <= prawa)
                {
                    int temp = tab[lewa];
                    tab[lewa] = tab[prawa];
                    tab[prawa] = temp;
                    lewa++;
                    prawa--;
                }
            }
            if (dol < prawa)
                quickSortR(dol, prawa);
            if (lewa < gora)
                quickSortR(lewa, gora);
        }
    }
}