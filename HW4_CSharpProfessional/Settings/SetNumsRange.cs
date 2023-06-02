using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CSharpProfessional.Settings
{
    public class SetNumsRange
    {
        /// <summary>
        /// Диапозон чисел
        /// </summary>
        /// <return></return>
        public List<int> NumsRange()
        {
            RangeRequest rangeRequest = new RangeRequest();
            List<int> listInt = rangeRequest.GetRange();

            return listInt;
        }

    }
}
