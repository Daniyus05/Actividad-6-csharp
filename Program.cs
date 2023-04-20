// See https://aka.ms/new-console-template for more information
        Console.WriteLine("¡Hola! A continuación, ingresa dos números: ");
        Console.Write("Primer número: ");
      var primerNumero = Console.ReadLine();
 int numero1 = int.Parse(primerNumero); 
Console.WriteLine("¿Cuál es el segundo número que has elegido?");
var segundoNumero = Console.ReadLine();
int numero2 = int.Parse(segundoNumero); 
        Console.WriteLine("Suma: " + Sumar(numero1, numero2));
        Console.WriteLine("Resta: " + Restar(numero1, numero2));
        Console.WriteLine("Multiplicación: " + Multiplicar(numero1, numero2));
        Console.WriteLine("División: " + Dividir(numero1, numero2));
        
        static double Sumar(int numero1, int numero2)
    {
        return numero1 + numero2;
    }

    static double Restar(int numero1, int numero2)
    {
        return numero1 - numero2;
    }

    static double Multiplicar(int numero1, int numero2)
    {
        return numero1 * numero2;
    }

    static double Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

