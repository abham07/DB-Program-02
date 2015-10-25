drop database if exists "Assignment2.Proj2";

drop role if exists "Assignment2";
create role "Assignment2" login;
comment on role "Assignment2" is 'Resctricted ISS app pool user';

drop role if exists "Levi";
create role "Levi" login superuser;
comment on role "Levi" is 'Personal developer superuser';

create database "Assignment2.Proj2";
comment on database "Assignment2.Proj2" is 'Dabatase for Assigment2';

grant connect on database "Assignment2.Proj2" to "Assignment2";