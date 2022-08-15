

// (System.Console.WriteLine("Введите первое число:");
//  int a = Convert.ToInt32(Console.ReadLine());

//  System.Console.WriteLine("Введите второе число:");
//  int b = Convert.ToInt32(Console.ReadLine());

//  if (a > b)
//  {
//  System.Console.WriteLine(a);
// }
//  else System.Console.WriteLine(b);)




System.Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите третье число:");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;


if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

System.Console.WriteLine(max);



System.Console.WriteLine("Введите число:");
int bread = Convert.ToInt32(Console.ReadLine());

if (bread % 2 == 0)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("Нет");
}



int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);

while (i <= num)
{

    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}
if (not)
{
    Console.Write("Четных чисел нет(убежали)");
}
