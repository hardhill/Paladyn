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
        private List<Task> tasks;

        public God()
        {
            tasks = new List<Task>(MAX_ENTIES);
        }

        public List<Task> GetTread()
        {
            return tasks;
        }

        public int Genesis(Textgen textgen)
        {
            var token = new CancellationTokenSource();
            CancellationToken cancelToken = token.Token;

            Task task = new Task(textgen.Live, token.Token);
            
            tasks.Add(task);
            task.Start();
            return tasks.Count;
        }

        public List<String> ListTextgens()
        {
            List<String> otvet = new List<String>();
            for(int i = 0; i < tasks.Count; i++)
            {
                otvet.Add(i.ToString());
            }
            return otvet;
        }

        internal void Kill(int i)
        {
            Task task = tasks[i];
            task = null;
            tasks.RemoveAt(i);
        }
    }
    
}
