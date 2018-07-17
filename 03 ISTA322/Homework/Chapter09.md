### Author: Justin Mourfield
### Date : May, 26, 2018
### Title: chapter 09

1.Model binding is the process of creating .NET objects using the data sent by the browser in an HTTP request. He creates a model binder that obtains the Cart object contained in the session data. The creates Cart objects and passes them as parameters to the action methods in the CartController class.

2.It redirects a result using a specified route values dictionary. its used as a return type for multiple redirecttoroute calls. Viewresult returns a view.

3.He uses required which requires a value to be entered by the user before the page can be accepted.

4.The Html.HiddenFor is a helper method that creates a hidden field for thr ReturnUrl model property.

5.The system.datamodel.dataannotations namespace provides attributes to objects that can be evaluated by code.

6.Html.action link returns <a href=".."><a/> tag where as action only returns a url.

7.metadata is information about a specific object and the author uses it to simplify code and take out redundancy.

8.null-coalescing operator. It returns the left-hand operand if the operand is not null; otherwise it returns the right hand operand. listing 9-12 < label >@( property.DisplayName ?? property.PropertyName) </ label >

9. listing 9-12 < label >@( property.DisplayName ?? property.PropertyName) </ label >

10. im sure there is a way to have dependancy injection without the use of interfaces but im not sure how. Interface segregation and dependancy inversion.

11.the web.config file is contains the main settings and configuration file for web application.

12. errors are displayed through a css property to highlight the problematic fields

13. Html.ValidaitonSummary method

14.client side validation makes the checks happen without communicating to the server which could be done through constant value that are compared by the web page without communication. server side validation occurs after a page is submitted and the server holds the values to compare the sent information against. 