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
            var perc = new Adaline(3);
            double bias = 1;
            var inputs = new double[,]
             {
                {bias, 2, 1},
                {bias, 2, 2},
                {bias, 0, 6},
                {bias, -2, 10},
                {bias, -2, 0},
                {bias, 0, 0},
                {bias, 4, -20}
             };
            var outputs = new double[]
            {
                1, 1, 1, -1, -1, -1, -1
            };
            Console.WriteLine($"\n eps:{perc.CalculateEpsilon(inputs,outputs)} ");
            perc.Train(inputs, outputs,1);
            Console.WriteLine();
            //perc.Test(inputs, outputs);
            Console.ReadLine();

        }
    }
}
