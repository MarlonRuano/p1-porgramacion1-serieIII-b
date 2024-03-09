using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
   
        Console.WriteLine("¡Bienvenido a la tienda!");

        double precioProducto1, precioProducto2, precioProducto3;
        double totalCompraBruto = 0;
        double totalCompraDescuento = 0;
        double totalDescuento = 0;

        Console.Write("Introduzca el precio del primer producto: ");
        precioProducto1 = double.Parse(Console.ReadLine());

        Console.Write("Introduzca el precio del segundo producto: ");
        precioProducto2 = double.Parse(Console.ReadLine());

        Console.Write("Introduzca el precio del tercer producto: ");
        precioProducto3 = double.Parse(Console.ReadLine());

        totalCompraBruto = precioProducto1 + precioProducto2 + precioProducto3;

        if (precioProducto1 > 100000)
        {
            totalDescuento += CalcularDescuento(precioProducto1, 0.15);
        }

        if (precioProducto2 > 100000)
        {
            totalDescuento += CalcularDescuento(precioProducto2, 0.15);
        }

        if (precioProducto3 > 100000)
        {
            totalDescuento += CalcularDescuento(precioProducto3, 0.15);
        }

        totalCompraDescuento = totalCompraBruto - totalDescuento;

        Console.WriteLine("Total compra sin descuentos: {0:C2}", totalCompraBruto);
        Console.WriteLine("Total descuento: {0:C2}", totalDescuento);
        Console.WriteLine("Total compra con descuentos: {0:C2}", totalCompraDescuento);


    
        Console.ReadKey();
    }
    static double CalcularDescuento(double precio, double porcentajeDescuento)
    {
        return precio * porcentajeDescuento;
    }
}
