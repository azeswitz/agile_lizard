using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using RestSharp.Deserializers;
using System.Threading.Tasks;
using AgileLizard.Fbopen.Client.Interfaces;
using AgileLizard.Fbopen.Client.Dto;

namespace AgileLizard.Fbopen.Client.Managers
{
    public class DocumentManager : IDocumentManager
    {
        private static string serviceHost = "https://api.data.gov";
        private static string serviceUri = "/gsa/fbopen/v0/opps";
        private static string activationKey = "uaLZF212ZZIVraHytE9aIQiI9Kgxi0CJL0XRGDW9";

        //https://api.data.gov/gsa/fbopen/v0/opps?q=software+development&api_key=uaLZF212ZZIVraHytE9aIQiI9Kgxi0CJL0XRGDW9

        public IList<Doc> GetRecords(string searchParams, int startingRecord = 0)
        {
            var client = new RestClient(serviceHost);
            var request = new RestRequest(serviceUri, Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("q", searchParams);
            request.AddParameter("api_key", activationKey);
            if (startingRecord > 0)
            {
                request.AddParameter("start", startingRecord);
            }
            var response = client.Execute(request);
            RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();
            RootObject docList = deserial.Deserialize<RootObject>(response);
            return docList.docs;
        }
    }
}
