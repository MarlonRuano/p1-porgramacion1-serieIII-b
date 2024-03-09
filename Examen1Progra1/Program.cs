using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
  
        Console.WriteLine("¡Bienvenido!");


        Console.Write("Introduzca su correo electrónico: ");
        string correoElectronico = Console.ReadLine();

        if (correoElectronico.EndsWith("@gmail.com"))
        {
         
            string nuevoCorreo = correoElectronico.Replace("@gmail.com", "@miumg.edu.gt");

            
            Console.WriteLine("Su nuevo correo electrónico es: {0}", nuevoCorreo);
        }
        else
        {
          
            Console.WriteLine("El correo electrónico introducido no es válido. Debe terminar en @gmail.com");
        }

       
        Console.ReadKey();
    }
}
