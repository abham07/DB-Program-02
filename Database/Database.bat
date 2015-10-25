
SET PATH=%PATH%;C:\Program Files (x86)\Graphviz2.38\bin

java -jar schemaSpy_5.0.0.jar ^
     -t pgsql ^
     -host localhost:5432 ^
     -db "Assignment2.Proj2" ^
     -u postgres ^
     -s public ^
     -o reverse_engineered ^
     -dp ".\postgresql-9.4-1200.jdbc4.jar" ^
     -p astronauta
