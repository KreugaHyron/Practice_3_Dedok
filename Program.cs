// See https://aka.ms/new-console-template for more information\

//3
Console.WriteLine("Task_3: ");
Predicate<int> isEven = (int number) => number % 2 == 0;
Predicate<int> isOdd = (int number) => number % 2 != 0;
Predicate<int> isPrime = IsPrime;
Predicate<int> isFibonacci = IsFibonacci;
Console.Write("Введіть число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {number} є парним: {isEven.Invoke(number)}");
Console.WriteLine($"Число {number} є непарним: {isOdd.Invoke(number)}");
Console.WriteLine($"Число {number} є простим: {isPrime.Invoke(number)}");
Console.WriteLine($"Число {number} є числом Фібоначчі: {isFibonacci.Invoke(number)}");
static bool IsPrime(int number)
{
    if (number <= 1)
        return false;
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}
static bool IsFibonacci(int number)
{
    if (number < 0)
        return false;
    int a = 0, b = 1;
    while (a < number)
    {
        int temp = a;
        a = b;
        b = temp + b;
    }
    return a == number;
}
//4
Console.WriteLine("Task_4: ");
Predicate<int> isEven_1 = delegate (int number_1)
    {
        return number_1 % 2 == 0;
    };

    Console.Write("Введіть число: ");
    int number_1 = Convert.ToInt32(Console.ReadLine());

    bool result = isEven_1(number_1);

    if (result)
    {
        Console.WriteLine($"Число {number_1} є парним.");
        Console.WriteLine();
}
    else
    {
        Console.WriteLine($"Число {number_1} є непарним.");
        Console.WriteLine();
}
//5
Console.WriteLine("Task_5: ");
Func<int, int> cube = x => x * x * x;
Console.Write("Введіть число для підрахунку його куба: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
int result_1 = cube(number_2);

Console.WriteLine($"Куб числа {number_2} дорівнює {result_1}");
Console.WriteLine();
//6
Console.WriteLine("Task_6: ");
Random random = new Random();
int[] randomArray = new int[10];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = random.Next(1, 100); 
}
Console.WriteLine("Згенерований масив:");
Console.WriteLine(string.Join(" ", randomArray));
var oddNumbers = randomArray.Where(x => x % 2 != 0).ToArray();
Console.WriteLine("\nНепарні числа:");
Console.WriteLine(string.Join(" ", oddNumbers));
Console.WriteLine();