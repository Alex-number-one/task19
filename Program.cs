int num = Convert.ToInt32(Console.ReadLine());
if (num <= 9999 || num > 99999)
{
    Console.WriteLine("Please write an avaliable number");
}
else
{
    int num1 = num / 10000;
    int num2 = num % 10;
    int num3 = num / 1000; // don`t use
    int num4 = num3 % 10;
    int num5 = num % 100; // same
    int num6 = num5 / 10;
    if (num1 == num2 && num4 == num6)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }









}


Console.WriteLine();