using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Cook : IWork
    {
        public void StartLine()
        {
            Console.WriteLine($"Повар начинает готовить еду ");
        }

        public void WorkLine(string line)
        {
            Console.WriteLine($"{line} приготовлено");
        }

        public void WorkLineAndNextLine(string line, string nextLine)
        {
            Console.WriteLine($"{line} приготовлено. Следующая еда - {nextLine}");
        }

        public void EndLine()
        {
            Console.WriteLine("Вся еда приготовлена. Повар заканчивает рабочий день.");
        }
    }
}