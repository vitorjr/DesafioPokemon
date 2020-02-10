using System;
using System.Net;
using HtmlAgilityPack;
using System.IO;
using System.Linq;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string url = "https://www.pokemon.com/us/pokemon-tcg/pokemon-cards/?cardName=&cardText=&evolvesFrom=&simpleSubmit=&format=unlimited&hitPointsMin=0&hitPointsMax=340&retreatCostMin=0&retreatCostMax=5&totalAttackCostMin=0&totalAttackCostMax=5&particularArtist=";
            WebClient wc = new WebClient();
            string html = wc.DownloadString(url);
            Console.WriteLine(html);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            foreach(HtmlNode node in doc.DocumentNode.SelectNodes("cards-grid clear"))
            {
                Console.WriteLine(node.InnerText);
            }
            */
            
            
            
            
            
            
            
            
            /*
            Console.WriteLine("1 - Acesse o site https://www.pokemon.com/us/pokemon-tcg/pokemon-cards/");
            Console.WriteLine("2 - Realize uma pesquisa sem preencher nenhum campo(Clicando em Search)");
            Console.WriteLine("3 - Informe abaixo a quantidade de páginas:");*/

            //string url_pokemon = "https://www.pokemon.com/us/pokemon-tcg/pokemon-cards/";
            //HtmlWeb web = new HtmlWeb();

            //HtmlDocument doc = web.Load(url_pokemon + "?cardName=&cardText=&evolvesFrom=&simpleSubmit=&format=unlimited&hitPointsMin=0&hitPointsMax=340&retreatCostMin=0&retreatCostMax=5&totalAttackCostMin=0&totalAttackCostMax=5&particularArtist=");

           

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            

            var wc = new WebClient();
            string teste = "https://www.pokemon.com/us/pokemon-tcg/pokemon-cards/?cardName=&cardText=&evolvesFrom=&simpleSubmit=&format=unlimited&hitPointsMin=0&hitPointsMax=340&retreatCostMin=0&retreatCostMax=5&totalAttackCostMin=0&totalAttackCostMax=5&particularArtist=";
            string pagina = wc.DownloadString(teste);

            htmlDocument.LoadHtml(pagina);

            Console.WriteLine("Passou");

            foreach(HtmlNode node in htmlDocument.DocumentNode.SelectNodes("//a[@href]"))
            {
                Console.WriteLine(node);
            }


            /*
            var titulo = string.Empty;
            string href_imagem = string.Empty;
            string testeurl = string.Empty;
            //FileInfo file;
            Console.WriteLine(htmlDocument.ToString());
            Console.WriteLine("Passou");
            Console.WriteLine("Passou");
            foreach (HtmlNode node in htmlDocument.GetElementbyId("cardResults").ChildNodes)
            {
                if(node.Descendants().Count() > 0)
                    href_imagem = node.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("content-block content-block-full animating")).InnerText;
                    //testeurl = node.Descendants().First(x => x.Equals("a")).InnerText;

                    Console.WriteLine(href_imagem);

                

            }

            */
        }
    }
}
