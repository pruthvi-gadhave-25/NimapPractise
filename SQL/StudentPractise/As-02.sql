--Get student details whose namefirst is having 4 characters only.


Select * From Student 
Where namefirst  LIKE '____'

--Get the ASCII value of the 3rd character of namefirst column.

SELECT ASCII(SUBSTRING(namefirst , 3,1)) as Ascii_Value_Of_Char 
From student ;

-- Get namefirst and namelast in lowercase.

SELECT LOWER(namefirst)as FIsrtName ,LOWER(namelast) as LastName  FROM Student  ;


--Display all course_batches who ends on ‘Sunday’.


Select * FROM course_batches
Where DATENAME(weekday , endson) = 'sunday' ;


--Combine to display student namefirst and namelast.
SELECT CONCAT(namefirst , ' ',namelast) as NAME FROM Student

SELECT *FROM student

--Write a query to display the following output for all student. If (namefirst, namelast or emailID) is null then replace it with a blank space.

SELECT 
	COALESCE(namefirst, '') AS namefirst,
    COALESCE(namelast, '') AS namelast,
    COALESCE(emailID, '') AS emailID
From student


--Get first 4 letters of student namefirst.

SELECT SUBSTRING(namefirst ,1,4) as FirstName FROM student 

--Get all student whose DOB is in the month of ‘October’.
SELECT * From student 
Where  DATENAME(month , DOB)= 'October' ;


--Get all student whose DOB is in the month of ‘January’ or ‘December
SELECT * FROM student 
Where DATENAME(month , DOB)= 'January' OR DATENAME(month , DOB)= 'December' 

--Print current date and time.
SELECT GETDATE() ;
--Extract month from the current date.
select DATENAME(m , GETDATE()) ;





