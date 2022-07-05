//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень В

Console.WriteLine("Введите первое число: ");
string firstStr = Console.ReadLine();
int firstA = int.Parse(firstStr);

Console.WriteLine("Введите второе число: ");
string secondStr = Console.ReadLine();
int secondB = int.Parse(secondStr);

int solution = 1;
int i = 1;
while(i <= secondB)
{
    solution = firstA * solution;
    i++;
}
Console.WriteLine(solution);

