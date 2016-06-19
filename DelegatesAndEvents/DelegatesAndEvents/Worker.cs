using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int WorkPerformedHandler(int hours, WorkType workType);

    public class Worker
    {
        public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkCompleted;

        public virtual void DoWork(int hours, WorkType workType)
        {
            // Do work here and notify the customer that work has been performed

            for (int i = 0; i < hours; i++)
            {
                // Raise event
                OnWorkPerformed(i + 1, workType);
            }
            OnWorkCompleted();
            //Work completed
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            //throw new NotImplementedException();
            //WorkPerformedHandler del = WorkPerformed as WorkPerformedHandler;

            //if (del != null)
            //{
            //    del(hours, workType);
            //}

            if (WorkPerformed != null)
            {
                WorkPerformed(hours, workType);
            }

        }

        protected virtual void OnWorkCompleted()
        {
            if (WorkCompleted != null)
            {
                WorkCompleted(this, EventArgs.Empty);
            }

        }
    }
}
