[![Build Status](https://travis-ci.com/poychang/MessageCardModel.svg?branch=master)](https://travis-ci.com/poychang/MessageCardModel)
[![NuGet version](https://badge.fury.io/nu/MessageCardModel.svg)](https://badge.fury.io/nu/MessageCardModel)

# Message Card Model

Message Cards are meant to provide easy to read, at-a-glance information that users can very quickly decipher and act upon when appropriate.
This package help developer to design thier own Message Cards easier.

## How to use

A piece of code can explain a lot.

```csharp
// Create a variable like below
var card = new MessageCard
{
    Title = "This is the title",
    Text = "Message text",
    Sections = new[]
    {
        new Section
        {
            Text = "Section title",
            Actions = new[]
            {
                new OpenUriAction
                {
                    Name = "Open My Blog",
                    Type = ActionType.OpenUri,
                    Targets = new List<Target>
                    {
                        new Target
                        {
                            OS = TargetOs.Default,
                            Uri = "http://blog.poychang.net/"
                        }
                    }
                }
            }
        }
    }
};
// Now you get Json string to send or play in https://messagecardplayground.azurewebsites.net
var json = card.ToJson();
```

## REF

- [Message Card Playground](https://messagecardplayground.azurewebsites.net) You can use this website to design your card, and try to use this MessageCardModel nuget package to implement that.
