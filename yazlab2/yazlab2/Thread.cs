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
        public int mrequest = 0;
        public int mcapacity = 10000;

        /*public void requestAccept()
        {
            Random rnd = new Random();
            mrequest += rnd.Next(1, 101);
            if (mrequest > mcapacity)
            {
                mrequest = mcapacity;
            }
            Thread.Sleep(500);
        }

        public void requestReturn()
        {
            Random rnd = new Random();
            mrequest -= rnd.Next(1, 51);
            if (mrequest < 0)
            {
                mrequest = 0;
            }
            Thread.Sleep(200);
        }*/

        public void mainRequest()
        {
            Random rnd = new Random();
            mrequest += rnd.Next(1, 101);
            if (mrequest > mcapacity)
            {
                mrequest = mcapacity;
            }
            Thread.Sleep(200);
        
            Random rnd1 = new Random();
            mrequest -= rnd1.Next(1, 51);
            if (mrequest < 0)
            {
                mrequest = 0;
            }
            Thread.Sleep(300);
        }

    }

    public class SubThreads : MainThread
    {
        public int srequest = 0;
        public int scapacity = 5000;

        //public void srequestAccept()
        //{
        //    Random rnd = new Random();
        //    int random,negativeExcess;
        //    random = rnd.Next(1, 51);
        //    mrequest -= random;
        //    if (mrequest < 0)
        //    {
        //        negativeExcess = 0 - mrequest;
        //        mrequest = 0;
        //        srequest -= negativeExcess;
        //    }
        //    srequest += random;

        //    Thread.Sleep(500);
        //}

        //public void srequestReturn()
        //{
        //    Random rnd = new Random();
        //    srequest -= rnd.Next(1, 51);
        //    if (srequest < 0)
        //    {
        //        srequest = 0;
        //    }
        //    Thread.Sleep(300);
        //}

        public void subRequest()
        {
            Random rnd = new Random();
            int random, negativeExcess;
            random = rnd.Next(1, 51);
            mrequest -= random;
            if (mrequest < 0)
            {
                negativeExcess = 0 - mrequest;
                mrequest = 0;
                srequest -= negativeExcess;
            }
            srequest += random;

            Thread.Sleep(300);

            Random rnd1 = new Random();
            srequest -= rnd1.Next(1, 51);
            if (srequest < 0)
            {
                srequest = 0;
            }
            Thread.Sleep(200);
        }

    }

    public class ThreadCreator : SubThreads
    {
        public ThreadCreator(List<Thread> threads , int thrCounter)
        {
            for(int i = 0; i < threads.Count; i++)
            {
                if ()
                {

                }
            }
        }
    }

    public class ThreadWatcher : SubThreads
    {
        public ThreadWatcher(List<Thread> threads)
        {

        }
    }
}
