CREATE DATABASE EmployeesDb

USE EmployeesDb

CREATE TABLE [dbo].[Employees](
	[Id][int]IDENTITY(1,1) NOT NULL,
	[FirstName][nvarchar](255) NOT NULL,
	[LastName][nvarchar](255) NOT NULL,
	[Role][nvarchar](255) NOT NULL,
	[Salary][float] NOT NULL,
	[PhoneNumber][nvarchar](255) NOT NULL,
	[Status][bit] NOT NULL
)

CREATE PROCEDURE EmployeeProcedure  
(  
    @Id INT = NULL,  
    @FirstName nvarchar(255) = NULL,
    @LastName nvarchar(255) = NULL,
    @Role nvarchar(255) = NULL,
    @Salary decimal = NULL,
    @PhoneNumber nvarchar(255) = NULL,
    @Status bit = NULL,
	@Offset int = NULL,
	@Take int = NULL,
	@SalaryFrom decimal = NULL,
	@SalaryPriorTo decimal = NULL,
    @ActionType nvarchar(255)
)
AS
BEGIN
    IF @ActionType = 'SaveData'
    BEGIN
        IF NOT EXISTS (SELECT * FROM Employees WHERE Id=@Id)  
			BEGIN
				INSERT INTO Employees (FirstName, LastName, Role, Salary, PhoneNumber, Status)  
				VALUES (@FirstName, @LastName, @Role, @Salary, @PhoneNumber, @Status)  
			END
        ELSE
			BEGIN
				UPDATE Employees SET FirstName=@FirstName,LastName=@LastName,Role=@Role,  
				Salary=@Salary, PhoneNumber=@PhoneNumber, Status=@Status WHERE Id=@Id  
			END
    END
	
    IF @ActionType = 'DeleteData'
		BEGIN
			DELETE Employees WHERE [Id]=@Id
		END
	
    IF @ActionType = 'GetData'
		IF @Offset IS NOT NULL AND @Take IS NOT NULL
			BEGIN
				SELECT * 
				FROM [EmployeesDb].[dbo].[Employees]
				ORDER BY [Id]
				OFFSET @Offset ROWS
				FETCH NEXT @Take ROWS ONLY
			END
		ELSE
			BEGIN
				SELECT [Id] AS [Id],FirstName,LastName,Role,Salary,PhoneNumber, [Status] FROM Employees ORDER BY [Id]
			END

    IF @ActionType = 'GetById'
		BEGIN
			SELECT [Id] AS [Id],FirstName,LastName,Role,Salary,PhoneNumber, Status FROM Employees
			WHERE [Id]=@Id
		END

	IF @ActionType = 'Search'
		BEGIN 
			SELECT * 
				FROM Employees
				WHERE (FirstName = @FirstName OR @FirstName IS NULL)
				AND (LastName = @LastName OR @LastName IS NULL)
				AND (Role = @Role OR @Role IS NULL)
				AND (Salary > @SalaryFrom OR @SalaryFrom IS NULL)
				AND (Salary < @SalaryPriorTo OR @SalaryPriorTo IS NULL)
		END
END