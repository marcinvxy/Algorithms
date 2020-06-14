using System;
using System.Windows.Forms;

namespace Algorytmy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FibonacciSequence_Click(object sender, EventArgs e)
        {
            FibonacciPanel.Visible = true;
            FibonacciPanel.Location = new System.Drawing.Point(220, 100);
            PasekPanel.Height = FibonacciSequence.Height;
            PasekPanel.Top = FibonacciSequence.Top;
            PasekPanel.Visible = true;
            QuickSortPanel.Visible = false;
            HanoiOfTowerPanel.Visible = false;
        }

        private void TowerOfHanoi_Click(object sender, EventArgs e)
        {
            HanoiOfTowerPanel.Visible = true;
            HanoiOfTowerPanel.Location = new System.Drawing.Point(220, 100);
            PasekPanel.Height = TowerOfHanoi.Height;
            PasekPanel.Top = TowerOfHanoi.Top;
            PasekPanel.Visible = true;
            QuickSortPanel.Visible = false;
            FibonacciPanel.Visible = false;
        }

        private void QuickSort_Click(object sender, EventArgs e)
        {
            QuickSortPanel.Visible = true;
            QuickSortPanel.Location = new System.Drawing.Point(220, 100);
            PasekPanel.Height = QuickSort.Height;
            PasekPanel.Top = QuickSort.Top;
            PasekPanel.Visible = true;
            HanoiOfTowerPanel.Visible = false;
            FibonacciPanel.Visible = false;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int rozmiar = Convert.ToInt32(TabSizeNumeric.Value);
            int[] tablica1 = new int[rozmiar];
            int[] tablica2 = new int[rozmiar];

            for (int i = 0; i < tablica1.Length; i++)
            {
                int a = random.Next(0, 100);
                tablica1[i] = a;
                tablica2[i] = a;
            }

            QuickSort quickSort = new QuickSort();
            czasIterSort.Text = Convert.ToString(quickSort.iteration(tablica1));
            czasRekSort.Text = Convert.ToString(quickSort.recursion(tablica2));
        }

        private void HanoiButton_Click(object sender, EventArgs e)
        {
            int iloscDyskow = Convert.ToInt32(hanoiNumeric.Value);
            TowerOfHanoi towerOfHanoi = new TowerOfHanoi();
            DateTime startTime = DateTime.Now;
            towerOfHanoi.recursion(iloscDyskow, "A", "C", "B");
            DateTime stopTime = DateTime.Now;
            czasHanoiRek.Text = Convert.ToString(stopTime - startTime);

            DateTime startTime2 = DateTime.Now;
            towerOfHanoi.iteration(iloscDyskow);
            DateTime stopTime2 = DateTime.Now;
            czasHanoiIter.Text = Convert.ToString(stopTime2 - startTime2);
        }

        private void RekurencjaButton_Click(object sender, EventArgs e)
        {
            FibonacciSequence fibonacciSequence = new FibonacciSequence();
            DateTime startTime = DateTime.Now;
            fibonacciWynikRek.Text = Convert.ToString(fibonacciSequence.recursion(Convert.ToInt32(fibonacciNumeric.Value)));
            DateTime stopTime = DateTime.Now;
            czasFibonacciRek.Text = Convert.ToString(stopTime - startTime);
        }

        private void IteracjaButton_Click(object sender, EventArgs e)
        {
            FibonacciSequence fibonacciSequence = new FibonacciSequence();
            DateTime startTime = DateTime.Now;
            String a = Convert.ToString(fibonacciSequence.iteration(Convert.ToInt32(fibonacciNumeric.Value)));
            fibonacciWynikIter.Text = a;
            DateTime stopTime = DateTime.Now;
            czasFibonacciIter.Text = Convert.ToString(stopTime - startTime);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QuickSortPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void czasFibonacciRek_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TabSizeNumeric_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}