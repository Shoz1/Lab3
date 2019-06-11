using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_3
{
    class Vector
    {
        double ax;
        double ay;
        double az;

        double bx;
        double by;
        double bz;

        double cx;
        double cy;
        double cz;

        public double GetLA()
        {
            double LA = Math.Abs(Ax) + Math.Abs(Ay) + Math.Abs(Az);

            return LA;
        }

        public double GetLB()
        {
            double LB = Math.Abs(Bx) + Math.Abs(By) + Math.Abs(Bz);

            return LB;
        }

        public double GetLC()
        {          
            double LC = Math.Abs(Cx) + Math.Abs(Cy) + Math.Abs(Cz);

            return LC;
        }

        public string GetScalar()
        {
            double SumX = Ax + Bx + Cx;

            double SumY = Ay + By + Cy;

            double SumZ = Az + Bz + Cz;

            return Convert.ToString(SumX) + " " + Convert.ToString(SumY) + " " + Convert.ToString(SumZ);          
        }

        public string GetVector()
        {
            double SumX = Ax * Bx * Cx;

            double SumY = Ay * By * Cy;

            double SumZ = Az * Bz * Cz;

            return Convert.ToString(SumX) + " " + Convert.ToString(SumY) + " " + Convert.ToString(SumZ);
        }

        public string GetR()
        {
       
            double SumX = Ax + Bx;

            double SumY = Ay + By;

            double SumZ = Az + Bz;

            double ResultX = SumX * Cx;
            double ResultY = SumY * Cy;
            double ResultZ = SumZ * Cz;


            return "\n Вектор r = " + Convert.ToString(ResultX) + " "
                + Convert.ToString(ResultY) + " "
                + Convert.ToString(ResultZ) + " ";
        }

        public string GetT()
        {
            double MultiplyAX = Ax * Cx;
            double MultiplyAY = Ay * Cy;
            double MultiplyAZ = Az * Cz;

            double MultiplyCX = Cx * Cx;
            double MultiplyCY = Cy * Cy;
            double MultiplyCZ = Cz * Cz;

            double ResultX = MultiplyAX * MultiplyCX;
            double ResultY = MultiplyAY * MultiplyCY;
            double ResultZ = MultiplyAZ * MultiplyCZ;



            return "\n Вектор t = " + Convert.ToString(ResultX) + " "
                + Convert.ToString(ResultY) + " "
                + Convert.ToString(ResultZ) + " ";
        }

        public string ToString()        
        {
            return "\nДлина а : " + this.GetLA() + " " 
                + "\nДлина b : " + this.GetLB() + " "
                + "\nДлина c : " + this.GetLC();
        }

        public string ToStringPlus()
        {
            return "\nСумма : " + this.GetScalar();
        }

        public string ToStringYmn()
        {
            return "\nСумма : " + this.GetVector();
        }
        
       

        public double Ax { get => ax; set => ax = value >= 0 ? value : 0; }
        public double Ay { get => ay; set => ay = value >= 0 ? value : 0; }
        public double Az { get => az; set => az = value >= 0 ? value : 0; }

        public double Bx { get => bx; set => bx = value >= 0 ? value : 0; }
        public double By { get => by; set => by = value >= 0 ? value : 0; }
        public double Bz { get => bz; set => bz = value >= 0 ? value : 0; }

        public double Cx { get => cx; set => cx = value >= 0 ? value : 0; }
        public double Cy { get => cy; set => cy = value >= 0 ? value : 0; }
        public double Cz { get => cz; set => cz = value >= 0 ? value : 0; }

    }
}
