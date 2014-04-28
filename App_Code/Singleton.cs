using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Singleton
    {
        private static Singleton _singleton;
        // Constructor is 'protected'
        protected Singleton()
        { 

        }

        public static Singleton getInstance()
        {
            if (_singleton == null)
            {

                _singleton = new Singleton();
            }     
        
            return _singleton;
        }

    }
}