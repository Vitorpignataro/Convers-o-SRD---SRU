using System;
using Srum.Entities;
using System.Globalization;
namespace Srum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char test = 'N';
                while (test != 'y' || test != 'Y')
                {
                    Console.WriteLine("Type conver:");
                    Console.Write("type 1 for SRU > SRD or type 2 for SRD > SRU: ");
                    int type = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter The resolution (ex: 1024x970)");
                    int N = 2;
                    double[] vec = new double[N];
                    string[] s = Console.ReadLine().Split('x');
                    vec[0] = double.Parse(s[0], CultureInfo.InvariantCulture);
                    vec[1] = double.Parse(s[1], CultureInfo.InvariantCulture);
                    double resX = vec[0];
                    double rexY = vec[1];
                    Console.WriteLine("Input Xmax:");
                    double Xmax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Input Xmin:");
                    double Xmin = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Input X");
                    double Xu = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Input Ymax");
                    double Ymax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Input Ymin");
                    double Ymin = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Input Y");
                    double Yu = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    SrumPro srum = new SrumPro(resX, rexY, Xmax, Xmin, Ymax, Ymin);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("SRD result: " + "(" + srum.SRUTOSRDX(Xu).ToString("f0", CultureInfo.InvariantCulture) + "," + srum.SRUTOSRDY(Yu).ToString("f0", CultureInfo.InvariantCulture) + ")");
                            Console.WriteLine("Done?");
                            test = char.Parse(Console.ReadLine());                           
                            break;

                        case 2:
                            Console.WriteLine("Dale");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);   
            }           
        }
    }
}
