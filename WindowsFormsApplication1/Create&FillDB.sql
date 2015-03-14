--    данный скрипт создает базу данных toplivo с тремя таблицами и генерирует тестовые записи:
-- 1. виды топлива (Fuels) - 1000 штук
-- 2. список емкостей (Tanks) - 100 штук
-- 3. факты совершения операций прихода, расхода топлива (Operations) - 300000 штук

CREATE DATABASE toplivo

GO

ALTER DATABASE toplivo SET RECOVERY SIMPLE
GO

USE toplivo
--DROP TABLE Fuels, Tanks, Operations
--DROP VIEW View_AllOperations
CREATE TABLE dbo.Fuels (FuelID int IDENTITY(1,1) NOT NULL PRIMARY KEY, FuelType nvarchar(50), FuelDensity real) -- виды топлива
CREATE TABLE dbo.Tanks (TankID int IDENTITY(1,1) NOT NULL PRIMARY KEY, TankType nvarchar(20), TankVolume real, TankWeight real, TankMaterial nvarchar(20)) -- емкости
CREATE TABLE dbo.Operations (OperationID int IDENTITY(1,1) NOT NULL PRIMARY KEY, FuelID int, TankID int, Inc_Exp real, [Date] date) -- операции





SET NOCOUNT ON


DECLARE @Symbol CHAR(52)= 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz',
		@Position INT,
		@i INT,
		@NameLimit INT,
		@FuelType nvarchar(50),
		@TankType nvarchar(20),
		@TankMaterial nvarchar(20),
		@odate date,
		@RowCount INT,
		@NumberFuels int,
		@NumberTanks int,
		@NumberOperations int


SET @NumberFuels =1000
SET @NumberTanks =  100
SET @NumberOperations =  300000



BEGIN TRAN

SELECT @i=0 FROM dbo.Fuels WITH (TABLOCKX) WHERE 1=0

-- виды топлива -1000
	SET @RowCount=1
	
	WHILE @RowCount<=@NumberFuels
	BEGIN
		
		SET @FuelType=''
		SET @NameLimit=5+RAND()*45 -- имя от 5 до 50 символов
		SET @i=1

		WHILE @i<=@NameLimit
		BEGIN
			SET @Position=RAND()*52
			SET @FuelType = @FuelType + SUBSTRING(@Symbol, @Position, 1)
			SET @i=@i+1
		END

		INSERT INTO dbo.Fuels (FuelType, FuelDensity) SELECT @FuelType, (1+RAND())
		

		SET @RowCount +=1
	END



-- емкости 100
SELECT @i=0 FROM dbo.Tanks WITH (TABLOCKX) WHERE 1=0
SET @RowCount=1
	
	WHILE @RowCount<=@NumberTanks
	BEGIN
		
		SET @TankType=''
		SET @TankMaterial=''
		SET @NameLimit=5+RAND()*15 -- им¤ от 5 до 20 символов
			

		SET @i=1

		WHILE @i<=@NameLimit
		BEGIN
			SET @Position=RAND()*52
			SET @TankType = @TankType + SUBSTRING(@Symbol, @Position, 1)
			SET @Position=RAND()*52
			SET @TankMaterial=@TankMaterial + SUBSTRING(@Symbol, @Position, 1)
			SET @i=@i+1
		END

		INSERT INTO dbo.Tanks (TankType, TankVolume, TankWeight, TankMaterial) 
		SELECT @TankType, RAND()*500, RAND()*700, @TankMaterial
		

		SET @RowCount +=1
	END



-- операции 300000
SELECT @RowCount=1 FROM dbo.Operations WITH (TABLOCKX) WHERE 1=0
	
	WHILE @RowCount<=@NumberOperations
	BEGIN
		
		SET @odate=dateadd(day,-RAND()*15000,GETDATE())
		INSERT INTO dbo.Operations (FuelID, TankID, Inc_Exp, [Date])
		SELECT 
		CAST( (1+RAND()*(@NumberFuels-1)) as int),
		CAST( (1+RAND()*(@NumberTanks-1)) as int),
		250-RAND()*500, 
		@odate
		
		SET @RowCount +=1
	END


COMMIT TRAN
GO
CREATE VIEW [dbo].[View_AllOperations]
AS
SELECT        dbo.Operations.OperationID, dbo.Operations.FuelID, dbo.Operations.TankID, dbo.Operations.Inc_Exp, dbo.Operations.Date, dbo.Fuels.FuelType, 
                         dbo.Tanks.TankType
FROM            dbo.Fuels INNER JOIN
                         dbo.Operations ON dbo.Fuels.FuelID = dbo.Operations.FuelID INNER JOIN
                         dbo.Tanks ON dbo.Operations.TankID = dbo.Tanks.TankID


