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
        
        static int Sumar(int operando1, int operando2)
    {
        return operando1 + operando2;
    }

    static int Restar(int numero1, int numero2)
    {
        return numero1 - numero2;
    }

    static int Multiplicar(int numero1, int numero2)
    {
        return numero1 * numero2;
    }

    static int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

