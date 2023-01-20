// Написать программу, которая будет выдавать название дня недели по заданному номеру: 3 -> среда; 5 -> пятница. 
// Для оптимизации проекта лучше использовать не if, а else if, т.к при if программа будет сравнивать последовательно все варианты, а при else if программа остановится, когда найдет верный. В больших проектах, это будет энерго-затратно и будет тормозить

System.Console.Write("Введите число от 1 до 7 ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
 {
    System.Console.WriteLine("Понедельник");
 }
 else if (num == 2)
 {
    System.Console.WriteLine("Вторник");
 }
 else if (num == 3)
 {
    System.Console.WriteLine("Среда");
 }
 else if (num == 4)
 {
    System.Console.WriteLine("Четверг");
 }
 else if (num == 5)
 {
    System.Console.WriteLine("Пятница");
 }
 else if (num == 6)
 {
    System.Console.WriteLine("Суббота");
 }
 else if (num == 7)
 {
    System.Console.WriteLine("Воскресенье");
 }
 else 
 {
    Console.WriteLine("Такого дня не бывает");
 }
