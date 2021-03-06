USE [master]
GO
/****** Object:  Database [AVIOES]    Script Date: 27/06/2020 05:12:42 ******/
CREATE DATABASE [AVIOES]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AVIOES', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AVIOES.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AVIOES_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AVIOES_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AVIOES] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AVIOES].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AVIOES] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AVIOES] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AVIOES] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AVIOES] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AVIOES] SET ARITHABORT OFF 
GO
ALTER DATABASE [AVIOES] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AVIOES] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AVIOES] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AVIOES] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AVIOES] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AVIOES] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AVIOES] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AVIOES] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AVIOES] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AVIOES] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AVIOES] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AVIOES] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AVIOES] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AVIOES] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AVIOES] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AVIOES] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AVIOES] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AVIOES] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AVIOES] SET  MULTI_USER 
GO
ALTER DATABASE [AVIOES] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AVIOES] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AVIOES] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AVIOES] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AVIOES] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AVIOES] SET QUERY_STORE = OFF
GO
USE [AVIOES]
GO
/****** Object:  Table [dbo].[Aluguel]    Script Date: 27/06/2020 05:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aluguel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clienteID] [int] NULL,
	[data] [datetime] NULL,
 CONSTRAINT [PK_Aluguel] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Avioes]    Script Date: 27/06/2020 05:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Avioes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[modelo] [varchar](15) NULL,
	[fabricante] [varchar](15) NULL,
	[ano] [int] NULL,
	[cor] [varchar](10) NULL,
 CONSTRAINT [PK_Avioes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 27/06/2020 05:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](35) NULL,
	[cpf] [int] NULL,
	[rg] [int] NULL,
	[cidade] [varchar](25) NULL,
	[endereco] [varchar](60) NULL,
	[uf] [varchar](2) NULL,
	[telefone] [int] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Itens_Aluguel]    Script Date: 27/06/2020 05:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Itens_Aluguel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[aluguelID] [int] NULL,
	[aviaoID] [int] NULL,
	[validade] [datetime] NULL,
 CONSTRAINT [PK_itens_aluguel] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Aluguel] ON 

INSERT [dbo].[Aluguel] ([id], [clienteID], [data]) VALUES (2, 12, CAST(N'2020-06-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Aluguel] ([id], [clienteID], [data]) VALUES (3, 11, CAST(N'2020-06-29T00:00:00.000' AS DateTime))
INSERT [dbo].[Aluguel] ([id], [clienteID], [data]) VALUES (4, 1018, CAST(N'2020-06-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Aluguel] ([id], [clienteID], [data]) VALUES (6, 1019, CAST(N'2020-06-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Aluguel] ([id], [clienteID], [data]) VALUES (1003, 1020, CAST(N'2020-07-03T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Aluguel] OFF
GO
SET IDENTITY_INSERT [dbo].[Avioes] ON 

INSERT [dbo].[Avioes] ([id], [modelo], [fabricante], [ano], [cor]) VALUES (1, N'G-5', N'Mercedez', 1925, N'Preto')
INSERT [dbo].[Avioes] ([id], [modelo], [fabricante], [ano], [cor]) VALUES (2, N'A380', N'Airbus', 1990, N'Branco')
INSERT [dbo].[Avioes] ([id], [modelo], [fabricante], [ano], [cor]) VALUES (5, N'A456', N'Airbus', 2004, N'Amarelo')
SET IDENTITY_INSERT [dbo].[Avioes] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([id], [nome], [cpf], [rg], [cidade], [endereco], [uf], [telefone]) VALUES (11, N'Vitor Oliveira', 12351, 12351, N'Maracai', N'Messias Silva', N'SP', 19377313)
INSERT [dbo].[Clientes] ([id], [nome], [cpf], [rg], [cidade], [endereco], [uf], [telefone]) VALUES (12, N'Luiz', 3123, 351, N'Maracai', N'Android', N'SP', 3125134)
INSERT [dbo].[Clientes] ([id], [nome], [cpf], [rg], [cidade], [endereco], [uf], [telefone]) VALUES (1017, N'Jose Almeida', 1351514, 531255146, N'Assis', N'Marechal 123', N'SP', 13673425)
INSERT [dbo].[Clientes] ([id], [nome], [cpf], [rg], [cidade], [endereco], [uf], [telefone]) VALUES (1018, N'Lucas Jeff', 12351313, 353124431, N'Ourinhos', N'Barbosa 7452', N'SP', 234513251)
INSERT [dbo].[Clientes] ([id], [nome], [cpf], [rg], [cidade], [endereco], [uf], [telefone]) VALUES (1019, N'Joao', 123513123, 755467864, N'Sao Paulo', N'Teodoro 1454', N'SP', 34512313)
INSERT [dbo].[Clientes] ([id], [nome], [cpf], [rg], [cidade], [endereco], [uf], [telefone]) VALUES (1020, N'Manoel da Silva', 35123513, 3215613, N'Assis', N'Rua Aparecida', N'SP', 2353114)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Itens_Aluguel] ON 

INSERT [dbo].[Itens_Aluguel] ([id], [aluguelID], [aviaoID], [validade]) VALUES (1, 3, 2, CAST(N'1900-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Itens_Aluguel] ([id], [aluguelID], [aviaoID], [validade]) VALUES (2, 2, 1, CAST(N'1900-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Itens_Aluguel] ([id], [aluguelID], [aviaoID], [validade]) VALUES (3, 6, 1, CAST(N'1900-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Itens_Aluguel] ([id], [aluguelID], [aviaoID], [validade]) VALUES (4, 4, 5, CAST(N'1900-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Itens_Aluguel] ([id], [aluguelID], [aviaoID], [validade]) VALUES (5, 6, 2, CAST(N'1900-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Itens_Aluguel] ([id], [aluguelID], [aviaoID], [validade]) VALUES (6, 2, 2, CAST(N'1900-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Itens_Aluguel] ([id], [aluguelID], [aviaoID], [validade]) VALUES (7, 6, 5, CAST(N'1900-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Itens_Aluguel] ([id], [aluguelID], [aviaoID], [validade]) VALUES (8, 4, 2, CAST(N'1900-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Itens_Aluguel] ([id], [aluguelID], [aviaoID], [validade]) VALUES (9, 1003, 1, CAST(N'1900-01-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Itens_Aluguel] OFF
GO
ALTER TABLE [dbo].[Aluguel]  WITH CHECK ADD  CONSTRAINT [FK_Aluguel_Clientes] FOREIGN KEY([clienteID])
REFERENCES [dbo].[Clientes] ([id])
GO
ALTER TABLE [dbo].[Aluguel] CHECK CONSTRAINT [FK_Aluguel_Clientes]
GO
ALTER TABLE [dbo].[Itens_Aluguel]  WITH CHECK ADD  CONSTRAINT [FK_Itens_Aluguel_Aluguel] FOREIGN KEY([aluguelID])
REFERENCES [dbo].[Aluguel] ([id])
GO
ALTER TABLE [dbo].[Itens_Aluguel] CHECK CONSTRAINT [FK_Itens_Aluguel_Aluguel]
GO
ALTER TABLE [dbo].[Itens_Aluguel]  WITH CHECK ADD  CONSTRAINT [FK_Itens_Aluguel_Avioes] FOREIGN KEY([aviaoID])
REFERENCES [dbo].[Avioes] ([id])
GO
ALTER TABLE [dbo].[Itens_Aluguel] CHECK CONSTRAINT [FK_Itens_Aluguel_Avioes]
GO
USE [master]
GO
ALTER DATABASE [AVIOES] SET  READ_WRITE 
GO
