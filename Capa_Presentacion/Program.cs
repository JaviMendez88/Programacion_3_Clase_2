// See https://aka.ms/new-console-template for more information
using Capa_LogicaNegocio.Operaciones;

/*
String escrituraUsuario = Console.ReadLine();
Console.WriteLine(escrituraUsuario);
*/


Suma opSuma = new Suma();

Console.WriteLine("Escriba un número: ");
String num1 = Console.ReadLine();
Console.WriteLine("Escriba otro número: ");
String num2 = Console.ReadLine();

// Se establece un try catch para que el programa no se caiga si el usuario ingresa caracteres y no números

int numeroCorrecto1 = 0;
int numeroCorrecto2 = 0;

try
{
    numeroCorrecto1 = Int32.Parse(num1);
    numeroCorrecto2 = Int32.Parse(num2);

} catch (Exception e)
{
    Console.WriteLine("\n¡Digite números únicamente!\n");

}
    
double resultadoSuma = opSuma.Sume_Dos_Numeros(Int32.Parse(num1), Int32.Parse(num2)); //Parsing for number data type change (double to Int)
Console.WriteLine("El resultado de la SUMA hecha es: "+resultadoSuma);


//Operacion de resta *****************************************************************************


Resta opResta = new Resta();
Console.WriteLine("Escriba un número: ");
String num3 = Console.ReadLine();
Console.WriteLine("Escriba otro número: ");
String num4 = Console.ReadLine();

try
{
    numeroCorrecto1 = Int32.Parse(num3);
    numeroCorrecto2 = Int32.Parse(num4);

}
catch (Exception e)
{
    Console.WriteLine("\n¡Digite números únicamente!\n");

}

double resultado = opResta.Reste_Dos_Numeros(Int32.Parse(num3), Int32.Parse(num4)); //Parsing for number data type change (double to Int)
Console.WriteLine("El resultado de la RESTA hecha es: " + resultado);

/*
char tipoOperacion;

switch (tipoOperacion)
{
    case r: 
        break;
    case s:
        break;
    case m:
        break;
    case d:
        break;
}
*/