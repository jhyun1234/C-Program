using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Shield : IItem, IWaitTime
    {
        public void Use()
        {
            Console.WriteLine("Use Shiled");
        }

        public void Wait(float timer)
        {
            Console.WriteLine("wait time :" + timer);
        }
    }
}
