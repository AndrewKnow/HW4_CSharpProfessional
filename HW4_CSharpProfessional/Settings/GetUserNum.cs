using HW4_CSharpProfessional.GameAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CSharpProfessional.NumberGenerate
{
    /// <summary>
    /// Валидация полученного от пользователя числа
    /// </summary>
    public class GetUserNum: IGeUsertNum, IParse<string>, ITryParse<string>
    {
        public int GetNum()
        {
            var read = Console.ReadLine();

            bool tryParseToInt = TryParseObj(read);


            if (tryParseToInt)
            {
                return ParseObj(read);
            }

            return 0;
        }

        public int ParseObj(string obj)
        {
            int parseToInt = int.Parse(obj);
            return parseToInt;
        }

        public bool TryParseObj(string obj)
        {
            bool tryParseToInt = int.TryParse(obj, out int _);
            return tryParseToInt;
        }
    }
}
