CREATE TABLE [dbo].[Users]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY UNIQUE, 
    [username] VARCHAR(25) NOT NULL UNIQUE, 
    [passsword] VARCHAR(16) NOT NULL, 
    [name] VARCHAR(35) NOT NULL, 
    [is_manager] BIT NOT NULL
)
