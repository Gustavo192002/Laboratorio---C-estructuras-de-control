namespace ejercicio_5;

class Program
{
    static void Main(string[] args)
    {
        //Escribir un programa que pida ingresar la coordenada de un punto en el plano, es decir
        //dos valores enteros x e y (distintos a cero). Posteriormente imprimir en pantalla
        //en que cuadrante se ubica dicho punto. 
        //(1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0, etc.)
    
        Console.WriteLine("Introduce la coordenada x (distinta de cero):");
        int x = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine("Introduce la coordenada y (distinta de cero):");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("El punto se encuentra en el 1º Cuadrante.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("El punto se encuentra en el 2º Cuadrante.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("El punto se encuentra en el 3º Cuadrante.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("El punto se encuentra en el 4º Cuadrante.");
        }
        else
        {
            Console.WriteLine("Error las coordenadas no deben ser cero.");
        }

        Console.ReadLine();
    }
}
