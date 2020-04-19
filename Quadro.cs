using System;

namespace ClassLibrary
{
    public class Quadro
    {
        private double a;
        private double b;
        private double c;
        public double A
        {
            get { return a; }
            set { if (value > 0) a = value; }
        }
        public double B
        {
            get { return b; }
            set { if (value > 0) b = value; }
        }
        public double C
        {
            get { return c; }
            set { if (value > 0) c = value; }
        }
        public Quadro()
        {
            A = 0;
            B = 0;
            C = 0;
        }
        public Quadro (double x,double y, double z)
        {
            A = x;
            B = y;
            C = z;
        }
        public double dis()
        {
            double D = Math.Pow(b,2)-4*a* c;
            if (D>0 || D == 0)
            {
               double x1 = (-b + Math.Sqrt(D)) / (2 * a);
               double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            }
            else 
            {
                Console.WriteLine("Корней нет");
            }   
            return D;
        }
    }
}
