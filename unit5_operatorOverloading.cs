using System;

namespace ConsoleApp{

    class Distance
    {

        int m, cm;

        public Distance(int a, int b)
        {

            m = a;
            cm = b;

        }
        
        public static Distance operator*(Distance x, Distance y)
        {
            Distance z = new Distance(0, 0);
            z.m = x.m * y.m;
            z.cm = x.cm * y.cm;
            return z;
        }
        
        public void display(){

            Console.WriteLine("Meters : {0}", m);
            Console.WriteLine("CentiMeters : {0}", cm);
            
        }
        
    }
    
    class MainProgram{
        
        public static void Main(string[] args){

            Distance d1 = new Distance(10, 20);
            Distance d2 = new Distance(30, 40);
            Distance d3 = new Distance(0, 0);

            d3 = d2 * d1;

            d1.display();
            d2.display();
            d3.display();

            Console.ReadLine();
            
        }
        
    }
    
}