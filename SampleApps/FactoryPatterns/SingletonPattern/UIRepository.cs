using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns.SingletonPattern
{
    /// <summary>
    /// Without thread safety
    /// </summary>
   public class UIRepository
   {
       private static UIRepository _instance = null;
        private UIRepository()
        {

        }

        public static UIRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance=new UIRepository();
                }

                return _instance;
            }
        }
        
    }



    /// <summary>
    /// With threadsafety but expensive since lock is an expensive operation
    /// </summary>
    public class UiRepository1
    {
        private static UiRepository1 _instance = null;

        private static object _syncLock=new object();
        private UiRepository1()
        {

        }

        public static UiRepository1 Instance
        {
            get
            {
                lock (_syncLock) //Always locking eventhough instance is already created or not. Which is an expensive operation
                {
                    if (_instance == null)
                    {
                        _instance = new UiRepository1();
                    }
                    return _instance;
                }
            }
        }


    }

    public class UiRepository2
    {
        private static UiRepository2 _instance = null;

        private static object _syncLock = new object();
        private UiRepository2()
        {

        }

        public static UiRepository2 Instance
        {
            get
            {
                if (_instance == null) // if instance already created no need to lock
                {
                    //(1)
                    lock (_syncLock)
                    {
                        //there is a chance that second thread reaches beyond point 1 while first thread is locked. So instance is checked again here
                        if (_instance == null)
                        {
                            _instance = new UiRepository2();
                        }
                      
                    }
                }
                return _instance;
            }
        }


    }

    //All the above are lazy initialization

    public class UiRepository3
    {
        private static UiRepository3 _instance = new UiRepository3();

        private UiRepository3()
        {

        }

        public static UiRepository3 Instance
        {
            get
            {
                if (_instance == null) // if instance already created no need to lock
                {
                    _instance = new UiRepository3();
                }
                return _instance;
            }
        }


    }

    public class UIRepo
    {
        private UIRepo()
        {
            
        }
        private static UIRepo _instance;
        private  static  object lockObj=new object();

        public static UIRepo Instance
        {
            get
            {
                if (_instance == null)
                {
                    //1
                    lock (lockObj)
                    {
                        if (_instance == null)
                        {
                            return _instance = new UIRepo();
                        }
                    }

                }

                return _instance;

            }
        }
    }
    


}
