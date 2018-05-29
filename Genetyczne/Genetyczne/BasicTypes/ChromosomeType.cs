using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GA.Extensions;

namespace GA.BasicTypes
{
    public class ChromosomeType
    {
        private static Random _random = new Random();
        public bool[] Chromosome { get; set; }
        public double DecodedValue { get { return GetDecodedValue(); } }

        public ChromosomeType(int chromosomeSize)
        {
            Chromosome = new bool[chromosomeSize];

            for (int i = 0; i < Chromosome.Length; i++)
            {
                Chromosome[i] = _random.NextBool();
            }
        }

        private double GetDecodedValue()
        {
            double decoded = 0;
            for (int i = 0; i < Chromosome.Length; i++)
            {
                if (Chromosome[i] == true)
                {
                    decoded += Math.Pow(2, Chromosome.Length - i - 1);
                }
            }

            return decoded;
        }
    }

}
