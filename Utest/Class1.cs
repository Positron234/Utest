using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utest
{
    internal class Class1
    {
        public double DuimtoSantimetr(double duim)
        {
            double sm;
            sm=duim*2.54;
            return sm;
        }
        public bool ChetnotChet(int a)
        {
            if (a == 0) throw new ArgumentException("Ноль не имеет четности");
            //если четное то истинно
            if (a%2 == 0) return true;
            return false;
        }
        public int MaxElement(int[] arr)
        {
            if(arr.Length == 0) { return 0; }
            int max=arr[0];
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public int Modul(int a,int b)
        {
            if (b <= 0) throw new ArgumentException("Делитель должен быть >= 0");
            int c = a % b;
            return c;
        }

    }
}
