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
            var gitHubIssueOpenedJson = @"{""@type"":""MessageCard"",""@context"":""http://schema.org/extensions"",""originator"":null,""summary"":""Issue 176715375"",""themeColor"":""0078D7"",""title"":""Issue opened: \u0022Push notifications not working\u0022"",""text"":null,""sections"":[{""title"":null,""startGroup"":false,""activityTitle"":""Poy Chang"",""activitySubtitle"":""1/1/2020, 00:00am"",""activityText"":null,""activityImage"":""https://connectorsdemo.azurewebsites.net/images/MSC12_Oscar_002.jpg"",""heroImage"":null,""text"":""There is a problem with Push notifications, they don\u0027t seem to be picked up by the connector."",""facts"":[{""name"":""Repository"",""value"":""poychang\\test""},{""name"":""Issue #:"",""value"":""176715375""}],""images"":null,""potentialAction"":null}],""potentialAction"":[{""inputs"":[{""id"":""comment"",""isRequired"":false,""title"":""Enter your comment"",""value"":null}],""actions"":[{}],""@type"":0,""name"":""Add a comment""},{""name"":""Close"",""target"":""http://..."",""headers"":null,""body"":null,""bodyContentType"":""Json"",""@type"":1},{""targets"":[{""os"":""Default"",""uri"":""http://...""}],""@type"":2,""name"":""View in GitHub""}]}";
            var gitHubIssueOpened = new MessageCard
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
            var json = gitHubIssueOpened.ToJson();

            Debug.WriteLine(json);
            Assert.AreEqual(gitHubIssueOpenedJson, json);
        }

        [TestMethod]
        public void Issue4_SerializeAllPropertiesOfDerivedActions()
        {
            var msgCard = new MessageCard
            {
                Title = "Message Title (optional)",
                Text = "This is a sing line **message** with markdown",
                Sections = new[]
                {
                    new Section
                    {
                        Text = "Action Section",
                        Actions = new[]
                        {
                            new ActionCardAction
                            {
                                Name = "ActionCardAction",
                                Type = ActionType.ActionCard
                            },
                        }
                    },
                    new Section
                    {
                        Text = "Action Section",
                        Actions = new[]
                        {
                            new HttpPostAction
                            {
                                Name = "HttpPostAction",
                                Type = ActionType.HttpPost,
                            },
                        }
                    },
                    new Section
                    {
                        Text = "Action Section",
                        Actions = new[]
                        {
                            new OpenUriAction
                            {
                                Name = "OpenUriAction",
                                Type = ActionType.OpenUri,
                                Targets = new List<Target>()
                            },
                        }
                    },
                },
            };
            var json = msgCard.ToJson();

            Debug.WriteLine(json);
            Assert.IsTrue(json.Contains("inputs") && json.Contains("headers") && json.Contains("targets"));
        }
    }
}
