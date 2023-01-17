# CodeComplete
Code Generation Tool use by me for years now

# How it works in a NutShell

In one of three ways you point the tool at a sql server database and a specific table or view in that database. Then informing the tool about a couple of things pertaining to the chosen table/view, the tool creates a FULL Data Abstraction class for that database entity with...
* *Various contstructors to accomodate the classes creation out of thin air*
* *Properties to Read and write to the various things that the database contained in the selected Table/View*
* *Methods to READ a specific entity out of the database given its ID (Thats one of the things you select at the outset)*
* *Methods to write back the class to a specific ID (UPDATE)*
* *Methods to Insert a completely new entity into the selected database (CREATE)*
* *Methods to Delete a chosen entity from the database. (DELETE)*

Some Screenshots
Main Screen Interface

![Screenshot](https://raw.github.com/harlock123/codecomplete/TaiCodeComplete/images/Screenshot1.jpg)
