Console.WriteLine("==== Ejercicio 2 - CalculadoraV1 ====");

int operacion, num1, num2, repetir;

do
{
    Console.WriteLine("Ingrese la operación que desea realizar (1: sumar, 2: restar, 3: multiplicar, 4: dividir)");
    operacion = Convert.ToInt32(Console.ReadLine());   
    
    Console.WriteLine("Ingrese el primer número: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo número: ");
    num2 = Convert.ToInt32(Console.ReadLine()); 

    if (operacion == 4)
    {
        while (num2 == 0)
        {
            Console.WriteLine("ERROR! el divisor no puede ser 0");
            Console.WriteLine("Ingrese nuevamente el divisor: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
    }
    
    switch (operacion)
    {
        case 1:
            Console.WriteLine($"El resultado de la suma es: {sumar(num1, num2)}");
            break;
        case 2:
            Console.WriteLine($"El resultado de la resta es: {restar(num1, num2)}");
            break;
        case 3:
            Console.WriteLine($"El resultado del producto es: {multiplicar(num1, num2)}");
            break;
        case 4:
            Console.WriteLine($"El resultado de la división es: {dividir(num1, num2)}");
            break;
    }

    Console.WriteLine("Desea realizar otro cálculo? (1: Si, 0: No)");
    repetir = Convert.ToInt32(Console.ReadLine());

} while (repetir == 1);


int sumar(int a, int b)
{
    return a + b;
}

int restar(int a, int b)
{
    return a - b;
}

int multiplicar(int a, int b)
{
    return a * b;
}

int dividir(int a, int b)
{
    return a / b;
}