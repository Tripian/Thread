using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace yazlab2
{
    public class MainThread
    {
        public int request = 0;
        public int capacity = 10000;

        public void requestAccept()
        {
            Random rnd = new Random();
            request += rnd.Next(1, 101);
            if (request > capacity)
            {
                request = capacity;
            }
            Thread.Sleep(500);
        }

        public void requestReturn()
        {
            Random rnd = new Random();
            request -= rnd.Next(1, 51);
            if (request < 0)
            {
                request = 0;
            }
            Thread.Sleep(200);
        }
    }
}
