# DESIGN-DOCS: C#.NET CORE ASP MVC

## ModleViewController - QuoteMaster

 
### About

The C#.NET MVC or Model View Controller are used to build a full-fledged **CRUD** application. The application also features: ease of startup with minimal clicks, a working **Authentication** and **Authorization** system as well as an easily expandible solution.

The .NET CORE MVC is the foundation of the Razor and further on, the Blazor frameworks.


### Purpose

The purpose of committing to this project is to get familiar with the general concept of c#'s .NET MVC. That's because of future plans to work on an introductory course in Blazer and possibly Razor in the between. Thus the need for the general MVC concept. 

**Neither C# MVC, Razor nor Blazor are meant to build any expertise on their subject, only to build a sense of familiarity.**
## Documentaion & Presentation
##### *Following paragraphs will feature code, code-paths and parts of the project per se.*

### QuoteMaster Project
This project is meant to store quotes and their corresponding author.

###  Presentaiton

The application is run with the Internet Information Service Express or ISS Express for short. ISS is running localhost and compiling the written code for us.
The directory tree features several folders, which includes but are not limited to the following:
    

  <!-- - > Properties    -  Start properties for project
  - > ./wwwRoot     -  -->

#### Directory Overview
>| Path | Description |
>| - | - |
>| .\Properties | Properties of project |
>| .\wwwroot| Features editble CSS, JS, libs (incl. JQuery) and favicon for the website.   | 
>| .\Controllers | Features controlls or handling events for the website| 
>| .\Migration | The MySQL database handelers for current website | 
>| .\Models | Classes for content (not actual visual content) |
>|  .\Views| Contains ```.cshtml``` files, featuring Razor syntax and the foundation for elements featured. .\Views are also function callers into .\Controller |
>| .\Shared| The shared layout between pages, such as nav-bars & footers etc.|

#### In-death
*.\Controllers* contains methods and events to handle navigation on the webpage. The *Index*-method handles the initial GET request, which later on, are used by other methods to work with the rest of the page. E.g. the custom method *showSearchForm* which returns the view "showSearchForm". The *[Authorize]*-tag claims that, for the action to be run, the user must be logged in.

*.\Views* are pages-pars; such as forms and lists, and actions; such as crud. As seen, for example in *.\Views\Quotes\showSearchForm.cshtml*, the syntax is basically the same as standard Html with some minor exceptions. In the **asp-action**-tag, C# chooses what method should be executed on running said block,while **asp-validation-for**-tag says that the block should be validated. This could be for, eg. a form. 
````html
<form asp-action="ShowSearchResult">

            <div class="form-group">
                <label name="SearchPhrase" class="control-label"></label>
                ...
            </div>
        </form>
 ````
This form's asp-action will execute ShowSearchResult on submit.

## Takeaways & Notes
During the development, there were some fatal errors, likely due to a partially corrupt operating system. These problems delayed the project and made it take way longer than it should originally have taken. The specified problem was fixed by wiping the computer.

Something that is a little irrelevant to C#.NET is the CSS '!important'-tag, which means that the '!important'-attribute will be priortated over the usual cascade order which is featuring self, id and class -attribute priority order.

Also used a hardlink junction to link the README.md file one direcory above the project with the command:
 ````
 cmd> mklink /H "C:\Users\HK\OneDrive - Halmstads kommun\Te18-T4\Tech_Spec\MVC_dotNet_crashCourse\QuoteMaster\README.md" "C:\Users\HK\OneDrive - Halmstads kommun\Te18-T4\Tech_Spec\MVC_dotNet_crashCourse\README.md"
 ````

Otherwise an intressting project, faily ok to learn. I can see great potential in it.
### Dates
Week 38 to week 40 - 2021
