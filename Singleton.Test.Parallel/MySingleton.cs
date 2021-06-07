using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;

namespace Singleton.Test
{
	internal interface IMySingleton
	{
        int Increase();
	}
	public class MySingleton : IMySingleton
    {
        private static readonly ThreadLocal<MySingleton> instance = new ThreadLocal<MySingleton>(() => new MySingleton());

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static MySingleton()
        {
        }

        private MySingleton()
        {
        }

        public static MySingleton Instance
        {
            get
            {               
                return instance.Value;
            }
        }

        private int _value;
		public int Increase()
		{
            _value++;
            return _value;
		}
	}
}		
