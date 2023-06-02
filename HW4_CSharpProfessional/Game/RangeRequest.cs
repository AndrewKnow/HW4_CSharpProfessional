using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CSharpProfessional.Game
{
    public class RangeRequest
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
