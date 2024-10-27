namespace ejercicio_6;

class Program
{
    static void Main(string[] args)
    {
        //De un operario se conoce su sueldo y los años de antigüedad.
        //Se pide confeccionar un programa que lea los datos de entrada e informe:
        //a.Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años, 
        //otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
        //b.Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, 
        //otorgarle un aumento de 5 %
        //c.Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios
        Console.WriteLine("Introduce el sueldo del operario: ");
        double sueldo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce los años de antigüedad del operario: ");
        int antiguedad = Convert.ToInt32(Console.ReadLine());

        if (sueldo < 500)
        {
            if (antiguedad >= 10)
            {
                sueldo += sueldo * 0.20;
            }
            else
            {
                sueldo += sueldo * 0.05;
            }
        }

        Console.WriteLine("El sueldo a pagar es de: {0}", sueldo);
        Console.ReadLine();
    }
}
