using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  16. Спортсмен - лыжник начал тренировки, пробежав в первый день 10 км. 
    Каждый следующий день он увеличивал длину пробега на P процентов 
    от пробега предыдущего дня (P — вещественное, 0 < P < 50). 
    По данному P определить, после какого дня суммарный пробег лыжника 
    за все дни превысит 200 км, и вывести найденное количество дней 
    K (целое) и суммарный пробег S (вещественное число).*/

namespace Lab_3_1_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double probeg = 10;
            double S = probeg;
            double P = 10;
            int K = 1;
            Console.WriteLine($"K = {K}, probeg = {probeg}, S = {S}");
            while (S < 200)
            {
                probeg *= 1 + P / 100;
                S += probeg;
                K++;
                Console.WriteLine($"K = {K}, probeg = {probeg}, S = {S}");
            }
            Console.ReadKey();
        }
    }
}
