use libretto2
DROP TABLE dbo.Orders;
DROP TABLE dbo.Auctions;
DROP TABLE dbo.Users;
DROP TABLE dbo.Roles;

CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Roles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
))


CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Avatar] [varbinary](max) NULL,
	[UserRole_RoleId] [int] NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
))

ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Users_dbo.Roles_UserRole_RoleId] FOREIGN KEY([UserRole_RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_dbo.Users_dbo.Roles_UserRole_RoleId]



CREATE TABLE [dbo].[Auctions](
	[AuctionId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[ItemQuantity] [int] NOT NULL,
	[Image] [varbinary](max),
	[PricePerUnit] [decimal](18, 2) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Creator_UserId] [int] NULL,
 CONSTRAINT [PK_dbo.Auctions] PRIMARY KEY CLUSTERED 
(
	[AuctionId] ASC
))

ALTER TABLE [dbo].[Auctions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Auctions_dbo.Users_Creator_UserId] FOREIGN KEY([Creator_UserId])
REFERENCES [dbo].[Users] ([UserId])
ALTER TABLE [dbo].[Auctions] CHECK CONSTRAINT [FK_dbo.Auctions_dbo.Users_Creator_UserId]


CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Auction_AuctionId] [int] NULL,
	[Buyer_UserId] [int] NULL,
	[Seller_UserId] [int] NULL,
 CONSTRAINT [PK_dbo.Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
))

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Orders_dbo.Auctions_Auction_AuctionId] FOREIGN KEY([Auction_AuctionId])
REFERENCES [dbo].[Auctions] ([AuctionId])

ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_dbo.Orders_dbo.Auctions_Auction_AuctionId]

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Orders_dbo.Users_Buyer_UserId] FOREIGN KEY([Buyer_UserId])
REFERENCES [dbo].[Users] ([UserId])

ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_dbo.Orders_dbo.Users_Buyer_UserId]

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Orders_dbo.Users_Seller_UserId] FOREIGN KEY([Seller_UserId])
REFERENCES [dbo].[Users] ([UserId])

ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_dbo.Orders_dbo.Users_Seller_UserId]





SET IDENTITY_INSERT dbo.Roles ON; 

INSERT INTO dbo.Roles (RoleId, Name) VALUES (1, 'USER'),
 (2, 'ADMIN');

 SET IDENTITY_INSERT dbo.Roles OFF; 

SET IDENTITY_INSERT dbo.Users ON; 

INSERT INTO dbo.Users (UserId, Username, Password, UserRole_RoleId) VALUES (1, 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918',2),
(2, 'user', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 1), 
(3, 'john', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8',1),
(4, 'kazumi', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8',1),  
(5, 'jin', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8',1);

SET IDENTITY_INSERT dbo.Users OFF; 

SET IDENTITY_INSERT dbo.Auctions ON;  

INSERT INTO dbo.Auctions(AuctionId, Title, PricePerUnit, ItemQuantity, Description, Creator_UserId) 
VALUES (1, 'Usb Adapters', 12.50, 150, 'Usb 2.0 to 3.0 Adapter.', 1),
(2, 'Coconut Juice', 10, 40, 'Fresh coconut juice.', 2),
(3, 'Milk Drink', 4.2, 40, 'Coconut milk drink.', 3),
(4, 'Aloe Vera Juice', 10, 40, 'Fresh water with aloe vera pulp.', 5);

SET IDENTITY_INSERT dbo.Auctions OFF; 

SET IDENTITY_INSERT dbo.Orders ON; 

INSERT INTO dbo.Orders(OrderId, Auction_AuctionId, Buyer_UserId, Seller_UserId, Quantity, dbo.Orders.Date, dbo.Orders.Address)
VALUES (1, 1, 4, 3, 2, '03-07-2017', 'Warszawska 76 Be³chatów'),
(2, 1, 1, 1, 2, '03-07-2017', 'Grzybowa 12 £ódŸ'),
(3, 2, 2, 2, 12, '03-07-2017', 'Warszawska 176 Pabianice'),
(4, 3, 3, 3, 7, '04-07-2017', 'Olszytyñska 16 Olsztyn'),
(5, 4, 5, 5, 18, '04-07-2017', 'Piaskowa 3 Be³chatów'),
(6, 1, 4, 1, 3, '05-07-2017', 'Warszawska 76');

SET IDENTITY_INSERT dbo.Orders OFF;


