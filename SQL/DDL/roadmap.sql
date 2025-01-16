Create Database Sample1 ;
USE  Sample1  ;
--alter db Name 
Alter Database Sample1 Modify Name = Sample2 ;

--alter db name using SP built in 
Execute  sp_renameDB 'Sample2', 'Sample4' ;


--DrOP DB if no one is using it 
--drop DB 
Drop Database Sample4 ;

use Sample4
---------Table ------------

Create Table tblGender (

ID int NOT NULL  PRIMARY KEY ,
Gender nvarchar(50) NOT NULL 
) ;

Create Table tblPerson (
	ID int NOT NULL PRIMARY KEY ,
	Name nvarchar(50) ,
	Email nvarchar(50) , 
	GenderId    int  FOREIGN KEY    REFERENCES tblGender(ID) 
) ;


SELEct * FROM tblPerson;

Insert into  tblGender (Id ,Gender ) Values  
	(3 , 'Unknown' ) ;
	


SELECT * from  tblGender  ;


Insert into tblPerson (ID ,  Name ,Email , GenderId)
values (5 , 'Sam' , 'sam@mail.com' , '1'),
(2 , 'Soumy' , 'soumy@mail.com' , '2'),
(3 , 'Rashi' , 'Rashi@mail.com' , '3') ,
(4 , 'Raghu' , 'raghu@mail.com' , '1');


Alter table tblPerson 
Add Age int  ;


--Not working 
Insert into tblPerson ( Age)
Values(25,23 , 34 , 56) ;

Delete from  tblPerson where ID = 5 ;  

-- forign  key  constraint 
Delete from tblGender where ID =  3  ; 

--Update 

Update tblPerson 
Set Name =  'Roshni'  
Where ID =  2 ;

SELECT * From tblPerson

--Order By 

Select * from tblPerson 
Order BY Id Desc


--Group By 
Select GenderId  ,Count(*)    as numbers   
From tblPerson 
Group By GenderId  
Having GenderId > 1 ;


--HAVING applies to summarized group records, whereas WHERE applies to individual records.