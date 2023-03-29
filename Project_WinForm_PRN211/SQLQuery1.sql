create database DB_PRN211_Project
use DB_PRN211_Project

create table Roles(
   id INT IDENTITY(1,1) PRIMARY KEY,
   [Name] nvarchar(50)
)

create table Accounts(
	 id INT IDENTITY(1,1) PRIMARY KEY,
	 username nvarchar(50) not null,
	 pasword nvarchar(50) not null,
	 phone nvarchar(50),
	 email nvarchar(50),
	 dob   datetime,
	 role_id int foreign key references Roles(id)
)

CREATE TABLE Brands (
   id INT IDENTITY(1,1) PRIMARY KEY,
   [Name] NVARCHAR(50)
);
drop table Products
CREATE TABLE Products (
   id INT IDENTITY(1,1) PRIMARY KEY,
   [Name] NVARCHAR(50),
   Price FLOAT,
   Descrip nvarchar(500),
   bid INT FOREIGN KEY REFERENCES Brands(id),
   cid INT FOREIGN KEY REFERENCES Categories(id)
);
drop table Categories
create table Categories(
	 id INT IDENTITY(1,1) PRIMARY KEY,
	 [Name] NVARCHAR(50)
);

--------------------------------------------
INSERT INTO [dbo].[Products]
           ([Name]
           ,[Price]
           ,[Descrip]
           ,[bid]
           ,[cid])
     VALUES(N'KEYCHRON1',400000,N'Thiết kế siêu mỏng, cùng switch low profile đòi hỏi ít lực hơn và sự di chuyển của ngón tay',5,1)
	 INSERT INTO [dbo].[Products]
           ([Name]
           ,[Price]
           ,[Descrip]
           ,[bid]
           ,[cid])
     VALUES(N'KEYCHRON2',600000,N'bàn phím cơ này mày mang phong cách thiết kế vô cùng tối giản đơn giản.',5,2)
           
	 INSERT INTO [dbo].[Products]
           ([Name]
           ,[Price]
           ,[Descrip]
           ,[bid]
           ,[cid])
     VALUES(N'KEYCHRON3',1800000,N'đây thực sự là một loại bàn phím rất hữu dụng bên cạnh những bàn phím chuyên dụng dành cho Macbook.',5,3)


