using BingO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BingSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ///Search about Bill Gates
                ///NB: This should be done asynchronously...
                SearchResult result = BingSearchHelper.Query("Bill Gates",
                    new BingQueryParameters(
                    apiKey: "",
                    count: 10,
                    offset: 0,
                    mkt: "en-us",
                    safeSearch: "Moderate")
                ).Result;

                ///Get a link to the first image of the search result.
                Console.WriteLine(result.images.value[0].thumbnailUrl);

                Console.WriteLine("Done!!!!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n" + e.StackTrace);
            }

            Console.ReadKey();
        }



        





        //    public static void NewsSearch()
        //    {

        //        // Create a Bing container.

        //        string rootUrl = "https://api.datamarket.azure.com/Bing/Search";

        //        var bingContainer = new Bing.BingSearchContainer(new Uri(rootUrl));



        //        // Get news for science and technology.

        //        string newsCat = "rt_ScienceAndTechnology";



        //        // Configure bingContainer to use your credentials.

        //        bingContainer.Credentials = new NetworkCredential("6297d6007e434a7b903189fd88c8cbea", "6297d6007e434a7b903189fd88c8cbea");



        //        // Build the query, limiting to 10 results.

        //        var newsQuery =

        //            bingContainer.News("top news", null, "market", null, null, null, null, newsCat, null);

        //        newsQuery = newsQuery.AddQueryOption("$top", 10);



        //        // Run the query and display the results.

        //        var newsResults = newsQuery.Execute();



        //        StringBuilder searchResult = new StringBuilder();

        //        foreach (Bing.NewsResult nResult in newsResults)
        //        {
        //            searchResult.Append(string.Format("<a href={0}>{1}</a><br /> {2}<br /> {3}&nbsp;{4}<br /><br />",

        //            nResult.Url,

        //            nResult.Title,

        //            nResult.Description,

        //            nResult.Source,

        //            nResult.Date));


        //        }

        //        StreamWriter w = new StreamWriter("doc.html");
        //        w.Write(searchResult.ToString());
        //        w.Close();
        //    }
    }
}
