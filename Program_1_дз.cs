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
//
