USE [RedSocialMascotas]
GO
/****** Object:  Table [dbo].[Comentario]    Script Date: 20/05/2022 19:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comentario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NULL,
	[IdUsuario] [int] NULL,
	[IdPublicacion] [int] NULL,
	[FechaPublicacion] [datetime] NULL,
 CONSTRAINT [PK_Comentario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especie]    Script Date: 20/05/2022 19:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especie](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
 CONSTRAINT [PK_Especie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Foto]    Script Date: 20/05/2022 19:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Foto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Imagen] [nvarchar](500) NULL,
	[IdMascota] [int] NULL,
 CONSTRAINT [PK_Foto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mascota]    Script Date: 20/05/2022 19:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascota](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[EstadoAdoptivo] [bit] NULL,
	[IdEspecie] [int] NULL,
	[IdUsuario] [int] NULL,
	[IdRaza] [int] NULL,
 CONSTRAINT [PK_Mascota] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publicacion]    Script Date: 20/05/2022 19:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publicacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](500) NULL,
	[Descripcion] [varchar](500) NULL,
	[FechaPublicacion] [datetime] NULL,
	[IdRaza] [int] NULL,
	[IdEspecie] [int] NULL,
	[IdUsuario] [int] NULL,
	[IdMascota] [int] NULL,
 CONSTRAINT [PK_Publicacion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Raza]    Script Date: 20/05/2022 19:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Raza](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[IdEspecie] [varchar](100) NULL,
 CONSTRAINT [PK_Raza] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 20/05/2022 19:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](100) NULL,
	[Nombres] [varchar](100) NULL,
	[Password] [varchar](100) NULL,
	[Dni] [varchar](50) NULL,
	[ApellidoPaterno] [varchar](100) NULL,
	[ApellidoMaterno] [varchar](100) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Telefono] [char](15) NULL,
	[Imagen] [nvarchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Especie] ON 

INSERT [dbo].[Especie] ([Id], [Nombre]) VALUES (1, N'Perro')
INSERT [dbo].[Especie] ([Id], [Nombre]) VALUES (2, N'Gato')
SET IDENTITY_INSERT [dbo].[Especie] OFF
GO
SET IDENTITY_INSERT [dbo].[Foto] ON 

INSERT [dbo].[Foto] ([Id], [Imagen], [IdMascota]) VALUES (23, N'pitbull1.jpg', 24)
INSERT [dbo].[Foto] ([Id], [Imagen], [IdMascota]) VALUES (24, N'pitbull2.jpg', 24)
INSERT [dbo].[Foto] ([Id], [Imagen], [IdMascota]) VALUES (25, N'pitbull3.jpg', 24)
INSERT [dbo].[Foto] ([Id], [Imagen], [IdMascota]) VALUES (26, N'Gato 1 persa.png', 25)
INSERT [dbo].[Foto] ([Id], [Imagen], [IdMascota]) VALUES (27, N'gato 1.2.jpg', 25)
INSERT [dbo].[Foto] ([Id], [Imagen], [IdMascota]) VALUES (28, N'gato 1.3.jpg', 25)
SET IDENTITY_INSERT [dbo].[Foto] OFF
GO
SET IDENTITY_INSERT [dbo].[Mascota] ON 

INSERT [dbo].[Mascota] ([Id], [Nombre], [EstadoAdoptivo], [IdEspecie], [IdUsuario], [IdRaza]) VALUES (24, N'Pity', 1, 1, 5, 3)
INSERT [dbo].[Mascota] ([Id], [Nombre], [EstadoAdoptivo], [IdEspecie], [IdUsuario], [IdRaza]) VALUES (25, N'Fluffy', 0, 2, 5, 2)
SET IDENTITY_INSERT [dbo].[Mascota] OFF
GO
SET IDENTITY_INSERT [dbo].[Publicacion] ON 

INSERT [dbo].[Publicacion] ([Id], [Nombre], [Descripcion], [FechaPublicacion], [IdRaza], [IdEspecie], [IdUsuario], [IdMascota]) VALUES (38, N'Pity', N'RAZONES POR LAS QUE PONGO EN ADOPCION MI PITBULL: 
1. Mi hermano tiene fobia a los perros 
2. Ya no cuento con tiempo para sacarle a pasear
-> si estás interesdo escribeme al whatsaap <-', CAST(N'2022-05-20T18:43:29.553' AS DateTime), 3, 1, 5, 24)
SET IDENTITY_INSERT [dbo].[Publicacion] OFF
GO
SET IDENTITY_INSERT [dbo].[Raza] ON 

INSERT [dbo].[Raza] ([Id], [Nombre], [IdEspecie]) VALUES (1, N'Dálmata', N'1')
INSERT [dbo].[Raza] ([Id], [Nombre], [IdEspecie]) VALUES (2, N'Persa', N'2')
INSERT [dbo].[Raza] ([Id], [Nombre], [IdEspecie]) VALUES (3, N'Pitbull', N'1')
SET IDENTITY_INSERT [dbo].[Raza] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Id], [Username], [Nombres], [Password], [Dni], [ApellidoPaterno], [ApellidoMaterno], [FechaNacimiento], [Telefono], [Imagen]) VALUES (1, N'Meyler', N'Meyler', N'aaaaaa', N'18759643', N'Tejada ', N'Portilla', CAST(N'2003-11-16T00:00:00.000' AS DateTime), N'976485912      ', N'about-02.jpg')
INSERT [dbo].[Usuario] ([Id], [Username], [Nombres], [Password], [Dni], [ApellidoPaterno], [ApellidoMaterno], [FechaNacimiento], [Telefono], [Imagen]) VALUES (2, N'Brayan', N'Brayan ', N'aaaaaa', N'71727374', N'Vargas', N'Rosell', CAST(N'2003-11-10T00:00:00.000' AS DateTime), N'986734251      ', N'about-03.jpg')
INSERT [dbo].[Usuario] ([Id], [Username], [Nombres], [Password], [Dni], [ApellidoPaterno], [ApellidoMaterno], [FechaNacimiento], [Telefono], [Imagen]) VALUES (3, N'Yudith', N'Yudith Anali ', N'aaaaaa', N'72458956', N'Llamoctanta', N'Ortiz', CAST(N'2003-11-16T00:00:00.000' AS DateTime), N'978465312      ', N'comment-2.jpg')
INSERT [dbo].[Usuario] ([Id], [Username], [Nombres], [Password], [Dni], [ApellidoPaterno], [ApellidoMaterno], [FechaNacimiento], [Telefono], [Imagen]) VALUES (4, N'Jack', N'Jackson', N'aaaaaa', N'26784953', N'De la cruz', N'Ruiz', CAST(N'2002-11-18T00:00:00.000' AS DateTime), N'978452631      ', N'about-04.jpg')
INSERT [dbo].[Usuario] ([Id], [Username], [Nombres], [Password], [Dni], [ApellidoPaterno], [ApellidoMaterno], [FechaNacimiento], [Telefono], [Imagen]) VALUES (5, N'Darick', N'Darick FKL', N'aaaaaa', N'77060406', N'Aponte', N'Tasilla', CAST(N'2006-12-19T00:00:00.000' AS DateTime), N'951834785      ', N'comment-1.jpg')
INSERT [dbo].[Usuario] ([Id], [Username], [Nombres], [Password], [Dni], [ApellidoPaterno], [ApellidoMaterno], [FechaNacimiento], [Telefono], [Imagen]) VALUES (6, N'KarenAp', N'Karen Stefany', N'aaaaaa', N'72458692', N'Chiroque', N'Saldaña', CAST(N'2001-02-25T00:00:00.000' AS DateTime), N'986754121      ', N'mujer.jpg')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
