using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Sort
    {
        public void hobab(ref int[] a)
        {
           
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int x;
                        x = a[j + 1];

                        a[j + 1] = a[j];
                        a[j] = x;
                    }
                }
            }
        }
    }
}
