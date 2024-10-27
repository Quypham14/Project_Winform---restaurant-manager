USE master;
GO
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'QUANLYNHAHANG')
BEGIN
   ALTER DATABASE QUANLYNHAHANG SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QUANLYNHAHANG;
END
GO
CREATE DATABASE QUANLYNHAHANG;
GO
USE QUANLYNHAHANG;
GO

-- Tạo bảng quản lý bàn
CREATE TABLE TableFood (
    id INT IDENTITY PRIMARY KEY,
    nametable NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
    status NVARCHAR(100) NOT NULL DEFAULT N'Trống' -- Trống || Có người
);
GO

-- Tạo bảng tài khoản
CREATE TABLE Account (
    UserName NVARCHAR(100) NOT NULL PRIMARY KEY,
    DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Quypham',
    PassWord NVARCHAR(1000) NOT NULL DEFAULT N'password',
    Type INT NOT NULL DEFAULT 0 CHECK (Type IN (0, 1)) -- Chỉ cho phép 0 hoặc 1
);
GO

-- Tạo bảng danh mục món ăn
CREATE TABLE FoodCategory (
    id INT IDENTITY PRIMARY KEY,
    nametable NVARCHAR(100) NOT NULL DEFAULT N'ĐÃ ĐẶT TÊN ĐÂU'
);
GO
-- Tạo bảng món ăn
CREATE TABLE Food (
    id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL DEFAULT N'ĐÃ ĐẶT TÊN ĐÂU',
    idCategory INT NOT NULL,
    price Float NOT NULL
    FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
);
GO

-- Tạo bảng hóa đơn
CREATE TABLE Bill (
    id INT IDENTITY PRIMARY KEY,
    DateCheckIn DATETIME NOT NULL DEFAULT GETDATE(),
    DateCheckOut DATETIME,
    idTable INT NOT NULL,
    status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán, 0: chưa thanh toán
	discount INT NOT NULL DEFAULT 0, -- Mặc định là 0
	totalPrice FLOAT
    FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
);
GO

-- Tạo bảng chi tiết hóa đơn
CREATE TABLE Billinfo (
    id INT IDENTITY PRIMARY KEY,
    idBill INT NOT NULL,
    idFood INT NOT NULL,
    count INT NOT NULL DEFAULT 0,
    FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
    FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
);
GO

-- Thêm tài khoản mẫu
INSERT INTO dbo.Account (UserName, DisplayName, PassWord, Type)
VALUES (N'Quypham14', N'Pham Sy Quy', N'14022003', 1);
GO
INSERT INTO dbo.Account (UserName, DisplayName, PassWord, Type)
VALUES (N'staff', N'Staff', N'66666666', 0);
GO

-- Tạo thủ tục lấy tài khoản theo UserName
CREATE PROC USP_GetAccountByUserName
@userName NVARCHAR(100)
AS
BEGIN
    SELECT * FROM dbo.Account WHERE UserName = @userName;
END;
GO

-- Thực thi thủ tục
EXEC dbo.USP_GetAccountByUserName @userName = N'Staff';
GO

-- Tạo thủ tục đăng nhập
CREATE PROC USP_Login
@userName NVARCHAR(100), @passWord NVARCHAR(100)
AS
BEGIN
    SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord;
END;
GO

-- Thêm 30 bàn vào TableFood
DECLARE @i INT = 1;
WHILE @i <= 20
BEGIN
    INSERT INTO dbo.TableFood (nametable) VALUES (N'BÀN ' + CAST(@i AS NVARCHAR(100)));
    SET @i = @i + 1;
END;
GO

-- Tạo thủ tục lấy danh sách bàn
CREATE PROC USP_GetTableList
AS
BEGIN
    SELECT * FROM dbo.TableFood;
END;
GO

-- Thực thi thủ tục
EXEC dbo.USP_GetTableList;
GO

-- Thêm các danh mục món ăn
INSERT INTO dbo.FoodCategory (nametable) VALUES (N'Hải sản'), (N'Đặc sản miền núi'), 
(N'Cơm'), (N'Đồ uống'), (N'Tráng miệng');
GO

-- Thêm món ăn
INSERT INTO dbo.Food (name, idCategory, price)
VALUES 
(N'Hàu nướng mỡ hành', 1, 15000),
(N'Nghêu hấp xả', 1, 50000),
(N'Mực một nắng sa tế', 1, 120000),
(N'Thắng cố', 2, 800000),
(N'Dê hấp xả', 2, 200000),
(N'Trâu gác bếp', 2, 250000),
(N'Lợn rừng quay', 2, 500000),
(N'Cơm lam', 3, 15000),
(N'Cơm cháy', 3, 160000),
(N'Coca', 4, 10000),
(N'7up', 4, 10000),
(N'Nước lọc', 4, 7000),
(N'Rượu nếp cái hoa vàng', 4, 70000),
(N'Rượu ba kích', 4, 100000),
(N'Rượu táo mèo', 4, 70000),
(N'Kem', 5, 20000),
(N'Hoa quả', 5, 30000);
GO
-- Truy vấn dữ liệu
SELECT * FROM dbo.Bill;
SELECT * FROM dbo.Billinfo;
SELECT * FROM dbo.Food;
SELECT * FROM dbo.FoodCategory;
GO
CREATE PROC USP_InsertBill
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
CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
INSERT INTO dbo.Billinfo (idBill, idFood, count)
VALUES 
	 (
	 @idBill,
	 @idFood,
	 @count
	 )
END
GO
ALTER PROC USP_InsertBillInfo 
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
CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @idBill INT;
    DECLARE @idTable INT;
    DECLARE @count INT;

    -- Lấy idBill từ bản ghi vừa được chèn/cập nhật
    SELECT @idBill = idBill FROM Inserted;

    -- Lấy idTable từ bảng Bill có trạng thái chưa thanh toán (status = 0)
    SELECT @idTable = idTable 
    FROM dbo.Bill 
    WHERE id = @idBill AND status = 0;

    -- Đếm số lượng món trong hóa đơn
    SELECT @count = COUNT(*) 
    FROM dbo.BillInfo 
    WHERE idBill = @idBill;

    -- Cập nhật trạng thái bàn dựa vào số món ăn
    IF (@count > 0)
        UPDATE dbo.TableFood 
        SET status = N'Có người' 
        WHERE id = @idTable;
    ELSE
        UPDATE dbo.TableFood 
        SET status = N'Trống' 
        WHERE id = @idTable;
END;
GO
CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill
FOR UPDATE
AS
BEGIN
    DECLARE @idBill INT;
    DECLARE @idTable INT;
    DECLARE @count INT = 0;

    -- Lấy idBill từ bản ghi được cập nhật
    SELECT @idBill = id FROM Inserted;

    -- Lấy idTable từ bảng Bill dựa trên idBill
    SELECT @idTable = idTable 
    FROM dbo.Bill 
    WHERE id = @idBill;

    -- Đếm số hóa đơn chưa thanh toán của bàn này (status = 0)
    SELECT @count = COUNT(*) 
    FROM dbo.Bill 
    WHERE idTable = @idTable AND status = 0;

    -- Nếu không còn hóa đơn chưa thanh toán, cập nhật bàn thành "Trống"
    IF (@count = 0)
        UPDATE dbo.TableFood 
        SET status = N'Trống' 
        WHERE id = @idTable;
END;
GO

CREATE PROC USP_SwitchTabel
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
CREATE PROC USP_GetListBillByDate
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
CREATE PROC USP_UpdateAccount
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
CREATE TRIGGER UTG_DeleteBillinfo
ON dbo.Billinfo
FOR DELETE
AS 
BEGIN
    DECLARE @idBill INT, @idTable INT;

    -- Lặp qua từng dòng trong bảng Deleted để xử lý
    DECLARE cur CURSOR FOR
    SELECT idBill FROM Deleted;

    OPEN cur;
    FETCH NEXT FROM cur INTO @idBill;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Lấy idTable từ hóa đơn liên quan
        SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill;

        -- Kiểm tra xem còn chi tiết hóa đơn nào chưa thanh toán không
        IF NOT EXISTS (
            SELECT 1 
            FROM dbo.Billinfo AS bi
            JOIN dbo.Bill AS b ON b.id = bi.idBill
            WHERE b.id = @idBill AND b.status = 0
        )
        BEGIN
            -- Cập nhật trạng thái bàn thành "Trống" nếu không còn món ăn nào
            UPDATE dbo.TableFood
            SET status = N'Trống'
            WHERE id = @idTable;
        END

        FETCH NEXT FROM cur INTO @idBill;
    END

    CLOSE cur;
    DEALLOCATE cur;
END;
GO
