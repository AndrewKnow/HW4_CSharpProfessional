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
        private readonly IGameAttempts _gameAttempts;

        public BeginPlay(INumGenerator numGenerator, IGetNum getNum, IGameAttempts gameAttempts)
        {
            _numGenerator = numGenerator;
            _getNum = getNum;
            _gameAttempts = gameAttempts;
        }

        public void InstallGameSettings()
        {
            Console.Write("Угадайте число из загаданного программой дипозона указанных вами чисел\n");
            ReadUserNum(out int secretNum, out int gameAttempts);
            Play(secretNum, gameAttempts);
        }

        public void ReadUserNum(out int secretNum, out int gameAttempts)
        {
            Console.Write("Введите минимальное чсило для диапозона:");
            int min = _getNum.GetNum();
            Console.Write("Введите максимальное чсило для диапозона:");
            int max = _getNum.GetNum();

            secretNum = _numGenerator.Generat(min, max);
            gameAttempts = _gameAttempts.ChangeSettings();
        }

        public void Play(int secretNum, int gameAttempts)
        {

            Console.Write($"Секретное число загадано.\nКоличество попыток: {gameAttempts} ");

            int i = 0;
            while(true)
            {
                i++;
                Console.Write("Угадайте число:");

                int userNum = _getNum.GetNum();
                
                if (userNum == secretNum)
                {
                    Console.Write("Ты угадал!!!");
                    break;
                }

                if (i == gameAttempts)
                {


                    break;
                }
                   
            }
        }
    }
}
