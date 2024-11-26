using Tyuiu.BilousEYu.Sprint5.Task7.V8.Lib;
namespace Tyuiu.BilousEYu.Sprint5.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Билоус Е.Ю. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Билоус Елизавета Юрьевна | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть                                                *");
            Console.WriteLine("* набор символьных данных.Заменить все заглавные русские буквы на         *");
            Console.WriteLine("* строчные. Полученный результат сохранить в файл                         *");
            Console.WriteLine("* OutPutDataFileTask7V8.txt.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\User\source\repos\Tyuiu.BilousEYu.Sprint5\DataSprint5\OutPutDataFileTask7V8.txt";

            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string PathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine($"Данные находятся в файле");
            Console.WriteLine(PathSaveFile);
        }
    }
}
