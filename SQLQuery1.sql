

create table stud(id int primary key,name varchar(20),gender char(10),dob date,phone varchar(15),
department varchar(10),address char(20));

select * from stud;

select * from teacher;

drop table stud;
drop table teacher;

create table atten(id int,name varchar(20),dept varchar(50),totaldays int,
dayspresent int,daysabsent int)

insert into atten values(101,'Navaneeta','BSc',70,45,25);
insert into atten values(102,'Naveen','BE',80,50,30);
insert into atten values(103,'Harini','ECE',90,80,10);

select * from atten;

create table teac(tid int,name varchar(20),major varchar(10),gender char(10),phone varchar(10),department varchar(5),adddress varchar(30));

insert into teac values(1,'Meena','PHD','Female',6578940984,'BE','Madurai');
insert into teac values(2,'Arun','PHD','Male',9847847389,'FT','Chennai');

select * from teac;


update teac set Department='EEE' where tid=2
create procedure searchs @FId int
as
begin
select * from stud
where id=@FId
end
go

create table markk(id int FOREIGN KEY references stud(id),subject1 int,subject2 int,subject3 int,subject4 int,subject5 int,average float );

select * from markk;

delete markk where id=101;

create procedure studmark @id int, @mark1 int,@mark2 int,@mark3 int,@mark4 int,@mark5 int
as
begin
insert into markk values(@id,@mark1,@mark3,@mark3,@mark4,@mark5,(@mark1+@mark2+@mark3+@mark4+@mark5)/5)
end
go

drop procedure studmark

exec studmark 101,85,78,68,25,65
exec studmark 102,88,76,79,99,87
exec studmark 103,98,67,58,58,57

select 
stud.name,stud.gender,stud.dob,stud.phone,stud.department,stud.address,
atten.daysabsent,atten.dayspresent,markk.subject1,markk.subject2,markk.subject3,markk.subject4,markk.subject5,markk.average
from stud inner join markk on stud.id=markk.id
inner join atten on markk.id=atten.id;



