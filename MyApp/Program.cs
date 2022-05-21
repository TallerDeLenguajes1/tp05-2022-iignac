Console.WriteLine("==== Ejercicio 1 ====");

Console.WriteLine("Ingrese el número a invertir (mayor a 0): ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    int numeroInvertido = 0, ultimoDigito;
    while (numero > 0)
    {
        ultimoDigito = numero % 10;
        numeroInvertido = (numeroInvertido * 10) + ultimoDigito;
        numero = numero / 10;
    }
    Console.WriteLine("El número invertido es: " + numeroInvertido);
}
else
{
    Console.WriteLine("La conversión no se realizó porque el número ingresado NO es mayor a 0");
}


/* otra forma: tomar el número como una cadena y luego invertirlo

Console.WriteLine("Ingrese el numero a invertir (mayor a 0): ");
char[] array = Console.ReadLine().ToCharArray();

Array.Reverse(array);

string numeroInvertido = new string(array);

Console.WriteLine("El numer invertido es: " + numeroInvertido); */