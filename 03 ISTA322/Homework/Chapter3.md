### Author: Justin Mourfield
### Date : April, 07, 2018
### Title: Chapter3


1. Stateless means the view itself doesnt store information to be used in the future. essentially the information only exists in this instance of that view. 

2. The domain model - is a software representation of real world entities, operations, and rules that exist in the idustry or activity the application is supporting. It consists of C# classes, structs etc. The view model is the data being transferred beteween the views and the controllers.

3. Work and home life.

4. A view engine is what is responsible for processing a ciew in order to generate a response for the browser. 

5.It provides separation of functionality and processing logic as well as data. this means that changes to data or implementation of future functionality is easily achieved. in addition to these benefits, it makes testing easier because it decouples the different sections allowing them each to be tested individually and as a whole. 

6.The difference is the employment of the finished products. A mvc application is focused on separation of actions, information and views because it functions based on send and receive requests. A UWP application may need to reveal and have interdependancy of information for some aspects of functionality and although it may send and receive requests this is not done through a server but generally a database that is linked via server routing. 

7. The two parts of dependancy injection are to remove any dependancies on concrete classes from the component in other words if an object of one type needs to then use an object of another class then that is what is referenced as dependancies such as using interfaces to connect two objects since an interface cannot be instantiated. The second part is injecting dependencies which uses objects as arguments to a constructor of a separate class.

8. Separation of church and state with me being the interface that is implemented by both concrete entities

9.unit testing and integration testing. unit testing is in premise what i do when i create new segments of code then immediately test that they work in conjunction with previous code and i get the desired output. in reality unit testing involves writing a separate class to test each individual behavior. Integration testing is everything works as it should together and separately.

10.
- Determine that you need a new feature or method to your application
-write the test that will validate the behavior of the new feature once it is written
-run the test and get a red light
-write the code that implements the new feature
-run the test again and correct the code until you get a green light 
-refactor the code if required 
-run the test to confirm that your changes have not changed the behavior of your additions
