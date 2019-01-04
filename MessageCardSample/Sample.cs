using MessageCardModel;
using MessageCardModel.Actions;
using MessageCardModel.Actions.ActionCard;
using MessageCardModel.Actions.OpenUri;
using System.Collections.Generic;

namespace MessageCardSample
{
    public static class Sample
    {
        public static MessageCard GitHubIssueOpened => new MessageCard
        {
            Summary = "Issue 176715375",
            ThemeColor = "0078D7",
            Title = "Issue opened: \"Push notifications not working\"",
            Sections = new List<Section>
            {
                new Section
                {
                    ActivityTitle = "Miguel Garcie",
                    ActivitySubtitle = "9/13/2016, 11:46am",
                    ActivityImage = "https://connectorsdemo.azurewebsites.net/images/MSC12_Oscar_002.jpg",
                    Facts = new List<Fact>
                    {
                        new Fact{ Name = "Repository", Value = "mgarcia\\test" },
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

        public static MessageCard MicrosoftFlowApproval => new MessageCard();

        public static MessageCard TinyPulseEngage => new MessageCard();

        public static MessageCard TrelloCardCreated => new MessageCard();

        public static MessageCard YammerDigest => new MessageCard();
    }
}
