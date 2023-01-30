CREATE TABLE [dbo].[Students]
(
	[rollNo] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(255) NOT NULL,
	[familyName] NVARCHAR(255) NOT NULL,
	[Address] NVARCHAR(255) NOT NULL,
	[contactNumber] INT NOT NULL
	

)
