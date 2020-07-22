using MessageCardModel.Actions;
using MessageCardModel.Actions.ActionCard;
using MessageCardModel.Actions.OpenUri;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace MessageCardModel.Test
{
    [TestClass]
    public class MessageCardModelUnitTest
    {
        [TestMethod]
        public void TestRun_GitHubIssueOpened()
        {
            var GitHubIssueOpenedJson = @"{""@type"":""MessageCard"",""@context"":""http://schema.org/extensions"",""originator"":null,""summary"":""Issue 176715375"",""themeColor"":""0078D7"",""title"":""Issue opened: \""Push notifications not working\"""",""text"":null,""sections"":[{""title"":null,""startGroup"":false,""activityTitle"":""Poy Chang"",""activitySubtitle"":""1/1/2020, 00:00am"",""activityText"":null,""activityImage"":""https://connectorsdemo.azurewebsites.net/images/MSC12_Oscar_002.jpg"",""heroImage"":null,""text"":""There is a problem with Push notifications, they don't seem to be picked up by the connector."",""facts"":[{""name"":""Repository"",""value"":""poychang\\test""},{""name"":""Issue #:"",""value"":""176715375""}],""images"":null,""potentialAction"":null}],""potentialAction"":[{""Type"":""ActionCard"",""Name"":""Add a comment""},{""Type"":""HttpPost"",""Name"":null},{""Type"":""OpenUri"",""Name"":""View in GitHub""}]}";
            var GitHubIssueOpened = new MessageCard
            {
                Summary = "Issue 176715375",
                ThemeColor = "0078D7",
                Title = "Issue opened: \"Push notifications not working\"",
                Sections = new List<Section>
                {
                    new Section
                    {
                        ActivityTitle = "Poy Chang",
                        ActivitySubtitle = "1/1/2020, 00:00am",
                        ActivityImage = "https://connectorsdemo.azurewebsites.net/images/MSC12_Oscar_002.jpg",
                        Facts = new List<Fact>
                        {
                            new Fact{ Name = "Repository", Value = "poychang\\test" },
                            new Fact{ Name = "Issue #:", Value = "176715375" }
                        },
                        Text = "There is a problem with Push notifications, they don't seem to be picked up by the connector."
                    }
                },
                Actions = new List<IAction>
                {
                    new ActionCardAction
                    {
                        Type = ActionType.ActionCard,
                        Name = "Add a comment",
                        Inputs = new List<Input>{ new TextInput{ Id = "comment", Title = "Enter your comment", Multiline = true } },
                        Actions = new List<IEmbeddableAction>{ new HttpPostAction{ Type = ActionType.HttpPost, Name = "OK", Target = "http://..." } }
                    },
                    new HttpPostAction
                    {
                        Type = ActionType.HttpPost,
                        Name = "Close",
                        Target = "http://..."
                    },
                    new OpenUriAction
                    {
                        Type = ActionType.OpenUri,
                        Name = "View in GitHub",
                        Targets = new List<Target>{ new Target { OS = TargetOs.Default, Uri = "http://..." } }
                    }
                }
            };

            Debug.WriteLine(GitHubIssueOpened.ToJson());
            Assert.AreEqual(GitHubIssueOpenedJson, GitHubIssueOpened.ToJson());
        }
    }
}
