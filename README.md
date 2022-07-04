# ASP.NET MVC 5
***
## Introduction
The purpose of this project is to create an application that could be used for renting movies with functionalities relating to customer and movie management. Admins will be able to modify existing data, while other users will be given a read-only view. 

## MVC Architectural Pattern
MVC stands for Model, View and Controller. This architecture is widely used in the web for the purpose of implementing user interfaces. 

Model consists of classes that have properties and methods that purely represent the application state and rules. In other words, it contains application data and behaviour in terms of its domain. These are not tied to a user interface but are instead plain old CLR objects. 
Plain old CLR objects, or POCOs, are simple objects that are free of inheritance or attributes, and do not have dependencies on any external frameworks. These follow the rules of object-oriented programming. 

The View is the HTML markup that is displayed to the user. This is similar to, although perhaps not entirely the same as, the source code any webpage has, and contains the visual elements of the page in html form. 

The Controller is the one responsible for handling the HTTP requests, but in reality, this is not quite as simple. This is because there is a fourth component in the MVC structure that has not yet been mentioned, the Router. 

It is the router’s job to choose the correct controller for a given request. Controllers themselves may contain numerous methods, or actions, within them so then it becomes important for the router to find the correct action to take. An action in a controller is ultimately the one responsible for handling requests, not necessarily the controller itself. 

What makes this architecture strong is that each component has a distinct role to play in it, and so this leads to more maintainable applications. 

## Setting up Controller Environment
I set up Visual Studio 2019 for the purpose of creating this application. I downloaded **Productivity Power Tools 2017/2019** and **Web Essentials 2019** to help create this application. 

## Starting up the ASP.NET MVC app
I opened Visual Studio 2019 and created a new ASP.NET Core Web API in C#. The Solution Explorer shows some of the automatically created folders for this project. In there we should find at least folders for Controllers, Models, and Views. These will be populated by the classes, actions and other files we need to make this application work properly. By convention, when we use a controller, ASP.NET looks for a view under the same name, and in the case of the version of Visual Studio I was working with, I had to create those folders manually. 

The first step was to create basic functionality for this application. 

I added a new public class in Models called Movie. I gave it two properties to represent state: a string Name and an int Id. 

A short note on naming conventions in C#: 
>Pascal case (PascalCase) is used when naming classes, records, structs, naming public members of types (fields, properties, events, methods, and local functions), and the parameters when writing positional records. When naming interfaces, the pascal casing is used with an additional letter i as the prefix for the name (IPascalCase). 
>Camel casing (camelCasing) is used when naming private or internal fields, usually prefixed with an underscore (_), such as “_camelCase”. When we work with private or internal static fields, we use the “s_” prefix, and “t_” prefix for threaded static. Method parameters are usually written in camel casing as well. 

The next step is to create a simple controller to retrieve a random movie. To do this, I added a new empty controller under Controllers named MoviesController and changed the automatically generated method name form Index() to Random(). 

Because at this point we don’t have an actual database to retrieve information from, I made a movie that could be called in the View() method, and added this variable as the parameter. At first, I was unable to actually make this movie variable, but this was solved by adding a line at the top “using MVC_KatDemo.Models;” which allowed me to make one movie. Some extensions may do this automatically, but I had to write that in manually. 

The next step is to create the view for “Random”. I manually created a folder for Movies under Views, and inside added an empty view called “Random.cshtml”. This file contains a mixture of C# and html, and I manually added information related to the title and layout at the top. In the html section I added the title for the page (Random movie), and then called for the actual movie name. 
For this to be possible, I had to add a line at the very top that functions similarly to the “using” keyword, a directive that will allow us to find the correct properties to the model we wish to use. “@model MVC_KatDemo.Models.Movie” allowed me to retrieve specific properties of Model in the html section. 

***

### Notes for editing this document
For links: [link name] (target url "link title") --> [Github] (https://www.github.com "Github home")
_Italic text_
**Bold text**
~~Strikethrough~~
For images: [imagename] (target url)
To create tables: 
|Name|Email|Address|
|----|-----|-------|
|John|john@example.com|Address1|

Quotes: add a greater than symbol ">" at the start of the line
>Quotes look like this

To write code add ``` at the start and end of the clode block, and specify the language after the first ```.

```Language
your code
 ```
