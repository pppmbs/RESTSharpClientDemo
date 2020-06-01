using RestSharp;
using System;
using System.Collections.Generic;

namespace RESTSharpClientDemo
{
    class Program
    {
        private static RestClient client = new
        RestClient("http://localhost:5001/api/");
        static void Main(string[] args)
        {
            RestRequest request = new RestRequest("Default",
            Method.GET);
            IRestResponse<List<string>> response =
            client.Execute<List<string>>(request);
            Console.ReadKey();
        }
    }
}
