using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {

        static void Main(string[] args)
        {
            const double lightSpeed = 186000d;   // miles per second
            Console.WriteLine("Light speed = {0} Mile Per second", lightSpeed);
            const double mileTokm = 1.609344;
            Console.WriteLine("Light speed = {0} km Per second", lightSpeed * mileTokm);
            Console.WriteLine(" ");
            string[] Planet = new string[9];
            Planet[0] = "SuntoEarth";
            Planet[1] = "SuntoMercury";
            Planet[2] = "SuntoVenus";
            Planet[3] = "SuntoEarth";
            Planet[4] = "SuntoMars";
            Planet[5] = "SuntoJupiter";
            Planet[6] = "SuntoUranus";
            Planet[7] = "SuntoNeptune";
            Planet[8] = "SuntoPluto";
            double[] Distance = new double[9];
            Distance[0] = 93000000d;
            Distance[1] = 35983605d;    
            Distance[2] = 67232362d;    
            Distance[3] = 93000000d;    
            Distance[4] = 141635349d;   
            Distance[5] = 483631838d;   
            Distance[6] = 1785541183d;  
            Distance[7] = 2796791726d;  
            Distance[8] = 3694610958d;  
            for (int i = 0; i < Distance.Length; i++)
            {
                Console.WriteLine("{0}Distance = {1} km", Planet[i], Distance[i] * mileTokm);
                double SunTo_TimeOfLight = Distance[i] / lightSpeed;  // miles
                Console.WriteLine("{0}TimeOfLight = {1} seconds", Planet[i], SunTo_TimeOfLight);
                Console.WriteLine("{0}TimeOfLight = {1} minutes", Planet[i], SunTo_TimeOfLight / 60d);
                Console.WriteLine("{0}AU = {1} A.U.", Planet[i], Distance[i] / Distance[2]);
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        
    }
    }
}
