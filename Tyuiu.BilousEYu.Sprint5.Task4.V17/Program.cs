using Tyuiu.BilousEYu.Sprint5.Task4.V17.Lib;
namespace Tyuiu.BilousEYu.Sprint5.Task4.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Билоус Е.Ю. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:                                                                   *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила: Билоус Елизавета Юрьевна | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из      *");
            Console.WriteLine("*  архива согласно вашему варианту. Создать папку в ручную                *");
            Console.WriteLine("*  С:\\DataSprint5\\ и скопировать в неё файл) в котором есть             *");
            Console.WriteLine("*  вещественное значение. Прочитать значение из файла и подставить вместо *");
            Console.WriteLine("*  Х в формуле . Вычислить значение по формуле (Полученное значение       *");
            Console.WriteLine("*  округлить до трёх знаков после запятой) и вернуть полученный результат *");
            Console.WriteLine("*  на консоль.                                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\User\source\repos\BilousEYu.Sprint5\DataSprint5\InPutDataFileTask4V17.txt";

            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
