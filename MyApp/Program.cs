// obtener algunas letras que forman parte de una cadena:
string name = "David";
char first = name[0];
Console.WriteLine(first);
Console.WriteLine(name[1]);
Console.WriteLine(name[4]);

// Obtener la longitud de la cadena y muestre por pantalla
Console.WriteLine("La cadena nombre contiene {0} caracteres", name.Length);

// ToString: convierte una variable de cualquier tipo en un objeto del tipo String
bool booleanvariable = true;
string stringvariable = booleanvariable.ToString();
Console.WriteLine(stringvariable);


// Concatenar (Unir) dos cadenas distintas
string cadena1 = "conca";
string cadena2 = "tenar";
string cadenaAux = cadena1 + cadena2;
Console.WriteLine(cadenaAux);

// otro ejemplo de concatenar:
string dateString = DateTime.Today.ToShortDateString();
string str = "Hello " + name + ". Today is " + dateString + ".";
Console.WriteLine(str);

str += " How are you today?";
Console.WriteLine(str);


// Extraer una subcadena
string cadena3 = "hola como estas";
cadena3 = cadena3.Substring(0, 9);
// 0: posicion de la cadena desde donde extraer la subcadena
// 9: cantidad de caracteres a extraer
Console.WriteLine(cadena3);


//Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
string cadena4 = "soy una cadena bien piola";

foreach (char item in cadena4)
{
    Console.WriteLine(item);  
}

// recorriendo con for:
for (int i = 0; i < cadena4.Length; i++)
{
    Console.WriteLine(cadena4[i]);
}


// Buscar la ocurrencia de una palabra determinada en la cadena ingresada
int ocurrencia = cadena4.IndexOf("piola"); // busco la ocurrencia de la palabra 'piola' en 'cadena4'
Console.WriteLine("ocurrencia: " + ocurrencia);


// Convierta la cadena a Mayúsculas y luego minúsculas
cadena4 = cadena4.ToUpper();
Console.WriteLine(cadena4);

cadena4 = cadena4.ToLower();
Console.WriteLine(cadena4);


// Ingrese una nueva cadena y luego compare los valores de ambas
string cadena5 = "soy una cadena bien piola";
int resultado = cadena4.CompareTo(cadena5);
if (resultado == 0)
{
    Console.WriteLine("Las cadenas son iguales");
}


// Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split())
string cadena6 = "boca*le ganó*a*tigre y salió*campeón";
char [] separador = {'*' , ' '};
string [] trozos = cadena6.Split(separador);

for (int i = 0; i < trozos.Length; i++)
{
    Console.WriteLine("Fragmento {0} = {1}", (i+1), trozos[i]);
    
}


// ingrese una ecuación simple como cadena de caracteres y que el sistema lo resuelva
Console.WriteLine("Ingrese una ecuación simple, de 2 operandos y 1 operador (Ejemplo: 582+2)");
string ecuacion = Console.ReadLine();
string [] array = ecuacion.Split('+', '-', '*', '/');
int numero1 = Convert.ToInt32(array[0]);
int numero2 = Convert.ToInt32(array[1]);

if (ecuacion.Contains('+'))
{
    Console.WriteLine($"La suma de {numero1} y {numero2} es {numero1+numero2}");
}
else
{
    if (ecuacion.Contains('-'))
    {
        Console.WriteLine($"La resta de {numero1} y {numero2} es {numero1-numero2}");
        
    }
    else
    {
        if (ecuacion.Contains('*'))
        {
            Console.WriteLine($"La multiplicación de {numero1} por {numero2} es {numero1*numero2}");
        }
        else
        {
            Console.WriteLine($"La división de {numero1} en {numero2} es {numero1/numero2}");
        }
    }
}