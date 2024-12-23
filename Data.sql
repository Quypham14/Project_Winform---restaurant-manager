USE [master]
GO
/****** Object:  Database [QUANLYNHAHANG]    Script Date: 10/28/2024 3:08:52 PM ******/
CREATE DATABASE [QUANLYNHAHANG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYNHAHANG', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QUANLYNHAHANG.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QUANLYNHAHANG_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QUANLYNHAHANG_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QUANLYNHAHANG] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYNHAHANG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYNHAHANG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QUANLYNHAHANG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYNHAHANG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYNHAHANG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QUANLYNHAHANG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYNHAHANG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QUANLYNHAHANG] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYNHAHANG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYNHAHANG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYNHAHANG] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUANLYNHAHANG] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QUANLYNHAHANG] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QUANLYNHAHANG] SET QUERY_STORE = ON
GO
ALTER DATABASE [QUANLYNHAHANG] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QUANLYNHAHANG]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END

GO
/****** Object:  Table [dbo].[Account]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [datetime] NOT NULL,
	[DateCheckOut] [datetime] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL,
	[discount] [int] NOT NULL,
	[totalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Billinfo]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Billinfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nametable] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nametable] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'Quypham14', N'Pham Sy Quy', N'1329013217221118314444184154251233253117147', 1)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'staff', N'Staff', N'1247312010420123021122820746135579911420559', 0)
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (2, CAST(N'2024-10-28T12:31:54.123' AS DateTime), CAST(N'2024-10-28T12:35:53.360' AS DateTime), 2, 1, 0, 360000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (4, CAST(N'2024-10-28T12:36:10.200' AS DateTime), CAST(N'2024-10-28T12:47:15.917' AS DateTime), 1, 1, 0, 1710000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (5, CAST(N'2024-10-28T13:43:26.950' AS DateTime), CAST(N'2024-10-28T13:43:30.940' AS DateTime), 1, 1, 0, 35000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (6, CAST(N'2024-10-28T13:43:40.887' AS DateTime), CAST(N'2024-10-28T13:43:42.783' AS DateTime), 2, 1, 0, 800000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (7, CAST(N'2024-10-28T13:43:46.630' AS DateTime), CAST(N'2024-10-28T13:43:55.767' AS DateTime), 3, 1, 0, 545000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (8, CAST(N'2024-10-28T13:43:59.140' AS DateTime), CAST(N'2024-10-28T13:44:04.813' AS DateTime), 1, 1, 15, 425000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (9, CAST(N'2024-10-28T13:44:10.443' AS DateTime), CAST(N'2024-10-28T13:44:29.713' AS DateTime), 7, 1, 15, 1547000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (10, CAST(N'2024-10-28T13:44:33.490' AS DateTime), CAST(N'2024-10-28T13:44:40.647' AS DateTime), 2, 1, 25, 562500)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (11, CAST(N'2024-10-28T13:44:48.140' AS DateTime), CAST(N'2024-10-28T13:45:00.210' AS DateTime), 15, 1, 30, 1309000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (12, CAST(N'2024-10-28T13:45:38.543' AS DateTime), CAST(N'2024-10-28T13:45:41.657' AS DateTime), 1, 1, 30, 140000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (13, CAST(N'2024-10-28T13:45:52.023' AS DateTime), CAST(N'2024-10-28T13:46:06.557' AS DateTime), 4, 1, 15, 382500)
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1, N'Hàu nướng mỡ hành', 1, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2, N'Nghêu hấp xả', 1, 50000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3, N'Mực một nắng sa tế', 1, 120000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4, N'Thắng cố', 2, 800000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5, N'Dê hấp xả', 2, 200000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6, N'Trâu gác bếp', 2, 250000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7, N'Lợn rừng quay', 2, 500000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (8, N'Cơm lam', 3, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (9, N'Cơm cháy', 3, 160000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (10, N'Coca', 4, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (11, N'7up', 4, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (12, N'Nước lọc', 4, 7000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (13, N'Rượu nếp cái hoa vàng', 4, 70000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (14, N'Rượu ba kích', 4, 100000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (15, N'Rượu táo mèo', 4, 70000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (16, N'Kem', 5, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (17, N'Hoa quả', 5, 30000)
SET IDENTITY_INSERT [dbo].[Food] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodCategory] ON 

INSERT [dbo].[FoodCategory] ([id], [nametable]) VALUES (1, N'Hải sản')
INSERT [dbo].[FoodCategory] ([id], [nametable]) VALUES (2, N'Đặc sản miền núi')
INSERT [dbo].[FoodCategory] ([id], [nametable]) VALUES (3, N'Cơm')
INSERT [dbo].[FoodCategory] ([id], [nametable]) VALUES (4, N'Đồ uống')
INSERT [dbo].[FoodCategory] ([id], [nametable]) VALUES (5, N'Tráng miệng')
SET IDENTITY_INSERT [dbo].[FoodCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[TableFood] ON 

INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (1, N'BÀN 1', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (2, N'BÀN 2', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (3, N'BÀN 3', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (4, N'BÀN 4', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (5, N'BÀN 5', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (6, N'BÀN 6', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (7, N'BÀN 7', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (8, N'BÀN 8', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (9, N'BÀN 9', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (10, N'BÀN 10', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (11, N'BÀN 11', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (12, N'BÀN 12', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (13, N'BÀN 13', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (14, N'BÀN 14', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (15, N'BÀN 15', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (16, N'BÀN 16', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (17, N'BÀN 17', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (18, N'BÀN 18', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (19, N'BÀN 19', N'Trống')
INSERT [dbo].[TableFood] ([id], [nametable], [status]) VALUES (20, N'BÀN 20', N'Trống')
SET IDENTITY_INSERT [dbo].[TableFood] OFF
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'Quypham') FOR [DisplayName]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'password') FOR [PassWord]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [discount]
GO
ALTER TABLE [dbo].[Billinfo] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT (N'ĐÃ ĐẶT TÊN ĐÂU') FOR [name]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  DEFAULT (N'ĐÃ ĐẶT TÊN ĐÂU') FOR [nametable]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Bàn chưa có tên') FOR [nametable]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Trống') FOR [status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [dbo].[TableFood] ([id])
GO
ALTER TABLE [dbo].[Billinfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[Billinfo]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[FoodCategory] ([id])
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD CHECK  (([Type]=(1) OR [Type]=(0)))
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Tạo thủ tục lấy tài khoản theo UserName
CREATE PROC [dbo].[USP_GetAccountByUserName]
@userName NVARCHAR(100)
AS
BEGIN
    SELECT * FROM dbo.Account WHERE UserName = @userName;
END;
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetListBillByDate]
    @checkIn DATE, 
    @checkOut DATE
AS
BEGIN
    SELECT 
        t.nametable AS [Tên bàn], 
        b.totalPrice AS [Tổng tiền], 
        b.DateCheckIn AS [Ngày vào], 
        b.DateCheckOut AS [Ngày ra], 
        b.discount AS [Giảm giá]
    FROM 
        dbo.Bill AS b
    JOIN 
        dbo.TableFood AS t ON t.id = b.idTable
    WHERE 
        b.DateCheckIn >= @checkIn 
        AND b.DateCheckOut <= @checkOut 
        AND b.status = 1;
END;
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDateAndPage]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetListBillByDateAndPage]
@checkIn date, @checkOut date, @page int
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows
	
	;WITH BillShow AS( SELECT b.ID, t.nametable AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE id NOT IN (SELECT TOP (@exceptRows) id FROM BillShow)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetNumBillByDate]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetNumBillByDate]
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT COUNT(*)
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableList]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Tạo thủ tục lấy danh sách bàn
CREATE PROC [dbo].[USP_GetTableList]
AS
BEGIN
    SELECT * FROM dbo.TableFood;
END;
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBill]
@idTable INT
AS
BEGIN
	INSERT dbo.Bill
	(
	DateCheckIn,
	DateCheckOut,
	idTable,
	status,
	discount,
	totalPrice
	)
	VALUES (GETDATE(), --DateCheckIn -date
			NULL , --DateCheckOut -date
			@idTable, --idTable -int
			0, --status - int
			0,
			0
			)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBillInfo] 
@idBill INT, @idFood INT, @count INT
AS
BEGIN
    DECLARE @isExitsBillInfo INT;
    DECLARE @foodCount INT = 1;
    SELECT @isExitsBillInfo = id, @foodCount = b.count 
    FROM dbo.BillInfo AS b 
    WHERE idBill = @idBill AND idFood = @idFood;

    IF (@isExitsBillInfo > 0)
    BEGIN
        DECLARE @newCount INT = @foodCount + @count;

        IF (@newCount > 0)
        BEGIN
            UPDATE dbo.BillInfo 
            SET count = @newCount 
            WHERE idFood = @idFood AND idBill = @idBill;
        END
        ELSE
        BEGIN
            IF EXISTS (SELECT 1 FROM dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood)
            BEGIN
                DELETE FROM dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood;
            END
        END
    END
    ELSE
    BEGIN
        IF @count > 0
        BEGIN
            INSERT INTO dbo.Billinfo (idBill, idFood, count)
            VALUES (@idBill, @idFood, @count);
        END
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Tạo thủ tục đăng nhập
CREATE PROC [dbo].[USP_Login]
@userName NVARCHAR(100), @passWord NVARCHAR(100)
AS
BEGIN
    SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord;
END;
GO
/****** Object:  StoredProcedure [dbo].[USP_MergeTable]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_MergeTable]
    @mainTableID INT,
    @otherTableID INT
AS
BEGIN
    DECLARE @idBillMain INT, @idBillOther INT;

    -- Lấy ID hóa đơn của bàn chính và bàn phụ
    SELECT @idBillMain = id FROM Bill WHERE idTable = @mainTableID AND status = 0;
    SELECT @idBillOther = id FROM Bill WHERE idTable = @otherTableID AND status = 0;

    IF @idBillMain IS NULL
    BEGIN
        -- Nếu bàn chính không có hóa đơn, chuyển hóa đơn từ bàn phụ sang bàn chính
        UPDATE Bill SET idTable = @mainTableID WHERE id = @idBillOther;
    END
    ELSE IF @idBillOther IS NOT NULL
    BEGIN
        -- Nếu cả hai bàn đều có hóa đơn, hợp nhất hóa đơn từ bàn phụ sang bàn chính
        UPDATE BillInfo
        SET idBill = @idBillMain
        WHERE idBill = @idBillOther;

        -- Xóa hóa đơn cũ của bàn phụ
        DELETE FROM Bill WHERE id = @idBillOther;
    END

    -- Cập nhật trạng thái bàn chính theo trạng thái hiện tại của bàn phụ
    UPDATE TableFood
    SET status = N'Có người'
    WHERE id = @mainTableID;

    -- Nếu không còn hóa đơn nào trên bàn phụ, chuyển bàn phụ về trạng thái "Trống"
    IF NOT EXISTS (SELECT 1 FROM Bill WHERE idTable = @otherTableID AND status = 0)
    BEGIN
        UPDATE TableFood SET status = N'Trống' WHERE id = @otherTableID;
    END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SwitchTabel]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_SwitchTabel]
@idTable1 INT, @idTable2 INT
AS
BEGIN
    DECLARE @idFirstBill INT, @idSecondBill INT;
    DECLARE @isFirstTableEmpty BIT = 1, @isSecondTableEmpty BIT = 1;

    -- Lấy hóa đơn hiện tại của 2 bàn (nếu có)
    SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0;
    SELECT @idSecondBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0;

    -- Nếu bàn 1 không có hóa đơn, tạo mới
    IF @idFirstBill IS NULL
    BEGIN
        INSERT INTO dbo.Bill (DateCheckIn, DateCheckOut, idTable, status)
        VALUES (GETDATE(), NULL, @idTable1, 0);

        SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0;
    END

    -- Nếu bàn 2 không có hóa đơn, tạo mới
    IF @idSecondBill IS NULL
    BEGIN
        INSERT INTO dbo.Bill (DateCheckIn, DateCheckOut, idTable, status)
        VALUES (GETDATE(), NULL, @idTable2, 0);

        SELECT @idSecondBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0;
        SET @isSecondTableEmpty = 1;
    END

    -- Chuyển các món từ hóa đơn này sang hóa đơn kia
    SELECT id INTO #TempBillInfo FROM dbo.BillInfo WHERE idBill = @idSecondBill;

    UPDATE dbo.BillInfo SET idBill = @idSecondBill WHERE idBill = @idFirstBill;
    UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM #TempBillInfo);

    DROP TABLE #TempBillInfo;

    -- Cập nhật trạng thái bàn
    IF NOT EXISTS (SELECT 1 FROM dbo.BillInfo WHERE idBill = @idSecondBill)
        UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2;

    IF NOT EXISTS (SELECT 1 FROM dbo.BillInfo WHERE idBill = @idFirstBill)
        UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1;
END;
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 10/28/2024 3:08:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateAccount]
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE UserName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	end
END
GO
USE [master]
GO
ALTER DATABASE [QUANLYNHAHANG] SET  READ_WRITE 
GO
