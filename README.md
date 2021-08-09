# Dirs21
This task implemented in .net core framework by visual studio code.

steps to launch the task:

1- There is a bakup file from sqlserver database named Dirs21.bak
   please restore it in sql server.

2- there is a MongoDB folder that contain the collection. name of collection is "Dirs" and name of db and "Menu" is name of collection.
   plese restore it or make a DB and collection with above mentioned names.

3- open Dirs21 main folder by visual studio code and and run the Menu controller with command "dotnet run"

4- in your browser type the controller and method : "http://localhost:5000/Menu/GetMenu"
   at first it select menu from sql DB by EF core and then it saves those fetched records to MongoDB

5- in order to fetch records directly from MongoDB use another method : "http://localhost:5000/Menu/MenuMongo"

