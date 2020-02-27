# Blazor Lightboard
## The Blazor Lightweight Dashboard Template

![.NET Core](https://github.com/nbiada/BlazorLightboard/workflows/.NET%20Core/badge.svg)

This project is a template for a lightweight responsive dashboard in Blazor.\
It's based on the _Blazor-Dashboard_ project available via github.

I've developed this admin template for my .net core projects.\
The aim was to use Blazor (C#), Boostrap and _the smallest amount_ of Javascript for development in server side mode.

I've implemented a simple **State Manager** that you can expand as you like.\
Try to fill the input text in the _Home_ or to increment the counter, you'll see the updated properties on the right card.\
All the updates are made via State Manager methods.

The value of the _Counter_ property is persisted via localStorage.\
I've used the [Blazor Storage Library](https://github.com/cloudcrate/BlazorStorage) for localStorage support.

This template is available under the MIT License.
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)


## Usage

1. Clone or Download [nbiada/BlazorLightboard](https://github.com/nbiada/BlazorLightboard)
2. open a Command Prompt or a shell
3. change directory to the BlazorLightboard subfolder
4. ``dotnet run``
5. Access the dashboard through https://localhost:5001/


## See it in Action

[Blazor Lightboard](https://blazorlightboard.azurewebsites.net/)


### Home
![Home](https://user-images.githubusercontent.com/4179320/75267717-e1cb7480-57f6-11ea-8c06-aefc0b6ed335.png?s=400)

### Counter
![Counter](https://user-images.githubusercontent.com/4179320/75267777-f7d93500-57f6-11ea-8568-a5a6cc6c39a2.png)

### Weather
![Weather](https://user-images.githubusercontent.com/4179320/75267795-fad42580-57f6-11ea-927e-3b51cd638190.png)

### Home Mobile
![Home-Mobile](https://user-images.githubusercontent.com/4179320/75267808-ff98d980-57f6-11ea-87ea-82907fa211fc.png)
