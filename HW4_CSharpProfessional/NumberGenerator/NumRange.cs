using HW4_CSharpProfessional.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CSharpProfessional.Game
{
    public class NumRange
    {
        private int _num { get; set; }

        public NumRange(int num)
        {
            _num = num;
        }
        public int NumGenerate(INumGenerator numGenerator)
        {
            _num = numGenerator.Generat();
            return _num;
        }
    }
}
