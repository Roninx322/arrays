using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _array
{
    class arrays
    {
        int n;
        int m;
        double[,] data;


        public arrays(int n, int m)
        {
            this.n = n;
            this.m = m;
            data = new double[n, m];
        }
        //создание массива
        public void create()
        {
            Random rnd = new Random();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = rnd.Next(1, 10);
                }
            }
        }
        //вывод массивов
        public virtual string print()
        {
            string str = "";
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    str += Convert.ToString(data[i, j]) + " ";
                }
                str += "\r\n";
            }
            return str;
        }

        public static arrays operator +(arrays mass1, arrays mass2)
        {
            arrays buf = new arrays(mass1.data.GetLength(1), mass1.data.GetLength(0));
            if (mass1.data.GetLength(1) == mass2.data.GetLength(0))
                for (int i = 0; i < mass1.data.GetLength(0); i++)
                {
                    for (int j = 0; j < mass1.data.GetLength(1); j++)
                    {
                        buf.data[i, j] = 0;
                        buf.data[i, j] = mass1.data[i, j] + mass2.data[i, j];
                    }
                }
            else
            {
                Console.WriteLine("Error");
                Console.ReadLine();
            }
            return buf;
        }

        public static arrays operator -(arrays mass1, arrays mass2)
        {
            arrays buf = new arrays(mass1.data.GetLength(1), mass1.data.GetLength(0));
            if (mass1.data.GetLength(1) == mass2.data.GetLength(0))
                for (int i = 0; i < mass1.data.GetLength(0); i++)
                {
                    for (int j = 0; j < mass1.data.GetLength(1); j++)
                    {
                        buf.data[i, j] = 0;
                        buf.data[i, j] = mass1.data[i, j] - mass2.data[i, j];
                    }
                }
            else
            {
                Console.WriteLine("Error");
                Console.ReadLine();
            }
            return buf;
        }

        public arrays exponent (arrays mass,int n)
        {
            for (int i = 0; i < n; i++)
            {
                mass *= mass;
            }
           return (mass);
        }
        public static arrays operator *(arrays mass1, arrays mass2)
        {
            arrays buf = new arrays(mass1.data.GetLength(1), mass1.data.GetLength(0));
            if (mass1.data.GetLength(1) == mass2.data.GetLength(0))
                for (int i = 0; i < buf.data.GetLength(0); i++)
                {
                    for (int j = 0; j < buf.data.GetLength(1); j++)
                    {
                        buf.data[i, j] = 0;
                        for (int k = 0; k < mass1.data.GetLength(1); k++)
                        {
                            buf.data[i, j] = buf.data[i, j] + mass1.data[i, k] * mass2.data[k, j];
                        }
                    }
                }
            else
            {
                Console.WriteLine("Error");
                Console.ReadLine();
            }
            return buf;
        }
        public static arrays operator /(arrays mass1, arrays mass2)
        {
            arrays buf = new arrays(mass1.data.GetLength(1), mass1.data.GetLength(0));
            //mass2
            return buf;
        }
        //деление в разработке))
        //
        //
        //public double[,] mylt(double[,] mass, double a)
        //{
        //    for (int k = 0; k < mass.GetLength(0); k++)
        //    {
        //        for (int n = 0; n < mass.GetLength(1); n++)
        //        {
        //            mass[k, n] *= (double)a;
        //        }
        //    }
        //    return mass;
        //}
        //public double[,] mylt(double[,] mass, int a)
        //{
        //    for (int k = 0; k < mass.GetLength(0); k++)
        //    {
        //        for (int n = 0; n < mass.GetLength(1); n++)
        //        {
        //            mass[k, n] *= (double)a;
        //        }
        //    }
        //    return mass;
        //}
        //public double apredelitel(arrays mass)
        //{
        //    double a = 0;
        //    bool b = false;
        //    do
        //    {
        //        if (mass.data.GetLength(0) >= 3)
        //        {
        //            double[,] apr = new double[mass.data.GetLength(0) - 1, mass.data.GetLength(1) - 1];

        //            for (int i = 0; i < mass.data.GetLength(0); i++)
        //            {
        //                for (int j = 0; j < mass.data.GetLength(1); j++)
        //                {
        //                    double[,] mas = mini(i, j, mass.data);
        //                    double a1 = mass.data[i, j] * Math.Pow(-1, i + j);
        //                    mas = mylt(mas, a1);

        //                    for (int n = 0; n < mas.GetLength(0); n++)
        //                    {
        //                        for (int k = 0; k < mas.GetLength(1); k++)
        //                        {
        //                            apr[n, k] += mas[n, k];
        //                        }
        //                    }
        //                }

        //            }
        //            mass.data = apr;
        //        }
        //        else
        //        {
        //            b = true;
        //            a = apr(mass.data);
        //        }
        //    } while (b != true);
        //    return a;
        //}
        //public double[,] mini(int i, int j, double[,] mass)
        //{
        //    for (int i1 = i; i1 < mass.GetLength(0) - 1; i1++)
        //    {
        //        for (int j1 = j; j1 < mass.GetLength(1) - 1; j1++)
        //        {
        //            mass[i1, j1] = mass[i1 + 1, j1];
        //        }
        //    }
        //    for (int j1 = i; j1 < mass.GetLength(0) - 1; j1++)
        //    {
        //        for (int i1 = j; i1 < mass.GetLength(1) - 1; i1++)
        //        {
        //            mass[i1, j1] = mass[i1, j1 + 1];
        //        }
        //    }
        //    double[,] mass1 = new double[mass.GetLength(0) - 1, mass.GetLength(1) - 1];
        //    for (int i1 = 0; i1 < mass1.GetLength(0); i1++)
        //    {
        //        for (int j1 = 0; j1 < mass1.GetLength(1); j1++)
        //        {
        //            mass1[i1, j1] = mass[i1, j1];
        //        }
        //    }

        //    return (mass1);
        //}
        //public double apr(double[,] mass)
        //{
        //    return (mass[0, 0] * mass[1, 1] - mass[0, 1] * mass[1, 0]);
        //}

    }
}
