namespace Algorytmy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.QuickSort = new System.Windows.Forms.Button();
            this.TowerOfHanoi = new System.Windows.Forms.Button();
            this.FibonacciSequence = new System.Windows.Forms.Button();
            this.QuickSortPanel = new System.Windows.Forms.Panel();
            this.czasRekSort = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.czasIterSort = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TabSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.SortButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.HanoiOfTowerPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.czasHanoiIter = new System.Windows.Forms.Label();
            this.czasHanoiRek = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hanoiNumeric = new System.Windows.Forms.NumericUpDown();
            this.HanoiButton = new System.Windows.Forms.Button();
            this.FibonacciPanel = new System.Windows.Forms.Panel();
            this.IteracjaButton = new System.Windows.Forms.Button();
            this.fibonacciWynikIter = new System.Windows.Forms.Label();
            this.RekurencjaButton = new System.Windows.Forms.Button();
            this.fibonacciWynikRek = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.czasFibonacciIter = new System.Windows.Forms.Label();
            this.czasFibonacciRek = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fibonacciNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.PasekPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.QuickSortPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabSizeNumeric)).BeginInit();
            this.HanoiOfTowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hanoiNumeric)).BeginInit();
            this.FibonacciPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fibonacciNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.QuickSort);
            this.flowLayoutPanel1.Controls.Add(this.TowerOfHanoi);
            this.flowLayoutPanel1.Controls.Add(this.FibonacciSequence);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 600);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Algorithms";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // QuickSort
            // 
            this.QuickSort.FlatAppearance.BorderSize = 0;
            this.QuickSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuickSort.ForeColor = System.Drawing.Color.White;
            this.QuickSort.Image = global::Algorytmy.Properties.Resources.sort__1_;
            this.QuickSort.Location = new System.Drawing.Point(3, 109);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(200, 100);
            this.QuickSort.TabIndex = 6;
            this.QuickSort.Text = "Quick Sort";
            this.QuickSort.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.QuickSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.QuickSort.UseVisualStyleBackColor = true;
            this.QuickSort.Click += new System.EventHandler(this.QuickSort_Click);
            // 
            // TowerOfHanoi
            // 
            this.TowerOfHanoi.FlatAppearance.BorderSize = 0;
            this.TowerOfHanoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TowerOfHanoi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TowerOfHanoi.ForeColor = System.Drawing.Color.White;
            this.TowerOfHanoi.Image = global::Algorytmy.Properties.Resources.tower2;
            this.TowerOfHanoi.Location = new System.Drawing.Point(3, 215);
            this.TowerOfHanoi.Name = "TowerOfHanoi";
            this.TowerOfHanoi.Size = new System.Drawing.Size(200, 100);
            this.TowerOfHanoi.TabIndex = 5;
            this.TowerOfHanoi.Text = "Tower of Hanoi";
            this.TowerOfHanoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TowerOfHanoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TowerOfHanoi.UseVisualStyleBackColor = true;
            this.TowerOfHanoi.Click += new System.EventHandler(this.TowerOfHanoi_Click);
            // 
            // FibonacciSequence
            // 
            this.FibonacciSequence.FlatAppearance.BorderSize = 0;
            this.FibonacciSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FibonacciSequence.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FibonacciSequence.ForeColor = System.Drawing.Color.White;
            this.FibonacciSequence.Image = global::Algorytmy.Properties.Resources.fibo2;
            this.FibonacciSequence.Location = new System.Drawing.Point(3, 321);
            this.FibonacciSequence.Name = "FibonacciSequence";
            this.FibonacciSequence.Size = new System.Drawing.Size(200, 100);
            this.FibonacciSequence.TabIndex = 3;
            this.FibonacciSequence.Text = "Fibonacci Sequence";
            this.FibonacciSequence.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FibonacciSequence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FibonacciSequence.UseVisualStyleBackColor = true;
            this.FibonacciSequence.Click += new System.EventHandler(this.FibonacciSequence_Click);
            // 
            // QuickSortPanel
            // 
            this.QuickSortPanel.AutoSize = true;
            this.QuickSortPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.QuickSortPanel.Controls.Add(this.czasRekSort);
            this.QuickSortPanel.Controls.Add(this.label5);
            this.QuickSortPanel.Controls.Add(this.czasIterSort);
            this.QuickSortPanel.Controls.Add(this.label4);
            this.QuickSortPanel.Controls.Add(this.label3);
            this.QuickSortPanel.Controls.Add(this.TabSizeNumeric);
            this.QuickSortPanel.Controls.Add(this.SortButton);
            this.QuickSortPanel.Controls.Add(this.label2);
            this.QuickSortPanel.Location = new System.Drawing.Point(235, 289);
            this.QuickSortPanel.Name = "QuickSortPanel";
            this.QuickSortPanel.Size = new System.Drawing.Size(1662, 835);
            this.QuickSortPanel.TabIndex = 1;
            this.QuickSortPanel.Visible = false;
            this.QuickSortPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.QuickSortPanel_Paint);
            // 
            // czasRekSort
            // 
            this.czasRekSort.AutoSize = true;
            this.czasRekSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.czasRekSort.ForeColor = System.Drawing.Color.White;
            this.czasRekSort.Location = new System.Drawing.Point(366, 268);
            this.czasRekSort.Name = "czasRekSort";
            this.czasRekSort.Size = new System.Drawing.Size(0, 21);
            this.czasRekSort.TabIndex = 8;
            this.czasRekSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(212, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "rekurencyjnie:";
            // 
            // czasIterSort
            // 
            this.czasIterSort.AutoSize = true;
            this.czasIterSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.czasIterSort.ForeColor = System.Drawing.Color.White;
            this.czasIterSort.Location = new System.Drawing.Point(366, 306);
            this.czasIterSort.Name = "czasIterSort";
            this.czasIterSort.Size = new System.Drawing.Size(0, 21);
            this.czasIterSort.TabIndex = 6;
            this.czasIterSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(234, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "iteracyjnie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(334, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Czas wykonania";
            // 
            // TabSizeNumeric
            // 
            this.TabSizeNumeric.BackColor = System.Drawing.Color.Gray;
            this.TabSizeNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TabSizeNumeric.Location = new System.Drawing.Point(377, 129);
            this.TabSizeNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.TabSizeNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.TabSizeNumeric.Name = "TabSizeNumeric";
            this.TabSizeNumeric.Size = new System.Drawing.Size(120, 27);
            this.TabSizeNumeric.TabIndex = 3;
            this.TabSizeNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TabSizeNumeric.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TabSizeNumeric.ValueChanged += new System.EventHandler(this.TabSizeNumeric_ValueChanged);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(339, 373);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(200, 29);
            this.SortButton.TabIndex = 2;
            this.SortButton.Text = "Sortuj";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wprowadź rozmiar tablicy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HanoiOfTowerPanel
            // 
            this.HanoiOfTowerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.HanoiOfTowerPanel.Controls.Add(this.label7);
            this.HanoiOfTowerPanel.Controls.Add(this.czasHanoiIter);
            this.HanoiOfTowerPanel.Controls.Add(this.czasHanoiRek);
            this.HanoiOfTowerPanel.Controls.Add(this.label10);
            this.HanoiOfTowerPanel.Controls.Add(this.label9);
            this.HanoiOfTowerPanel.Controls.Add(this.label8);
            this.HanoiOfTowerPanel.Controls.Add(this.hanoiNumeric);
            this.HanoiOfTowerPanel.Controls.Add(this.HanoiButton);
            this.HanoiOfTowerPanel.Location = new System.Drawing.Point(449, 127);
            this.HanoiOfTowerPanel.Name = "HanoiOfTowerPanel";
            this.HanoiOfTowerPanel.Size = new System.Drawing.Size(903, 497);
            this.HanoiOfTowerPanel.TabIndex = 2;
            this.HanoiOfTowerPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(231, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(422, 39);
            this.label7.TabIndex = 8;
            this.label7.Text = "Wprowadź liczbę krążków";
            // 
            // czasHanoiIter
            // 
            this.czasHanoiIter.AutoSize = true;
            this.czasHanoiIter.ForeColor = System.Drawing.Color.White;
            this.czasHanoiIter.Location = new System.Drawing.Point(366, 306);
            this.czasHanoiIter.Name = "czasHanoiIter";
            this.czasHanoiIter.Size = new System.Drawing.Size(0, 21);
            this.czasHanoiIter.TabIndex = 7;
            // 
            // czasHanoiRek
            // 
            this.czasHanoiRek.AutoSize = true;
            this.czasHanoiRek.ForeColor = System.Drawing.Color.White;
            this.czasHanoiRek.Location = new System.Drawing.Point(366, 268);
            this.czasHanoiRek.Name = "czasHanoiRek";
            this.czasHanoiRek.Size = new System.Drawing.Size(0, 21);
            this.czasHanoiRek.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(234, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "iteracyjnie:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(212, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "rekurencyjnie:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(334, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "Czas wykonania";
            // 
            // hanoiNumeric
            // 
            this.hanoiNumeric.BackColor = System.Drawing.Color.Gray;
            this.hanoiNumeric.Location = new System.Drawing.Point(377, 129);
            this.hanoiNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hanoiNumeric.Name = "hanoiNumeric";
            this.hanoiNumeric.Size = new System.Drawing.Size(120, 27);
            this.hanoiNumeric.TabIndex = 2;
            this.hanoiNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hanoiNumeric.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // HanoiButton
            // 
            this.HanoiButton.Location = new System.Drawing.Point(339, 373);
            this.HanoiButton.Name = "HanoiButton";
            this.HanoiButton.Size = new System.Drawing.Size(200, 29);
            this.HanoiButton.TabIndex = 0;
            this.HanoiButton.Text = "Przekładaj";
            this.HanoiButton.UseVisualStyleBackColor = true;
            this.HanoiButton.Click += new System.EventHandler(this.HanoiButton_Click);
            // 
            // FibonacciPanel
            // 
            this.FibonacciPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.FibonacciPanel.Controls.Add(this.IteracjaButton);
            this.FibonacciPanel.Controls.Add(this.fibonacciWynikIter);
            this.FibonacciPanel.Controls.Add(this.RekurencjaButton);
            this.FibonacciPanel.Controls.Add(this.fibonacciWynikRek);
            this.FibonacciPanel.Controls.Add(this.label14);
            this.FibonacciPanel.Controls.Add(this.czasFibonacciIter);
            this.FibonacciPanel.Controls.Add(this.czasFibonacciRek);
            this.FibonacciPanel.Controls.Add(this.label13);
            this.FibonacciPanel.Controls.Add(this.label12);
            this.FibonacciPanel.Controls.Add(this.label11);
            this.FibonacciPanel.Controls.Add(this.fibonacciNumeric);
            this.FibonacciPanel.Controls.Add(this.label6);
            this.FibonacciPanel.Location = new System.Drawing.Point(267, 91);
            this.FibonacciPanel.Name = "FibonacciPanel";
            this.FibonacciPanel.Size = new System.Drawing.Size(903, 497);
            this.FibonacciPanel.TabIndex = 3;
            this.FibonacciPanel.Visible = false;
            // 
            // IteracjaButton
            // 
            this.IteracjaButton.Location = new System.Drawing.Point(488, 373);
            this.IteracjaButton.Name = "IteracjaButton";
            this.IteracjaButton.Size = new System.Drawing.Size(200, 29);
            this.IteracjaButton.TabIndex = 12;
            this.IteracjaButton.Text = "Iteracja";
            this.IteracjaButton.UseVisualStyleBackColor = true;
            this.IteracjaButton.Click += new System.EventHandler(this.IteracjaButton_Click);
            // 
            // fibonacciWynikIter
            // 
            this.fibonacciWynikIter.AutoSize = true;
            this.fibonacciWynikIter.ForeColor = System.Drawing.Color.White;
            this.fibonacciWynikIter.Location = new System.Drawing.Point(557, 306);
            this.fibonacciWynikIter.Name = "fibonacciWynikIter";
            this.fibonacciWynikIter.Size = new System.Drawing.Size(0, 21);
            this.fibonacciWynikIter.TabIndex = 11;
            // 
            // RekurencjaButton
            // 
            this.RekurencjaButton.Location = new System.Drawing.Point(238, 373);
            this.RekurencjaButton.Name = "RekurencjaButton";
            this.RekurencjaButton.Size = new System.Drawing.Size(200, 29);
            this.RekurencjaButton.TabIndex = 10;
            this.RekurencjaButton.Text = "Rekurencja";
            this.RekurencjaButton.UseVisualStyleBackColor = true;
            this.RekurencjaButton.Click += new System.EventHandler(this.RekurencjaButton_Click);
            // 
            // fibonacciWynikRek
            // 
            this.fibonacciWynikRek.AutoSize = true;
            this.fibonacciWynikRek.ForeColor = System.Drawing.Color.White;
            this.fibonacciWynikRek.Location = new System.Drawing.Point(557, 265);
            this.fibonacciWynikRek.Name = "fibonacciWynikRek";
            this.fibonacciWynikRek.Size = new System.Drawing.Size(0, 21);
            this.fibonacciWynikRek.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(547, 212);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 30);
            this.label14.TabIndex = 8;
            this.label14.Text = "Wynik";
            // 
            // czasFibonacciIter
            // 
            this.czasFibonacciIter.AutoSize = true;
            this.czasFibonacciIter.ForeColor = System.Drawing.Color.White;
            this.czasFibonacciIter.Location = new System.Drawing.Point(275, 306);
            this.czasFibonacciIter.Name = "czasFibonacciIter";
            this.czasFibonacciIter.Size = new System.Drawing.Size(0, 21);
            this.czasFibonacciIter.TabIndex = 6;
            // 
            // czasFibonacciRek
            // 
            this.czasFibonacciRek.AutoSize = true;
            this.czasFibonacciRek.ForeColor = System.Drawing.Color.White;
            this.czasFibonacciRek.Location = new System.Drawing.Point(275, 268);
            this.czasFibonacciRek.Name = "czasFibonacciRek";
            this.czasFibonacciRek.Size = new System.Drawing.Size(0, 21);
            this.czasFibonacciRek.TabIndex = 5;
            this.czasFibonacciRek.Click += new System.EventHandler(this.czasFibonacciRek_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(125, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 21);
            this.label13.TabIndex = 4;
            this.label13.Text = "iteracyjnie:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(106, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 21);
            this.label12.TabIndex = 3;
            this.label12.Text = "rekurencynie:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(233, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 30);
            this.label11.TabIndex = 2;
            this.label11.Text = "Czas wykonania";
            // 
            // fibonacciNumeric
            // 
            this.fibonacciNumeric.BackColor = System.Drawing.Color.Gray;
            this.fibonacciNumeric.Location = new System.Drawing.Point(377, 129);
            this.fibonacciNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.fibonacciNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fibonacciNumeric.Name = "fibonacciNumeric";
            this.fibonacciNumeric.Size = new System.Drawing.Size(120, 27);
            this.fibonacciNumeric.TabIndex = 1;
            this.fibonacciNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fibonacciNumeric.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(88, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(688, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "Wprowadź n-tą liczbę ciągu Fibonacciego";
            // 
            // PasekPanel
            // 
            this.PasekPanel.BackColor = System.Drawing.Color.DimGray;
            this.PasekPanel.Location = new System.Drawing.Point(209, 12);
            this.PasekPanel.Name = "PasekPanel";
            this.PasekPanel.Size = new System.Drawing.Size(10, 100);
            this.PasekPanel.TabIndex = 4;
            this.PasekPanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.FibonacciPanel);
            this.Controls.Add(this.HanoiOfTowerPanel);
            this.Controls.Add(this.QuickSortPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PasekPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1116, 639);
            this.MinimumSize = new System.Drawing.Size(1116, 639);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.QuickSortPanel.ResumeLayout(false);
            this.QuickSortPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabSizeNumeric)).EndInit();
            this.HanoiOfTowerPanel.ResumeLayout(false);
            this.HanoiOfTowerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hanoiNumeric)).EndInit();
            this.FibonacciPanel.ResumeLayout(false);
            this.FibonacciPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fibonacciNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FibonacciSequence;
        private System.Windows.Forms.Button TowerOfHanoi;
        private System.Windows.Forms.Button QuickSort;
        private System.Windows.Forms.Panel QuickSortPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.NumericUpDown TabSizeNumeric;
        private System.Windows.Forms.Label czasIterSort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label czasRekSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel HanoiOfTowerPanel;
        private System.Windows.Forms.NumericUpDown hanoiNumeric;
        private System.Windows.Forms.Button HanoiButton;
        private System.Windows.Forms.Label czasHanoiIter;
        private System.Windows.Forms.Label czasHanoiRek;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel FibonacciPanel;
        private System.Windows.Forms.Label czasFibonacciIter;
        private System.Windows.Forms.Label czasFibonacciRek;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown fibonacciNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label fibonacciWynikRek;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button RekurencjaButton;
        private System.Windows.Forms.Label fibonacciWynikIter;
        private System.Windows.Forms.Button IteracjaButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PasekPanel;
    }
}

