using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01
{
    class SleepHelper
    {
        public static void SleepAWhile(int second)
        {
            int ms = second;
            
            
            System.Threading.Thread.Sleep(ms);
        }
    }
}
