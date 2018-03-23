CREATE TABLE [dbo].[Login History]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [admin_id] INT NOT NULL, 
    [username] NCHAR(25) NOT NULL, 
    [log_details] NCHAR(160) NULL
)
