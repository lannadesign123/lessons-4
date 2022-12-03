//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
void Degree(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
Console.WriteLine (result);
}

Console.WriteLine("Input number A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number B: ");
int B = Convert.ToInt32(Console.ReadLine());

Degree ( A, B);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11


/*void Summ(int number)
{
    int sum = 0;
    int i = 1;
    int num = 0;

    while (i > 10)
    {
    num  = i % 10;     
    int newNum = i / 10;
    sum = i + num;
    }
    {    
    Console.WriteLine($"Summ numbers is: {sum} ");
    }
}

Console.WriteLine("Input number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

Summ(user_num);
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
int [] NewArray (int size)
{
    int[] isArray = new int [size];
    
    for ( int i = 0; i < size; i++)
    isArray [i] = new Random().Next();       
    {
    return (isArray); 
    }
}

void show (int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Input count of elements : ");
int count_of_elem = Convert.ToInt32(Console.ReadLine());

show (NewArray (count_of_elem));
*/