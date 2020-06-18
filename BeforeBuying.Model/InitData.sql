USE [BeforeBuying]
GO

INSERT INTO [dbo].[ItemSet] ([Name], [EAN], [UnitOfMeasure]) VALUES ('Maslo 50g','123456789','ks')
INSERT INTO [dbo].[ItemSet] ([Name], [EAN], [UnitOfMeasure]) VALUES ('Mlieko 1l','234567891','ks')
GO

INSERT INTO [dbo].[ShopSet] ([Name]) VALUES ('Tesco')
INSERT INTO [dbo].[ShopSet] ([Name]) VALUES ('Billa')
GO

INSERT INTO [dbo].[PriceSet] ([PriceInclVAT],[ItemId],[ShopId],[PricePerUnit]) VALUES (1.5, 1, 1, 1, 1.5)
GO

INSERT INTO [dbo].[DiscountSet]([DiscountFrom],[DiscountTo],[Percent],[PriceInclVAT],[PriceId]) VALUES('20120618 10:34:09 AM','20120619 10:34:09 AM', 50, 1.5, 1)
GO