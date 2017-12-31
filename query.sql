
Create table AccountType (
	id varchar(6),
	name nvarchar(6),
	PRIMARY KEY (id)
)

Create table Account (
	id varchar(10),
	username varchar(50),
	password nvarchar(50),
	email nvarchar(100),
	phone varchar(11),
	address nvarchar(200),
	acctypeId varchar(6),
	PRIMARY KEY (id),
	FOREIGN KEY (acctypeId) REFERENCES AccountType(id)
)

Create table Manufacturer(
	id varchar(10),
	name nvarchar (150),	
	PRIMARY KEY (id)
)
 
Create table ProductType(
	id int,
	name nvarchar (100),
	PRIMARY KEY (id)
)

Create table Product(
	id varchar(10),
	name varchar(50),
	technical_parameters varchar(250),
	description nvarchar(250), 
	price int,
	manufacturer varchar(10),
	producttype int,
	PRIMARY KEY (id),
	FOREIGN KEY (manufacturer) REFERENCES Manufacturer(id),
	FOREIGN KEY (producttype) REFERENCES ProductType(id)
)

Create table _Order (
	id int,
	accId varchar(10),
	_datetime datetime,
	total int,
	PRIMARY KEY (id),
	FOREIGN KEY (accId) REFERENCES Account(id)
)

Create table Order_Product (
	id int,
	orderId int,
	productId varchar(10),
	quantity int,
	total int,
	PRIMARY KEY (id),
	FOREIGN KEY (orderId) REFERENCES _Order(id),
	FOREIGN KEY (productId) REFERENCES Product(Id)
)

Create table Subscribes (
	accId varchar(10),
	productId varchar(10),
	PRIMARY KEY (productId,accId),
	FOREIGN KEY (accId) REFERENCES Account(id),
	FOREIGN KEY (productId) REFERENCES Product(Id)
)

--Insert data to table
insert into AccountType(id, name) values (1,'admin'), (2,'nv'), (3,'kh')
insert into Manufacturer(id, name) values ('M001','SamSung'), ('M002','Apple'), ('M003', 'Sony'), ('M004', 'Nokia')
insert into ProductType (id, name) values (1,'Mobile'), (2,'Tablet'), (3,'Laptop')
insert into Product(id,name,technical_parameters,description,price,manufacturer,producttype) values  (1,'Iphone X', 'Camera: 16MP, Ram: 128GB', 'This is a product of Apple', 30000000, 'M002', 1)
insert into Account(id,username,password,email,phone,address,acctypeId) values ('user001','bluesea','test123','bluesea1696@gmail.com','0943734018',N'Bình Tân',2)
insert into _Order(id,accId,_datetime,total) values (1,'user001','2017-12-03 17:07:00',900000)
insert into Order_Product(id,orderId,productId,quantity,total) values (1,1,1,3,900000)
insert into Subscribes(accId,productId) values ('user001', 1)


update Product set name = 'Iphone X', technical_parameters = '', description = '', price = , manufacturer = '', producttype =  where id = 1
--Select by id
select * from Account where username like ''
select * from Manufacturer where id like ''
select * from ProductType where id like ''

select * from _Order where id like ''
select * from Order_Product where id like ''
select * from Subscribes where accId like ''

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

