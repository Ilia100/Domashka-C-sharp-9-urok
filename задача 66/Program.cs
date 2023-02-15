/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumOfNumbers(int num1, int num2)
{
    
    if (num1 < num2)
    {
        return num1+ SumOfNumbers(num1+1,num2);

    }
    else

        return num2;
}


int sum = SumOfNumbers(1,15);
System.Console.WriteLine(sum);