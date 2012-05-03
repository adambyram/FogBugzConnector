using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FogBugzConnector.Tests
{
    [TestClass]
    public class ConnectorUnitTests
    {
        public Uri BaseUri { get; set; }
        public Uri APIUri { get; set; }
        public IFogBugzWebAdapter WebAdapter { get; set; }

        [TestInitialize]
        public void Setup()
        {
            BaseUri = new Uri("https://mycorp.fogbugz.com");
            APIUri = new Uri(BaseUri, "api.asp?");
            WebAdapter = new FogBugzWebAdapter();
        }


        [TestMethod]
        public void ShouldCheckAndInitializeAPIVersion()
        {
            var connector = new FogBugzConnector(BaseUri);
            connector.WebAdapter = WebAdapter;
            Assert.IsFalse(connector.IsInitialized);

            connector.Initialize();
            Assert.IsTrue(connector.IsInitialized);
            Assert.AreEqual(APIUri,connector.APIUri);
        }
    }
}
