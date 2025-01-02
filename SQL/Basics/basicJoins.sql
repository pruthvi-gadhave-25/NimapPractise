Create Table Products (
	product_id	INT  PRIMARY KEY IDENTITY(1,1) ,
	product_name Varchar(50)  ,
	product_code Varchar(50)  ,
	product_price Decimal(10,2 )   ,
	product_quantity Int  ,
)

use invioceDB

Insert into  Products (product_name, product_code, product_price, product_quantity)
Values  ('Laptop' ,'P001' , '50000.00' ,'4') ;

Insert into  Products (product_name, product_code, product_price, product_quantity)
Values   ('Smartphone', 'P002', 499.99, 150),
    ('Headphones', 'P003', 129.99, 200),
    ('Monitor', 'P004', 299.99, 75),
    ('Keyboard', 'P005', 49.99, 300);



	-- Union  No duplicates 
	SELECT product_name ,product_code from Products 
	union 
	Select  name ,code FRom Customer ;


	--Union all   Duplicates 
	SELECT product_name ,product_code from Products 
	union  All
	Select  name ,code FRom Customer ;


	-------Address 


	Create Table Address 
	(
		address_id INT PRIMARY KEY IDENTITY(1,1),
		customer_id INT  FOREIGN KEY REFERENCES Customer(id) ,
		address Varchar(100) ,
		city varchar(50)
	);

	INSERT INTO Address (customer_id, address, city)
VALUES
    (1, '123 Main St, Apt 4B', 'New York'),
    (2, '456 Oak Rd', 'Los Angeles'),
    (3, '789 Pine Ln', 'Chicago'),
    (4, '101 Maple Ave', 'Houston');

	INSERT INTO Address (customer_id, address, city)
VALUES
    (NUll, '123 Dadar', 'Mumbai');

	SELECT * from Address ;
	--Update 
	Update Address 
	Set customer_id   =2 
	where address_id = 3  ;

	--Delete on row

	Delete from Address 
	Where address_id =   5



	---Join Table Customer and Address 
	-- Inner Join
	
	SELECT * From Customer as c
	INNER JOIN  Address  as a
	on  c.id = a.address_id ;

	--Left Join 
	SELECT * From Customer as c
	Left JOIN  Address  as a
	on  c.id = a.address_id ;

--Right Join 
	SELECT * From Customer as c
	Right JOIN  Address  as a
	on  c.id = a.address_id ;

	--Full outer Join
	SELECT * From Customer as c
	Full Outer  JOIN  Address  as a
	on  c.id = a.address_id ;

	Select * from Customer 
	SELECT * From Customer 
	Cross  JOIN  Address  ;;
	


