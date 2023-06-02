using HW4_CSharpProfessional.Game;

namespace HW4_CSharpProfessional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Принцип открытости/закрытости (Open/Closed Principle)
            //Выбор минимального и максимального числа абстрагирован в интерфейсе INumGenerator и определен в реализациях 
            //этого интерфейса GenerateMaxNum и GenerateMinNum.
            //Класс NumRequester делегирует назначение рандомного числа методу Generat INumGenerator.
            RangeRequest rangeRequest = new RangeRequest();
            List<int> listInt = rangeRequest.GetRange();

            Console.WriteLine(listInt[0]);
            Console.WriteLine(listInt[listInt.Count - 1]);
        }
    }
}