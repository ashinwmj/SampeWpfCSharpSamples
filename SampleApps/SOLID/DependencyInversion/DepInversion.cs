using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID.DependencyInversion
{
    //High level modules/classes should not depend on low level modules/classes
   public class DepInversion
    {
    }

   /// <summary>
   /// High level class
   /// </summary>
   public class ExceptionLogger
   {
       public static void LogIntoFile(Exception ex)
       {
           var fileLogger=new FileLogger();  //Depending on low level class
           fileLogger.LogMessage(ex.Message);
       }

       public static void LogIntoDb(Exception ex)
       {
           var dbLogger=new DbLogger();
           dbLogger.LogMessage(ex.Message);
       }

   }

   public class FileLogger
   {
       public void LogMessage(string message)
       {
            //
       }
   }
   public class DbLogger
   {
       public void LogMessage(string message)
       {
            //
       }
   }
   //******************RefactoredCode*************************************************************

   public interface ILogger
   {
       void LogMessage(string message);
   }
   public class FileLoggerRef:ILogger
   {
       public void LogMessage(string message)
       {
           // Log message to the file;
       }
   }

   public class DbLoggerRef:ILogger
   {
       public void LogMessage(string message)
       {
           // Log message to the Db
       }
   }
   public class ExceptionLoggerRef
   {
       private  ILogger _logger;

       public ExceptionLoggerRef(ILogger logger)
       {
           _logger = logger;
       }

       public  void LogException(Exception exception)
       {
           _logger.LogMessage(exception.Message);
       }

   }

    //*****************************************Client code********************************************

    //Before Refactoring
    public class DataExporter
   {
       public void ExportFromFile()
       {
           try
           {

           }
           catch (IOException ex)
           {
               ExceptionLogger.LogIntoDb(ex);
           }
           catch (Exception e)
           {
               ExceptionLogger.LogIntoFile(e);
           }
       }
   }
    //After Refactoring 
    public class DataExporterRef
    {
        public void ExportFromFile()
        {
            try
            {

            }
            catch (IOException ex)
            {
                var exceptionLogger=new ExceptionLoggerRef(new  DbLoggerRef());
                exceptionLogger.LogException(ex);
            }
            catch (Exception e)
            {
                var exceptionLogger=new ExceptionLoggerRef(new FileLoggerRef());
               exceptionLogger.LogException(e);
            }
        }
    }
}
