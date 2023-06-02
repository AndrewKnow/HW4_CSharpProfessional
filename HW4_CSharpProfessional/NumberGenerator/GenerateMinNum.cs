using HW4_CSharpProfessional.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CSharpProfessional.Game
{
    public class GenerateMinNum : INumGenerator
    {
        public int Generat()
        {
            Random random = new Random();
            int num = random.Next(1, 10);
            return num;
        }
    }
}
