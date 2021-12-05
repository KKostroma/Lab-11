using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    public class Yravnenie
    {
        public float k;
        public float b;
        public double x;


        public Yravnenie(float k, float b)
        {
            this.k = k;
            this.b = b;
        }

        public void Root()
        {
            double x = -b / k;
            Console.WriteLine("Ответ {0}", x);
        }
    }
}
