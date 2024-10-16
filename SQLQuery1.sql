﻿CREATE DATABASE QUANLYNHAHANG
GO
USE QUANLYNHAHANG
GO
--Food
--Table
--FoodCategory
--Account
--Bill
--BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	nametable NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'--Trống || Có người
)
GO
CREATE TABLE Account
(
	UserName NVARCHAR(100) NOT NULL PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Quypham',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 -- 1: ADMIN 0: nhan vien
)
GO
CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	nametable NVARCHAR(100) NOT NULL DEFAULT N'ĐÃ ĐẶT TÊN ĐÂU'
)
GO
CREATE TABLE Food
( 
	id INT IDENTITY PRIMARY KEY NOT NULL,
	name NVARCHAR(100) NOT NULL DEFAULT N'ĐÃ ĐẶT TÊN ĐÂU',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO
CREATE TABLE Bill
( 
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE NOT NULL,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0--1: đã thanh toán và 0: chưa thanh toán
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO
CREATE TABLE Billinfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id),
)
GO
INSERT INTO dbo.Account
( UserName , 
DisplayName ,
PassWord ,
Type
)
VALUES (N'Staff', -- UserName -nvarchar(100)
		N'staff', --DisplayName -nvarchar(100)
		N'66666666', -- PassWord -nvarchar(1000)
		2 --Type -int
)
GO
CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName=@userName
END 
GO
EXEC dbo.USP_GetAccountByUserName @userName =N'staff' --varchar(100)
