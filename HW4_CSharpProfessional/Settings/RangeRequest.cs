using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW4_CSharpProfessional.Game;
using HW4_CSharpProfessional.GameAbstractions;

namespace HW4_CSharpProfessional.Settings
{
    public class RangeRequest: IRangeRequest
    {
        public List<int> GetRange()
        {
            NumRange rangeRequest = new NumRange(0);
            int min = rangeRequest.NumGenerate(new GenerateMinNum());
            int max = rangeRequest.NumGenerate(new GenerateMaxNum());

            List<int> nums = new List<int>();

            for (int i = min; i <= max; i++)
            {
                nums.Add(i);
            }
            return nums;
        }
    }
}
