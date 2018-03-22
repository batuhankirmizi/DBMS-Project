CREATE TABLE [dbo].[Users] (
    [id]         INT        NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    [username]   VARCHAR(25) NOT NULL,
    [password]   VARCHAR(16) NOT NULL,
    [name]       VARCHAR(30) NOT NULL,
    [is_manager] BIT        NOT NULL
);

