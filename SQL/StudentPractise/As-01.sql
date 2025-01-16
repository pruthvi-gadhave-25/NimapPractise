--List all courses.

SELECT * From course ;

--List namefirst, namelast of all student.
SELECT namefirst ,namelast From student


--Display student information of the ID is 15.
SELECT *FROM student 
WHERE ID = 15 ;

--List namefirst, namelast, and emailID of student whose student namefirstis ‘Nitish’.
SELECT  namefirst, namelast,  emailID  FROM student 
Where namefirst like '%Nitish%' ;
-- Where namefirst = 'Nitish'  ;

--List all students having ID greater than equal to 12.
SELECT * From Student 
Where ID >=  12  ;


-- List all student details whose DOB is ‘1980-12-01’
SELECT * From Student 
Where DOB = '1980-12-01' ;

--Display the phone details where student ID is 5;
SELECT *  From student_phone 
Where ID =5  ;



--List student address whose student ID is 10
SELECT *  From student_address 
Where ID =10  ;


--List all modules in ascending order of module names.
SELECT *FROM modules
Order By name ;


--Display the student_address whose studentID is either 2, 4, 6 or 10 in descending order of studentID.

Select * From student_address 
Where studentID  IN(1,4,6,10) 
Order By (STudentID) DESC 

SELECT *FROM student_address
