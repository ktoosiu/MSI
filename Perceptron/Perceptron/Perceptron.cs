using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace Perceptron
{
    public class Perceptron
    {
        public Func<double, double> ActivationFunction { get; set; }
        public List<double> Weights { get; set; }
        public int NumberOfInputs { get; set; }

        public Perceptron(int numberOfInputs)
        {
            this.NumberOfInputs = numberOfInputs;
            Weights = new List<double>(NumberOfInputs);
            InitWeights();
            ActivationFunction = Signum;


        }

        public void ShowWeights()
        {
            Console.WriteLine();
            for (int i = 0; i < Weights.Count; i++)
            {
                Console.Write($"\tw{i}: {Weights[i]}");
            }
        }

        public void InitWeights(double startRange = 0.01, double endRange = 10.0)
        {
            var random = new Random();
            Console.WriteLine();
            Console.WriteLine("Inicjuję wagi: ");
            for (int i = 0; i < NumberOfInputs; i++)
            {
                Weights.Add(Math.Round(random.NextDouble() * (endRange - startRange)
                    + startRange, 4));
                Console.Write($"\tw{i}: {Weights[i]}  ");
            }
        }
        public void Test(double[,] inputs, double[] outputs, int n = -1)
        {

            for (int i = 0; i < inputs.GetLength(0); i++)
            {
                var temp = new double[inputs.GetLength(1)];
                for (int j = 0; j < temp.Length; j++)
                {
                    temp[j] = inputs[i, j];
                }


                Console.WriteLine($"\n------------ZESTAW {i}------------");
                this.ShowWeights();
                Console.Write($"\t  y: {this.CalculateOutput(temp)}");
                Console.WriteLine();
                for (int l = 0; l < temp.Length; l++)
                {
                    Console.Write($"\tx{l}: {temp[l]}\t");
                }
                Console.Write($"\tf(x): {outputs[i]}");
                Console.WriteLine();

                for (int l = 0; l < temp.Length; l++)
                {
                    Console.Write($" \t{Weights[l] * inputs[i, l]}\t");
                }

                Console.WriteLine();
            }
        }

        //public void Train(double[,] trainInputs, double[] trainOutputs, double epsilon)
        //{
        //    int t = 0;
        //    while (CalculateEpsilon(trainInputs, trainOutputs) > epsilon)
        //    {

        //        for (int i = 0; i < trainOutputs.Length; i++)
        //        {
        //            var temp = new double[trainInputs.GetLength(1)];
        //            for (int j = 0; j < trainInputs.GetLength(1); j++)
        //            {
        //                temp[j] = trainInputs[i, j];

        //            }

        //            Console.WriteLine();
        //            Console.WriteLine();
        //            Console.WriteLine($"------------------------t{t}:----------------------------");

        //            for (int j = 0; j < temp.Length; j++)
        //            {
        //                Console.Write($"x{j}:{temp[j]} \t\t");
        //            }

        //            Console.WriteLine();
        //            for (int j = 0; j < temp.Length; j++)
        //            {
        //                Console.Write($"w{j}:{_weights[j]} \t");
        //            }

        //            Console.WriteLine();
        //            double calc = CalculateOutput(temp);
        //            Console.WriteLine($"d: {trainOutputs[i]}\t\ty:{calc}");
        //            Console.WriteLine();
        //            if (calc != trainOutputs[i])
        //            {
        //                ChangeWeights(temp, trainOutputs[i]);
        //            }

        //            t++;
        //        }

        //    }

        //    Console.WriteLine($"\n Siec nauczona z epsilon={CalculateEpsilon(trainInputs, trainOutputs)} w {t}krokach \nWagi końcowe: ");
        //    for (int i = 0; i < _weights.Count; i++)
        //    {
        //        Console.Write($"\tw{i}: {Math.Round(_weights[i], 5)}");
        //    }
        //}
        public void Train(double[,] trainInputs, double[] trainOutputs, double epsilon)
        {
            int t = 0;
            int epoch = 0;
            while (CalculateEpsilon(trainInputs, trainOutputs) > epsilon)
            {
                t = 0;
                epoch++;
                for (int i = 0; i < trainOutputs.Length; i++)
                {
                    var temp = new double[trainInputs.GetLength(1)];
                    for (int j = 0; j < trainInputs.GetLength(1); j++)
                    {
                        temp[j] = trainInputs[i, j];

                    }


                    double calc = CalculateOutput(temp);

                    if (Math.Abs(calc - trainOutputs[i]) > 1e-10)
                    {
                        Console.WriteLine($"\n---------------e {epoch}  t {t%_weights.Count+1}----------------\n");
                        ChangeWeights(temp, trainOutputs[i]);
                        Console.WriteLine();
                    }
                    t++;

                }

            }

            Console.WriteLine($"\n Siec nauczona z epsilon={CalculateEpsilon(trainInputs, trainOutputs)} w {epoch}epokach \nWagi końcowe: ");
            for (int i = 0; i < Weights.Count; i++)
            {
                Console.Write($"\tw{i}: {Math.Round(Weights[i], 5)}");
            }
        }
        public void ChangeWeights(double[] inputs, double output)
        {
            double s = 0.3;//wspolczynnik nauczania
            for (int i = 0; i < Weights.Count; i++)
            {
                Console.Write($"\tw{i}: {Math.Round(Weights[i], 4)} ->");
                Weights[i] += inputs[i] * output * s;
                Console.Write($"{Math.Round(Weights[i], 4)}");
            }
        }

        public double CalculateEpsilon(double[,] inputs, double[] outputs)
        {
            double eps = 0;

            for (int i = 0; i < inputs.GetLength(0); i++)
            {
                var temp = new double[Weights.Count];
                for (int j = 0; j < temp.Length; j++)
                {
                    temp[j] = inputs[i, j];
                }

                if (this.CalculateOutput(temp) != outputs[i]) eps++;
            }
            return eps;
        }

        public double CalculateOutput(double[] inputs)
        {
            double result = 0;
            for (int i = 0; i < Weights.Count; i++)
            {
                result += inputs[i] * Weights[i];
            }

            double sig = ActivationFunction(result);

            return sig;
        }

        private double Signum(double x)
        {
            if (x >= 0) return 1;
            else
                return -1;

        }


    }
}