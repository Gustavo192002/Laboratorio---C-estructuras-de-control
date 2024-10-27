namespace ejercicio_7;

class Program
{
    static void Main(string[] args)
    {
        //Desarrollar un programa que permita cargar n números enteros y luego nos 
        //informe cuántos valores fueron pares y cuántos impares.
        Console.WriteLine("Introduzca la cantidad de numeros enteros: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int pares = 0;
        int impares = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Introduce el numero {i + 1}:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }
        Console.WriteLine("Cantidad de números pares es de {0} y la cantidad de numeros impares es de {1}", pares, impares);
        Console.ReadLine();
    }
}
