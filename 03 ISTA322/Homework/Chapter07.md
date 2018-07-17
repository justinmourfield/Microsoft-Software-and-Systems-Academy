### Author: Justin Mourfield
### Date : April, 20, 2018
### Title: chapter 07

1.A visual studios solution is a container for one or more projects. 

2.An empty solution takes out the predetermined features that are automatically included otherwise. Using an empty project allows you to better understand application because they are built from the ground up. the draw back is that some of the things we are used to seeing or being able to do may not be available because the references arent included. 

3. Nuget is a portal to download SDKs or APIs that will be used in the program. Its essentially a one stop shop for most things you may need in a program. 

4.A reference is a named dependency on projects. This is used to include functionality thats been created by other code without having to retype that code in the new program. you can add references by right clicking on the solution you can add references. to remove them you open the references folder, right click which reference to remove and click delete. 

5.A DI container is meant to reduce the work that instantiation requires by determining, creating, and injecting all dependencies. Plenty of other DI software exists and works in visual studios. 

6.A domain model is the focal point of an MVC application it handles the data transferred by the user interface and the database. a view model represents what you want to display on a view or page to the user. 

7.A repository pattern is an abstraction that separates functionality and reduces complexity/dependencies. 

8.Mock repositories support unit testing development. You would use a mock repository to create "fake" for the purposes of testing. 

9.the controller handles the interaction between the view or UI and the model. A view as explained in this chapter is a UI.

10.The default route tells the compiler which controller action method to reference when a view is presented. having readable urls makes them more rememorable and easier to decipher which will lead to people utilizing the url they can read and understand over the one they cant. 

11.Object relational mapping is the programming technique for converting data between incompatible type systems in OOP languages. We are using ORM anytime we link a SQL database to a C# program. 

12.There is an abundance of SDKs that support database integration. Entity Framework is the native SDK that visual studios has.

13. A context class associates a model with a database.

14. the page=1 in the ViewResult List(int page=1)

15. TDD means test driven development. this approach to development involves writing a test before writing code to pass the test. 

16.The test is passed if all functionality works as specified, if it doesnt you rework the code until you get the desired output. 

17.HTML helpers are extension methods that generate the HTML for a set of page links using the information provided in the PaginInfo object

18. The nested lambda expression returns a the argument for the HTML.PageLinks method. the Model.PagingInfo property is stored as the variable x which is fed into the URL.Action method as an argument. the URL.Action method takes a string argument and creates a new page variable that is initialized to the value of X.
MVCHTMLString displays the string representation of HTML information.

19.It is an HTML, CSS, javascript framework that you can use as a basis for creating web sites or web applications.