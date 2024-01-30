using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Gianni", "Morandi", 79);
            Console.WriteLine(persona1.GetNome());
            Console.WriteLine(persona1.GetCognome());
            Console.WriteLine(persona1.GetEtà());

            Console.WriteLine(persona1.GetDettagli());
            Console.WriteLine("");

            Persona persona2 = new Persona();
            Console.WriteLine("Inserisci il nome:");
            persona2.Nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome:");
            persona2.Cognome = Console.ReadLine();
            Console.WriteLine("Inserisci l'età:");
            persona2.Età = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine(persona2.GetDettagli());

            Console.ReadLine();
        }
    }
}
