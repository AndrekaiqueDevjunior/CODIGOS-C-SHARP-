using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseComErro
{
    internal class Filme
    {
        public string nome;
        public string Desc;
        public string ano;
        public string studio;
        public List<string> atores = new List<string>();

        static public string plataforma = "PobreFlix";
        public void Executar()
        {
            Console.WriteLine("Rodando Filme: " + nome);


        }

        public void Pausar()
        {
            Console.WriteLine(plataforma);
            Console.WriteLine("PAUSADO ||");
            Console.WriteLine();
        }
    }
}
////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseComErro
{
    //animal;mamifero

    public class ClasseComErro
    {
        static void Main(string[] args)
        {
            Filme filme = new Filme();
            filme.nome = "As Branquelas";
            filme.Executar();


            Filme filme2 = new Filme();
            filme2.nome = "Ta dando Onda";
            filme2.Executar();

            Filme filme3 = new Filme();
            filme3.nome = "A Era do Gelo";
            filme3.Executar();

            Filme filme4 = new Filme();
            filme4.nome = "AVATAR  A LENDA DE AANG";
            filme4.Executar();

            Filme.Pausar();

            Console.ReadLine();
        }
    }

}
        
