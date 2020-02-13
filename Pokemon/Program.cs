using System;
using System.Net;
using HtmlAgilityPack;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Pokemon.Entities;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> timecarta = new List<Card>();
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
            string urlPrincipal = "https://www.pokemon.com/";
            string urlSecundaria = urlPrincipal + "us/pokemon-tcg/pokemon-cards/";
            string seach_url = "?cardName=&cardText=&evolvesFrom=&simpleSubmit=&format=unlimited&hitPointsMin=0&hitPointsMax=340&retreatCostMin=0&retreatCostMax=5&totalAttackCostMin=0&totalAttackCostMax=5&particularArtist=";
            string url = "https://www.pokemon.com/us/pokemon-tcg/pokemon-cards/?cardName=&cardText=&evolvesFrom=&simpleSubmit=&format=unlimited&hitPointsMin=0&hitPointsMax=340&retreatCostMin=0&retreatCostMax=5&totalAttackCostMin=0&totalAttackCostMax=5&particularArtist=";
            string pagina = wc.DownloadString(url);

            htmlDocument.LoadHtml(pagina);

            Console.WriteLine("Passou");

            List<string> dataAttribute = new List<string>();
            List<string> spanText = new List<string>();

            HtmlNodeCollection nodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@id=\"filters\"]/section[2]/div/div///li");

            foreach (HtmlNode node in nodeCollection)
            {
                dataAttribute.Add(node.GetAttributeValue("data", "null"));
                spanText.Add(node.SelectSingleNode("span").InnerText);
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
