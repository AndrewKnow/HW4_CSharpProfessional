using HW4_CSharpProfessional.Game;
using HW4_CSharpProfessional.Settings;

namespace HW4_CSharpProfessional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Принцип открытости/закрытости (Open/Closed Principle)
            // Суть этого принципа состоит в том, что система должна быть построена таким образом,
            // что все ее последующие изменения должны быть реализованы с помощью добавления нового кода, а не изменения уже существующего
            //Выбор минимального и максимального значения диапозона абстрагирован в интерфейсе INumGenerator и определен в реализациях интерфеса
            //GenerateMaxNum и GenerateMinNum.
            //Класс NumRange делегирует назначение рандомного дипозона методу Generat объета INumGenerator.


            //Принцип подстановки Лисков(Liskov Substitution Principle)



       



            //RangeRequest rangeRequest = new RangeRequest();
            //List<int> listInt = rangeRequest.GetRange();

            //Console.WriteLine(listInt[0]);
            //Console.WriteLine(listInt[listInt.Count - 1]);



        }
    }
}