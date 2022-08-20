
Console.WriteLine("task 2");
    Console.WriteLine("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a > b)
            Console.WriteLine("Первое число больше!");
    if (a == b)
           Console.WriteLine("Числа равны!");
    if (a < b)
           Console.WriteLine("Второе число больше!");

Console.WriteLine(""); 
Console.WriteLine("task 4");
    Console.WriteLine("Введите первое число: ");
    int aa = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int bb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число: ");
    int c = Convert.ToInt32(Console.ReadLine());
    int max = aa;
    if (aa > max) max = aa;
    if (bb > max) max = bb;
    if (c > max) max = c;
    Console.Write("Max = ");
    Console.WriteLine(max);

Console.WriteLine("");
Console.WriteLine("task 6");
Console.WriteLine("Введите любое число: ");
int d = Convert.ToInt32(Console.ReadLine());
if (d % 2 == 0)
    Console.WriteLine("Число четное");
else
    Console.WriteLine("Число нечетное");

Console.WriteLine("");
Console.WriteLine("task 8");
Console.WriteLine("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int i = 1;
while (i <= n)
{
    if (i % 2 == 0)
    Console.WriteLine(i);
    i++;
}
