using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Control
    {
        protected IWork worker;
        public Control(IWork newWorker)
        {
            worker = newWorker;
        }

        public void ReControl(IWork newWorker)
        {
            worker = newWorker;
        }

        public void Voice(List<string> foodList)
        {
            var count = foodList.Count();           
            worker.StartLine();
            for (int i = 0; i <= count - 2; i++)
            {
                worker.WorkLineAndNextLine(foodList[i], foodList[i + 1]);
            }
            worker.WorkLine(foodList[count - 1]);
            worker.EndLine();
        }

    }
}
