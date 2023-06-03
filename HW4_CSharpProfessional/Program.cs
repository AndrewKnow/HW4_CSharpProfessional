using HW4_CSharpProfessional.Game;
using HW4_CSharpProfessional.Settings;
using HW4_CSharpProfessional.Abstractions;
namespace HW4_CSharpProfessional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Принцип единственной обязанности (Single Responsibility Principle) можно сформулировать так:
            //Каждый компонент должен иметь одну и только одну причину для изменения.
            //GenerateMinNum, GenerateMaxNum от


            //Принцип открытости/закрытости (Open/Closed Principle)
            // Суть этого принципа состоит в том, что система должна быть построена таким образом,
            // что все ее последующие изменения должны быть реализованы с помощью добавления нового кода, а не изменения уже существующего
            //Выбор минимального и максимального значения диапозона абстрагирован в интерфейсе INumGenerator и определен в реализациях интерфеса
            //GenerateMaxNum и GenerateMinNum.
            //Класс NumRange делегирует назначение рандомного дипозона методу Generat объета INumGenerator.


            //Принцип подстановки Лисков(Liskov Substitution Principle)



            //Принцип разделения интерфейсов(Interface Segregation Principle) относится к тем случаям, 
            //    когда классы имеют "жирный интерфейс", то есть слишком раздутый интерфейс, не все методы
            //    и свойства которого используются и могут быть востребованы.Таким образом, интерфейс получатся 
            //    слишком избыточен или "жирным".


            //Принцип инверсии зависимостей(Dependency Inversion Principle)
            //    служит для создания слабосвязанных сущностей, которые легко тестировать, модифицировать и обновлять




        }

    }
}