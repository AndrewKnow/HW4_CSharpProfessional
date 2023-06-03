using HW4_CSharpProfessional.GameAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CSharpProfessional.NumberGenerate
{
    public class GetUserNum: IGetNum
    {
        public int GetNum()
        {
            var read = Console.ReadLine();
            bool tryParseToInt = int.TryParse(read, out int _);

            if (tryParseToInt)
            {
                return Convert.ToInt32(read);
            }

            return 0;
        }
    }
}
