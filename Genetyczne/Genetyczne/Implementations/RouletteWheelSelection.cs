using System;
using System.Collections.Generic;
using System.Linq;
using GA.Abstracts;
using GA.BasicTypes;

namespace Genetyczne.Implementations
{
    public class RouletteWheelSelection : ISelectionOperator
    {
        Individual[] ISelectionOperator.GenerateParentPopulation(Individual[] currentPopulation)
        {
            Random _random = new Random();
            Individual[] parents = new Individual[currentPopulation.Length];
            double[] probability = new double[currentPopulation.Length];
            double numberParent;
            double fitnessSum = 0;
            double addValueIfNegative = 0;
            foreach (var chromosome in currentPopulation)
            {
                if (chromosome.Fitness < 0)
                {
                    addValueIfNegative += (chromosome.Fitness * -2);
                }

                fitnessSum += chromosome.Fitness;
            }

            foreach (var chromosome in currentPopulation)
            {
                fitnessSum += addValueIfNegative;
            }

            for (int i = 0; i < currentPopulation.Length; i++)
            {
                probability[i] = currentPopulation[i].Fitness + addValueIfNegative;
                if (i != 0) probability[i] += probability[i - 1];
            }

            for (int i = 0; i < currentPopulation.Length; i++)
            {
                numberParent = _random.NextDouble() * fitnessSum;
                for (int j = 0; j < currentPopulation.Length - 1; j++)
                {
                    if (numberParent > probability[j] && numberParent <= probability[j + 1])
                    {
                        parents[i] = new Individual(currentPopulation[j + 1].Chromosome.Chromosome.Length);
                        parents[i].Chromosome.CloneChromosome(currentPopulation[j + 1].Chromosome);
                    }
                    else if (numberParent >= 0 && numberParent <= probability[j] && j == 0)
                    {
                        parents[i] = new Individual(currentPopulation[j].Chromosome.Chromosome.Length);
                        parents[i].Chromosome.CloneChromosome(currentPopulation[j].Chromosome);
                    }
                }
            }

            return parents;
        }
    }
}