namespace C__lab;

class Program
{
    static void Main(string[] args)
    {
        //Realizar la carga del lado de un cuadrado, mostrar por pantalla 
        //el perímetro del mismo (El perímetro de un cuadrado se calcula
        //multiplicando el valor del lado por cuatro)
        Console.WriteLine("Ingrese el valor del lado del cuadrado: ");
        double lado = Convert.ToDouble(Console.ReadLine());  

        double perimetro = lado * 4;
        
        Console.WriteLine("El perimetro es: {0}", perimetro);
        Console.ReadLine();
    }
}