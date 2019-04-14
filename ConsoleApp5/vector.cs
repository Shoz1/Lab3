using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    
    public class vector
    {
        private static double[] x = new double[3];
        private static double[] y = new double[3];
        private static double[] z = new double[3];

        public static double[] X { get => x; set => x = value; }
        public static double[] Y { get => y; set => y = value; }
        public static double[] Z { get => z; set => z = value; }
        public static double la,lb,lc;
        public static double result;




        /*public static double operator +( A, B)
        {
           return A + B;
        }*/

        public static double GetL()
        {

            la = Math.Sqrt(Math.Pow(X[0], 2) + Math.Pow(Y[0], 2) + Math.Pow(Z[0], 2));
            lb = Math.Sqrt(Math.Pow(X[1], 2) + Math.Pow(Y[1], 2) + Math.Pow(Z[1], 2));
            lc = Math.Sqrt(Math.Pow(X[2], 2) + Math.Pow(Y[2], 2) + Math.Pow(Z[2], 2));

            return result; 
        }
    }   
    
}

