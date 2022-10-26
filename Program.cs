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


// Задача 6

         {
         Console.WriteLine((int.Parse(Console.ReadLine()) & 1) == 0? "Да": "Нет");
         }


// Задача 8 
     {
     foreach (int i in Enumerable.Range(1, int.Parse(Console.ReadLine()) >> 1))
     Console.WriteLine(i << 1);
     }

//Задача 10           


 Console.Clear();
 Console.WriteLine("Задача 10 ");
 Console.Write("Введи трёхзначное число: ");
 int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
 string stringNumber = Convert.ToString(threeDigitNumber);
 Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);


// //Задача 13

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


// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

 Console.WriteLine("Задача 19");
 Console.Write("Введите число: ");
 string? number = Console.ReadLine();

 void CheckingNumber(string number){
   if (number[0]==number[4] || number[1]==number[3]){
     Console.WriteLine($"Ваше число: {number} - палиндром.");
   }
   else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
 }

 if (number!.Length == 5){
   CheckingNumber(number);
 }
 else Console.WriteLine($"Введи правильное число");


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

 Console.WriteLine("\n Задача 21");
 int x1 = Coordinate("x", "A");
 int y1 = Coordinate("y", "A");
 int z1 = Coordinate("z", "A");
 int x2 = Coordinate("x", "B");
 int y2 = Coordinate("y", "B");
 int z2 = Coordinate("z", "B");

 int Coordinate(string coorName, string pointName)
 {
     Console.Write($"Введите координату {coorName} точки {pointName}: ");
     return Convert.ToInt16(Console.ReadLine());
 }

 double Decision(double x1, double x2, 
                 double y1, double y2, 
                 double z1, double z2){
   return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                    Math.Pow((y2-y1), 2) + 
                    Math.Pow((z2-z1), 2));
 }

 double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

 Console.WriteLine($"Длина отрезка  {segmentLength}");

//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

 Console.WriteLine("\n Задача 23");
 Console.Write("Введите число: ");
 int cube = Convert.ToInt32(Console.ReadLine());

 void Cube(int[] cube){
   int counter = 0;
   int length = cube.Length;
   while (counter <  length){
     cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
     counter++;
   }
 }

 void PrintArray(int[] coll){
   int count = coll.Length;
   int index = 0;
   while(index < count){
     Console.Write(coll[index]+ " ");
     index++;
   }
 } 

 int[] array = new int[cube+1];
 Cube(array);
 PrintArray(array);


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

 Console.WriteLine($"\nЗадача 25. Возведене числа A в натуральную степень B");

 int Exponentiation(int numA, int numB)
 {
   int result = 1;
   for(int i=1; i <= numB; i++){
     result = result * numA;
   }
     // int result = Math.Pow(numrA, numB);
     return result;
 }

   Console.Write("Введите число A: ");
   int numA = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите число B: ");
   int numB = Convert.ToInt32(Console.ReadLine());

   int exponentiation = Exponentiation(numA, numB);
   Console.WriteLine("Ответ: " + exponentiation);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

 Console.WriteLine($"\nЗадача 27. Выдаёт сумму цифр в числе");
 Console.Write("Введите число N: ");
 int numN = Convert.ToInt32(Console.ReadLine());

   int SumNum(int numN)
   {
    
     int counter = Convert.ToString(numN).Length;
     int advance = 0;
     int result = 0;

     for (int i = 0; i < counter; i++){
       advance = numN - numN % 10;
       result = result + (numN - advance);
       numN = numN / 10;
     }
    return result;
   }

 int sumNum = SumNum(numN);
 Console.WriteLine("Сумма цифр в числе: " + sumNum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

 Console.WriteLine($"\nЗадача 29. Ряд чисел преобразует в массив");
 Console.Write("Введите ряд чисел, разделенных запятой : ");
 string? seriesOfNumbers = Console.ReadLine();

  seriesOfNumbers = seriesOfNumbers + ",";    

  string RemovingSpaces (string series)
  {
    string seriesNew = "";
    for (int i = 0; i < series.Length; i++)
    {
      if (series[i] != ' ') 
      {
        seriesNew += series[i];
      }
    }
    return seriesNew;
  }

  void СheckNumber2 (int  series)
  {

        if (series == '0'||series == '1'||series == '2'
        ||series == '3'||series == '4'||series == '5'||series == '6'
        ||series == '7'||series == '8'||series == '9'||series == ','
        ||series == '-')
        {
        }
          else {
            Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

        }
 }

 int[] ArrayOfNumbers(string seriesNew)
 { 

   int[] arrayOfNumbers = new int[1];    

   int j =0;

   for (int i = 0; i < seriesNew.Length; i++)
   {
     string seriesNew1 = "";

     while (seriesNew[i] != ',' && i < seriesNew.Length)
     {
       seriesNew1 += seriesNew[i];
       СheckNumber2(seriesNew[i]);
       i++;
     }
     arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    
     if (i < seriesNew.Length-1){
       arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    
     }
     j++;
   }
   return arrayOfNumbers;
 }

 void PrintArry(int[] coll)
 {
   int count = coll.Length;
   int index = 0;
   Console.Write("[");
   while(index < count){
     Console.Write(coll[index]);
     index++;
     if (index < count){
       Console.Write(", ");
     }
   }
   Console.Write("]");
 } 

  string seriesNew = RemovingSpaces(seriesOfNumbers);

  int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

 PrintArry(arrayOfNumbers);

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
Console.WriteLine($"Задача 34. Количество чётных чисел в массиве:\n");
int[] num = new int[4];

void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int QuantityPositive(int[] array)
{
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 != 1)
    {
      quantity++;
    }
  }
  return quantity;
}

FillArray(num, 100, 1000);
WriteArray(num);
Console.WriteLine();

int quantity = QuantityPositive(num);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine($"\nЗадача 36. Сумма элементов, стоящих на нечётных позициях:\n");
Console.Write($"Введи количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numberElements, int min, int max)
  {
  int[] randomNumbers = new int[numberElements];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ )
    {
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 == 1)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

int randomNumbers =  RandomNumbers(numberElements, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine($"\nЗадача 38. Найдите разницу между максимальным и минимальным элементов массива из вещественных чисел:\n");

double[] arrayRealNumbers = new double[5];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");

// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine($"Задача 41. Cколько чисел больше 0 ввёл пользователь \n");
Console.Write($"Введите число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Чисел больше 0: {Comparison(massiveNumbers)} ");

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine($"\nЗадача 43.  Найти точку пересечения двух прямых \n");

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients()
{
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void OutputResponse(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(coeff);
    Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
OutputResponse(coeff);

// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine($"Задача 47: Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.");

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);

WriteArray(array);

Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}

// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine($"Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.");

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);

WriteArray(array);

Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}

Console.Write("Введите координаты позиции элемента, разделенных запятой: ");

string? positionElement = Console.ReadLine();
positionElement = RemovingSpaces(positionElement);
int[] position = ParserString(positionElement);

if(position[0] <= m 
&& position[1] <= n 
&& position[0] >= 0 
&& position[1] >= 0) 
{
  double result = array[position[0]-1, position[1]-1];
  Console.Write($"Значение элемента: {result}");
}
else Console.Write($"такого элемента в массиве нет.");

int[] ParserString(string input)
{
  int countNumbers = 1;
  for (int i = 0; i < input.Length; i++)
  {
      if (input[i] == ',')
          countNumbers++;
  }

  int[] numbers = new int[countNumbers];

  int numberIndex = 0;
  for(int i = 0; i < input.Length; i++)
  {
    string subString = String.Empty;

    while (input[i] != ',')
    {
      subString += input[i].ToString();
      if (i >= input.Length - 1)
        break;
      i++;
    }
    numbers[numberIndex] = Convert.ToInt32(subString);
    numberIndex++;
  }

  return numbers;
}

string RemovingSpaces (string input)
{
  string output = String.Empty;
  for (int i = 0; i < input.Length; i++)
  {
    if (input[i] != ' ') 
    {
      output += input[i];
    }
  }
  return output;
}

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine($"Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.");

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);

WriteArray(array);

Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}

int[,] arrayWhole = new int[m, n];
arrayWhole = TransformationArrayWhole(array);

WriteArrayInt(arrayWhole);

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticMean += arrayWhole[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / m, 1);
  Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
}

int[,] TransformationArrayWhole (double[,] array)
{
  int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return arrayWhole;
}

void WriteArrayInt (int[,] arrayWhole){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write(arrayWhole[i, j] + " ");
      }
      Console.WriteLine();
  }
}
