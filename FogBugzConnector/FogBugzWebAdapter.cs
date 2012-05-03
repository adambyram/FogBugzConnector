using System;
using System.Linq;
using System.Net;
using System.Xml.Linq;

namespace FogBugzConnector
{
    public class FogBugzWebAdapter : IFogBugzWebAdapter
    {
        private readonly string _initialAPIEndpoint = "api.xml";

        public Uri EndpointForBaseUri(Uri baseUri)
        {
            var webClient = new WebClient();
            var response = webClient.DownloadString(new Uri(baseUri, _initialAPIEndpoint));
            var responseDocument = XDocument.Parse(response);
            return new Uri(baseUri, responseDocument.Root.Elements().Where( e => e.Name == "url" ).Select( e => e.Value ).Single());
        }
    }
}