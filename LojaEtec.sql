USE [master]
GO
/****** Object:  Database [LojaDeUniformes]    Script Date: 17/07/2020 20:38:07 ******/
CREATE DATABASE [LojaDeUniformes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LojaDeUniformes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\LojaDeUniformes.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LojaDeUniformes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\LojaDeUniformes_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LojaDeUniformes] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LojaDeUniformes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LojaDeUniformes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET ARITHABORT OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LojaDeUniformes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LojaDeUniformes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LojaDeUniformes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LojaDeUniformes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LojaDeUniformes] SET  MULTI_USER 
GO
ALTER DATABASE [LojaDeUniformes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LojaDeUniformes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LojaDeUniformes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LojaDeUniformes] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LojaDeUniformes] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LojaDeUniformes] SET QUERY_STORE = OFF
GO
USE [LojaDeUniformes]
GO
/****** Object:  Table [dbo].[tb_Alunos]    Script Date: 17/07/2020 20:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Alunos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ra] [varchar](50) NOT NULL,
	[nome] [varchar](200) NOT NULL,
	[curso] [varchar](50) NOT NULL,
	[dataultimamodificacao] [datetime] NULL,
	[usuarioultimamodificacao] [varchar](100) NULL,
 CONSTRAINT [PK_tb_Aluno] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_tb_Alunos] UNIQUE NONCLUSTERED 
(
	[ra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_CategoriasDeUniforme]    Script Date: 17/07/2020 20:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CategoriasDeUniforme](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NULL,
	[dataultimamodificacao] [datetime] NULL,
	[usuarioultimamodificacao] [varchar](100) NULL,
 CONSTRAINT [PK_tb_CategoriasDeUniforme] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_tb_CategoriasDeUniforme] UNIQUE NONCLUSTERED 
(
	[nome] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_ListadeProdutos]    Script Date: 17/07/2020 20:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ListadeProdutos](
	[id_lista] [int] IDENTITY(1,1) NOT NULL,
	[nomepeca] [varchar](100) NULL,
	[tamanhopeca] [varchar](100) NULL,
	[precopeca] [varchar](100) NULL,
	[quantidadepeca] [varchar](100) NULL,
	[valortotalpecaquantidade] [varchar](100) NULL,
 CONSTRAINT [PK_tb_ListadeProdutos] PRIMARY KEY CLUSTERED 
(
	[id_lista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Uniformes]    Script Date: 17/07/2020 20:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Uniformes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[peca] [varchar](100) NOT NULL,
	[categoria] [varchar](100) NULL,
	[tamanho] [varchar](10) NULL,
	[preco] [decimal](10, 2) NULL,
	[quantidade] [int] NULL,
	[dataultimamodificacao] [datetime] NULL,
	[usuarioultimamodificacao] [varchar](100) NULL,
 CONSTRAINT [PK_tb_Uniforme] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_tb_Uniformes] UNIQUE NONCLUSTERED 
(
	[peca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Usuarios]    Script Date: 17/07/2020 20:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nomedeusuario] [varchar](100) NULL,
	[nome] [varchar](100) NULL,
	[senha] [varchar](100) NULL,
	[dataultimamodificacao] [datetime] NULL,
	[usuarioultimamodificacao] [varchar](100) NULL,
 CONSTRAINT [PK_tb_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_tb_Usuarios] UNIQUE NONCLUSTERED 
(
	[nomedeusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Vendas]    Script Date: 17/07/2020 20:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Vendas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fk_Lista] [int] NULL,
	[fk_RaAluno] [varchar](100) NULL,
	[fk_NomeAluno] [varchar](100) NULL,
	[fk_CursoAluno] [varchar](100) NULL,
	[fk_NomeUsuario] [varchar](100) NULL,
	[DataVenda] [datetime] NULL,
	[Subtotal] [decimal](10, 2) NULL,
	[Desconto] [int] NULL,
	[ValorPago] [decimal](10, 2) NULL,
	[Troco] [decimal](10, 2) NULL,
	[ValorTotal] [decimal](10, 2) NULL,
	[Observacao] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_Vendas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [LojaDeUniformes] SET  READ_WRITE 
GO
