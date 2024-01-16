// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

int CountOfNum(int Num)
{
    int countNum = 0;
    while (Num > 0)
    {
        countNum++;
        Num = Num / 10;

    }
    return countNum;
}
int[] ReturnNumbersAsArray(int Num, int countOfNumbers)
{
    int[] array = new int[countOfNumbers];
    for (int i = array.Length - 1; i >= 0; i--)
    {
        array[i] = Num % 10;
        Num = Num / 10;
    }
    return array;
}
int SumOfArrayNumbers(int[] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Sum = Sum + array[i];
    }
    return Sum;
}
bool IsNumberEven(int number, bool IsEven = false)
{
    if (number % 2 == 0)
    {
        IsEven = true;
    }
    return IsEven;
}
bool IsEnteringQ(string Entering)
{
    bool IsItQ = false;
    if (Entering == "q")
    {
        IsItQ = true;
    }
    return IsItQ;
}


string Entering = "0";
int Number;
int countOfNum;
int[] arrayOfNums;
int Sum;
bool IsItEven = false;

while (IsItEven == false)
{
    System.Console.WriteLine("Enter the integer number");
    Entering = Console.ReadLine();
    if (IsEnteringQ(Entering))
    {
        break;
    }
    
    Number = Convert.ToInt32(Entering);
    if(Number == 0)
    {
        continue;
    }
    countOfNum = CountOfNum(Number);
    arrayOfNums = new int[countOfNum];
    arrayOfNums = ReturnNumbersAsArray(Number, countOfNum);
    Sum = SumOfArrayNumbers(arrayOfNums);
    IsItEven = IsNumberEven(Sum);

}




