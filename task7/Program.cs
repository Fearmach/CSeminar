// Написать программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа (456 -> 46)


int randNumber = new Random().Next(100, 1000); 
System.Console.WriteLine(randNumber);

//int a = (randNumber/10);
//int b = (randNumber%10);

//System.Console.WriteLine($"{a/10}{b}");

System.Console.WriteLine((randNumber/100) * 10 + randNumber%10 );