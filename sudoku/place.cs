using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku
{
    class place
    {
        public int data;
        public int[] D;
        public bool is_checked, is_true;

        public place()
        {
            data = 0;
            D = new int[9];
            for (int i = 1; i < 10; i++)
            {
                D[i - 1] = i;
            }
            is_checked = false;
            is_true = true;
        }
        public place(int data1)
        {
            data = data1;
        }
    }
}
