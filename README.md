# Sprocket-Order-App
C# /.NET I
Sprocket Oder Form
OBJECTIVES
5.1.	Explain and demonstrate how to declare and abstract classes and methods.
5.3.	Explain and demonstrate how to build constructors in derived classes.
6.20.	Explain and demonstrate how to create a WPF form with controls.
6.23.	Explain and demonstrate how to use WPF Message Boxes.
6.24.	Explain and demonstrate how to use WPF file dialogs.
6.26.	Explain and demonstrate how to create a custom dialog.
TURN IN REQUIREMENTS:
1.	Please name your Program LastnameP1, such as NelsonP3.
2.	Check your code into source control. 
3.	Upload your QA checklist to blackboard
PROGRAM Requirements:
1.	Write your name, email address and file name at the top of your source code in a comment.
2.	Put your name and program title in the Text Property of the Form.
3.	Use good C# programming style and formatting for your program.
4.	Use appropriate comments to explain what you are doing.  
You have been commissioned by Spacely Sprockets to build an application to manage orders for sprockets. Sprockets are gear like devices that are used in various types of machines (you’ve seen them on bicycles).  Spacely Sprockets makes custom made sprockets that can be made out of steel, aluminum or plastic. Their customers can order sprockets with any number of teeth. Spacely charges 5 cents per tooth for steel sprockets, 4 cents per tooth for aluminum, 2 cents per tooth for plastic. The cost of a sprocket is the number of teeth times the number of sprockets times the price per tooth.
CLASSES
SPROCKET.CS
The sprocket class and ABSTRACT class that has the following members:
Fully qualified properties for, number of items and number of teeth.
A read only property for Price and ItemID.
A protected abstract void Calculate method that will be implemented in three child class to calculate the price based on the business logic described above.
A parameterless and a three-parameter constructor (itemID, numItems and numteeth).
A ToString that concatenates order number, number, teeth, material and price.  
SteelSproket, AluminumSprocket and PlasticSprocket will inherit from the Abstract Sprocket class and implement a different Calc method each that implements the business logic described above. Each will also need constructors that can be implemented by calling the base class constructor if you want. The ToString should call the base class ToString and add the material (“ Material: steel” for example).

SPROCKETORDER.CS
The SprocketOrder class is a class that has a List of sprockets the customer is ordering as well as the following: 
Properties for Address, CustomerName and TotalPrice.
Methods to Add and Remove items from the Items List.
A private void calculate method that calculates the total price by adding all the Items List prices together.
Parameterless and 4-parameter constructors.
A ToString method that returns Customer name, count of items in the order, total price and address if address is not null or “Local Pickup” if address is null.
ADDRESS CLASS:
Create a class to hold an address:
SPROCKETORDERFORM.XAML:
The sprocket order form should provide the user the ability to enter their address or select Local Pickup via a check box. Selecting Local Pickup should hide the address elements.
          
The Add button should open a dialog form that will add a sprocket to the order (see below).
Selecting a sprocket and clicking the remove button should result in a dialog confirming the delete then remove the item.
   
Clicking on the update button will open a file dialog allowing the user to save the current order:
 
A file should be saved that has the ToString from the SprocketOrder class at the top and a line for each sprocket in the order using that sproket’s ToString.
Something like:
George Jetson: 3 items, Total Price: $11.60
Ship to: 1 Skypad Apartments
Orbit City Earth 11111

Order num: 1 Number: 2 Teeth: 25 Price: $2.00 Material: aluminum.
Order num: 2 Number: 4 Teeth: 25 Price: $5.00 Material: steel.
Order num: 3 Number: 10 Teeth: 23 Price: $4.60 Material: plastic.
SPROCKETFORM.XAML
Clicking on Add should open a SprocketForm as a dialog. This form should provide the ability to enter item id, select material using a combo box, number of teeth and number of items.
The submit button should result in the item being added to the list on the SproketOrderForm.
The cancel button should cancel the form and not result in anything being added to the list.


