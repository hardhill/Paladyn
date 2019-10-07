using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Paladyn
{
    class God
    {
        const int MAX_ENTIES = 20;
        private List<Thread> threads;
        public God()
        {
            threads = new List<Thread>(MAX_ENTIES);
        }

        public List<Thread> GetTread()
        {
            return threads;
        }

        public int Genesis(Textgen textgen)
        {
            Thread thread = new Thread(new ThreadStart(textgen.Live));
            threads.Add(thread);
            thread.Start();
            return threads.Count;
        }

        public List<String> ListTextgens()
        {
            List<String> otvet = new List<String>();
            for(int i = 0; i < threads.Count; i++)
            {
                otvet.Add(i.ToString());
            }
            return otvet;
        }

        internal void Kill(int i)
        {
           Thread tr = threads[i];
            if (tr.IsAlive)
            {
                try
                {
                    tr.Interrupt();
                    tr.Abort();
                }
                catch(Exception ex)
                {

                }
                finally
                {
                    
                }
                
                threads.Remove(tr);
            }
            
        }
    }
    
}
