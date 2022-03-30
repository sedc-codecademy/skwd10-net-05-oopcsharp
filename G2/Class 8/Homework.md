# Homework Class 8 📒

## Task 1
* Give the user an option to input numbers
* After inputing each number ask them if they want to input another with a Y/N question
* Store all numbers in a QUEUE
* When the user is done adding numbers print the number in the order that the user entered them from the QUEUE

## Task 2
* Create a class called User with the following properties :
    * Id (integer, unique - no two users can have the same id)
    * FirstName (string, max length 255 charracters)
    * LastName (string, max length 255 charracters)
    * CreatedOn (datetime,date and time when the user was created)
* Store predefined users in a dictionary
* Give the user two options : (R)egister and (S)earch
    * When the choice is the option R, he can create a new User and store it in that dictionary.
    * When the choice is S, then the input can be either first name and last name or the id
        * After the input of first name and last name or id, the respecive user will be printed

## Task 3
* Create a class called Car with the following properties :
    * Id (integer)
    * BrandName (string)
    * ModelName (string)
    * Color (enum - Red,Blue,Green,Yellow,Brown)
    * DistanceTraveled (int, distance in KM)
    * DateOfModel (DateTime)
* Store predefined cars in a list
* Create a method called CalculatePrice(), which calculates the price by multiplying the distance traveled by the age of the car (in years) then dividing  it by three
* Calculate the price of all cars that have the Color Red
* Calcualte the price of all the cars that are of the brand Ford
* Get all of the cars which have a distance traveled less than 100,000 KM
* BONUS : Use LINQ