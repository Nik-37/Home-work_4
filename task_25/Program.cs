int A;
int B;
int result = 1;
string str;

Console.WriteLine("Введи число А: ");
str = Console.ReadLine();
A = Convert.ToInt32(str);
Console.WriteLine("Веди число В: ");
str = Console.ReadLine();
B = Convert.ToInt32(str);

for (int i = 1; i <= B; i ++)
{
result = result * A;
}
Console.WriteLine("Значение числа возведенного в степень =  " + result);

