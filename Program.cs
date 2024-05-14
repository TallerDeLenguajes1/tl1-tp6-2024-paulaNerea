// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
int a;
int b;
a=10;
b=a;

Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/

//Ejercicio1 (Invertir un num)
//otra froma de leer un num y convertirlo directamente num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\t Ingrese un numero mayor a cero: ");

string texto;
texto = Console.ReadLine();
int sinInvertir;

if (int.TryParse(texto, out sinInvertir)) //si es un num... (tryparse devuelve un bool)
{
    Console.WriteLine("El num sin invertir:" + sinInvertir);
    if (sinInvertir > 0)
    {
        int invertido = 0;
        while (sinInvertir != 0)
        {
            int UltDigito = sinInvertir % 10; //obtengo el ult digito
            invertido = invertido * 10 + UltDigito; //agrego el ult digito al num invertido
            sinInvertir /= 10; //el num sin el ult digito
        }

        Console.WriteLine("El num invertido: " + invertido);
    }
    
}else
{
    Console.WriteLine("No ingreso un num"); 
}

//Ejercicio2




