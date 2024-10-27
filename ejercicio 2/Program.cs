namespace ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        //Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad 
        //que lleva el cliente. Mostrar lo que debe abonar el comprador.
        Console.WriteLine("Ingrese el precio del articulo: ");
        double precioArticulo = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Ingrese las unidades que desea comprar: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        double total = precioArticulo * cantidad;

        Console.WriteLine("Su total a pagar es de: Q.{0}",total);
        Console.ReadLine();
    }
}
