USE [ProductosDB]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 23/11/2020 6:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Nombre] [nchar](32) NOT NULL,
	[Dni] [int] NOT NULL,
	[Usuario] [nchar](32) NOT NULL,
	[Contraseña] [nchar](15) NOT NULL,
	[Apellido] [nchar](32) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 23/11/2020 6:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](130) NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[Descripcion] [nchar](500) NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Clientes] ([Nombre], [Dni], [Usuario], [Contraseña], [Apellido]) VALUES (N'santiago                        ', 405045, N'santi                           ', N'1234           ', N'sbaglia                         ')
INSERT [dbo].[Clientes] ([Nombre], [Dni], [Usuario], [Contraseña], [Apellido]) VALUES (N'Pepe                            ', 324, N'asd                             ', N'sda            ', N'Peposo                          ')
INSERT [dbo].[Clientes] ([Nombre], [Dni], [Usuario], [Contraseña], [Apellido]) VALUES (N'santiagoo                       ', 456, N'santii                          ', N'1234           ', N'sbbaglia                        ')
INSERT [dbo].[Clientes] ([Nombre], [Dni], [Usuario], [Contraseña], [Apellido]) VALUES (N'lucas                           ', 4545450, N'luqui                           ', N'pepa           ', N'rodriguez                       ')
INSERT [dbo].[Clientes] ([Nombre], [Dni], [Usuario], [Contraseña], [Apellido]) VALUES (N'eze                             ', 454545, N'ezee                            ', N'peposo         ', N'ogioni                          ')
INSERT [dbo].[Clientes] ([Nombre], [Dni], [Usuario], [Contraseña], [Apellido]) VALUES (N'jose                            ', 4848080, N'josecito                        ', N'1234           ', N'Gonzalez                        ')
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Descripcion]) VALUES (1, N'savalo                                                                                                                            ', CAST(209.99 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Descripcion]) VALUES (2, N'mcEze                                                                                                                             ', CAST(500.99 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Descripcion]) VALUES (3, N'pc                                                                                                                                ', CAST(50000.00 AS Decimal(18, 2)), N'ryzen3                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ')
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Descripcion]) VALUES (4, N'jose                                                                                                                              ', CAST(6000.00 AS Decimal(18, 2)), N'Disco solido                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        ')
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Descripcion]) VALUES (5, N'Monitor Samsung                                                                                                                   ', CAST(40000.00 AS Decimal(18, 2)), N'tv 32                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               ')
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
