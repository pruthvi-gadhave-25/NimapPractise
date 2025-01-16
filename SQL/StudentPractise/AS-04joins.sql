use StudentDb

select *from student
select *from student_qualifications	
select *from student_phone	
select *from student_address	

--Display all student and with their address from student and student_address tables.
SELECT  s.namefirst , s.namelast ,a.address 
FROM student s
Inner join  student_address a 
ON s.ID = studentID  ;

-- Display (namefirst, namelast, emailID, and student_qualification details) from student and student_qualification relations
select 

SELECT s.namefirst ,s.namelast  , q.*
FROM student s  
JOIN  student_qualifications  q
ON s.ID =  q.studentID ;


--Display (namefirst, namelast, emailID, college, and university) who have studied in 'Yale University'. (Use student, and student_qualification relation)

SELECT s.namefirst ,s.namelast  , q.*
FROm student s 
 inner JOIN student_qualifications q 
ON s.ID = q.studentID 
Where q.university = 'Yale University' ;


--Display all student details his phone details and his qualification details. (Use student, student_phone and student_qualification relation)
SELECT s.namefirst ,s.namelast  , q.* ,p.number ,p.isActive
FROm student s 
 inner JOIN student_qualifications q 
ON s.ID = q.studentID  
INNER JOIN student_phone  p
ON s.ID =   p.studentID  ;

-- Display (studentID, namefirst, namelast, name, college, university, and marks) whose name is ‘BE’.(Use student, and student_qualification relation)

SELECT s.namefirst ,s.namelast  , q.* 
FROm student s 
inner JOIN student_qualifications q 
ON s.ID = q.studentID  
where  q.name = 'BE' ;

--Print phone number of all student in the given format 7032300034*****.
select SUBSTRING(number , 1,7)+ '****'  as PhoneNUmber from student_phone
select SUBSTRING(NUMBER , 1,4)+ '****' + SUBSTRING(number ,8,12 ) as Phone_number FROM student_phone ;


--Display the module name and the duration of the module for the batch “Batch1”.

select * from course
select * from course_batches
-- work on course and course_batch tble 
SELECT  c.name , c.duration  From  course c 
INNER jOIN course_batches b 
ON c.ID  =  b.courseID 
WHere b.name = 'Batch1' ;

--Display module names for “PG-DAC” course.
select * from course
select *from modules
select *from course_modules

select c.name , m.name
FROM modules   m
INNER JOIN  course_modules cm 
ON m.ID =  cm.moduleID 
INNER JOIN  course  c
ON  c.ID =  cm.courseID 
Where c.name = 'PG-DAC' ;

--Display namefirst, namelast, and batch name for all students.



select * from student 
select * from course_batches

select  * from course
select * from batch_students
select * from modules


--Display (namefirst, namelast, phone number, and emailid) whose student ID is 13
select * from student 
select * from student_phone

SELECT  s.namefirst, s.namelast, p.number, s.emailid 
FROM student s
INNER JOIN  student_phone p
ON s.ID =  p.studentID 
Where s.ID = 13 ; 

--Display (namefirst and count the total number of phones a student is having) for all student.
SELECT   s.namefirst  ,COUNT(p.number) 
FROM student s
INNER JOIN  student_phone p
ON s.ID =  p.studentID  
Group By s.namefirst 



--Get student’s (namefirst, namelast, DOB, address, name, college, university, marks, and year).
select * from student 
select * from student_qualifications


SELECT   s.*   , q.*
FROM student s
INNER JOIN  student_qualifications q
ON s.ID =  q.studentID  



--Get (namefirst, namelast, emailID, phone number, and address) whose faculty name is ‘ketan’.
select * from student 
select * from faculty
select * from faculty_address
select * from faculty_phone

SELECT  f.* , fa.address , fp.number
FROM faculty  f
INNER JOIN faculty_address fa 
ON f.ID =  fa.facultyID
INNER JOIN faculty_phone fp 
ON fp.facultyID = f.ID 
Where F.namefirst ='Ketan' ;


--Get(course name and batch name)for all courses.
select * from course 
select * from course_batches


--SELECT 
--FROM course c
--LEFT JOIN  course_batches cb  
--ON c.ID = cb.courseID 
--Group by c.name

use StudentDb

--Get all course details which had started on ‘2016-02-01’.
SELECT * FROM course 
SELECT * FROM course_modules  
SELECT * FROM modules  


SELECT  c.*  ,cb.starton
FROM course c
INNER JOIN course_batches cb
ON c.ID =  cb.courseID 
WHERE cb.starton = '2016-02-01';


--Display the courses where ‘JAVA1’ is taught
SELECT  c.* ,m.name 
FROM  course c 
INNER JOIN course_modules cm 
ON c.ID =  cm.courseID 
INNER JOIN  modules m 
ON cm.moduleID =  m.ID
WHERE m.name = 'Java1' ;


--Display all student who have taken admission in 6 months course.
--not done 
select * FROM student 
SELECT * FROM student_qualifications


--Write a query to display the output in the following manner.
--'saleel', 'Aadhaar, Driving Licence, PAN, Voter ID, Passport, Debit, Credit'
--Arrange the data is ascending order of nameFirst.

---Write a query to display the output in the following manner.
--'saleel', 'Aadhaar, Driving Licence, PAN, Voter ID, Passport, Debit, Credit'
--Arrange the data is ascending order of nameFirst.












