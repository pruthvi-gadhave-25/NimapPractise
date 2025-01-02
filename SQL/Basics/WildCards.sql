create Database InvioceDB 

use InvioceDB  ;

create Table Customer(
	id INT PRIMARY KEY IDENTITY(1,1), 
    name NVARCHAR(100) ,
    code NVARCHAR(50) ,
    phone_no NVARCHAR(15) 
)

SELECT * From Customer ;


Insert into Customer (name ,code, phone_no)
Values
	  ('John Doe', 'CUST001', '123-456-7890'),
    ('Jane Smith', 'CUST002', '987-654-3210'),
    ('Alice Johnson', 'CUST003', '555-123-4567'),
    ('Bob Brown', 'CUST004', '444-555-6789'),
    ('Charlie Davis', 'CUST005', '222-333-4444');


	Insert into Customer Values
	('Charlie Davis', 'CUST006', '2223336767');

	Select name, code  From Customer 
	where name ='Charlie Davis' And id = 5;
	



	--Order by 

	Select name, code  From Customer 
	Order By name  Desc ;

	Select name, code  From Customer 
	Order By name Asc;

	--two columns for sort 
	Select name, code  From Customer 
	Order By  code ,name  desc;

	--Alias name forcolumn 

	Select id as CustomerId , name as CustomerName From
	Customer

	---Distinct 
	Select Distinct name as CustomerName  from Customer ;   -- Work fine on column --it will remove duplicate from o/p columns 
	Select Distinct *   from Customer  ;  -- not works on all Columns * 
	 

	 --pattern and Wild cards 
	 Select * From Customer 
	 where name like 'jane%'  Or  name like '%C';


	  Select * From Customer 
	 where name like '%D_e'; -- John Doe    --   _ for space 
	   
	  Select * From Customer 
	 where name like '%j%n'; -- Alice Johnson  %  use for any letter 


	 Select * From Customer 
	 Where name like  '[^C]%'    -- negate where name does not starts with C 


