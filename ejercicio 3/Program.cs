namespace ejercicio_3;

class Program
{
    static void Main(string[] args)
    {
        //Confeccionar un programa que permita cargar un número entero positivo
        //de hasta tres digitos y muestre un mensaje indicando si tiene 1, 2, o 3 dígitos. 
        //Mostrar un mensaje de error si el número de dígitos es mayor
        // Solicitar al usuario que ingrese un número entero positivo de hasta tres dígitos
        Console.WriteLine("Introdusca el numero entero positivo de hasta 3 digitos: ");
        int numeroEntero = Convert.ToInt32(Console.ReadLine());

        if (numeroEntero >= 0 && numeroEntero <= 9)
        {
            Console.WriteLine("El numero tiene 1 digito");
        }
        else if (numeroEntero >= 10 && numeroEntero <= 99)
        {
            Console.WriteLine("El numero tiene 2 digitos");
        }
        else if (numeroEntero >= 100 && numeroEntero <= 999)
        {
            Console.WriteLine("El numero tiene 3 digitos");
        }
        else
        {
            Console.WriteLine("Error el numero: {0} tiene mas de 3 digitos", numeroEntero);
        }
        Console.ReadLine();
    }
}
