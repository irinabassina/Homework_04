// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


void FindDegreeAinB(int num_a, int num_b)
{
    int result = 1;
    for (int current = 1; current <= num_b; current ++)
    {
      result = result * num_a;
    }
Console.WriteLine(result);
}
Console.Write("Input the number A: " );
int user_num_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number B: ");
int user_num_b = Convert.ToInt32(Console.ReadLine());

if (user_num_b > 0)
{
    FindDegreeAinB(user_num_a, user_num_b);
}
else
Console.WriteLine("Impossible value of B");

