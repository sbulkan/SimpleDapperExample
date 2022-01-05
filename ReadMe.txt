First u need to create DB.
name must be(for this example) dapperDb(you can change name in code)
then u need to create a table name with Employees and add column with EmployeeId, EmployeFullName, Age, City 

USE [dapperDb]
GO

/****** Object:  Table [dbo].[Employees]  ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[EmployeeId] [nvarchar](50) NULL,
	[EmployeeFullName] [nvarchar](150) NULL,
	[Age] [int] NULL,
	[City] [nvarchar](50) NULL
) ON [PRIMARY]
GO

