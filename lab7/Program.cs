using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _920a_Omeniuk_PZ7
{
    internal class Program
    {
        struct Order
        {
            public long payer;
            public long receiver;
            public double sum;
        };


        bool SumDesc(Order a,Order b)
        {
            return a.sum > b.sum;
        }

        private static void Main(string[] args)
        {
            const int NUM_ORDERS = 2;
            Order[] orders = new Order[NUM_ORDERS];
            Order dummy;

            for(int i = 0;i< NUM_ORDERS; ++i)
            {
                Console.WriteLine("\n Порядок: " + i);
                Console.WriteLine("\n Рахунок платника: ");
                orders[i].payer = (long)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n Рахунок одержувача: ");
                orders[i].receiver = (long)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n Гривнiв: ");
                orders[i].sum = (long)Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine("\nРахунок платника для розрахунку суми виплат: ");
            dummy.payer = (long)Convert.ToDouble(Console.ReadLine());

            dummy.sum = 0.0;
            for (int i = 0; i < NUM_ORDERS; ++i) { 
                if (dummy.payer == orders[i].payer) { 
                    dummy.sum += orders[i].sum;
                }
     
            }
            Console.WriteLine(dummy.sum + " суму яку Україна сплачувала з цього рахунку.");

            Array.Sort(orders, (x, y) => x.payer.CompareTo(y.payer));

            for (int i = 0;i< NUM_ORDERS; i++)
            {
                Console.WriteLine(orders[i].payer + "\t" + orders[i].receiver + "\t" + orders[i].sum);
            }
        }
    }
}