USE [bdDiti2023]
GO
/****** Object:  Table [dbo].[Produits]    Script Date: 18/12/2023 20:30:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produits](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameProduit] [nvarchar](80) NOT NULL,
	[DescriptionProduit] [nvarchar](400) NOT NULL,
	[PriceProduit] [int] NOT NULL,
	[QteMinimal] [int] NULL,
 CONSTRAINT [PK_dbo.Produits] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
