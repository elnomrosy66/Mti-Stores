USE [Stores]
GO
/****** Object:  User [MTI]    Script Date: 01/16/2021 11:47:57 ******/
CREATE USER [MTI] FOR LOGIN [MTI] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[users]    Script Date: 01/16/2021 11:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[user_name] [nvarchar](50) NOT NULL,
	[pass] [nvarchar](50) NOT NULL,
	[type] [nvarchar](50) NOT NULL,
	[allowed_store] [int] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unites]    Script Date: 01/16/2021 11:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unites](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_unites] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stores]    Script Date: 01/16/2021 11:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_stores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[items]    Script Date: 01/16/2021 11:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[items](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](250) NOT NULL,
	[store_id] [int] NOT NULL,
	[locker] [nvarchar](50) NULL,
	[row] [nvarchar](50) NULL,
	[cell] [nvarchar](50) NULL,
	[main_unit] [int] NOT NULL,
	[rate] [int] NOT NULL,
	[requestLimit] [int] NOT NULL,
 CONSTRAINT [PK_items] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[movements_header]    Script Date: 01/16/2021 11:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movements_header](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[place] [nvarchar](max) NOT NULL,
	[reciever] [nvarchar](max) NOT NULL,
	[store_id] [int] NOT NULL,
	[date] [date] NOT NULL,
	[user_id] [int] NOT NULL,
	[approved] [int] NOT NULL,
	[userApproved] [int] NULL,
	[type] [nvarchar](50) NOT NULL,
	[number] [int] NOT NULL,
 CONSTRAINT [PK_movements_header] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_store]    Script Date: 01/16/2021 11:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_store](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[store_id] [int] NOT NULL,
 CONSTRAINT [PK_user_store] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unites_relations]    Script Date: 01/16/2021 11:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unites_relations](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[item_id] [int] NOT NULL,
	[sup_unit] [int] NOT NULL,
	[ratio] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_unites_relations] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[movements]    Script Date: 01/16/2021 11:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movements](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[item_id] [int] NOT NULL,
	[qty] [decimal](18, 2) NOT NULL,
	[unit_id] [int] NOT NULL,
	[mvt_id] [int] NULL,
	[qty_unit] [decimal](18, 2) NULL,
 CONSTRAINT [PK_movements] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GetItems]    Script Date: 01/16/2021 11:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetItems]
as
select name as 'اسم الصنف' from items
GO
/****** Object:  StoredProcedure [dbo].[store_items]    Script Date: 01/16/2021 11:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[store_items]
@store_id int
AS
BEGIN
select stores.name as 'اسم المخزن',  items.name as 'اسم الصنف' , (SUM(case  when movements_header.type = 'وارد' then movements.qty else 0 end  )+ SUM(case  when movements_header.type = 'إفتتاحي' then movements.qty else 0 end  ))- SUM(case  when movements_header.type = 'صادر' then movements.qty else 0 end  )as inn  
from items inner join stores on items.store_id = stores.id
inner join unites_relations on items.id = unites_relations.item_id
inner join unites on unites_relations.sup_unit = unites.id and unites_relations.ratio=1
inner join movements on movements.item_id = items.id
inner join movements_header on movements_header.id = movements.mvt_id
where stores.id = @store_id
group by stores.name , items.name

END
GO
/****** Object:  StoredProcedure [dbo].[rptStores]    Script Date: 01/16/2021 11:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[rptStores]
/*@store_id int*/
as
select stores.name as 'اسم المخزن',  items.name as 'اسم الصنف' , SUM(case  when movements_header.type = 'وارد' then movements.qty else 0 end  )as 'inn', SUM(case  when movements_header.type = 'إفتتاحي' then movements.qty else 0 end  )as 'start', SUM(case  when movements_header.type = 'صادر' then movements.qty else 0 end  )as 'out'  from items 
inner join stores on items.store_id = stores.id
inner join unites_relations on items.id = unites_relations.item_id
inner join unites on unites_relations.sup_unit = unites.id and unites_relations.ratio=1
inner join movements on movements.item_id = items.id
inner join movements_header on movements_header.id = movements.mvt_id
group by stores.name , items.name
GO
/****** Object:  StoredProcedure [dbo].[mvtReport]    Script Date: 01/16/2021 11:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[mvtReport]
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	movements_header.id ,
	movements_header.number as 'الرقم',
	 place , 
	 reciever ,
	 date,
	 type,
	 number ,
	 stores.name as 'اسم المخزن',
	 items.name as 'اسم الصنف',
	 movements.qty,
	 unites.name,
	 approved
	      from movements_header 
	inner join stores on store_id = stores.id
	inner join movements on movements.mvt_id = movements_header.id
	inner join items on movements.item_id = items.id
	inner join unites on movements.unit_id = unites.id
	where movements_header.id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[GetActiveItems]    Script Date: 01/16/2021 11:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetActiveItems]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select stores.name as 'اسم المخزن',  items.name as 'اسم الصنف' ,SUM(case  when movements_header.type = 'صادر' then movements.qty else 0 end  )as inn  
from items inner join stores on items.store_id = stores.id
inner join unites_relations on items.id = unites_relations.item_id
inner join unites on unites_relations.sup_unit = unites.id and unites_relations.ratio=1
inner join movements on movements.item_id = items.id
inner join movements_header on movements_header.id = movements.mvt_id

group by stores.name , items.name
END
GO
/****** Object:  Default [DF_items_rate]    Script Date: 01/16/2021 11:47:56 ******/
ALTER TABLE [dbo].[items] ADD  CONSTRAINT [DF_items_rate]  DEFAULT ((0)) FOR [rate]
GO
/****** Object:  Default [DF_items_requestLimit]    Script Date: 01/16/2021 11:47:56 ******/
ALTER TABLE [dbo].[items] ADD  CONSTRAINT [DF_items_requestLimit]  DEFAULT ((0)) FOR [requestLimit]
GO
/****** Object:  Default [DF_movements_qty_unit]    Script Date: 01/16/2021 11:47:56 ******/
ALTER TABLE [dbo].[movements] ADD  CONSTRAINT [DF_movements_qty_unit]  DEFAULT ((0)) FOR [qty_unit]
GO
/****** Object:  Default [DF_movements_header_approved]    Script Date: 01/16/2021 11:47:56 ******/
ALTER TABLE [dbo].[movements_header] ADD  CONSTRAINT [DF_movements_header_approved]  DEFAULT ((0)) FOR [approved]
GO
/****** Object:  ForeignKey [FK_items_stores]    Script Date: 01/16/2021 11:47:56 ******/
ALTER TABLE [dbo].[items]  WITH CHECK ADD  CONSTRAINT [FK_items_stores] FOREIGN KEY([store_id])
REFERENCES [dbo].[stores] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[items] CHECK CONSTRAINT [FK_items_stores]
GO
/****** Object:  ForeignKey [FK_movements_items]    Script Date: 01/16/2021 11:47:56 ******/
ALTER TABLE [dbo].[movements]  WITH CHECK ADD  CONSTRAINT [FK_movements_items] FOREIGN KEY([item_id])
REFERENCES [dbo].[items] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[movements] CHECK CONSTRAINT [FK_movements_items]
GO
/****** Object:  ForeignKey [FK_movements_movements_header]    Script Date: 01/16/2021 11:47:56 ******/
ALTER TABLE [dbo].[movements]  WITH CHECK ADD  CONSTRAINT [FK_movements_movements_header] FOREIGN KEY([mvt_id])
REFERENCES [dbo].[movements_header] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[movements] CHECK CONSTRAINT [FK_movements_movements_header]
GO
/****** Object:  ForeignKey [FK_movements_unites]    Script Date: 01/16/2021 11:47:56 ******/
ALTER TABLE [dbo].[movements]  WITH CHECK ADD  CONSTRAINT [FK_movements_unites] FOREIGN KEY([unit_id])
REFERENCES [dbo].[unites] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[movements] CHECK CONSTRAINT [FK_movements_unites]
GO
/****** Object:  ForeignKey [FK_movements_header_users]    Script Date: 01/16/2021 11:47:56 ******/
ALTER TABLE [dbo].[movements_header]  WITH CHECK ADD  CONSTRAINT [FK_movements_header_users] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[movements_header] CHECK CONSTRAINT [FK_movements_header_users]
GO
/****** Object:  ForeignKey [FK_unites_relations_items]    Script Date: 01/16/2021 11:47:56 ******/
ALTER TABLE [dbo].[unites_relations]  WITH CHECK ADD  CONSTRAINT [FK_unites_relations_items] FOREIGN KEY([item_id])
REFERENCES [dbo].[items] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[unites_relations] CHECK CONSTRAINT [FK_unites_relations_items]
GO
/****** Object:  ForeignKey [FK_unites_relations_unites]    Script Date: 01/16/2021 11:47:56 ******/
ALTER TABLE [dbo].[unites_relations]  WITH CHECK ADD  CONSTRAINT [FK_unites_relations_unites] FOREIGN KEY([sup_unit])
REFERENCES [dbo].[unites] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[unites_relations] CHECK CONSTRAINT [FK_unites_relations_unites]
GO
/****** Object:  ForeignKey [FK_user_store_stores]    Script Date: 01/16/2021 11:47:56 ******/
ALTER TABLE [dbo].[user_store]  WITH CHECK ADD  CONSTRAINT [FK_user_store_stores] FOREIGN KEY([store_id])
REFERENCES [dbo].[stores] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user_store] CHECK CONSTRAINT [FK_user_store_stores]
GO
/****** Object:  ForeignKey [FK_user_store_users]    Script Date: 01/16/2021 11:47:56 ******/
ALTER TABLE [dbo].[user_store]  WITH CHECK ADD  CONSTRAINT [FK_user_store_users] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user_store] CHECK CONSTRAINT [FK_user_store_users]
GO
