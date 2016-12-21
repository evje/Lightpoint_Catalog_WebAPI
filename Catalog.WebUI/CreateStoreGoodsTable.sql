CREATE TABLE [dbo].[StoreGoods] (
    [Store_Id] INT NOT NULL,
    [Good_Id]  INT NOT NULL,
    CONSTRAINT [PK_dbo.StoreGoods] PRIMARY KEY CLUSTERED ([Store_Id] ASC, [Good_Id] ASC),
    CONSTRAINT [FK_dbo.StoreGoods_dbo.Stores_Store_Id] FOREIGN KEY ([Store_Id]) REFERENCES [dbo].[Stores] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.StoreGoods_dbo.Goods_Good_Id] FOREIGN KEY ([Good_Id]) REFERENCES [dbo].[Goods] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Store_Id]
    ON [dbo].[StoreGoods]([Store_Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Good_Id]
    ON [dbo].[StoreGoods]([Good_Id] ASC);