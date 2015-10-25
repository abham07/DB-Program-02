/*
Preconditions:
-You should have connected to the server using user "postgres", database "Assignment2.Proj2"
- The database structure is created (i. e. the tables exist)


Post conditions
- The database is full of an initial set of the test data
*/
truncate animals restart identity cascade;
insert into animals(breed, weight1,age) values
('Tiger',120,5),
('Dog', 35,4);