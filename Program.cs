// Задача 2           

	Console.WriteLine("Введи 2 числа и мы тебе скажем какое из них больше");
	int a, b;
	Console.WriteLine("Введи свое первое число - ");
	a = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Введи свое второе число - ");
	b = Convert.ToInt32(Console.ReadLine());
 
	bool Chto0 = a > b;
	bool Chto1 = a == b;
	bool Chto2 = a < b;
 
	if (Chto0)
	{
	Console.WriteLine($"Число {a} больше чем {b}");
	}
	else if (Chto1)
	{
	Console.WriteLine($"Числа {a} и {b} равны");
	}
	else
	{
	Console.WriteLine($"Число {b} больше чем {a}");
	}
//

// Задача 4

        {
        Console.WriteLine("Введи 3 числа и мы тебе скажем какое из них больше");
        int a, b, c;
        Console.WriteLine("Введи свое первое число - ");
        a = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Введи свое второе число - ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введи свое третье число - ");
        c = Convert.ToInt32(Console.ReadLine());
        int max = a;

        if (b > max)max=b;
        if (c > max)max=c;

        Console.WriteLine($"Максимальное число {max}");
            
        }
//

// Задача 6

        {
        Console.WriteLine((int.Parse(Console.ReadLine()) & 1) == 0? "Да": "Нет");
        }
//

// Задача 8 
    {
    foreach (int i in Enumerable.Range(1, int.Parse(Console.ReadLine()) >> 1))
    Console.WriteLine(i << 1);
    }
//﻿
//Задача 10           


Console.Clear();
Console.WriteLine("Задача 10 ");
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
//

//Задача 13

Console.WriteLine("Задача 13 ");

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
//

//Задача 15

Console.WriteLine("Задача 15 ");

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);
//

// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Задача 19");
// Console.Write("Введите число: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number){
//   if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine($"Ваше число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// }

// if (number!.Length == 5){
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");
//

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("\n Задача 21");
// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// double Decision(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2){
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                    Math.Pow((z2-z1), 2));
// }

// double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine($"Длина отрезка  {segmentLength}");
//
//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.WriteLine("\n Задача 23");
// Console.Write("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cube){
//   int counter = 0;
//   int length = cube.Length;
//   while (counter <  length){
//     cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//     counter++;
//   }
// }

// void PrintArray(int[] coll){
//   int count = coll.Length;
//   int index = 0;
//   while(index < count){
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 

// int[] array = new int[cube+1];
// Cube(array);
// PrintArray(array);
//
