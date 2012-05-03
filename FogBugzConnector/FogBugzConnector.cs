using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FogBugzConnector
{
    public class FogBugzConnector
    {
        private Uri _baseAPIUri;

        public Uri APIUri { get; set; }
        public Boolean IsInitialized { get; set; }

        public IFogBugzWebAdapter WebAdapter { get; set; }

        public FogBugzConnector(Uri baseAPIUri)
        {
            _baseAPIUri = baseAPIUri;
            IsInitialized = false;
        }

        public void Initialize()
        {
            APIUri = WebAdapter.EndpointForBaseUri(_baseAPIUri);
            IsInitialized = true;
        }
    }
}
