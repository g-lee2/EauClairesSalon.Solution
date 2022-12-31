# Eau Claire's Salon

#### By Grace Lee

#### Brief Description of Application
This application allows the user to organize a list of the salon's stylist and their clients.

## Technologies Used

* _C#_
* _.NET_
* _Entity Framework Core_
* _MySQL_

## Description
This is an application that allows the user(Claire) to create a list that consists of all stylists that work at the salon. The user is able to add and remove stylists, and even update the stylist's information. The user is also able to add a list of clients under a specific stylist, to keep track of the stylist's clients. New clients can also be added, removed, and updated.

## Setup/Installation Requirements
* Clone this repository to your desktop:
```
    $ git clone https://github.com/g-lee2/EauClairesSalon.Solution.git
```
* Navigate to the EauClairesSalon.Solution directory on your desktop and open the cloned directory with your favorite text editor (Visual Studio Code was used when setting this project up).

* Navigate into the HairSalon production directory and run the code:
```
    $ dotnet restore
```
* Within the production directory "HairSalon", create a new file called `appsettings.json`.

* Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL Workbench. Please install MySQL Workbench if not already installed on your local machine. 

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_ef_core;uid=root;pwd=epicodus;"
  }
}
```

* To start the application, run the following codes in the production directory:
```
    $ dotnet build
```
```
    $ dotnet watch run
```

* To re-create the database:
1. Launch MySQL Workbench and open your local instance.
2. Then follow [instructions](https://www.learnhowtoprogram.com/c-and-net-part-time/database-basics/introduction-to-mysql-workbench-creating-a-database) to create a database, based on the data from `grace_lee.sql`.
3. You should have two tables called `clients` and `stylists`.
4. Your `clients` table should have 5 columns and your `stylists` table should have 6 columns.

## Known Bugs

* _No known bugs as of now_

## License
MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) _2022_ _Grace Lee_