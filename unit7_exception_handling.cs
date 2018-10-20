using System;

namespace ConsoleApp{
    
    class DivideNos{

        int result;
        
        DivideNos(){
            result = 0;
        }
        
        public void divide(int num1, int num2){
            
            try{
                result = num1 / num2;
            }catch (DivideByZeroException e){
                Console.WriteLine("Exception Caught : {0}", e);
            }finally{
                Console.WriteLine("Result : {0}", result);
            }
            
        }
     
        public static void Main(string[] a){

            DivideNos divide = new DivideNos();

            divide.divide(10, 0);
            Console.ReadLine();
            
        }
        
    }
    
}