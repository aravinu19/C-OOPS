using System;
using System.Threading;

namespace ConsoleAdvApp{
    
    class ThreadSchedule{
        
        public static void childThread1(){

            Console.WriteLine("Child Thread 1 started");
            Console.WriteLine("Child Thread - Counting from 1 to 10");

            for (int T = 1; T <= 10; T++){
                for (int Cnt = 0; Cnt < 100; Cnt++) Console.Write(".");
                Console.Write(" {0}", T);
            }

            Console.WriteLine("Child Thread 1 Finished");
            
        }
        
        
        public static void childThread2(){
            
            Console.WriteLine("Child Thread 2 started");
            Console.WriteLine("Child Thread - Counting Slowly from 11 to 20");

            for (int T = 11; T <= 20; T++)
            {
                for (int Cnt = 0; Cnt < 100; Cnt++) Console.Write(".");
                Console.Write(" {0}", T);
            }

            Console.WriteLine("Child Thread 2 Finished");
            
        }
        
        public static void Main(string[] args){

            ThreadStart child1 = new ThreadStart(childThread1);
            ThreadStart child2 = new ThreadStart(childThread2);

            Console.WriteLine("Main - Creating Child Threads");

            Thread thread1 = new Thread(child1);
            Thread thread2 = new Thread(child2);

            thread1.Start();
            thread2.Start();

            Console.ReadLine();
            
        }
        
    }
    
}