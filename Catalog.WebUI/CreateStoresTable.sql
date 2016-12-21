CREATE TABLE [dbo].[Stores] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (100) NOT NULL,
    [Address] NVARCHAR (100) NOT NULL,
    [Mode]    NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_dbo.Stores] PRIMARY KEY CLUSTERED ([Id] ASC)
);