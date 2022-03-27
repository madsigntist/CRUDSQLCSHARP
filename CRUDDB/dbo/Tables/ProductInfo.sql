CREATE TABLE [dbo].[ProductInfo]
(
		[ProductID] INT NOT NULL PRIMARY KEY, 
    [ItemName] NVARCHAR(50) NULL, 
    [Design] NVARCHAR(150) NULL, 
    [Color] NVARCHAR(50) NULL, 
    [InsertDate] DATETIME NULL, 
    [UpdateDate] DATETIME NULL, 
    [ModifyDate] DATETIME NULL
)

