using Projeto02.Entidade;
using System;

namespace Projeto02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme filme1;
            filme1 = new Filme();
            filme1.Titulo = "avatar";
            filme1.Duracao = 190;

            Filme filme2;
            filme2 = new Filme();
            filme2.Titulo = "dinossauro";
            filme2.Duracao = 120;

            Filme filme3;
            filme3 = new Filme();
            filme3.Titulo = "fuga";
            filme3.Duracao = 90;


        }
    }
}
