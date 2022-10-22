using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskForLab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Task#1.6
            double L=0;
            double[] a = new double[5];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Введите элемент масиива под инфексом {0}:", i);
                double.TryParse(Console.ReadLine(), out a[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                L += Math.Pow(a[i], 2);
            }
            Console.WriteLine("Длина вектора: {0}", L);
            #endregion

            #region Task#1.10
            int P, Q;
            int[] a1 = new int[10];
            for (int i = 0; i < 10; i ++)
            {
                Console.WriteLine("Введите элемент масива под индексом {0}", i);
                int.TryParse(Console.ReadLine(), out a1[i]);
            }
            Console.WriteLine("Введите P: ");
            int.TryParse(Console.ReadLine(), out P);
            Console.WriteLine("Введите Q: ");
            int.TryParse(Console.ReadLine(), out Q);
            int P1 = Array.FindIndex(a1, i => i == P);
            int Q1 = Array.FindIndex(a1, i => i == Q);
            Console.WriteLine(Math.Abs(P1 - Q1)-1);
            #endregion

            #region Task#1.11
            int[] a2 = new int[10];
            for (int i = 0; i < 10; i ++)
            {
                Console.WriteLine("Введите элемент массива под индексом {0}: ", i);
                int.TryParse(Console.ReadLine(), out a2[i]);
            }
            int[] rez = Array.FindAll(a2, i => i > 0);
            for (int i = 0; i < rez.Length; i++)
                Console.Write("{0:d} ", rez[i]);
            Console.WriteLine();
            #endregion

            #region Task#1.12
            int[] a3 = new int[8];
            for (int i = 0; i < 8; i ++)
            {
                Console.WriteLine("Введите элемент массива под инцексом {0}", i);
                int.TryParse(Console.ReadLine(), out a3[i]);
            }
            int rez3 = Array.FindLastIndex(a3, i => i < 0);
            Console.WriteLine("Знаение {0} и номер {1} последнего отрицательного элемента",a[rez3], rez3);
            #endregion

            #region Task#1.13
            int[] a4 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Введите элемент массива под индексом {0}", i);
                int.TryParse(Console.ReadLine(), out a4[i]);
            }
            int[] re1 = Array.FindAll(a4, i => i > 0);
            int[] re2 = Array.FindAll(a4, i => i < 0);
            for (int i = 0; i < re1.Length; i++)
            {
                Console.Write("{0:d} ", re1[i]);
            }
            Console.WriteLine("-Положительный массив");
            for (int i = 0; i < re2.Length; i++)
            {

                Console.Write("{0:d} ", re2[i]);
            }
            Console.WriteLine("-Отрицательный массив");
            #endregion

            #region Task#2.5
            int elemCount;
            Console.WriteLine("Введите кол-во элеметов массива:");
            int.TryParse(Console.ReadLine(), out elemCount);
            if (elemCount <= 0) Console.WriteLine("Error");
            int[] b = new int[elemCount];
            for (int j = 0; j < b.Length; j++)
            {
                Console.WriteLine("Введите элемент массива под индексом {0}", j);
                int.TryParse(Console.ReadLine(), out b[j]);
            }
            List<double> ans = new List<double>();
            int bmax = b[0], bmin = b[0], jmin = 0, jmax = 0;
            for (int j = 0; j < b.Length; j++)
            {
                if (b[j] > bmax)
                {
                    jmax = j;
                }
                if (b[j] < bmin)
                {
                    jmin = j;
                }
            }
            for (int j = Math.Min(jmin, jmax); j <= Math.Max(jmin, jmax); j++)
            {
                if (b[j] < 0) ans.Add(b[j]);
                else j++;
            }
            double[] rezl = ans.ToArray();
            for (int j = 0; j < rezl.Length; j++)
                Console.WriteLine("{0:f1}", rezl[j]);
            Console.WriteLine();
            #endregion

            #region Task#2.6
            Console.WriteLine("Введите кол-во элементов массива");
            int.TryParse(Console.ReadLine(), out int g);
            if (g <= 0) Console.WriteLine("Error");
            int[] R = new int[g + 1];
            for (int i = 0; i < R.Length - 1; i++)
            {
                Console.WriteLine("Введите элемент под индексом {0}", i);
                int.TryParse(Console.ReadLine(), out R[i]);
            }
            double Sr = R.Sum() / g;
            int ii = 0;
            for (int i = 0; i < g; i++)
            {
                if (Math.Abs(Sr - R[ii]) > Math.Abs(Sr - R[i])) ii = i;
            }
            Console.WriteLine("Введите значение P:");
            int.TryParse(Console.ReadLine(), out int PP);
            for (int i = g - 1; i >= ii + 1; i--)
                R[i + 1] = R[i];
            R[ii + 1] = PP;
            for (int i = 0; i < R.Length; i++)
                Console.Write("{0:d} ", R[i]);
            Console.WriteLine();
            #endregion

            #region Task#2.9
            int elemCount2;
            Console.WriteLine("Введите кол-во элеметов массива:");
            int.TryParse(Console.ReadLine(), out elemCount2);
            if (elemCount2 <= 0) Console.WriteLine("Error");
            double[] b2 = new double[elemCount2];
            for (int j = 1; j < b2.Length; j++)
            {
                Console.WriteLine("Введите элемент массива под индексом {0}", j);
                double.TryParse(Console.ReadLine(), out b2[j]);
            }
            int count2 = 0, jmax2 = 0, jmin2 = 0;
            double max2 = b2[0], min2 = b2[0];
            double sum2 = 0, sr;
            for (int j = 0; j < b2.Length; j++)
            {
                if (max2 < b2[j])
                {
                    max2 = b2[j];
                    jmax2 = j;
                }
                if (min2 > b2[j])
                {
                    min2 = b2[j];
                    jmin2 = j;
                }
            }
            if (jmax2 >= jmin2)
            {
                for (int j = jmin2 + 1; j < jmax2; j++)
                {
                    sum2 += b2[j];
                    count2++;
                }
            }
            if (jmax2 < jmin2)
            {
                for (int j = jmax2 + 1; j < jmin2; j++)
                {
                    sum2 += b2[j];
                    count2++;
                }
            }
            sr = sum2 / count2;
            Console.WriteLine(sr);
            #endregion

            #region Task#2.10
            int elemCount3;
            Console.WriteLine("Введите кол-во элеметов массива:");
            int.TryParse(Console.ReadLine(), out elemCount3);
            if (elemCount3 <= 0) Console.WriteLine("Error");
            double[] b3 = new double[elemCount2];
            for (int j = 0; j < b3.Length; j++)
            {
                Console.WriteLine("Введите элемент массива под индексом {0}", j);
                double.TryParse(Console.ReadLine(), out b3[j]);
            }
            double min3 = b3[0];
            int jmin3 = 0;
            for (int j = 0; j < b3.Length; j++)
            {
                if ((a[j] > 0) && (a[j] < min3))
                {
                    min3 = b3[j];
                    jmin3 = j;
                }
            }
            for (int j = jmin3; j < b2.Length-1;j++)
            {
                b3[j] = b3[j + 1];
            }
            for (int j = 0; j < b3.Length-1; j++)
            {
                Console.WriteLine("{0:f1", b3[j]);
            }
            Console.WriteLine();
            #endregion

            #region Task#2.11
            int elemCount4;
            Console.WriteLine("Введите кол-во элеметов массива:");
            int.TryParse(Console.ReadLine(), out elemCount4);
            if (elemCount4 <= 0) Console.WriteLine("Error");
            double[] b4 = new double[elemCount4 + 1];
            for (int j = 0; j < b4.Length - 1; j++)
            {
                Console.WriteLine("Введите элемент массива под индексом {0}", j);
                double.TryParse(Console.ReadLine(), out b4[j]);
            }
            Console.WriteLine("Введите значение P:");
            double.TryParse(Console.ReadLine(), out double P4);
            int bb = Array.FindLastIndex(b4, j => j > 0);
            for (int i = elemCount4 - 2; i >= bb + 1; i--)
                b4[i + 1] = b4[i];
            b4[bb + 1] = P4;
            for (int j = 0; j < b4.Length; j++)
                Console.WriteLine("{0:f1}", b4[j]);
            Console.WriteLine();
            #endregion

            #region Task#2.13
            int elemCount5;
            Console.WriteLine("Введите кол-во элеметов массива:");
            int.TryParse(Console.ReadLine(), out elemCount5);
            if (elemCount5 <= 0) Console.WriteLine("Error");
            double[] b5 = new double[elemCount5];
            for (int j = 0; j < b5.Length; j++)
            {
                Console.WriteLine("Введите элемент массива под индексом {0}", j);
                double.TryParse(Console.ReadLine(), out b5[j]);
            }
            double mxb5 = b5[0];
            int jmx = 0;
            for (int j = 2; j < b5.Length; j++)
            {
                if (b5[j] > mxb5)
                {
                    mxb5 = b5[j];
                    jmx = j;
                }
            }
            b5[Array.IndexOf(b5, mxb5)] = Array.IndexOf(b5, mxb5);
            for (int j = 0; j < b5.Length; j++)
                Console.WriteLine("{0:f1}", b5[j]);
            Console.WriteLine();
            #endregion

            #region Task#2.15
            Console.WriteLine("Введите размер списка A:");
            int.TryParse(Console.ReadLine(), out int n);
            if (n <= 0) Console.WriteLine("Error");
            List<int> A = new List<int>();
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Введите элемент списка {0}", j);
                int.TryParse(Console.ReadLine(), out int Aj);
                A.Add(Aj);
            }
            Console.WriteLine("Введите размер списка B:");
            int.TryParse(Console.ReadLine(), out int m);
            List<int> B = new List<int>();
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine("Введите элемент списка {0}", j);
                int.TryParse(Console.ReadLine(), out int Bj);
                B.Add(Bj);
            }
            Console.WriteLine("ВВедите k:");
            int.TryParse(Console.ReadLine(), out int k);
            A.InsertRange(k, B);
            int[] rl = A.ToArray();
            for (int j = 0; j < rl.Length; j++)
                Console.WriteLine("{0:d}", rl[j]);
            Console.WriteLine();
            #endregion

            #region Task#3.1
            Console.WriteLine("Введите кол-во элеиментов массива: ");
            int.TryParse(Console.ReadLine(), out int f);
            if (f <= 0) Console.WriteLine("Error");
            double[] arr = new double[f];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите элемент под индексом {0}", i);
                double.TryParse(Console.ReadLine(), out arr[i]);
            }
            List<int> lst = new List<int>();
            double arrmx = arr.Max();
            for (int i = 0; i < f; i++)
            {
                if (arr[i] == arrmx)
                {
                    lst.Add(i);
                }
            }
            int[] rar = lst.ToArray();
            for (int i = 0; i < rar.Length; i++)
                Console.WriteLine("{0:d}", rar[i]);
            Console.WriteLine();
            #endregion

            #region Task#3.5
            Console.WriteLine("Введите кол-во элеиментов массива: ");
            int.TryParse(Console.ReadLine(), out int f1);
            if (f1 <= 0) Console.WriteLine("Error");
            double[] arr1 = new double[f1];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Введите элемент под индексом {0}", i);
                double.TryParse(Console.ReadLine(), out arr1[i]);
            }
            double ij;
            for (int i = 0; i < f1; i += 2)
            {
                for (int j = i + 2; j < f1; j += 2)
                {
                    if (arr1[i] > arr1[j])
                    {
                        ij = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = ij;
                    }
                }

            }
            for (int i = 0; i < f1; i++)
                Console.Write("{0:f1} ", arr1[i]);
            Console.WriteLine();
            #endregion

            #region Task#3.8
            Console.WriteLine("Введите кол-во элементов массива");
            int.TryParse(Console.ReadLine(), out int len);
            if (len <= 0) Console.WriteLine("Error");
            int[] ar = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите элемент массива по индексом {0}", i);
                int.TryParse(Console.ReadLine(), out ar[i]);
            }
            for (int i = 0; i < len - 1; i++)
            {
                if (ar[i] < 0)
                {
                    int armx = ar[i];
                    int imx = i;
                    for (int j = i + 1; j < len; j++)
                    {
                        if (ar[j] > armx && ar[j] < 0)
                        {
                            armx = ar[j];
                            imx = j;
                        }
                    }
                    ar[imx] = ar[i];
                    ar[i] = armx;
                }
            }
            for (int i = 0; i < len; i++)
                Console.Write("{0:d} ", ar[i]);
            Console.WriteLine();
            #endregion

            #region Task#3.9
            Console.WriteLine("Введите кол-во элементов массива");
            int.TryParse(Console.ReadLine(), out int ln);
            if (ln <= 0) Console.WriteLine("Error");
            int[] Arr = new int[ln];
            for (int i = 0; i < ln; i++)
            {
                Console.WriteLine("Введите элемент массива под индексом {0}", i);
                int.TryParse(Console.ReadLine(), out Arr[i]);
            }
            int lnup = 0, lndown = 0, l = 0, ml = 0;
            for (int i = 0; i < ln - 1; i++)
            {
                int up = Arr[i], down = Arr[i], im = i;
                if (Arr[i] < Arr[i + 1])
                {
                    lnup++;
                    lndown = 0;
                    if (lnup > l) l = lnup;
                }
                else if (Arr[i] > Arr[i + 1])
                {
                    lndown++;
                    lnup = 0;
                    if (lndown > ml) ml = lndown;
                }
                else
                {
                    lndown = 0; lnup = 0;
                }
            }
            Console.WriteLine(Math.Max(l, ml) + 1);
            #endregion

            #region Task#3.12
            const int ll = 12;
            int[] aRr = new int[ll];
            for (int i = 0; i < ll; i++)
            {
                Console.WriteLine("Введите элемент под индексом {0}", i);
                int.TryParse(Console.ReadLine(), out aRr[i]);
            }
            int[] nwarr = Array.FindAll(aRr, i => i > 0);
            for (int i = 0; i < nwarr.Length; i++)
                Console.Write("{0:d} ", nwarr[i]);
            Console.WriteLine();
            #endregion

            #region Task#3.13
            Console.WriteLine("Введите кол-во элементов массива");
            int.TryParse(Console.ReadLine(), out int lg);
            if (lg <= 0) Console.WriteLine("Error");
            int[] Rr = new int[lg];
            for (int i = 0; i < lg; i++)
            {
                Console.WriteLine("Введите элемент под индексом {0}", i);
                int.TryParse(Console.ReadLine(), out Rr[i]);
            }
            int[] rezult = Rr.Distinct().ToArray();
            for (int i = 0; i < rezult.Length; i++)
                Console.Write("{0:d} ", rezult[i]);
            Console.WriteLine();
            #endregion
        }
    }
}