using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equations
{
    internal class Equation
    {
        private double a;
        private double b;
        private double c;

        public Equation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Discriminant()
        {
            return b * b - 4 * a * c;
        }

        public double[] Result()
        {
            double d = this.Discriminant();

            if (d == 0)
            {
                double[] res = new double[1];
                res[0] = (-1 * b) / (2 * a);
                Console.WriteLine("Корень уравнения равен " + res[0]);
                return res;
            }
            else if (d > 0)
            {
                double[] res = new double[2];
                res[0] = (-b + Math.Sqrt(d)) / (2 * a);
                res[1] = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Корни уравнения равны " + res[0] + " и " + res[1]);
                return res;
            }
            else
            {
                double[] res = new double[0];
                Console.WriteLine("Корней не существуют");
                return res;
            }
        }

        public static Equation operator ++(Equation x)
        {
            return new Equation(x.a + 1, x.b + 1, x.c + 1);
        }

        public static Equation operator --(Equation x)
        {
            return new Equation(x.a - 1, x.b - 1, x.c - 1);
        }

        public static implicit operator double(Equation x)
        {
            return x.Discriminant();
        }

        public static explicit operator bool(Equation x)
        {
            return x.Discriminant() >= 0;
        }

        public static bool operator ==(Equation x, Equation y)
        {
            return x.a == y.a && x.b == y.b && x.c == y.c;
        }

        public static bool operator !=(Equation x, Equation y)
        {
            return !(x.a == y.a && x.b == y.b && x.c == y.c);
        }

        public override string ToString()
        {
            return "(a = " + a + "; b = " + b + "; c = " + c + ")";
        }
    }
}
