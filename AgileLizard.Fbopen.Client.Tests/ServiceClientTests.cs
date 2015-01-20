using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using RestSharp;
using StructureMap;
using AgileLizard.Fbopen.Client.Dto;
using AgileLizard.Fbopen.Client.Interfaces;
using System.Reflection;
using RestSharp.Deserializers;


namespace AgileLizard.Fbopen.Client.Tests
{
    [TestClass]
    public class ServiceClientTests
    {
        private static string serviceHost = "https://api.data.gov";
        private static string serviceUri = "/gsa/fbopen/v0/opps";
        private static string activationKey = "uaLZF212ZZIVraHytE9aIQiI9Kgxi0CJL0XRGDW9";

        // for reference: https://api.data.gov/gsa/fbopen/v0/opps?q=software+development&api_key=uaLZF212ZZIVraHytE9aIQiI9Kgxi0CJL0XRGDW9

        [TestMethod]
        public void FboApi_CanGetRecords()
        {
            var client = new RestClient(serviceHost);
            //client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest(serviceUri, Method.GET);

            request.AddParameter("q", "software development");

            request.AddParameter("api_key", activationKey);
            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            Assert.AreNotEqual(0, content.ToString().Trim().Length);

        }

        [TestMethod]
        public void FboApi_CanMapToList()
        {
            var client = new RestClient(serviceHost);
            //client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest(serviceUri, Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("q", "software development");

            request.AddParameter("api_key", activationKey);
            // execute the request
            var response = client.Execute(request);
            //var content = response.Content; // raw content as string
            RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();
            RootObject docList;
            // (same as first example) 
            //Change the deserialize code to type <List<Class>>
            docList = deserial.Deserialize<RootObject>(response);

            Assert.AreNotEqual(0, docList.docs.Count);

        }
    }

}
