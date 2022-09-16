Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите квадрат первого числа");
int b = Convert.ToInt32(Console.ReadLine());

if(b == a * a)
{
    Console.WriteLine("ответ правельный");
}
else
{
    Console.WriteLine("ответ не верный");
}