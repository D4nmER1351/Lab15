using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Courier : IWork
    {
        public void StartLine()
        {
            Console.WriteLine($"Курьер начинает доставку заказов");
        }

        public void WorkLine(string line)
        {
            Console.WriteLine($"{line} доставлено");
        }

        public void WorkLineAndNextLine(string line, string nextLine)
        {
            Console.WriteLine($"{line} доставлено. Следующий заказ {nextLine}");
        }

        public void EndLine()
        {
            Console.WriteLine("Заказы кончились. Курьер заканчивает рабочий день.");
        }
    }
}
