﻿//przygotować dane spoza zestawy uczącego

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FANNCSharp;
#if FANN_FIXED
using FANNCSharp.Fixed;
using DataType = System.Int32;
#elif FANN_DOUBLE
using FANNCSharp.Double;
using DataType = System.Double;
#else
using FANNCSharp.Float;
using DataType = System.Single;
#endif
namespace LiteryTrain
{
    class LiteryTrain
    {

        static int PrintCallback(NeuralNet net, TrainingData train, uint max_epochs, uint epochs_between_reports,
            float desired_error, uint epochs, Object user_data)
        {
            Console.WriteLine(String.Format("Epochs     " + String.Format("{0:D}", epochs).PadLeft(8) +
                                            ". Current Error: " + net.MSE));
            return 0;
        }

        static void LiteryTest()
        {
            Console.WriteLine("\nLitery test started.");

            const float learning_rate = 0.7f;
            const uint num_layers = 6;
            const uint num_input = 100;
            const uint num_hidden1 = 80;
            const uint num_hidden2 = 60;
            const uint num_hidden3 = 40;
            const uint num_hidden4 = 10;
            const uint num_output = 3;
            const float desired_error = 0.0002f;
            const uint max_iterations = 1000000;
            const uint iterations_between_reports = 10000;

            Console.WriteLine("\nCreating network.");

            using (NeuralNet net = new NeuralNet(NetworkType.LAYER, num_layers, num_input, num_hidden1, num_hidden2,
                num_hidden3, num_hidden4, num_output))
            {
                net.LearningRate = learning_rate;

                net.ActivationSteepnessHidden = 1.0F;
                net.ActivationSteepnessOutput = 1.0F;

                net.ActivationFunctionHidden = ActivationFunction.SIGMOID_SYMMETRIC_STEPWISE;
                net.ActivationFunctionOutput = ActivationFunction.SIGMOID_STEPWISE;

                // Output network type and parameters
                Console.Write("\nNetworkType                         :  ");
                switch (net.NetworkType)
                {
                    case NetworkType.LAYER:
                        Console.WriteLine("LAYER");
                        break;
                    case NetworkType.SHORTCUT:
                        Console.WriteLine("SHORTCUT");
                        break;
                    default:
                        Console.WriteLine("UNKNOWN");
                        break;
                }

                net.PrintParameters();

                Console.WriteLine("\nTraining network.");

                using (TrainingData data = new TrainingData())
                {
                    if (data.ReadTrainFromFile(
                        @"C:\Users\mistr\Documents\Repo\MSI\Litery\Litery\cyfry_nauka.data"))
                    {
                        // Initialize and train the network with the data
                        net.InitWeights(data);

                        Console.WriteLine("Max Epochs " + max_iterations +
                                          ". Desired Error: " + desired_error);
                        net.SetCallback(PrintCallback, null);
                        net.TrainOnData(data, max_iterations, iterations_between_reports, desired_error);

                        Console.WriteLine("\nTesting network.");

                        //for (uint i = 0; i < data.TrainDataLength; i++)
                        //{
                        //    // Run the network on the test data
                        //    DataType[] calc_out = net.Run(data.Input[i]);

                        //    Console.WriteLine("Litery test ({0}) -> {1}, should be {2}, difference = {3}",
                        //        data.InputAccessor[(int)i][0],
                        //        calc_out[0] == 0 ? 0.ToString() : calc_out[0].ToString(),
                        //        data.OutputAccessor[(int)i][0].ToString(),
                        //        FannAbs(calc_out[0] - data.Output[i][0]));
                        //}

                        Console.WriteLine("\nSaving network.");

                        net.Save(
                            @"C:\Users\mistr\Documents\Repo\MSI\Litery\Litery\cyfry_net.net");
                        Console.WriteLine("\n Cyfry test completed.");
                        CalculateOutputs(net);
                    }
                }
            }
        }

        public static void CalculateOutputs(NeuralNet net)
        {
            using (TextReader reader = File.OpenText(@"C:\Users\mistr\Documents\Repo\MSI\Litery\Litery\cyfry_testowy.txt"))
            {


                int n = Array.ConvertAll(reader.ReadLine().Split(' '), Int32.Parse).First();


                for (int i = 0; i < n; i++)
                {
                    //float[] inputs = new float[100];
                    //var inputs = Array.ConvertAll(reader.ReadLine().Split(' '), Single.Parse);
                    var inputsChar = reader.ReadLine().Split(' ');
                    var outputsChar = reader.ReadLine().Split(' ');
                    var inputs = new float[100];
                    var outputs = new float[3];
                    for (int j = 0; j < inputsChar.Length; j++)
                    {
                        inputs[j] = Convert.ToSingle(inputsChar[j]);
                    }
                    for (int j = 0; j < outputsChar.Length; j++)
                    {
                        outputs[j] = Convert.ToSingle(outputsChar[j]);
                    }

                    float[] calc_out = net.Run(inputs);
                    for (int j = 0; j < 10; j++)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            Console.Write(inputs[10 * j + k] == 0 ? ' ' : 'H');
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    //Console.WriteLine($"zestaw{i}");
                    Console.WriteLine($"{outputs[0]} => {calc_out[0]} \t {outputs[1]} =>{calc_out[1]} \t{outputs[2]} => {calc_out[2]}");
                    Console.WriteLine("------------------------------------------------");
                }
            }
        }

        static int Main(string[] args)
        {
            LiteryTest();

            //try
            //{
            //    LiteryTest();
            //}
            //catch
            //{
            //    Console.Error.WriteLine("\nAbnormal exception.");
            //}

            Console.ReadKey();
            return 0;
        }

        static DataType FannAbs(DataType value)
        {
            return (((value) > 0) ? (value) : -(value));
        }
    }
}


