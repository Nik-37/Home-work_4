int a;
string str_a;
int count;
int sum = 0;

Console.WriteLine("Введи число А: ");
str_a = Console.ReadLine();
a = Convert.ToInt32(str_a);
while (a > 0)
{
    count = a % 10;
    sum = sum + count;
    a = a / 10;
}
Console.WriteLine(sum);