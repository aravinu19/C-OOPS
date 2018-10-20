using System;

namespace ConsoleApp{
    
    public interface Fly{

        void speed();
        
    }
    
    class AirPlane : Fly{
        
        public void print(){

            Console.WriteLine("Airplane");
            
        }
        
        public void speed(){

            Console.WriteLine("Fly-High");
            
        }
        
    }
    
    class Bird : Fly{
        
        public void print(){
            Console.WriteLine("Bird");
        }
        
        public void speed(){

            Console.WriteLine("Fly-Low");
            
        }
        
    }
    
    class MainProgram{
        
        public static void Main(string[] args){

            new AirPlane().print();
            new AirPlane().speed();

            new Bird().print();
            new Bird().speed();
            
        }
        
    }
    
}