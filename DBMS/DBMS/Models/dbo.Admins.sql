CREATE TABLE [dbo].[Users]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [username] NCHAR(25) NOT NULL, 
    [password] NCHAR(16) NOT NULL, 
    [name] NCHAR(30) NOT NULL, 
    [is_manager] BIT NOT NULL
)
