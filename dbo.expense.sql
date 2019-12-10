CREATE TABLE [dbo].[expense] (
    [id]     INT           NOT NULL,
    [amount] INT           NULL,
    [type]   VARCHAR (100) NULL,
    [category] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_expense] PRIMARY KEY CLUSTERED ([id] ASC)
);

