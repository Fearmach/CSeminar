// Написать программу, которая будет выдавать название дня недели по заданному номеру: 3 -> среда; 5 -> пятница. 
// Для оптимизации проекта лучше использовать не if, а else if, т.к при if программа будет сравнивать последовательно все варианты, а при else if программа остановится, когда найдет верный. В больших проектах, это будет энерго-затратно и будет тормозить

System.Console.Write("Введите число от 1 до 7 "); // Вывод в консоль
int day = Convert.ToInt32(Console.ReadLine()); // Ввод числа

switch (day){
    case 1:
    {
        System.Console.WriteLine("Понедельник");
        break;
    }
    case 2:
    {
        System.Console.WriteLine("Вторник");
        break;
    }
    case 3:
    {
        System.Console.WriteLine("Среда");
        break;
    }
    case 4:
    {
        System.Console.WriteLine("Четвергк");
        break;
    }
    case 5:
    {
        System.Console.WriteLine("Пятница");
        break;
    }
    case 6:
    {
        System.Console.WriteLine("Суббота");
        break;
    }
    case 7:
    {
        System.Console.WriteLine("Воскресенье");
        break;
    }
    default:
    {
        System.Console.WriteLine("Такого дня недели не бывает");
        break;
    }
   
}
