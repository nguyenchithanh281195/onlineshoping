
Create table AccountType (
	id int IDENTITY(1,1),
	name nvarchar(6),
	PRIMARY KEY (id)
)

Create table Account (
	id int IDENTITY(1,1),
	username varchar(50),
	password nvarchar(50),
	email nvarchar(100),
	acctype int,
	PRIMARY KEY (id),
	FOREIGN KEY (acctype) REFERENCES AccountType(id)
)

Create table Manufacturer(
	id int IDENTITY(1,1),
	name nvarchar (150),	
	PRIMARY KEY (id)
)
 
Create table ProductType(
	id int IDENTITY(1,1),
	name nvarchar (100),
	PRIMARY KEY (id)
)

Create table Product(
	id int IDENTITY(1,1),
	name varchar(50),
	technical_parameters varchar(250),
	description nvarchar(250), 
	price int,
	manufacturer int,
	producttype int,
	PRIMARY KEY (id),
	FOREIGN KEY (manufacturer) REFERENCES Manufacturer(id),
	FOREIGN KEY (producttype) REFERENCES ProductType(id)
)

Create table _Order (
	id int IDENTITY(1,1),
	accountid int,
	_datetime datetime,
	total int,
	PRIMARY KEY (id),
	FOREIGN KEY (accountid) REFERENCES Account(id)
)

Create table Order_Product (
	id int IDENTITY(1,1),
	orderId int,
	productId int,
	quantity int,
	total int,
	PRIMARY KEY (id),
	FOREIGN KEY (orderId) REFERENCES _Order(id),
	FOREIGN KEY (productId) REFERENCES Product(Id)
)

Create table Subscribes (
	accountid int,
	PRIMARY KEY (accountid),
	FOREIGN KEY (accountid) REFERENCES Account(id)
)

--Insert data to table
insert into AccountType(name) values ('admin'), ('nv'), ('kh')
insert into Manufacturer(name) values ('SamSung'), ('Apple'), ('Sony'), ('Nokia')
insert into ProductType (name) values ('Mobile'), ('Tablet'), ('Laptop')
insert into Product(name,technical_parameters,description,price,manufacturer,producttype) values  ('Iphone X', 'Camera: 16MP, Ram: 128GB', 'This is a product of Apple', 30000000, 2, 1)
insert into Account(username,password,email,phone,address,acctypeId) values ('bluesea','test123','bluesea1696@gmail.com','0943734018',N'Bình Tân',2)
insert into _Order(accountid,_datetime,total) values (1,'2017-12-03 17:07:00',900000)
insert into Order_Product(orderId,productId,quantity,total) values (1,1,3,900000)
insert into Subscribes(accountid) values (1)


update Product set name = 'Iphone X', technical_parameters = '', description = '', price = , manufacturer = '', producttype =  where id = 1
--Select by id
select * from Account where username like ''
select * from Manufacturer where id like ''
select * from ProductType where id like ''

select * from _Order where id like ''
select * from Order_Product where id like ''
select * from Subscribes where accountid like ''

--Select all data table
select * from AccountType
select * from Account
select * from Manufacturer
select * from ProductType
select * from _Order
select * from Order_Product
select * from Subscribes


--Update data
update Account set password = '' where username like ''

--Search product by name
Select * from Product where name like ''
--Search product by manufacturer
Select * from Product where manufacturer like ''
--Search product by price
Select * from Product where price = 
--Search product by producttype
Select * from Product where producttype like ''

--Concat string if search with multi requirements

--Drop table
drop table Subscribes
drop table Order_Product
drop table _Order
drop table Product
drop table ProductType
drop table Manufacturer
drop table Account
drop table AccountType

