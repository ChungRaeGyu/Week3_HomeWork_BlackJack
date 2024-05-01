using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConsoleUtility
{
    public int PromtChoice(int min, int max)
    {
        while (true)
        {
            if(int.TryParse(Console.ReadLine(), out var choice)&&min<=choice&&choice<=max)
            {
                return choice;
            }
        }
    }
}
