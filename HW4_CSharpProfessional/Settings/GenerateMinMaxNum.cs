using HW4_CSharpProfessional.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CSharpProfessional.NumberGenerate
{
    public class GenerateMinMaxNum : INumGenerator
    {
        public int Generat(int min, int max)
        {
            Random random = new Random();

            if (min < max)
            {
                int num = random.Next(min, max);
                return num;
            }
            if (min > max)
            {
                int num = random.Next(max, min);
                return num;
            }
            return 0;
        }
    }
}
