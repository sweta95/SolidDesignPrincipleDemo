using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeletonDesignPattern
{
    /// <summary>
    /// We saeled the class from anybody deriving or changing its behaviour.
    /// </summary>
    public sealed class MySingletonClass
    {
        //the voltaile keyword ensure that the instatintiation 
        //is complete before it can be accessed further helping with thread safety
        private static volatile MySingletonClass _instance;
        private static readonly object _syncLock = new object();
        /// <summary>
        ///Nobody outside of class can contruct it.
        /// </summary>
        private MySingletonClass()
        {
        }
        public static MySingletonClass Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new MySingletonClass();
                    }
                }
                return _instance;
            }          
        }
    }
}
