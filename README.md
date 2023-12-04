# Magic 8 Ball
This Magic 8 Ball repository is an evolving test bed for prototyping various .NET technologies used to implement a simple random-answer generator inspired by the original [Magic 8 Ball](https://www.mattel.com/products/magic-8-ball-dhw39). The new and improved version also provides an Artificially Intelligent Magic 8 Ball that uses Generative AI to create intelligent contextual answers to life's many questions.

The Visual Studio solution contains granular C# .NET projects that implement Magic 8 Ball Data, Services and User Interfaces as both a Windows Form App (for Windows 10 or later) and a Blazor Web App (for any modern web browser or mobile device).

Click [here](https://jolly-water-0879a521e.3.azurestaticapps.net/) to run the latest test version of the [Magic 8 Ball Blazor Web App](https://jolly-water-0879a521e.3.azurestaticapps.net/) hosted as an Azure Static Web App.

The Classic Magic 8 Ball service is available as a local .NET 8.0 library named `Magic8Ball.Classic` or as an Azure Function, which can be accessed via a [REST API](https://jolly-water-0879a521e.3.azurestaticapps.net/api/ask?question=Will%20I%20win%20the%20lottery?), or the `Magic8Ball.RESTClient` library. 

The Artificially Intelligent (AI) Magic 8 Ball service is also available as a local .NET 8.0 library named `Magic8Ball.AI` or via an Azure Function, which can be accessed via a [REST API](https://jolly-water-0879a521e.3.azurestaticapps.net/api/askai?question=Will%20I%20win%20the%20lottery?), or the `Magic8Ball.RESTClient` library. The AI version uses [Google's PaLM API](https://developers.generativeai.google/guide) and a little of the Classic Magic 8 Ball's magic to generate a contextual response.

If you haven't yet experienced Mattel's Magic 8 Ball or want to get one of your own, they are available via [Mattel's web site](https://www.mattel.com/products/magic-8-ball-dhw39) or directly on [Amazon](https://www.amazon.com/dp/B0149MC426).

The concept is simple: After “asking the ball” a yes or no question, click the Magic 8 Ball button and wait for your answer to be revealed on the screen.
Answers range from positive (“It is certain”) to negative (“Don’t count on it”) to neutral (“Ask again later”), or something much more personalized when using the AI Magic 8 Ball.

You can learn about this classic toy's history, design and more in [Wikipedia](https://en.wikipedia.org/wiki/Magic_8-Ball).

Magic 8 Ball Windows Form App sample question and answer:
![Magic 8 Ball WinForm App](Images/Magic%208%20Ball%20WinForm.png)

[Magic 8 Ball Blazor Web App](https://jolly-water-0879a521e.3.azurestaticapps.net/) sample question and AI answer:
![Magic 8 Ball Blazor App](Images/Magic%208%20Ball%20Blazor%20AI.png)
