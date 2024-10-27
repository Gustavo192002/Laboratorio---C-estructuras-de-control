namespace ejercicio_9;

class Program
{
    static void Main(string[] args)
    {
        //Realizar un programa que acumule (sume) valores ingresados por teclado
        //hasta ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). 
        //Imprimir el valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.
        

        Console.WriteLine("Introduzca los valores para acumular (ingresa 9999 para finalizar): ");
        int acumulado = 0;
        int numero;
        do
        {
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero != 9999)
            {
                acumulado += numero;
            }

        } while (numero != 9999);

        Console.WriteLine("El valor acumulado es: {0}",acumulado);

        if (acumulado > 0)
        {
            Console.WriteLine("El valor acumulado es mayor a cero.");
        }
        else if (acumulado < 0)
        {
            Console.WriteLine("El valor acumulado es menor a cero.");
        }
        else
        {
            Console.WriteLine("El valor acumulado es cero.");
        }
        Console.ReadLine();
    }
}
