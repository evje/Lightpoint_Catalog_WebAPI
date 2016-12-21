CREATE TABLE [dbo].[Goods] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_dbo.Goods] PRIMARY KEY CLUSTERED ([Id] ASC)
);