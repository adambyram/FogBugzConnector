using System;

namespace FogBugzConnector
{
    public interface IFogBugzWebAdapter
    {
        Uri EndpointForBaseUri(Uri baseUri);
    }
}