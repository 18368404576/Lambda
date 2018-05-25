using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        public delegate bool ComparisonHandler(int First, int Second);

        static void Main(string[] args)
        {
            int[] items = new int[8];
            for (int i = 0; i < items.Length; i++)
            {
                System.Console.Write("Enter an interger：");
                items[i] = int.Parse(System.Console.ReadLine());
            }
            Bubblesort(items, GreaterThan);
            for(int i = 0;i<items.Length;i++)
            {
                System.Console.WriteLine(items[i]);
                System.Console.Write("测试");
            }
        }

        public static void Bubblesort(int[] items,ComparisonHandler comparisonMethod)
        {
            int temp;

            if(comparisonMethod ==null)
            {
                throw new ArgumentNullException("compaisonMethod");
            }

            if (items == null)
            {
                return;
            }

            for (int i = items.Length - 1; i >= 0; i--)
            {
                for(int j = 1;j<=i;j++)
                {
                    if(comparisonMethod(items[j-1],items[j]))
                    {
                        temp = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = temp;
                    }
                }
            }
           
        }

        public static bool GreaterThan(int First, int Second)
        {
            return First > Second;
        }
    }
}
