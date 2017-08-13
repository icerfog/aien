using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allieverneed.Calc
{
    public partial class Calculator : Form
    {
        CalculatorController calc;
        public Calculator()
        {
            InitializeComponent();
            MatrixA.Columns.Add("a1", "");
            MatrixA.Rows.Add();
            MatrixB.Columns.Add("b1", "");
            MatrixB.Rows.Add();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Result r = new Result();
        }

        private void m1_ValueChanged(object sender, EventArgs e)
        {
            int i = MatrixA.Columns.Count - (int)(m1.Value = (int)m1.Value);
            if (i == 0) return;
            while (i < 0)
            {
                MatrixA.Columns.Add("a"+(MatrixA.Columns.Count+1).ToString(), "");
                i++;
            }
            while (i > 0)
            {
                MatrixA.Columns.Remove("a" + MatrixA.Columns.Count.ToString());
                i--;
            }
        }


        private void n1_ValueChanged(object sender, EventArgs e)
        {
            int i = MatrixA.Rows.Count - (int)(n1.Value = (int)n1.Value);
            if (i == 0) return;
            if (i < 0)
                MatrixA.Rows.Add(-i);
            while (i > 0)
            {
                MatrixA.Rows.Remove(MatrixA.Rows[0]);
                i--;
            }
        }        

        private void m2_ValueChanged(object sender, EventArgs e)
        {
            int i = MatrixB.Columns.Count - (int)(m2.Value = (int)m2.Value);
            if (i == 0) return;
            while (i < 0)
            {
                MatrixB.Columns.Add("b" + (MatrixB.Columns.Count + 1).ToString(), "");
                i++;
            }
            while (i > 0)
            {
                MatrixB.Columns.Remove("b" + MatrixB.Columns.Count.ToString());
                i--;
            }
        }

        private void n2_ValueChanged(object sender, EventArgs e)
        {
            int i = MatrixB.Rows.Count - (int)(n2.Value = (int)n2.Value);
            if (i == 0) return;
            if (i < 0)
                MatrixB.Rows.Add(-i);
            while (i > 0)
            {
                MatrixB.Rows.Remove(MatrixB.Rows[0]);
                i--;
            }
        }
    }
}
