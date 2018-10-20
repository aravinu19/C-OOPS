using System;

namespace ConsoleApp{
    
    public class AirTicket{
        
        string start, end, name, date, time;
        
        public void input(){
            
            Console.WriteLine("Enter Flight NAme: ");
            name = Console.ReadLine();
            
            Console.WriteLine("Enter flight time : ");
            time  = Console.ReadLine();
            
            Console.WriteLine("Enter flight date : ");
            date = Console.ReadLine();
            
            Console.WriteLine("Entter start place : ");
            start = Console.ReadLine();
            
            Console.WriteLine("Enter destination place : ");
            end = Console.ReadLine();
            
        }
        
        public void print(){
            
            Console.WriteLine("Flight name : {0}", name);
            Console.WriteLine("Flight date : {0}", date);
            Console.WriteLine("Flight time : {0}", time);
            Console.WriteLine("Flight start place : {0}", start);
            Console.WriteLine("Flight end place : {0}", end);
            
        }
        
    }
    
    public class ConfTicket : AirTicket
    {
        
        int seatNo;
        
        public ConfTicket(){}
        
        public void input(){
            base.input();
            Console.WriteLine("Enter the confirmed Seat No : ");
            seatNo = Convert.ToInt32(Console.ReadLine());
        }
        
        public void print(){
            
            base.print();
            Console.WriteLine("Seat No : {0}", seatNo);
            
        }
        
    }
    
    public class WaitingTicket : AirTicket{
        
        int WaitingTicketNo;
        
        public WaitingTicket(){}
        
        public void input(){
            
            base.input();
            Console.WriteLine("Enter WaitingTicket NO : ");
            WaitingTicketNo = Convert.ToInt32(Console.ReadLine());
            
        }
        
        public void print(){
            
            base.print();
            Console.WriteLine("Waiting No : {0}", WaitingTicketNo);
            
        }
        
    }
    
    class HelloWorld
    {
        static void Main(string[] commandLineArgs){
            ConfTicket conf = new ConfTicket();
            conf.input();
            conf.print();
            
            WaitingTicket Waiting = new WaitingTicket();
            Waiting.input();
            Waiting.print();
            
            Console.ReadLine();
        }
    }
    
}