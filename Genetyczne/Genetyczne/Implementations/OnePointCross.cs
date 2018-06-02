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

                bool[] ch1 =
                    parent1.Chromosome.Chromosome.Take(crossPoint).ToArray()
                        .Concat(parent2.Chromosome.Chromosome.Skip(crossPoint)).ToArray();


                bool[] ch2 =
                    parent2.Chromosome.Chromosome.Take(crossPoint).ToArray()
                        .Concat(parent1.Chromosome.Chromosome.Skip(crossPoint)).ToArray();
                parent1.Chromosome.Chromosome = ch1;
                parent2.Chromosome.Chromosome = ch2;

            }
            else throw new Exception("Difrent sizes of chromosomes");

        }
    }
}