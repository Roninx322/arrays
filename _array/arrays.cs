﻿using System;
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

        public arrays exponent(arrays mass, int n)
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




        public double apredelitel(arrays mass)
        {
            double a = 0;
            double massMinApr = 0;

            bool b = false;
            do
            {
                if (mass.data.GetLength(0) > 2 & mass.data.GetLength(1) > 2)
                {
                    for (int i = 0; i < mass.data.GetLength(0); i++)
                    {
                        for (int j = 0; j < mass.data.GetLength(1); j++)
                        {
                            double step = i + j;
                            massMinApr = apredelitel(mini(i, j, mass));
                            a += mass.data[i, j] * Math.Pow(-1, step) * massMinApr;
                        }
                    }
                    b = true;
                }
                else
                {
                    b = true;
                    a = apr_2x2(mass);
                }
            } while (b != true);
            return a;
        }
        public arrays mylt(arrays mass, double a)
        {
            for (int k = 0; k < mass.data.GetLength(0); k++)
            {
                for (int n = 0; n < mass.data.GetLength(1); n++)
                {
                    mass.data[k, n] *= (double)a;
                }
            }
            return mass;
        }
        public arrays mini(int i, int j, arrays mass)
        {
            arrays mass1 = new arrays(mass.data.GetLength(0) - 1, mass.data.GetLength(1) - 1);
            arrays mass2 = new arrays(mass.data.GetLength(0) , mass.data.GetLength(1));

            bool b1 = false;
            for (int i1 = 0; i1 < mass.data.GetLength(0) - 1; i1++)
            {
                for (int j1 = 0; j1 < mass.data.GetLength(1); j1++)
                {
                    if (i == i1)
                        b1 = true;

                    if (b1 == false)
                    {
                        mass2.data[i1, j1] = mass.data[i1, j1];
                    }
                    else
                    {
                        mass2.data[i1, j1] = mass.data[i1 + 1, j1];
                    }
                }
            }
            b1 = false;
            for (int j1 = 0; j1 < mass.data.GetLength(1) - 1; j1++)
            {
                for (int i1 = 0; i1 < mass.data.GetLength(0); i1++)
                {
                    if (j == j1)
                        b1 = true;

                    if (b1 == false)
                    {
                        mass1.data[i1, j1] = mass2.data[i1, j1];
                    }
                    else
                    {
                        mass1.data[i1, j1] = mass2.data[i1, j1 + 1];
                    }
                }
            }

            for (int j1 = 0; j1 < mass.data.GetLength(1) - 1; j1++)
            {
                for (int i1 = 0; i1 < mass.data.GetLength(0) - 1; i1++)
                {
                    mass1.data[i1, j1] = mass2.data[i1, j1];
                }
            }
            return (mass1);
        }
        //1231212123123
        public double apr_2x2(arrays mass)
        {
            return (mass.data[0, 0] * mass.data[1, 1] - mass.data[0, 1] * mass.data[1, 0]);
        }

    }
}
