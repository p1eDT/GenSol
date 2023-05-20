using System;
using GitHome10.Dependencies;

namespace GitHome10
{
    public class Program
    {
        ///<summary>
        ///1. Cоздать класс мониторинга средней цен на жилье, цена будет генерироваться с помощью класса рандом и выдавать случайное значение в определенном диапазоне. 
        ///Для того чтобы вывод цены был удобен пользователю в классе мониторинга создать поле делегат, обьект которого будет создаваться в классе мониторинга.  
        ///Пользователь указывает метод для отображения цены в удобном ему формате путем передачи метода в конструктор класса мониторинга.

        ///2.Реализовать паттерн наблюдатель в случае если цена на жилье опустилась ниже определенного значения, и сообщить всем кто на это событие подписался. 
        ///*реализовать как через событие так и через паттерн наблюдатель без события
        /// </summary>
        static void Main(string[] args)
        {
            PriceMonitor priceMonitor = new PriceMonitor(MyFormat);
            priceMonitor.Show();
 



        }

        public static void MyFormat(int price)
        {
             Console.WriteLine("Average price for me = " + string.Format(new System.Globalization.CultureInfo("En-US"), "{0:C0}", price));
        }
    }
}