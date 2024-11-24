using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date
{
    public class DateConverter
    {
        public static void Main(string[] args)
        {
            string dateText1 = "2024-03-15";
            string dateText2 = "15 марта 2024";
            string badDateText = "это не дата";

            // Простой способ (может ошибиться)
            try
            {
                DateTime date1 = DateTime.Parse(dateText1);
                Console.WriteLine($"Дата 1: {date1}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Ошибка при преобразовании '{dateText1}'");
            }

            // Более надежный способ (указывает формат)
            try
            {
                DateTime date2 = DateTime.ParseExact(dateText2, "dd MMMM yyyy", null);
                Console.WriteLine($"Дата 2: {date2}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Ошибка при преобразовании '{dateText2}'");
            }

            // Самый надежный способ (проверяет, получилось ли)
            if (DateTime.TryParse(badDateText, out DateTime date3))
            {
                Console.WriteLine($"Дата 3: {date3}");
            }
            else
            {
                Console.WriteLine($"Не удалось преобразовать '{badDateText}'");
            }
        }
    }

}
