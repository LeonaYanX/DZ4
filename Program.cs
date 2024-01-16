// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

// int CountOfNum(int Num)
// {
//     int countNum = 0;
//     while (Num > 0)
//     {
//         countNum++;
//         Num = Num / 10;

//     }
//     return countNum;
// }
// int[] ReturnNumbersAsArray(int Num, int countOfNumbers)
// {
//     int[] array = new int[countOfNumbers];
//     for (int i = array.Length - 1; i >= 0; i--)
//     {
//         array[i] = Num % 10;
//         Num = Num / 10;
//     }
//     return array;
// }
// int SumOfArrayNumbers(int[] array)
// {
//     int Sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         Sum = Sum + array[i];
//     }
//     return Sum;
// }
// bool IsNumberEven(int number, bool IsEven = false)
// {
//     if (number % 2 == 0)
//     {
//         IsEven = true;
//     }
//     return IsEven;
// }
// bool IsEnteringQ(string Entering)
// {
//     bool IsItQ = false;
//     if (Entering == "q")
//     {
//         IsItQ = true;
//     }
//     return IsItQ;
// }


// string Entering = "0";
// int Number;
// int countOfNum;
// int[] arrayOfNums;
// int Sum;
// bool IsItEven = false;

// while (IsItEven == false)
// {
//     System.Console.WriteLine("Enter the integer number");
//     Entering = Console.ReadLine();
//     if (IsEnteringQ(Entering))
//     {
//         break;
//     }

//     Number = Convert.ToInt32(Entering);
//     if(Number == 0)
//     {
//         continue;
//     }
//     countOfNum = CountOfNum(Number);
//     arrayOfNums = new int[countOfNum];
//     arrayOfNums = ReturnNumbersAsArray(Number, countOfNum);
//     Sum = SumOfArrayNumbers(arrayOfNums);
//     IsItEven = IsNumberEven(Sum);

// }

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// System.Console.WriteLine("Enter the size of the array");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] FillArrayRandom (int size)
// {
//     int[] array = new int[size];
// Random random = new Random();
// for(int i=0 ; i< array.Length ; i++ )
// {
//     array[i] = random.Next(100 , 1000);

// }
// return array;
// }
// int [] myArray = new int [size];
// myArray = FillArrayRandom (size);
// PrintArray (myArray);
// void PrintArray (int [] array)
// {
//     for(int i=0 ; i< array.Length ; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// int CountOfEvenInArray (int [] array)
// {
//     int count = 0;
//     for(int i=0 ; i< array.Length ; i++)
//     {
//         if(array[i]%2 == 0)
//         {
//             count = count +1;
//         }
//     }
//     return count;
// }
// System.Console.WriteLine();
// System.Console.WriteLine(CountOfEvenInArray (myArray));

// Задача 3: Напишите программу, 
// которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

// int[] ReverseArray(int[] array)
// {
//     int[] VSArray = new int[array.Length];
//     for (int i = 0, j = array.Length - 1; i < array.Length && j >= 0; i++, j--)
//     {
//         VSArray[i] = array[j];
//     }
//     return VSArray;
// }
// System.Console.WriteLine("Enter the array size");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = new int[size];
// int[] FillArrayRandom(int size)
// {
//     int[] array = new int[size];
//     Random random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(100, 1000);

//     }
//     return array;
// }
// myArray = FillArrayRandom(size);
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// PrintArray(myArray);
// System.Console.WriteLine();

// PrintArray(ReverseArray(myArray));



