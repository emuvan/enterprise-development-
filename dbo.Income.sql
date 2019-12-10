CREATE TABLE [dbo].[Income] (
    [Id]     INT        NOT NULL,
    [amount] INT        NULL,
    [type]   NCHAR (100) NULL,
    [category] NVARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

