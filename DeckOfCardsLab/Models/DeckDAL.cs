using Newtonsoft.Json;
using System.Net;

namespace DeckOfCardsLab.Models
{
    public class DeckDAL
    {
        public DeckModel DrawCards() //adjust 
        {
            //adjust this 
            //api URL 
            //string key = "482f7f75e99305b18389d300b9e85918"; // in real life, this is hidden
            string url = $"https://deckofcardsapi.com/api/deck/o5l72argm61r/draw/?count=5";


            //setup request 
            HttpWebRequest request = WebRequest.CreateHttp(url);

            //capture response back from server 
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //save response data 
            //need something to read response 

            StreamReader reader = new StreamReader(response.GetResponseStream());
            //take this info and get ready to read it ^^ 

            string JSON = reader.ReadToEnd();

            //adjust return 
            //string of JSON into an object 
            //convert: 
            //this will eventually return a weathermodel, per name of method 

            DeckModel result = JsonConvert.DeserializeObject<DeckModel>(JSON);
            return result;
        }



        public void ShuffleCards()
        {
            string url = $"https://deckofcardsapi.com/api/deck/o5l72argm61r/shuffle/";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }
    }
}
