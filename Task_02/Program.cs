// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int num_user)
{
    int sum = 0;
    while  (num_user > 0)
    {
        sum += num_user % 10;
        num_user /= 10;
    }
    return sum;
}
Console.WriteLine("Input number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int sum_res;

if (user_num >= 0)
sum_res = SumOfDigits(user_num);
else
{
    int user_num1 = user_num * (-1);
    sum_res = SumOfDigits(user_num1);
}
Console.WriteLine(sum_res);
