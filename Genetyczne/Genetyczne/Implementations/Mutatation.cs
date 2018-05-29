using System;
using System.Collections.Generic;
using GA.Abstracts;
using GA.BasicTypes;

namespace Genetyczne.Implementations
{
    public class Mutatation : IMutationOperator
    {
        public void Mutation(Individual parent, double mutationProbability)
        {
            Random rand = new Random();
            for (int i = 0; i < parent.Chromosome.Chromosome.Length; i++)
            {
                if (rand.NextDouble()<=mutationProbability)
                {
                    parent.Chromosome.Chromosome[i] =
                        parent.Chromosome.Chromosome[i] == false ? true : false;
                }
            }
        }
    }
}