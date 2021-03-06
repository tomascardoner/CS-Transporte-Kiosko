USE [master]
GO
/****** Object:  Database [CSTransporte]    Script Date: 30/10/2019 23:44:26 ******/
CREATE DATABASE [CSTransporte]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CSTransporte_Data', FILENAME = N'E:\CS-Transporte\CSTransporte.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CSTransporte_Log', FILENAME = N'E:\CS-Transporte\CSTransporte.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CSTransporte] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CSTransporte].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CSTransporte] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CSTransporte] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CSTransporte] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CSTransporte] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CSTransporte] SET ARITHABORT OFF 
GO
ALTER DATABASE [CSTransporte] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CSTransporte] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [CSTransporte] SET AUTO_SHRINK ON 
GO
ALTER DATABASE [CSTransporte] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CSTransporte] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CSTransporte] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CSTransporte] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CSTransporte] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CSTransporte] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CSTransporte] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CSTransporte] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CSTransporte] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CSTransporte] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CSTransporte] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CSTransporte] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CSTransporte] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CSTransporte] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CSTransporte] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CSTransporte] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CSTransporte] SET  MULTI_USER 
GO
ALTER DATABASE [CSTransporte] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CSTransporte] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CSTransporte] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CSTransporte] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CSTransporte', N'ON'
GO
USE [CSTransporte]
GO
/****** Object:  User [cstransporte]    Script Date: 30/10/2019 23:44:26 ******/
CREATE USER [cstransporte] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  StoredProcedure [dbo].[usp_Empresa_ObtenerPorID]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Empresa_ObtenerPorID]
	@IDEmpresa tinyint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT e.IDEmpresa, e.Codigo, e.Nombre, e.DatabaseName, e.Activo
			FROM Empresa AS e
			WHERE e.IDEmpresa = @IDEmpresa
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_EventLog_Agregar]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_EventLog_Agregar]
	@Tipo char(1),
	@IDKiosko tinyint,
	@Mensaje varchar(100),
	@Notas varchar(8000)
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		IF @Tipo IN ('I', 'A', 'E', 'S', 'F')			
			INSERT INTO EventLog
				(FechaHora, Tipo, IDKiosko, Mensaje, Notas)
				VALUES (GETDATE(), @Tipo, @IDKiosko, @Mensaje, @Notas)
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_Imagen_ObtenerPorID]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Imagen_ObtenerPorID]
	@IDImagen smallint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT i.IDImagen, i.Nombre, i.ImagenData
			FROM Imagen AS i
			WHERE i.IDImagen = @IDImagen
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_Kiosko_ActualizarUltimaConexion]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Kiosko_ActualizarUltimaConexion]
	@IDKiosko tinyint
	AS

	BEGIN
		UPDATE Kiosko
			SET UltimaConexion = GETDATE()
			WHERE IDKiosko = @IDKiosko
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_Kiosko_ActualizarUltimaOperacion]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Kiosko_ActualizarUltimaOperacion]
	@IDKiosko tinyint
	AS

	BEGIN
		UPDATE Kiosko
			SET UltimaOperacion = GETDATE()
			WHERE IDKiosko = @IDKiosko
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_Kiosko_ObtenerPorID]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Kiosko_ObtenerPorID]
	@IDKiosko tinyint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT k.IDKiosko, k.Nombre, k.MACAddress, k.IDEmpresa, k.IDLugar, k.IDKioskoConfiguracion, k.IDTicketPlantilla, k.Activo, k.UltimaConexion, k.UltimaOperacion
			FROM Kiosko AS k
			WHERE k.IDKiosko = @IDKiosko
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_Kiosko_ObtenerPorMAC]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Kiosko_ObtenerPorMAC]
	@MACAddress char(12)
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT k.IDKiosko, k.Nombre, k.MACAddress, k.IDEmpresa, k.IDLugar, k.IDKioskoConfiguracion, k.IDTicketPlantilla, k.Activo, k.UltimaConexion, k.UltimaOperacion
			FROM Kiosko AS k
			WHERE k.MACAddress = @MACAddress
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_KioskoConfiguracion_ObtenerPorID]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_KioskoConfiguracion_ObtenerPorID]
	@IDKioskoConfiguracion tinyint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT kc.IDKioskoConfiguracion, kc.Nombre
			FROM KioskoConfiguracion AS kc
			WHERE kc.IDKioskoConfiguracion = @IDKioskoConfiguracion
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_KioskoConfiguracion_ObtenerValores]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_KioskoConfiguracion_ObtenerValores]
	@IDKioskoConfiguracion tinyint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT kcv.IDKioskoConfiguracion, kcv.IDValor, kcv.ValorTexto, kcv.ValorNumeroEntero, kcv.ValorNumeroDecimal, kcv.ValorFechaHora, kcv.ValorSiNo, kcv.ValorIDImagen, i.ImagenData AS ValorImagenData
			FROM KioskoConfiguracionValor AS kcv LEFT JOIN Imagen AS i ON kcv.ValorIDImagen = i.IDImagen
			WHERE kcv.IDKioskoConfiguracion = @IDKioskoConfiguracion
			ORDER BY kcv.IDValor
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_KioskoConfiguracionValor_ObtenerPorID]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_KioskoConfiguracionValor_ObtenerPorID]
	@IDKioskoConfiguracion tinyint,
	@IDValor char(100)
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT kcv.IDKioskoConfiguracion, kcv.IDValor, kcv.ValorTexto, kcv.ValorNumeroEntero, kcv.ValorNumeroDecimal, kcv.ValorFechaHora, kcv.ValorSiNo, kcv.ValorIDImagen, i.ImagenData AS ValorImagenData
			FROM KioskoConfiguracionValor AS kcv LEFT JOIN Imagen AS i ON kcv.ValorIDImagen = i.IDImagen
			WHERE kcv.IDKioskoConfiguracion = @IDKioskoConfiguracion AND kcv.IDValor = @IDValor
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_TicketPlantilla_ObtenerComandos]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_TicketPlantilla_ObtenerComandos]
	@IDTicketPlantilla tinyint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT tpc.IDTicketPlantilla, tpc.IDComando, tpc.Texto, tpc.IDImagen, i.ImagenData, tpc.ImagenAncho, tpc.ImagenPosicion
			FROM TicketPlantillaComando AS tpc LEFT JOIN Imagen AS i ON tpc.IDImagen = i.IDImagen
			WHERE tpc.IDTicketPlantilla = @IDTicketPlantilla
			ORDER BY tpc.IDComando
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_TicketPlantilla_ObtenerPorID]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_TicketPlantilla_ObtenerPorID]
	@IDTicketPlantilla tinyint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT tp.IDTicketPlantilla, tp.Nombre, tp.Activo
			FROM TicketPlantilla AS tp
			WHERE tp.IDTicketPlantilla = @IDTicketPlantilla
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_TicketPlantillaComando_ObtenerPorID]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_TicketPlantillaComando_ObtenerPorID]
	@IDTicketPlantilla tinyint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT tpc.IDTicketPlantilla, tpc.IDComando, tpc.Texto, tpc.IDImagen, i.ImagenData, tpc.ImagenAncho, tpc.ImagenPosicion
			FROM TicketPlantillaComando AS tpc LEFT JOIN Imagen AS i ON tpc.IDImagen = i.IDImagen
			WHERE tpc.IDTicketPlantilla = @IDTicketPlantilla
			ORDER BY tpc.IDComando
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_VehiculoConfiguracion_ObtenerDetalles]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_VehiculoConfiguracion_ObtenerDetalles]
	@IDVehiculoConfiguracion tinyint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT vcd.IDVehiculoConfiguracion, vcd.IDDetalle, vcd.Tipo, vcd.AsientoIdentificacion
			FROM VehiculoConfiguracionDetalle AS vcd
			WHERE vcd.IDVehiculoConfiguracion = @IDVehiculoConfiguracion
			ORDER BY vcd.IDDetalle
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_VehiculoConfiguracion_ObtenerPorID]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_VehiculoConfiguracion_ObtenerPorID]
	@IDVehiculoConfiguracion tinyint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT vc.IDVehiculoConfiguracion, vc.Nombre, vc.UnidadAncho, vc.Activo
			FROM VehiculoConfiguracion AS vc
			WHERE vc.IDVehiculoConfiguracion = @IDVehiculoConfiguracion
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_VehiculoConfiguracionDetalle_ObtenerPorID]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_VehiculoConfiguracionDetalle_ObtenerPorID]
	@IDVehiculoConfiguracion tinyint,
	@IDDetalle tinyint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT vcd.IDVehiculoConfiguracion, vcd.IDDetalle, vcd.Tipo, vcd.AsientoIdentificacion
			FROM VehiculoConfiguracionDetalle AS vcd
			WHERE vcd.IDVehiculoConfiguracion = @IDVehiculoConfiguracion AND vcd.IDDetalle = @IDDetalle
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_ViajeDetalle_ObtenerPorID]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_ViajeDetalle_ObtenerPorID]
	@IDEmpresa tinyint,
	@IDViajeDetalle int
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT vd.IDEmpresa, vd.IDViajeDetalle, vd.IDViaje, vd.AsientoIdentificacion
			FROM ViajeDetalle AS vd
			WHERE vd.IDEmpresa = @IDEmpresa AND vd.IDViajeDetalle = @IDViajeDetalle
	END

GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empresa](
	[IDEmpresa] [tinyint] NOT NULL,
	[Codigo] [char](2) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[DatabaseName] [varchar](128) NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK__Empresa] PRIMARY KEY CLUSTERED 
(
	[IDEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 10) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EventLog]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EventLog](
	[IDEventLog] [int] IDENTITY(1,1) NOT NULL,
	[FechaHora] [smalldatetime] NOT NULL,
	[Tipo] [char](1) NOT NULL,
	[IDKiosko] [tinyint] NULL,
	[Mensaje] [varchar](100) NOT NULL,
	[Notas] [varchar](8000) NULL,
 CONSTRAINT [PK__EventLog] PRIMARY KEY CLUSTERED 
(
	[IDEventLog] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Imagen]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Imagen](
	[IDImagen] [smallint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[ImagenData] [varbinary](max) NOT NULL,
 CONSTRAINT [PK__Imagen] PRIMARY KEY CLUSTERED 
(
	[IDImagen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Kiosko]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kiosko](
	[IDKiosko] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[MACAddress] [char](12) NULL,
	[IDEmpresa] [tinyint] NOT NULL,
	[IDLugar] [int] NOT NULL,
	[IDKioskoConfiguracion] [tinyint] NOT NULL,
	[IDTicketPlantilla] [tinyint] NULL,
	[Activo] [bit] NOT NULL,
	[UltimaConexion] [smalldatetime] NULL,
	[UltimaOperacion] [smalldatetime] NULL,
 CONSTRAINT [PK__Kiosko] PRIMARY KEY CLUSTERED 
(
	[IDKiosko] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KioskoConfiguracion]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KioskoConfiguracion](
	[IDKioskoConfiguracion] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK__KioskoConfiguracion] PRIMARY KEY CLUSTERED 
(
	[IDKioskoConfiguracion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KioskoConfiguracionValor]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KioskoConfiguracionValor](
	[IDKioskoConfiguracion] [tinyint] NOT NULL,
	[IDValor] [char](100) NOT NULL,
	[ValorTexto] [nvarchar](max) NULL,
	[ValorNumeroEntero] [int] NULL,
	[ValorNumeroDecimal] [decimal](12, 4) NULL,
	[ValorFechaHora] [datetime] NULL,
	[ValorSiNo] [bit] NULL,
	[ValorIDImagen] [smallint] NULL,
 CONSTRAINT [PK__KioskoConfiguracionValor] PRIMARY KEY CLUSTERED 
(
	[IDKioskoConfiguracion] ASC,
	[IDValor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TicketPlantilla]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TicketPlantilla](
	[IDTicketPlantilla] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK__TicketPlantilla] PRIMARY KEY CLUSTERED 
(
	[IDTicketPlantilla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TicketPlantillaComando]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketPlantillaComando](
	[IDTicketPlantilla] [tinyint] NOT NULL,
	[IDComando] [tinyint] NOT NULL,
	[Texto] [nvarchar](max) NULL,
	[IDImagen] [smallint] NULL,
	[ImagenAncho] [smallint] NULL,
	[ImagenPosicion] [smallint] NULL,
 CONSTRAINT [PK__TicketPlantillaComando] PRIMARY KEY CLUSTERED 
(
	[IDTicketPlantilla] ASC,
	[IDComando] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VehiculoConfiguracion]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VehiculoConfiguracion](
	[IDVehiculoConfiguracion] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[UnidadAncho] [tinyint] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK__VehiculoConfiguracion] PRIMARY KEY CLUSTERED 
(
	[IDVehiculoConfiguracion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VehiculoConfiguracionDetalle]    Script Date: 30/10/2019 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VehiculoConfiguracionDetalle](
	[IDVehiculoConfiguracion] [tinyint] NOT NULL,
	[IDDetalle] [tinyint] NOT NULL,
	[Tipo] [char](1) NOT NULL,
	[AsientoIdentificacion] [varchar](5) NULL,
 CONSTRAINT [PK__VehiculoConfiguracionDetalle] PRIMARY KEY CLUSTERED 
(
	[IDVehiculoConfiguracion] ASC,
	[IDDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [AK__Imagen__Nombre]    Script Date: 30/10/2019 23:44:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [AK__Imagen__Nombre] ON [dbo].[Imagen]
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [AK__Kiosko__MACAddress]    Script Date: 30/10/2019 23:44:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [AK__Kiosko__MACAddress] ON [dbo].[Kiosko]
(
	[MACAddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [AK__Kiosko__Nombre]    Script Date: 30/10/2019 23:44:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [AK__Kiosko__Nombre] ON [dbo].[Kiosko]
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [AK__KioskoConfiguracion__Nombre]    Script Date: 30/10/2019 23:44:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [AK__KioskoConfiguracion__Nombre] ON [dbo].[KioskoConfiguracion]
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK__KioskoConfiguracionValor__Nombre]    Script Date: 30/10/2019 23:44:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [PK__KioskoConfiguracionValor__Nombre] ON [dbo].[KioskoConfiguracionValor]
(
	[IDValor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [AK__TicketPlantilla__Nombre]    Script Date: 30/10/2019 23:44:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [AK__TicketPlantilla__Nombre] ON [dbo].[TicketPlantilla]
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [AK__VehiculoConfiguracion__Nombre]    Script Date: 30/10/2019 23:44:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [AK__VehiculoConfiguracion__Nombre] ON [dbo].[VehiculoConfiguracion]
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EventLog]  WITH CHECK ADD  CONSTRAINT [FK__Kiosko__EventLog] FOREIGN KEY([IDKiosko])
REFERENCES [dbo].[Kiosko] ([IDKiosko])
GO
ALTER TABLE [dbo].[EventLog] CHECK CONSTRAINT [FK__Kiosko__EventLog]
GO
ALTER TABLE [dbo].[Kiosko]  WITH CHECK ADD  CONSTRAINT [FK__Empresa__Kiosko] FOREIGN KEY([IDEmpresa])
REFERENCES [dbo].[Empresa] ([IDEmpresa])
GO
ALTER TABLE [dbo].[Kiosko] CHECK CONSTRAINT [FK__Empresa__Kiosko]
GO
ALTER TABLE [dbo].[Kiosko]  WITH CHECK ADD  CONSTRAINT [FK__KioskoConfiguracion__Kiosko] FOREIGN KEY([IDKioskoConfiguracion])
REFERENCES [dbo].[KioskoConfiguracion] ([IDKioskoConfiguracion])
GO
ALTER TABLE [dbo].[Kiosko] CHECK CONSTRAINT [FK__KioskoConfiguracion__Kiosko]
GO
ALTER TABLE [dbo].[Kiosko]  WITH CHECK ADD  CONSTRAINT [FK__TicketPlantilla__Kiosko] FOREIGN KEY([IDTicketPlantilla])
REFERENCES [dbo].[TicketPlantilla] ([IDTicketPlantilla])
GO
ALTER TABLE [dbo].[Kiosko] CHECK CONSTRAINT [FK__TicketPlantilla__Kiosko]
GO
ALTER TABLE [dbo].[KioskoConfiguracionValor]  WITH CHECK ADD  CONSTRAINT [FK__Imagen__KioskoConfiguracionValor] FOREIGN KEY([ValorIDImagen])
REFERENCES [dbo].[Imagen] ([IDImagen])
GO
ALTER TABLE [dbo].[KioskoConfiguracionValor] CHECK CONSTRAINT [FK__Imagen__KioskoConfiguracionValor]
GO
ALTER TABLE [dbo].[KioskoConfiguracionValor]  WITH CHECK ADD  CONSTRAINT [FK__KioskoConfiguracion__KioskoConfiguracionValor] FOREIGN KEY([IDKioskoConfiguracion])
REFERENCES [dbo].[KioskoConfiguracion] ([IDKioskoConfiguracion])
GO
ALTER TABLE [dbo].[KioskoConfiguracionValor] CHECK CONSTRAINT [FK__KioskoConfiguracion__KioskoConfiguracionValor]
GO
ALTER TABLE [dbo].[TicketPlantillaComando]  WITH CHECK ADD  CONSTRAINT [FK__Imagen__TicketPlantillaComando] FOREIGN KEY([IDImagen])
REFERENCES [dbo].[Imagen] ([IDImagen])
GO
ALTER TABLE [dbo].[TicketPlantillaComando] CHECK CONSTRAINT [FK__Imagen__TicketPlantillaComando]
GO
ALTER TABLE [dbo].[TicketPlantillaComando]  WITH CHECK ADD  CONSTRAINT [FK__TicketPlantilla__TicketPlantillaComando] FOREIGN KEY([IDTicketPlantilla])
REFERENCES [dbo].[TicketPlantilla] ([IDTicketPlantilla])
GO
ALTER TABLE [dbo].[TicketPlantillaComando] CHECK CONSTRAINT [FK__TicketPlantilla__TicketPlantillaComando]
GO
ALTER TABLE [dbo].[VehiculoConfiguracionDetalle]  WITH CHECK ADD  CONSTRAINT [FK__VehiculoConfiguracion__VehiculoConfiguracionDetalle] FOREIGN KEY([IDVehiculoConfiguracion])
REFERENCES [dbo].[VehiculoConfiguracion] ([IDVehiculoConfiguracion])
GO
ALTER TABLE [dbo].[VehiculoConfiguracionDetalle] CHECK CONSTRAINT [FK__VehiculoConfiguracion__VehiculoConfiguracionDetalle]
GO
USE [master]
GO
ALTER DATABASE [CSTransporte] SET  READ_WRITE 
GO