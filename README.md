# Magic 8 Ball
This Visual Studio solution contains granular C# .NET projects that implement Data, Services and User Interfaces for both a Windows Forms and Blazor Web App. These projects are an evolving test bed for protyping various .NET technologies used to implement a simple random-answer generator inspired by the original Magic 8 Ball. 

Click [here](https://jolly-water-0879a521e.3.azurestaticapps.net/) to run the latest test version of the [Magic 8 Ball Blazor Web App](https://jolly-water-0879a521e.3.azurestaticapps.net/) hosted as a Azure Static Web App.

The Magic 8 Ball service is available as a local .NET 6.0 library named `Magic8Ball.Classic` or as an Azure Function, which can be accessed via a [REST API](https://dwmagic8ball.azurewebsites.net/api/ask?question=Will%20I%20win%20the%20lottery?) or via the `Magic8Ball.RESTClient` library.

If you haven't yet experienced Mattel's Magic 8 Ball or want to get one of your own, they are available via [Mattel's web site](https://www.mattel.com/products/magic-8-ball-dhw39) or directly on [Amazon](https://www.amazon.com/dp/B0149MC426).

The concept is simple: After “asking the ball” a yes or no question, turn the toy upside-down and wait for your answer to be revealed through the window.
Answers range from positive (“It is certain”) to negative (“Don’t count on it”) to neutral (“Ask again later”).

You can learn about this classic toy's history, design and more in [Wikipedia](https://en.wikipedia.org/wiki/Magic_8-Ball).

![Magic 8 Ball WinForm App](Images/Magic%208%20Ball%20WinForm.png)

![Magic 8 Ball Blazor App](Images/Magic%208%20Ball%20Blazor.png)
