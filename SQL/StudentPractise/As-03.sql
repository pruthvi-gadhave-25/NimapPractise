use StudentDb 

--Count total number of students.
SELECT count(*) FROM Student ;


--Count total number of students who are born in 1986.
SELECT count(*) FROM student 
Where DATENAME(year, dob) = 1986  ; 


select count(*) FROM student
Where DATENAME(month , dob) = 'july'  ;

--Count unique universities from student_qualifications table.
select COUNT(DISTINCT(university)) from student_qualifications

--Display the university name and the count of those students who have done ‘BE’
SELECT  university ,COUNT(name) FROM student_qualifications 
Where name = 'BE' 
Group BY University 
select *from student_qualifications

--Count how many students has not done ‘BE’.
SELECT  college ,COUNT(*) BE_Student_count FROM student_qualifications 
WHERE name ! = 'BE'
GROUP BY college ;

--Find the maximum marks student got in ‘BE’.
SELECT name , MAX(MARKS) as Max_Marks FROM  student_qualifications
WHere name='BE' 
Group by name  ;

--Count how many course_batches have started on ’2016-02-01’.
SELECT count(starton) as bAtches FROM course_batches
Where starton  = '2016-02-01' ;


SELECT* FROM course_batches

--Find the maximum marks any student has got in “BE”.
SELECT max(marks) fROM student_qualifications
WHERE name='BE' ;