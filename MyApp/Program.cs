Console.WriteLine("CalculadoraV2 (Mejoras para la V1) ====");

int operacion;
double num1, num2;

Console.WriteLine("Ingrese la operación que desea realizar:");
Console.WriteLine("[5] valor absoluto, [6] cuadrado, [7] raíz cuadrada, [8] seno, [9] coseno, [10] parte entera de un float)");
operacion = Convert.ToInt32(Console.ReadLine());   

Console.WriteLine("Ingrese el número a operar: ");
num1 = Convert.ToDouble(Console.ReadLine());

if (operacion == 7)
{
    while (num1 < 0)
    {
        Console.WriteLine("ERROR! La raíz cuadrada de un número negativo no existe");
        Console.WriteLine("Ingrese nuevamente el número: ");
        num1 = Convert.ToDouble(Console.ReadLine());
    }
}

switch (operacion)
{
    case 5:
        Console.WriteLine($"El valor absoluto es: {valorAbsoluto(num1)}");
        break;
    case 6:
        Console.WriteLine($"El cuadrado es: {cuadrado(num1)}");
        break;
    case 7:
        Console.WriteLine($"La raíz cuadrada es: {raizCuadrada(num1)}");
        break;
    case 8:
        Console.WriteLine($"El seno es: {seno(num1)}");
        break;
    case 9:
        Console.WriteLine($"El coseno es: {coseno(num1)}");
        break;
    case 10:
        Console.WriteLine($"La parte entera es: {parteEntera(num1)}");
        break;
}

Console.WriteLine("Ingrese la operación que desea realizar:");
Console.WriteLine("[11] el máximo entre 2 números, [12] el mínimo entre 2 números");
operacion = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Ingrese el primer número:");
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número:");
num2 = Convert.ToDouble(Console.ReadLine());
    
switch (operacion)
{
    case 11:
        Console.WriteLine($"El máximo entre los números es: {maximo(num1, num2)}");
        break;
    case 12:
        Console.WriteLine($"El mínimo entre los números es: {minimo(num1, num2)}");
        break;
}


double valorAbsoluto(double a)
{
    return Math.Abs(a);
}

double cuadrado(double a)
{
    return Math.Pow(a,2);
}

double raizCuadrada(double a)
{
    return Math.Sqrt(a);
}

double seno(double a)
{
    return Math.Sin(a);
}

double coseno(double a)
{
    return Math.Cos(a);
}

double parteEntera(double a)
{
    return Math.Truncate(a);
}

double maximo(double a, double b)
{
    return Math.Max(a, b);
}

double minimo(double a, double b)
{
    return Math.Min(a, b);
}