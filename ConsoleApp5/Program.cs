using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{

    class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Введите ax,bx,cx");

            for (int i = 0; i < 3; i++)
            {
                vector.X[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите ay,by,cy");

            for (int i = 0; i < 3; i++)
            {
            vector.Y[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите az,bz,cz");

            for (int i = 0; i < 3; i++)
             {
               vector.Z[i] = int.Parse(Console.ReadLine());
             }

            Console.Write("Векторы a,b,c : ");

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"{vector.X[i]},{vector.Y[i]},{vector.Z[i]}");
            }

            Console.WriteLine(vector.GetL());
            /*
            Console.WriteLine("длинна ветора a: " + vector.GetLa()) ;
            */     
        }
    }

}