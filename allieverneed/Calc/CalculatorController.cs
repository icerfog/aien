using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allieverneed.Calc
{
    class Matrix<T>
    {
        List<T> row;
        Matrix<T> nextRow = null;
        public int Count { get { return row.Count; } }

        public List<T> Row(int i)
        {
            if (i == 0) return row;
            return nextRow.Row(i-1);

        }
        public Matrix(T[,] array)
        {
            for (int i = 0; i < array.GetUpperBound(1); i++)
            {
                List<T> r = Row(i);
                r = (array.GetValue(i) as T[]).ToList<T>();
            }
        }
    }
    class CalculatorController
    {
        Matrix<int> a, b, r;
        public CalculatorController(int[m] first, int[][] second)
        {
            this.a = first;
            this.b = second;
        }
        public CalculatorController()
        {
        }



    }
}
