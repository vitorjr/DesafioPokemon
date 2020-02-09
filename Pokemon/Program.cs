using System;
using System.Net;
using HtmlAgilityPack;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Acesse o site https://www.pokemon.com/us/pokemon-tcg/pokemon-cards/");
            Console.WriteLine("2 - Realize uma pesquisa sem preencher nenhum campo(Clicando em Search)");
            Console.WriteLine("3 - Informe abaixo a quantidade de páginas:");
            int numero_paginas = int.Parse(Console.ReadLine());

            
            var wc = new WebClient();
            string pagina = wc.DownloadString("https://www.pokemon.com/us/pokemon-tcg/pokemon-cards/?cardName=&cardText=&evolvesFrom=&simpleSubmit=&format=unlimited&hitPointsMin=0&hitPointsMax=340&retreatCostMin=0&retreatCostMax=5&totalAttackCostMin=0&totalAttackCostMax=5&particularArtist=");

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(pagina);

            string url_imagem = string.Empty;
            string titulo = string.Empty;


        }
    }
}
