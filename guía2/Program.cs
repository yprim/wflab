using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guía2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool content = true;
            bool noContent = false;

            Console.WriteLine("Tipode booleanos en c#. content =" + content);
            Console.WriteLine("Tipos booleanos en c#. noContent = " + noContent);
            Console.ReadLine();
            int unario = 0;
            int preIncremento;
            int preDecremento;
            int postIncremento;
            int postDecremento;
            int positivo;
            int negative;
            bool noLog;

            preIncremento = ++unario;
            Console.WriteLine("pre-incremento:{0}", preIncremento);

            preDecremento = --unario;
            Console.WriteLine("pre-Decremento:{0}", preDecremento);

            postDecremento = unario--;
            Console.WriteLine("post-decremento: {0}", postDecremento);

            postIncremento = unario++;
            Console.WriteLine("Posst-Incremento: {0}", postIncremento);

            Console.WriteLine("valor final de la var unario: {0}", unario);

            positivo = -postIncremento;
            Console.WriteLine("positivo: {0}", positivo);

            negative = +postIncremento;
            Console.WriteLine("negativo: {0}", negative);

            noLog = false;

            noLog = !noLog;

            Console.WriteLine("No logico (negación): {0}", noLog);

            Console.ReadLine();
            




        }
    }
}
