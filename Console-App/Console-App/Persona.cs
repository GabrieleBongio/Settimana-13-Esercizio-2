using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Età { get; set; }

        public string GetNome() { return Nome; }
        public string GetCognome() { return Cognome; }
        public int GetEtà() { return Età; }
        public string GetDettagli() { return $"{Nome} {Cognome} di {Età} anni"; }

        public Persona() { }

        public Persona(string nome, string cognome, int età)
        {
            Nome = nome;
            Cognome = cognome;
            Età = età;
        }


    }
}
