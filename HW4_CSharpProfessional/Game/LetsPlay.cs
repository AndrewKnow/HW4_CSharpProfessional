using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW4_CSharpProfessional.Abstractions;
using HW4_CSharpProfessional.GameAbstractions;

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
            Console.WriteLine("\nУгадайте число из загаданного программой дипозона указанных вами чисел.\n");
            ReadUserNum(out int secretNum, out int gameAttempts);
            Play(secretNum, gameAttempts);
        }

        public void ReadUserNum(out int secretNum, out int gameAttempts)
        {
            Console.WriteLine("Введите минимальное чсило для диапозона:");
            int min = _getNum.GetNum();
            Console.WriteLine("Введите максимальное чсило для диапозона:");
            int max = _getNum.GetNum();

            secretNum = _numGenerator.Generat(min, max);
            gameAttempts = _gameAttempts.ChangeSettings();
        }

        public void Play(int secretNum, int gameAttempts)
        {
            Console.WriteLine($"Секретное число загадано.\nКоличество попыток: {gameAttempts} ");

            int i = 0;
            bool guessed = false;
            while (true)
            {
                i++;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите число:");

                int userNum = _getNum.GetNum();

                if (userNum > secretNum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Число {userNum} больше загаданного");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (userNum < secretNum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Число {userNum} меньше загаданного");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (userNum == secretNum)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Ты угадал загаданное число {secretNum}!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Количество попыток: {gameAttempts - i} ");
                Console.ForegroundColor = ConsoleColor.White;

                if (i == gameAttempts)
                {
                    if (guessed == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Ты не угадал загаданное число {secretNum}!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                }   
            }
        }
    }
}
