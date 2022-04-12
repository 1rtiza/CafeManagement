CREATE TABLE [dbo].[items]
(
	[iid] INT NOT NULL PRIMARY KEY, 
    [name] VARCHAR(50) NOT NULL, 
    [category] VARCHAR(250) NOT NULL, 
    [price] BIGINT NOT NULL
)
