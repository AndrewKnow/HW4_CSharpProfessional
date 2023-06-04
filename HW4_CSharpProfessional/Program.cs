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
        // Решение заняло порядка 4 часов
        /// <summary>
        /// S   Принцип единственной обязанности (Single Responsibility Principle) можно сформулировать так:
        ///     Каждый компонент должен иметь одну и только одну причину для изменения.
        ///     Метод ChangeSettings в классах UserSettingsNormal и UserSettingsHard имеет только одну причину для замены, если нужно поменять возвращаемое методом значение
        ///     
        /// O   Принцип открытости/закрытости (Open/Closed Principle)
        ///     Суть этого принципа состоит в том, что система должна быть построена таким образом,
        ///     что все ее последующие изменения должны быть реализованы с помощью добавления нового кода, а не изменения уже существующего
        ///     Выбор минимального и максимального значения диапазона абстрагирован в интерфейсе INumGenerator и определен в реализациях интерфейса
        ///     GenerateMaxNum и GenerateMinNum. Класс NumberGenerator делегирует назначение рандомного диапазона методу Generat объекта INumGenerator.
        ///     Класс NumberGenerator закрыт от изменений, за то мы можем легко расширить его функциональность, определив дополнительные реализации интерфейса INumGenerator.
        ///     
        /// L   Принцип подстановки Лисков(Liskov Substitution Principle)
        ///     UserSettingsNormal можно заменить классом UserSettingsHard и обратно, поведение игры не изменится, изменится игровой параметр "кол-во попыток"
        ///     
        /// I   Принцип разделения интерфейсов(Interface Segregation Principle)
        ///     Созданы отдельные интерфейсы IParse и ITryParse для проверки введённого пользователем значения
        ///     
        /// D   Принцип инверсии зависимостей(Dependency Inversion Principle)
        ///     Модули верхнего уровня не должны зависеть от модулей нижнего уровня. И те и другие должны зависеть от абстракций.
        ///     Класс LetsPlay зависит от абстракций INumGenerator IGeUsertNum IGameAttempts и не создаёт реализации внутри себя
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(@"Игра ""Угадай число"""); ;
            Console.WriteLine("\nУгадайте число из загаданного программой диапазона указанных вами чисел.\n");

            var numberGenerator = new GenerateMinMaxNum();
            var getNum = new GetUserNum();
            var userSettingsNormal = new UserSettingsNormal();

            LetsPlay LetsPlay = new LetsPlay(numberGenerator, getNum, userSettingsNormal);

            while(true)
            {
                LetsPlay.InstallGameSettings();
            }
        }
    }
}