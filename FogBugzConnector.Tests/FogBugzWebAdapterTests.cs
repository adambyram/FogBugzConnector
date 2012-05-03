using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FogBugzConnector.Tests
{
    [TestClass]
    public class FogBugzWebAdapterTests
    {
        [TestMethod]
        public void ShouldDiscoverAPIEndpoint()
        {
            var baseUri = new Uri("https://mycorp.fogbugz.com");
            var webAdapter = (IFogBugzWebAdapter) new FogBugzWebAdapter();
            Assert.AreEqual(new Uri("https://mycorp.fogbugz.com/api.asp?"),webAdapter.EndpointForBaseUri(baseUri));
        }
    }
}
