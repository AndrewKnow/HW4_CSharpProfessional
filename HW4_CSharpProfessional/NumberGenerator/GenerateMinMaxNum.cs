using HW4_CSharpProfessional.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CSharpProfessional.Game
{
    public class GenerateMinMaxNum : INumGenerator
    {
        public int Generat(int min, int max)
        {
            Random random = new Random();
            int num = random.Next(min, max);
            return num;
        }
    }
}
