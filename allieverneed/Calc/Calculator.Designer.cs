namespace allieverneed.Calc
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.NumericUpDown();
            this.m1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MatrixA = new System.Windows.Forms.DataGridView();
            this.n2 = new System.Windows.Forms.NumericUpDown();
            this.m2 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MatrixB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.n1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixB)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Умножить",
            "Разделить",
            "Привести к ступенчатому виду",
            "Вычислить неизвестные",
            "Транспорировать",
            "Посчитать обратную"});
            this.comboBox1.Location = new System.Drawing.Point(354, 288);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(598, 254);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(94, 55);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Посчитать";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(78, 254);
            this.n1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(60, 20);
            this.n1.TabIndex = 6;
            this.n1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n1.ValueChanged += new System.EventHandler(this.n1_ValueChanged);
            // 
            // m1
            // 
            this.m1.Location = new System.Drawing.Point(12, 254);
            this.m1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(60, 20);
            this.m1.TabIndex = 5;
            this.m1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m1.ValueChanged += new System.EventHandler(this.m1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MatrixA);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 236);
            this.panel1.TabIndex = 4;
            // 
            // MatrixA
            // 
            this.MatrixA.AllowUserToAddRows = false;
            this.MatrixA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MatrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixA.ColumnHeadersVisible = false;
            this.MatrixA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatrixA.Location = new System.Drawing.Point(0, 0);
            this.MatrixA.Name = "MatrixA";
            this.MatrixA.RowHeadersVisible = false;
            this.MatrixA.Size = new System.Drawing.Size(338, 236);
            this.MatrixA.TabIndex = 0;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(420, 254);
            this.n2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(60, 20);
            this.n2.TabIndex = 5;
            this.n2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n2.ValueChanged += new System.EventHandler(this.n2_ValueChanged);
            // 
            // m2
            // 
            this.m2.Location = new System.Drawing.Point(354, 254);
            this.m2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(60, 20);
            this.m2.TabIndex = 4;
            this.m2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m2.ValueChanged += new System.EventHandler(this.m2_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MatrixB);
            this.panel2.Location = new System.Drawing.Point(354, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 236);
            this.panel2.TabIndex = 3;
            // 
            // MatrixB
            // 
            this.MatrixB.AllowUserToAddRows = false;
            this.MatrixB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MatrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixB.ColumnHeadersVisible = false;
            this.MatrixB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatrixB.Location = new System.Drawing.Point(0, 0);
            this.MatrixB.Name = "MatrixB";
            this.MatrixB.RowHeadersVisible = false;
            this.MatrixB.Size = new System.Drawing.Size(338, 236);
            this.MatrixB.TabIndex = 0;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 321);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.m2);
            this.Controls.Add(this.m1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.comboBox1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.n1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MatrixB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.NumericUpDown n1;
        private System.Windows.Forms.NumericUpDown m1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView MatrixA;
        private System.Windows.Forms.NumericUpDown n2;
        private System.Windows.Forms.NumericUpDown m2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView MatrixB;
    }
}