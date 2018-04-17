﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Adaline
{
    public class Adaline
    {
        public Func<double, double> ActivationFunction { get; set; }
        protected List<double> _weights;
        public int _numberOfInputs;
        public Adaline(int numberOfInputs)
        {
            this._numberOfInputs = numberOfInputs;
            _weights = new List<double>(_numberOfInputs);
            InitWeights();
            ActivationFunction = Signum;


        }

        public void ShowWeights()
        {
            Console.WriteLine();
            for (int i = 0; i < _weights.Count; i++)
            {
                Console.Write($"\tw{i}: {_weights[i]}");
            }
        }
        public void InitWeights(double startRange = 0.01, double endRange = 1.0)
        {
            var random = new Random();
            Console.WriteLine();
            Console.WriteLine("Inicjuję wagi: ");
            for (int i = 0; i < _numberOfInputs; i++)
            {
                _weights.Add(Math.Round(random.NextDouble() * (endRange - startRange)
                    + startRange, 4));
                Console.Write($"\tw{i}: {_weights[i]}  ");
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
                    Console.Write($" \t{_weights[l] * inputs[i, l]}\t");
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
            while (CalculateEpsilon(trainInputs, trainOutputs) > epsilon)
            {

                for (int i = 0; i < trainOutputs.Length; i++)
                {
                    var temp = new double[trainInputs.GetLength(1)];
                    for (int j = 0; j < trainInputs.GetLength(1); j++)
                    {
                        temp[j] = trainInputs[i, j];

                    }


                    double calc = CalculateOutput(temp);

                    if (calc != trainOutputs[i])
                    {
                        Console.WriteLine($"\n---------------t {t}----------------\n");
                        ChangeWeights(temp, trainOutputs[i]);
                        Console.WriteLine();
                    }

                    t++;
                }

            }

            Console.WriteLine($"\n Siec nauczona z epsilon={CalculateEpsilon(trainInputs, trainOutputs)} w {t}krokach \nWagi końcowe: ");
            for (int i = 0; i < _weights.Count; i++)
            {
                Console.Write($"\tw{i}: {Math.Round(_weights[i], 5)}");
            }
        }
        public void ChangeWeights(double[] inputs, double output)
        {
            for (int i = 0; i < _weights.Count; i++)
            {
                double s = 0.8;
                Console.Write($"\tw{i}: {Math.Round(_weights[i], 4)} ->");
                _weights[i] += inputs[i] * (output-this.CalculateOutput(inputs))*s;
                Console.Write($"{Math.Round(_weights[i], 4)}");
            }
        }

        public double CalculateEpsilon(double[,] inputs, double[] outputs)
        {
            double eps = 0;

            for (int i = 0; i < inputs.GetLength(0); i++)
            {
                var temp = new double[_weights.Count];
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
            for (int i = 0; i < _weights.Count; i++)
            {
                result += inputs[i] * _weights[i];
            }

            double sig = ActivationFunction(result);

            return sig;
        }

        private double Signum(double x)
        {
            if (x > 0) return 1;
            else if (x < 0) return -1;
            return 10000000;
        }


    }
}