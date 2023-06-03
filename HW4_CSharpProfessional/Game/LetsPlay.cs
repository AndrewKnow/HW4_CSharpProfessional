using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW4_CSharpProfessional.Abstractions;
using HW4_CSharpProfessional.GameAbstractions;
using HW4_CSharpProfessional.Settings;

namespace HW4_CSharpProfessional.Game
{
    public class BeginPlay
    {
        private readonly INumGenerator _numGenerator;
        private readonly IGetNum _getNum;

        public BeginPlay(INumGenerator numGenerator, IGetNum getNum)
        {
            _numGenerator = numGenerator;
            _getNum = getNum;
        }


        public void InstallGameSettings()
        {
            Console.Write("Угадайте число из загаданного программой дипозона указанных вами чисел\n");
            this.ReadUserNum(out int min, out int max);
        }

        public void ReadUserNum(out int min, out int max)
        {
            Console.Write("Введите минимальное чсило из диапозона:");
            min = _getNum.GetNum();
            Console.Write("Введите максимальное чсило из диапозона:");
            max = _getNum.GetNum();

            _numGenerator.Generat(min, max);

        }


    }
}
