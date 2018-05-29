using System;
using System.Data.SqlTypes;
using System.Linq;
using GA.Abstracts;
using GA.BasicTypes;

namespace Genetyczne.Implementations
{
    public class OnePointCross : ICrossOperator
    {
        public void Crossover(Individual parent1, Individual parent2)
        {
            int length = parent1.Chromosome.Chromosome.Length;
            if (length == parent2.Chromosome.Chromosome.Length)
            {
                Random _random = new Random();
                int crossPoint = _random.Next(length);

                bool[] ch1 = new bool[length];
                bool[] ch11 = parent1.Chromosome.Chromosome.Take(crossPoint).ToArray();
                bool[] ch12= parent2.Chromosome.Chromosome.Skip(crossPoint).ToArray();
                Array.Copy(ch11, ch1, length);
                Array.Copy(ch12, 0, ch1, length, length);

                bool[] ch2 = new bool[length];
                bool[] ch21 = parent2.Chromosome.Chromosome.Take(crossPoint).ToArray();
                bool[] ch22 = parent1.Chromosome.Chromosome.Skip(crossPoint).ToArray();
                Array.Copy(ch11, ch1, length);
                Array.Copy(ch12, 0, ch1, length, length);
            }


        }
    }
}