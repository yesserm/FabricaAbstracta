using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            IFechaFactory factory;
            FechaTexto ft;
            FechaNum fn;

            String formato, pais;

            int a = 0, m = 0, d = 0;

            Console.WriteLine("Selecione formato de fecha (T/N)");
            formato = Console.ReadLine().ToUpper();

            Console.WriteLine("Seleccione el pais (E/U)");
            pais = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingrese año");
            a = Int32.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine("Ingrese mes");
            m = Int32.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine("Ingrese dia");
            d = Int32.Parse(Console.ReadLine().ToUpper());

            if (pais.Equals("E"))
            {
                factory = new SPFechaFactory();
                if (formato.Equals("T"))
                {
                    ft = factory.CrearFechaTexto(a,m,d);
                    Console.WriteLine(ft.PresentarFT());
                } 
                else if(formato.Equals("N"))
                {
                    fn = factory.CrearFechaNum();
                    Console.WriteLine(fn.PresentarFN());
                } 
                else
                {
                    Console.WriteLine("formato incorrecto");
                    Environment.Exit(0);
                }
            } 
            else if(pais.Equals("U"))
            {
                factory = new USFechaFactory();
                if(formato.Equals("T"))
                {
                    ft = factory.CrearFechaTexto(a,m,d);
                    Console.WriteLine(ft.PresentarFT());
                } 
                else if(formato.Equals("N"))
                {
                    fn = factory.CrearFechaNum();
                    Console.WriteLine(fn.PresentarFN());
                }
                else
                {
                    Console.WriteLine("Formato incorrecto");
                    Environment.Exit(0);
                }
            }
            Console.ReadKey();
        }
    }
}
