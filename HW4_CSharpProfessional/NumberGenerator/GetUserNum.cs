using HW4_CSharpProfessional.GameAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CSharpProfessional.NumberGenerator
{
    public class GetUserNum: IGetNum
    {
        public int GetNum()
        {
            int numRead = Console.Read();
            return numRead;
        }
    }
}
