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
CREATE TABLE dbo.Fuels (FuelId int IDENTITY(1,1) NOT NULL PRIMARY KEY, FuelType nvarchar(50), FuelDensity real) -- виды топлива
CREATE TABLE dbo.Tanks (TankId int IDENTITY(1,1) NOT NULL PRIMARY KEY, TankType nvarchar(20), TankVolume real, TankWeight real, TankMaterial nvarchar(20)) -- емкости
CREATE TABLE dbo.Operations (OperationId int IDENTITY(1,1) NOT NULL PRIMARY KEY, FuelId int, TankId int, Inc_Exp real, [Date] date) -- операции

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
		SET @NameLimit=5+RAND()*15 -- имя от 5 до 20 символов
			

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
		INSERT INTO dbo.Operations (FuelId, TankId, Inc_Exp, [Date])
		SELECT 
		CAST( (1+RAND()*(@NumberFuels-1)) as int),
		CAST( (1+RAND()*(@NumberTanks-1)) as int),
		250-RAND()*500, 
		@odate
		
		SET @RowCount +=1
	END

COMMIT TRAN
GO
-- ================================================
-- создание представления для отбора данных всех операций
CREATE VIEW [dbo].[View_AllOperations]
AS
SELECT        dbo.Operations.OperationId, dbo.Operations.FuelId, dbo.Operations.TankId, dbo.Operations.Inc_Exp, dbo.Operations.Date, dbo.Fuels.FuelType, 
                         dbo.Tanks.TankType
FROM            dbo.Fuels INNER JOIN
                         dbo.Operations ON dbo.Fuels.FuelId = dbo.Operations.FuelId INNER JOIN
                         dbo.Tanks ON dbo.Operations.TankId = dbo.Tanks.TankId
GO
-- ================================================
-- создание хранимой процедуры для выбора данных одной или нескольких операций по заданным параметрам.

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID ( 'dbo.uspGetOperations', 'P' ) IS NOT NULL 
    DROP PROCEDURE dbo.uspGetOperations;
GO
CREATE PROCEDURE dbo.uspGetOperations
	@FuelId int =-100, 
    @FuelType nvarchar(50) ='',
	@TankId int =-100, 
    @TankType nvarchar(20) =''
AS 
    BEGIN
    
	if @TankId>0 and @FuelId>0 	
	SELECT * 
    FROM dbo.View_AllOperations
	WHERE (
	(FuelType Like (@FuelType + '%')) AND 
	(TankType Like (@TankType + '%')) AND
	(TankId=@TankId) AND
    (FuelId=@FuelId)	
	);	
	
	if @TankId>0 and @FuelId<0	
	SELECT * 
    FROM dbo.View_AllOperations
	WHERE (
	(FuelType Like (@FuelType + '%')) AND 
	(TankType Like (@TankType + '%')) AND
	(TankId=@TankId)
	);	
	
	if @TankId<0 and @FuelId>0	
	SELECT * 
    FROM dbo.View_AllOperations
	WHERE (
	(FuelType Like (@FuelType + '%')) AND 
	(TankType Like (@TankType + '%')) AND
	(FuelId=@FuelId)
	);
	
	if @TankId<0 and @FuelId<0	
	SELECT * 
    FROM dbo.View_AllOperations
	WHERE (
	(FuelType Like (@FuelType + '%')) AND 
	(TankType Like (@TankType + '%')) 
	);		
	
	END;
GO