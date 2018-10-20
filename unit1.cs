using System;

namespace ConsoleApplication1{
    
    class Sales{

        string item;
        int qty;
        float price, total;
        
        public void input(){

            Console.WriteLine("Enter the item : ");
            item = Console.ReadLine();

            Console.WriteLine("Enter qty : ");
            qty = Convert.ToInt32(Console.ReadLine());
            
        }
        
        public void calc(){
            
            if(item == "pen"){
                price = 10;
            }else if(item == "pencil"){
                price = 5;
            }

            total = qty * price;
            
        }
        
        public void output(){
            Console.WriteLine("Total : {0}", total);
        }
        
    }
    
    class Program
    {
        static void Main(string[] commandLineArgs){

            Sales sales = new Sales();

            sales.input();
            sales.calc();
            sales.output();
            Console.ReadLine();
            
        }
    }
    
}