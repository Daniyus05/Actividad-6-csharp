// See https://aka.ms/new-console-template for more information
        Console.WriteLine("¡Hola! A continuación, ingresa dos números: ");
        Console.Write("Primer número: ");
      var primerNumero = Console.ReadLine();
 int numero1 = int.Parse(primerNumero); 
Console.WriteLine("¿Cuál es el segundo número que has elegido?");
var segundoNumero = Console.ReadLine();
int numero2 = int.Parse(segundoNumero); 
        Console.WriteLine("El resultado de sumar " +numero1+ " y " +numero2+ " es " + Sumar(numero1, numero2));
        Console.WriteLine("El resultado de restar " +numero1+ " y " +numero2+ " es " + Restar(numero1, numero2));
        Console.WriteLine("El resultado de multiplicar " +numero1+ " y " +numero2+ " es " + Multiplicar(numero1, numero2));
        Console.WriteLine("El resultado de dividir " +numero1+ " y " +numero2+ " es " + Dividir(numero1, numero2));
        
        static int Sumar(int sumando1, int sumando2)
    {
        return sumando1 + sumando2;
    }

    static int Restar(int minuendo, int sustraendo)
    {
        return minuendo - sustraendo;
    }

    static int Multiplicar(int factor1, int factor2)
    {
        return factor1 * factor2;
    }

    static int Dividir(int dividendo, int divisor)
        {
            return dividendo / divisor;
        }
