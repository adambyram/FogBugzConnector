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

        // TODO: Logon - Failed
        // TODO: Logon - Success
        // TODO: Logon - Ambiguous
        // TODO: Univeral check for not logged in error
        // TODO: Logoff
        // TODO: Command - listFilters
        // TODO: Command - search
        // TODO: Command - setCurrentFilter
        // TODO: Command - new
        // TODO: Command - edit
        // TODO: Command - assign
        // TODO: Command - reactivate
        // TODO: Command - reopen
        // TODO: Command - resolve
        // TODO: Command - close
        // TODO: Command - email
        // TODO: Command - reply
        // TODO: Command - forward
        // TODO: Command - listProjects
        // TODO: Command - listAreas
        // TODO: Command - listCategories
        // TODO: Command - listPriorities
        // TODO: Command - listPeople
        // TODO: Command - listStatuses
        // TODO: Command - listFixFors
        // TODO: Command - listMailboxes
        // TODO: Command - newProject
        // TODO: Command - newArea
        // TODO: Command - newPerson
        // TODO: Command - newFixFor
        // TODO: Command - viewProject
        // TODO: Command - viewArea
        // TODO: Command - viewPerson
        // TODO: Command - viewFixFor
        // TODO: Command - viewCategory
        // TODO: Command - viewPriority
        // TODO: Command - viewStatus
        // TODO: Command - viewMailbox
        // TODO: Command - addFixForDependency
        // TODO: Command - deleteFixForDependency
        // TODO: Command - listWorkingSchedule
        // TODO: Command - wsDateFromHours
        // TODO: Command - listProjectPercentTime
        // TODO: Command - addProjectPercentTime
        // TODO: Command - editProjectPercentTime
        // TODO: Command - deleteProjectPercentTime
        // TODO: Command - startWork
        // TODO: Command - stopWork
        // TODO: Command - newInterval
        // TODO: Command - listIntervals
        // TODO: Command - newCheckin
        // TODO: Command - listCheckins
        // TODO: Command - newWiki
        // TODO: Command - editWiki
        // TODO: Command - deleteWiki
        // TODO: Command - newArticle
        // TODO: Command - editArticle
        // TODO: Command - listWikis
        // TODO: Command - listArticles
        // TODO: Command - listRevisions
        // TODO: Command - viewArticle
        // TODO: Command - listTemplates
        // TODO: Command - listTemplateRevisions
        // TODO: Command - viewTemplate
        // TODO: Command - deleteTemplate
        // TODO: Command - newTemplate
        // TODO: Command - editTemplate
        // TODO: Command - wikiFileUpload
        // TODO: Command - listDiscussGroups
        // TODO: Command - listDiscussion
        // TODO: Command - listDicussTopic
        // TODO: Command - listScoutCase
        // TODO: Command - subscribe
        // TODO: Command - unsubscribe
        // TODO: Command - view
        // TODO: Command - viewSettings
        // TODO: Command - viewUserTimelineReport
        // TODO: Command - viewUserShipDateReport
        // TODO: Command - viewShipDateReport
        // TODO: Command - viewHoursRemainingReport
        // TODO: Command - listShipDate
        // TODO: Command - viewEstimator
    }
}
