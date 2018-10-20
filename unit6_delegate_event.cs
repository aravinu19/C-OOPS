using System;
using System.IO;

namespace ConsoleApp {
    
    public class DelegateEvent{

        public delegate void AttendanceLogHandler(string message);
        public event AttendanceLogHandler EventLog;
        
        public void LogProcess(){

            string reason = null;

            Console.WriteLine("Enter your Name : ");
            string username = Console.ReadLine();

            DateTime time = DateTime.Now;
            int hr = time.Hour;
            int min = time.Minute;
            
            if(hr >= 9){
                Console.WriteLine("Enter the Reason : ");
                reason = Console.ReadLine();
            }

            OnEventLog("Logging the info of " + username);
            
            if(hr >= 9 ){
                OnEventLog("Logged in at " + hr.ToString() + " : " + min.ToString() + " not within time because " + reason);
            }
            
        }
        
        protected void OnEventLog(string message){
            
            if(EventLog != null){
                EventLog(message);
            }
            
        }
        
    }
    
    public class AttendanceLogger{

        FileStream fileStream;
        StreamWriter streamWriter;
        
        public AttendanceLogger(string fn){

            fileStream = new FileStream(fn, FileMode.Append, FileAccess.Write);
            streamWriter = new StreamWriter(fileStream);
            
        }
        
        public void Logger(string LogInfo){

            streamWriter.WriteLine(LogInfo);
            
        }
        
        public void close(){

            fileStream.Close();
            streamWriter.Close();
            
        }
        
    }
    
    public class RecordAttendance{
        
        static void Logger(string LogInfo){
            Console.WriteLine(LogInfo);
        }
        
        public static void Main(string[] ars){

            AttendanceLogger attendanceLogger = new AttendanceLogger("hello.txt");
            DelegateEvent delegateEvent = new DelegateEvent();

            delegateEvent.EventLog += new DelegateEvent.AttendanceLogHandler(Logger);
            delegateEvent.EventLog += new DelegateEvent.AttendanceLogHandler(attendanceLogger.Logger);
            delegateEvent.LogProcess();
            Console.ReadLine();

            attendanceLogger.close();
            
        }
        
    }
    
}