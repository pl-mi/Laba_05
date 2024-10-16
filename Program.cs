using System;

class TTriangle
{
    private double a, b, c;

    public TTriangle()
    {
        a = 0;
        b = 0;
        c = 0;
    }

    public TTriangle(double sideA, double sideB, double sideC)
    {
        a = sideA;
        b = sideB;
        c = sideC;
    }

    public TTriangle(TTriangle triangle)
    {
        a = triangle.a;
        b = triangle.b;
        c = triangle.c;
    }

    public void InputSides()
    {
        Console.WriteLine("Введіть довжини трьох сторін трикутника:");
        Console.Write("Сторона A: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Сторона B: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Сторона C: ");
        c = Convert.ToDouble(Console.ReadLine());
    }

    public void PrintSides()
    {
        Console.WriteLine($"Сторони трикутника: A = {a}, B = {b}, C = {c}");
    }

    public double Area()
    {
        double s = (a + b + c) / 2; 
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public double Perimeter()
    {
        return a + b + c;
    }

    public bool CompareTo(TTriangle other)
    {
        return this.Perimeter() == other.Perimeter();
    }

    public static TTriangle operator +(TTriangle t1, TTriangle t2)
    {
        return new TTriangle(t1.a + t2.a, t1.b + t2.b, t1.c + t2.c);
    }

    public static TTriangle operator -(TTriangle t1, TTriangle t2)
    {
        return new TTriangle(t1.a - t2.a, t1.b - t2.b, t1.c - t2.c);
    }

    public static TTriangle operator *(TTriangle t, double multiplier)
    {
        return new TTriangle(t.a * multiplier, t.b * multiplier, t.c * multiplier);
    }
}

// Програма-клієнт для тестування
class Program
{
    static void Main(string[] args)
    {
        // Створення трикутників
        TTriangle triangle1 = new TTriangle(3, 4, 5);
        TTriangle triangle2 = new TTriangle();

        // Введення даних
        triangle2.InputSides();

        // Виведення сторін трикутників
        Console.WriteLine("Трикутник 1:");
        triangle1.PrintSides();
        Console.WriteLine("Трикутник 2:");
        triangle2.PrintSides();

        // Обчислення площі та периметру
        Console.WriteLine($"Площа трикутника 1: {triangle1.Area()}");
        Console.WriteLine($"Периметр трикутника 1: {triangle1.Perimeter()}");

        Console.WriteLine($"Площа трикутника 2: {triangle2.Area()}");
        Console.WriteLine($"Периметр трикутника 2: {triangle2.Perimeter()}");

        // Порівняння трикутників
        if (triangle1.CompareTo(triangle2))
        {
            Console.WriteLine("Трикутники мають однаковий периметр.");
        }
        else
        {
            Console.WriteLine("Трикутники мають різний периметр.");
        }

        // Операції додавання, віднімання та множення
        TTriangle sumTriangle = triangle1 + triangle2;
        Console.WriteLine("Сума трикутників:");
        sumTriangle.PrintSides();

        TTriangle subTriangle = triangle1 - triangle2;
        Console.WriteLine("Різниця трикутників:");
        subTriangle.PrintSides();

        TTriangle mulTriangle = triangle1 * 2;
        Console.WriteLine("Множення трикутника 1 на 2:");
        mulTriangle.PrintSides();
    }
}
