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
        private int _min { get; set; }
        private int _max { get; set; }
        private int _num { get; set; }
        public NumRange(int min, int max)
        {
            _min = min;
            _max = max;
        }
        public int NumGenerate(INumGenerator numGenerator)
        {
            _num = numGenerator.Generat(_min, _max);
            return _num;
        }
    }
}
