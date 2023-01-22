// Написать программу которая выводит случайное число из отрезка (10, 99) и показывает наибольшую цифру числа. Например 78 -> 8, 85 -> 8

Random rand = new Random(); // Объявление объекта класса Random
int randNumber = rand.Next(10, 100); // Генерация переменной от 10 до 99 -- [10; 100) Правую границу пишем на 1 больше || [10, 99]
// int randNumber = new Random().Next(10, 100); Можно и так, но если таких объектов будет много, постоянно прописывать это будет не удобно
System.Console.WriteLine(randNumber);

// От деления числа на 10 мы возьмем левую цифру числа, от остатка деления на 10 правую часть
if(randNumber/10 > randNumber%10)
{
    System.Console.WriteLine(randNumber/10);
}
else
{
    System.Console.WriteLine(randNumber%10);
}
