using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Program
    {
        static void Main(string[] args)
        {
            var perc = new Perceptron(3);
            var inputs = new double[,]
             {
                {1, 2, 1},
                {1, 2, 2},
                {1, 0, 6},
                {1, -2, 10},
                {1, -2, 0},
                {1, 0, 0},
                {1, 4, -20}
             };
            var outputs = new double[]
            {
                1, 1, 1, -1, -1, -1, -1
            };
            Console.WriteLine($"\n eps:{perc.CalculateEpsilon(inputs,outputs)} ");
            perc.Train(inputs, outputs, 0);
            Console.WriteLine();
            //perc.Test(inputs, outputs);
            Console.ReadLine();

        }
    }
}
