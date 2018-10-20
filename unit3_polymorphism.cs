using System;

namespace ConsoleApp{
    
    class Shapes{
        
        public virtual void area(){}
        
    }
    
    class Square : Shapes{
        
        public override void area() {
            int length = 10, area;
            Console.WriteLine("Length of Square : {0}", length);
            
            area = length * length;

            Console.WriteLine("Area of Square : {0}", area);
        }
        
    }
    
    class Rectangle : Shapes{

        public override void area(){
            
            int length = 10, breadth = 20, area;
            Console.WriteLine("Length of rectangle : {0}", length);
            Console.WriteLine("Breadth of rectangle : {0}", breadth);
            area = length * breadth;
            Console.WriteLine("Area of Rectangle : {0}", area);
            
        }
        
    }
    
    class MainProgram{
        
        public static void Main(string[] cla){

            Shapes[] shapes = new Shapes[2];
            shapes[0] = new Square();
            shapes[1] = new Rectangle();
            
            foreach(Shapes obj in shapes){
                obj.area();
            }

            Console.ReadLine();
            
        }
        
    }
    
}