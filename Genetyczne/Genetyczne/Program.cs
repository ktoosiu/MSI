using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GA;
using GA.Abstracts;
using Genetyczne.Implementations;

namespace Genetyczne
{
    class Program
    {
        public static double FitnessFunction(double x)
        {
            return (-1 * (x * x) + 100);
        }
        static void Main(string[] args)
        {
            ICrossOperator crossOperator = new OnePointCross();
            IMutationOperator mutationOperator = new Mutatation();
            ISelectionOperator selectionOperator = new RouletteWheelSelection();
            Func<double, double> function = FitnessFunction;
            GeneticAlgorithm algorithm = new GeneticAlgorithm(20, 5, crossOperator, mutationOperator, selectionOperator, function);
            for (int i = 0; i < 10; i++)
            {
            Console.WriteLine(algorithm.RunSimulation(100).Fitness);

            }

            Console.ReadLine();
        }
    }
}
