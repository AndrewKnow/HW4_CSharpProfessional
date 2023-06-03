using HW4_CSharpProfessional.Game;
using HW4_CSharpProfessional.Abstractions;
using HW4_CSharpProfessional.NumberGenerate;
using HW4_CSharpProfessional.GameAbstractions;
using System;
using HW4_CSharpProfessional.NumberGenerator;

namespace HW4_CSharpProfessional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Игра ""Угадай число"""); ;

            //Принцип единственной обязанности (Single Responsibility Principle) можно сформулировать так:
            //Каждый компонент должен иметь одну и только одну причину для изменения.
            //Метод ChangeSettings може


            //Принцип открытости/закрытости (Open/Closed Principle)
            // Суть этого принципа состоит в том, что система должна быть построена таким образом,
            // что все ее последующие изменения должны быть реализованы с помощью добавления нового кода, а не изменения уже существующего
            //Выбор минимального и максимального значения диапозона абстрагирован в интерфейсе INumGenerator и определен в реализациях интерфеса
            //GenerateMaxNum и GenerateMinNum.
            //Класс NumberGenerator делегирует назначение рандомного дипозона методу Generat объета INumGenerator.


            //Принцип подстановки Лисков(Liskov Substitution Principle)



            //Принцип разделения интерфейсов(Interface Segregation Principle) относится к тем случаям, 
            //    когда классы имеют "жирный интерфейс", то есть слишком раздутый интерфейс, не все методы
            //    и свойства которого используются и могут быть востребованы.Таким образом, интерфейс получатся 
            //    слишком избыточен или "жирным".


            //Принцип инверсии зависимостей(Dependency Inversion Principle)
            //    служит для создания слабосвязаных сущностей, которые легко тестировать, модифицировать и обновлять

            var numberGenerator = new GenerateMinMaxNum();
            var getNum = new GetUserNum();
            var userSettingsNormal = new UserSettingsNormal();

            BeginPlay beginPlay = new BeginPlay(numberGenerator, getNum, userSettingsNormal);

            while(true)
            {
                beginPlay.InstallGameSettings();
            }
            
        }

    }
}