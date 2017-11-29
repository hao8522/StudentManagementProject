
use master
go

if exists (select * from sysdatabases where name='SMDB')
drop database SMDB 
go

create database SMDB
on primary
(
	
    name='SMDB_data',

    filename='D:\DB\SMDB_data.mdf',

    size=10MB,
 
    filegrowth=1MB
)

log on
(
    name='SMDB_log',
    filename='D:\DB\SMDB_log.ldf',
    size=2MB,
    filegrowth=1MB
)
go

use SMDB
go
if exists (select * from sysobjects where name='Students')
drop table Students
go
create table Students
(
    StudentId int identity(100000,1) ,
    StudentName varchar(20) not null,
    Gender char(2)  not null,
    Birthday smalldatetime  not null,
    StudentIdNo numeric(18,0) not null,
    CardNo  varchar(20) not null,
    StuImage text null,
    Age int not null,
    PhoneNumber varchar(50),
    StudentAddress varchar(500),
    ClassId int not null  
)
go

if exists(select * from sysobjects where name='StudentClass')
drop table StudentClass
go
create table StudentClass
(
	ClassId int primary key,
    ClassName varchar(20) not null
)
go

if exists(select * from sysobjects where name='ScoreList')
drop table ScoreList
go
create table ScoreList
(
    Id int identity(1,1) primary key,
    StudentId int not null,
    CSharp int null,
    SQLServerDB int null,
    UpdateTime smalldatetime not null
)
go

if exists(select * from sysobjects where name='Attendance')
drop table Attendance
create table Attendance
(
	Id int identity(100000,1) primary key,
    CardNo varchar(20) not null,
    DTime smalldatetime not null 
)
go

if exists(select * from sysobjects where name='Admins')
drop table Admins
create table Admins
(
	LoginId int identity(1000,1) primary key,
    LoginPwd varchar(20) not null,
    AdminName varchar(20) not null
)
go

use SMDB
go

if exists(select * from sysobjects where name='pk_StudentId')
alter table Students drop constraint pk_StudentId

alter table Students
add constraint pk_StudentId primary key (StudentId)


if exists(select * from sysobjects where name='ck_Age')
alter table Students drop constraint ck_Age
alter table Students
add constraint ck_Age check (Age between 18 and 35) 


if exists(select * from sysobjects where name='uq_StudentIdNo')
alter table Students drop constraint uq_StudentIdNo
alter table Students
add constraint uq_StudentIdNo unique (StudentIdNo)

if exists(select * from sysobjects where name='uq_CardNo')
alter table Students drop constraint uq_CardNo
alter table Students
add constraint uq_CardNo unique (CardNo)


if exists(select * from sysobjects where name='ck_StudentIdNo')
alter table Students drop constraint ck_StudentIdNo
alter table Students
add constraint ck_StudentIdNo check (len(StudentIdNo)=18)


if exists(select * from sysobjects where name='df_StudentAddress')
alter table Students drop constraint df_StudentAddress
alter table Students 
add constraint df_StudentAddress default ('unknown' ) for StudentAddress

if exists(select * from sysobjects where name='df_UpdateTime')
alter table ScoreList drop constraint df_UpdateTime
alter table ScoreList 
add constraint df_UpdateTime default (getdate() ) for UpdateTime

if exists(select * from sysobjects where name='df_DTime')
alter table Attendance drop constraint df_DTime
alter table Attendance 
add constraint df_DTime default (getdate() ) for DTime


if exists(select * from sysobjects where name='fk_classId')
alter table Students drop constraint fk_classId
alter table Students
add constraint fk_classId foreign key (ClassId) references StudentClass(ClassId)

if exists(select * from sysobjects where name='fk_StudentId')
alter table ScoreList drop constraint fk_StudentId
alter table ScoreList
add constraint fk_StudentId foreign key(StudentId) references Students(StudentId)


-------------------------------------------insert data--------------------------------------
use SMDB
go


insert into StudentClass(ClassId,ClassName) values(1,'software 1')
insert into StudentClass(ClassId,ClassName) values(2,'software 2')
insert into StudentClass(ClassId,ClassName) values(3,'Computer science1')
insert into StudentClass(ClassId,ClassName) values(4,'Computer science2')
insert into StudentClass(ClassId,ClassName) values(5,'network 1')
insert into StudentClass(ClassId,ClassName) values(6,'network 2')

--插入学员信息
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('AAA','M','1989-08-07',22,120223198908071111,'0004018766','022-22222222','aaaaaaaaaaaaa',1)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('BBB','F','1989-05-06',22,120223198905062426,'0006394426','022-33333333','qqqqqqqqq',2)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('CCC','F','1990-02-07',21,120223199002078915,'0006073516','022-44444444','wwwwwwwww',4)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('DDD','F','1987-05-12',24,130223198705125167,'0006254540','022-55555555',default,2)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('EEE','F','1986-05-08',25,130223198605081528,'0006403803','022-66666666','ddddddddd',1)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('GGG','M','1987-07-18',24,130223198707182235,'0006404372','022-77777777',default,1)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('HHH','M','1988-09-28',24,130223198909282235,'0006092947','022-88888888','aaaaaaa',3)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('李铭','M','1987-01-18',24,130223198701182257,'0006294564','022-99999999','ddddddd',1)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('III','F','1987-06-15',24,130223198706152211,'0006092450','022-11111111',default,3)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('JJJ','F','1989-08-19',24,130223198908192235,'0006069457','022-11111222',default,4)
         
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('JKKK','F','1986-05-08',25,130224198605081528,'0006403820','022-66666666','ddddddddd',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('LLL','M','1986-05-08',25,130225198605081528,'0006403821','022-66666666','ddddddddd',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('MMM','M','1986-05-08',25,130226198605081528,'0006403822','022-66666666','ddddddddd',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('NNN','M','1986-05-08',25,130227198605081528,'0006403823','022-66666666','aaaaaaaaa',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('OOO','M','1986-05-08',25,130228198605081528,'0006403824','022-66666666','gggggggg',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('PPP','F','1986-05-08',25,130229198605081528,'0006403825','022-66666666','eeeeeeee',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('QQQ','F','1986-05-08',25,130222198605081528,'0006403826','022-66666666','sssssss',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('RRR','F','1986-05-08',25,130220198605081528,'0006403827','022-66666666','aaaaaaaaaa',1)
         
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('SSS','F','1986-05-08',25,130228198605081530,'0006403854','022-66666666','gggggggggg',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('TTT','M','1986-05-08',25,130229198605081531,'0006403855','022-66666666','ffffffff',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('UUU','F','1986-05-08',25,130222198605081532,'0006403856','022-66666666','ddddddddddd',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('VVV','F','1986-05-08',25,130220198605081544,'0006403857','022-66666666','AAA',1)
         
         
         

insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100000,60,78)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100001,55,88)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100002,90,58)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100003,88,75)

insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100004,62,88)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100006,52,80)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100007,91,66)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100009,78,35)

insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100000,60,78)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100001,55,88)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100002,90,58)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100003,88,75)

insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100004,62,88)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100006,52,80)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100007,91,66)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100009,78,35)

insert into Admins (LoginPwd,AdminName) values(123456,'AAA')
insert into Admins (LoginPwd,AdminName) values(123456,'BBB')


--delete from Students 



select * from Students
select * from StudentClass
select * from ScoreList
select * from Admins
select * from Attendance




