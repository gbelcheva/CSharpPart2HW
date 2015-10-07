## SQL Server and MySQL - Introduction

##### Create a new database `Pubs` and create new login with permissions to connect to it. 

![1](https://github.com/gbelcheva/TelerikAcademy/raw/master/Databases/HW05-SqlServerMySqlIntroduction/01.pubs-user-created.jpg)

##### Execute the script `install_pubs.sql` to populate the DB contents (you may need slightly to edit the script before).
![2](https://github.com/gbelcheva/TelerikAcademy/raw/master/Databases/HW05-SqlServerMySqlIntroduction/02.pubs-populated.jpg)

##### Attach the database `Northwind` (use the files `Northwind.mdf` and `Northwind.ldf`) to SQL Server and connect to it.
![3](https://github.com/gbelcheva/TelerikAcademy/raw/master/Databases/HW05-SqlServerMySqlIntroduction/03.northwind-attached.jpg)

##### Backup the database `Northwind` into a file named `northwind-backup.bak` and restore it as database named `North`.
![4](https://github.com/gbelcheva/TelerikAcademy/raw/master/Databases/HW05-SqlServerMySqlIntroduction/04.north-restored-from-northwind-backup.jpg)

##### Export the entire `Northwind` database as SQL script
* #####	Use `[Tasks]` > `[Generate Scripts]`
* #####	Ensure you have exported table data rows (not only the schema).

##### Create a database NW and execute the script in it to create the database and populate table data.
![5](https://github.com/gbelcheva/TelerikAcademy/raw/master/Databases/HW05-SqlServerMySqlIntroduction/05.nw-populated.jpg)

##### Detatch the database NW and attach it on another computer in the training lab
* #####	In case of name collision, preliminary rename the database.

![6](https://github.com/gbelcheva/TelerikAcademy/raw/master/Databases/HW05-SqlServerMySqlIntroduction/06.nw-reatteached.jpg)

##### Export the MySQL sample database "`world`" as SQL script.
##### Modify the script and execute it to restore the database world as "`worldNew`".

![7](https://github.com/gbelcheva/TelerikAcademy/raw/master/Databases/HW05-SqlServerMySqlIntroduction/07.world-restored-as-worldnew.jpg)

##### Connect through the MySQL console client and list the first 20 tons from the database "`worldNew`".

![8](https://github.com/gbelcheva/TelerikAcademy/raw/master/Databases/HW05-SqlServerMySqlIntroduction/08.list-first-20-towns-from-worldnew.jpg)


