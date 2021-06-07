﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton.Test
{
	public interface IMySingleton
	{
        Task<int> Increase();
	}
	public class MySingleton : IMySingleton
    {
        private static readonly AsyncLocal<IMySingleton> instance = new AsyncLocal<IMySingleton>();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static MySingleton()
        {
            
        }

        private MySingleton()
        {
        }

        public static IMySingleton Instance
        {
            get
            {
                if (instance.Value == null) instance.Value = new MySingleton();
                return instance.Value;
            }
        }

        private int _value;
		public Task<int> Increase()
		{
            _value++;
            return Task.FromResult(_value);
		}
	}
}		
