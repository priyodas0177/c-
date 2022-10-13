using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    struct Point { // struct keno banaisi/ ki kaje lagbe
        public int x;
        public int y;

        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public void PrintPoint(string info) {
            Console.WriteLine("{2}:({0},{1})", this.x, this.y, info);//{2}:({0},{1}) agulo keno liktesi
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            /* Point p1;
             p1.x = 10;
             p1.y = 20;
             Console.WriteLine("p1:({0},{1})", p1.x,p1.y);*/
            // p1.PrintPoint("p1");

            /*Point p2 = p1;
            p2.x++;
            p2.y--;
            p2.PrintPoint("p2");*/
            // p1.PrintPoint("p1");
            /*Console.WriteLine("p2:({0},{1})", p2.x, p2.y);    //"p2:({0},{1})"  agulo keno liktesi
            Console.WriteLine("p1:({0},{1})", p1.x, p1.y);*/

            /* Point p3 = new Point();
             p3.x = 9;
             p3.y = -34;
             p3.PrintPoint("p3");

             Point p4 = p3;
             p4.x++;
             p4.y--;
             p4.PrintPoint("p4");*/

            int[] ax = new int[4] { 10, 20, 30, 40 };
            ax[0] = 100;

            /*for (byte c = 0; c < ax.Length; c++)
            {
                Console.Write("{0} ", ax[c]);

            }
            Console.WriteLine();*/

            foreach (int info in ax)
            {
                Console.Write("{0} ", info);
            }


        }
    }
}
