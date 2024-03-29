USE [Aeropuerto]
GO
/****** Objeto:  Table [dbo].[Log]    Fecha de la secuencia de comandos: 11/23/2010 21:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Log](
	[CodRegistro] [int] IDENTITY(1,1) NOT NULL,
	[CodOperacion] [int] NOT NULL,
	[Tabla] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IP] [varchar](23) NOT NULL,
	[Razon] [varchar](500) NULL,
 CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED 
(
	[CodRegistro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[Avion]    Fecha de la secuencia de comandos: 11/23/2010 21:54:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Avion](
	[CodAvion] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Fabricante] [varchar](100) NOT NULL,
	[Serie] [varchar](50) NOT NULL,
	[CabinaTripulacion] [int] NOT NULL,
	[Pasajeros] [int] NOT NULL,
	[Longitud] [float] NOT NULL,
	[Envergadura] [float] NOT NULL,
	[Altura] [float] NOT NULL,
	[PesoVacio] [float] NOT NULL,
	[PesoMaxDespegue] [float] NOT NULL,
	[VelocidadCrucero] [float] NOT NULL,
	[VelocidadMax] [float] NOT NULL,
	[CarreraPesoMax] [float] NOT NULL,
	[AutonomiaPesoMaxDesp] [float] NOT NULL,
	[MaxFuel] [float] NOT NULL,
	[Motor] [varchar](500) NOT NULL,
	[Empuje] [varchar](500) NOT NULL,
	[Imagen] [image] NULL,
 CONSTRAINT [PK_Avion] PRIMARY KEY CLUSTERED 
(
	[CodAvion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[Aeropuerto]    Fecha de la secuencia de comandos: 11/23/2010 21:54:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aeropuerto](
	[CodAeropuerto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[Estado] [varchar](500) NOT NULL,
	[Ciudad] [varchar](500) NOT NULL,
	[IATA] [varchar](3) NULL,
	[OACI] [varchar](4) NULL,
	[Elevacion] [int] NOT NULL,
	[SEI] [int] NOT NULL,
	[Fuel] [int] NOT NULL,
	[Operacion] [varchar](1000) NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Aeropuerto] PRIMARY KEY CLUSTERED 
(
	[CodAeropuerto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[Aerolinea]    Fecha de la secuencia de comandos: 11/23/2010 21:54:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aerolinea](
	[CodAerolinea] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[RUC] [varchar](500) NOT NULL,
	[Procedencia] [varchar](500) NOT NULL,
	[Logotipo] [image] NULL,
 CONSTRAINT [PK_Aerolinea] PRIMARY KEY CLUSTERED 
(
	[CodAerolinea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[Excepcion]    Fecha de la secuencia de comandos: 11/23/2010 21:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Excepcion](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Mensaje] [varchar](8000) NULL,
	[StackTrace] [varchar](8000) NULL,
	[FechaCliente] [datetime] NULL,
	[FechaServidor] [datetime] NULL,
	[CodUsuario] [int] NULL,
	[IPCliente] [varchar](30) NULL,
 CONSTRAINT [PK_Excepcion] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[Factura]    Fecha de la secuencia de comandos: 11/23/2010 21:54:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Factura](
	[CodFactura] [int] IDENTITY(1,1) NOT NULL,
	[CodAerolinea] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Monto] [float] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Facturacion] PRIMARY KEY CLUSTERED 
(
	[CodFactura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[CobroEstacionamiento]    Fecha de la secuencia de comandos: 11/23/2010 21:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CobroEstacionamiento](
	[CodEstacionamiento] [int] IDENTITY(1,1) NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[FechaFin] [datetime] NOT NULL,
	[Duracion] [int] NOT NULL,
	[CodAerolinea] [int] NOT NULL,
	[Impuesto] [float] NOT NULL,
	[CodAvion] [int] NOT NULL,
 CONSTRAINT [PK_CobroEstacionamiento] PRIMARY KEY CLUSTERED 
(
	[CodEstacionamiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  StoredProcedure [dbo].[uspFacturaObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:53:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspFacturaObtener]
(
		@id int
)
as
begin
SELECT [CodFactura]
      ,[CodAerolinea]
      ,[Fecha]
      ,[Monto]
      ,[Descripcion]
  FROM [Aeropuerto].[dbo].[Facturacion]
where CodFactura = @id
end
GO
/****** Objeto:  Table [dbo].[TipoVuelo]    Fecha de la secuencia de comandos: 11/23/2010 21:55:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoVuelo](
	[CodTipoVuelo] [int] IDENTITY(1,1) NOT NULL,
	[TipoVuelo] [varchar](500) NOT NULL,
	[Impuesto] [float] NOT NULL,
 CONSTRAINT [PK_TipoVuelo] PRIMARY KEY CLUSTERED 
(
	[CodTipoVuelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[TipoMovimiento]    Fecha de la secuencia de comandos: 11/23/2010 21:55:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoMovimiento](
	[CodTipoMovimiento] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_TipoMovimiento] PRIMARY KEY CLUSTERED 
(
	[CodTipoMovimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[TDD]    Fecha de la secuencia de comandos: 11/23/2010 21:54:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TDD](
	[CodBarra] [int] NULL,
	[CodTipoVuelo] [varchar](500) NULL,
	[Aerolinea] [varchar](500) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[Salida]    Fecha de la secuencia de comandos: 11/23/2010 21:54:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Salida](
	[CodSalida] [int] NOT NULL,
	[CodPlanVuelo] [int] NOT NULL,
	[Numero] [int] NOT NULL,
	[Placa] [varchar](50) NOT NULL,
	[ReglasVuelo] [varchar](1) NOT NULL,
	[TipoVuelo] [varchar](1) NOT NULL,
	[CodAvion] [int] NOT NULL,
	[Hora] [datetime] NOT NULL,
	[CodAeropuerto] [int] NOT NULL,
	[Turbulencia] [varchar](1) NULL,
	[Equipo] [varchar](50) NULL,
	[Velocidad] [float] NULL,
	[Nivel] [float] NULL,
	[Ruta] [varchar](8000) NULL,
 CONSTRAINT [PK_Salida] PRIMARY KEY CLUSTERED 
(
	[CodSalida] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[Movimiento]    Fecha de la secuencia de comandos: 11/23/2010 21:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Movimiento](
	[CodMovimiento] [int] IDENTITY(1,1) NOT NULL,
	[CodTipoMovimiento] [int] NOT NULL,
	[CodAerolinea] [int] NOT NULL,
	[CodAvion] [int] NOT NULL,
	[Detalle] [varchar](500) NOT NULL,
	[CodAeropuertoOrigen] [int] NOT NULL,
	[CodAeropuertoDestino] [int] NOT NULL,
 CONSTRAINT [PK_Movimiento] PRIMARY KEY CLUSTERED 
(
	[CodMovimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[Plataforma]    Fecha de la secuencia de comandos: 11/23/2010 21:54:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Plataforma](
	[CodPlataforma] [int] IDENTITY(1,1) NOT NULL,
	[CodAeropuerto] [int] NOT NULL,
	[Naves] [int] NOT NULL,
	[Pavimento] [varchar](500) NOT NULL,
	[PCN] [varchar](500) NOT NULL,
	[Dimensiones] [varchar](500) NOT NULL,
	[NaveMaxPermisible] [varchar](500) NOT NULL,
 CONSTRAINT [PK_Plataforma] PRIMARY KEY CLUSTERED 
(
	[CodPlataforma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[Pista]    Fecha de la secuencia de comandos: 11/23/2010 21:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pista](
	[CodPista] [int] IDENTITY(1,1) NOT NULL,
	[CodAeropuerto] [int] NOT NULL,
	[Largo] [int] NOT NULL,
	[Ancho] [int] NOT NULL,
	[TORA] [int] NOT NULL,
	[TODA] [int] NOT NULL,
	[ASDA] [int] NOT NULL,
	[LDA] [int] NOT NULL,
	[Pavimento] [varchar](500) NOT NULL,
	[Designado] [varchar](500) NOT NULL,
	[PCN] [varchar](500) NOT NULL,
	[Franja] [varchar](500) NOT NULL,
	[Rodaje] [varchar](500) NOT NULL,
	[Estado] [varchar](500) NOT NULL,
 CONSTRAINT [PK_Pista] PRIMARY KEY CLUSTERED 
(
	[CodPista] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[IPAeropuerto]    Fecha de la secuencia de comandos: 11/23/2010 21:54:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IPAeropuerto](
	[IP] [varchar](30) NOT NULL,
	[CodAeropuerto] [int] NOT NULL,
 CONSTRAINT [PK_IPAeropuerto] PRIMARY KEY CLUSTERED 
(
	[CodAeropuerto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[PlanDeVuelo]    Fecha de la secuencia de comandos: 11/23/2010 21:54:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PlanDeVuelo](
	[CodPlanVuelo] [int] IDENTITY(1,1) NOT NULL,
	[CodAerolinea] [int] NOT NULL,
	[Destinatario] [varchar](1000) NOT NULL,
	[Remitente] [varchar](500) NOT NULL,
	[Presentador] [varchar](500) NOT NULL,
	[Requisitos] [varchar](1000) NOT NULL,
	[Prioridad] [varchar](50) NOT NULL,
	[Hora] [datetime] NOT NULL,
 CONSTRAINT [PK_PlanDeVuelo] PRIMARY KEY CLUSTERED 
(
	[CodPlanVuelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[TUUA]    Fecha de la secuencia de comandos: 11/23/2010 21:55:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TUUA](
	[CodTUUA] [int] NOT NULL,
	[CodTipoVuelo] [int] NOT NULL,
	[CodBoleto] [int] NOT NULL,
	[CodAerolinea] [int] NOT NULL,
	[Impuesto] [float] NOT NULL,
	[CodVuelo] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_TUUA] PRIMARY KEY CLUSTERED 
(
	[CodTUUA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[InformacionVuelo]    Fecha de la secuencia de comandos: 11/23/2010 21:54:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InformacionVuelo](
	[CodInfoVuelo] [int] IDENTITY(1,1) NOT NULL,
	[CodPlanVuelo] [int] NOT NULL,
	[Horas] [int] NOT NULL,
	[Min] [int] NOT NULL,
	[Personas] [int] NOT NULL,
	[UHF] [int] NULL,
	[VHF] [int] NULL,
	[ELT] [int] NULL,
	[Polar] [int] NULL,
	[Desierto] [int] NULL,
	[Maritimo] [int] NULL,
	[Selva] [int] NULL,
	[Fluor] [int] NULL,
	[Luz] [int] NULL,
	[Numero] [int] NULL,
	[Capacidad] [int] NOT NULL,
	[Cubierta] [int] NOT NULL,
	[Color] [varchar](500) NOT NULL,
	[MarcasNave] [varchar](500) NOT NULL,
	[Observaciones] [varchar](1000) NOT NULL,
	[Piloto] [varchar](500) NOT NULL,
 CONSTRAINT [PK_InformacionVuelo] PRIMARY KEY CLUSTERED 
(
	[CodInfoVuelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[Destino]    Fecha de la secuencia de comandos: 11/23/2010 21:54:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Destino](
	[CodDestino] [int] IDENTITY(1,1) NOT NULL,
	[CodPlanVuelo] [int] NOT NULL,
	[TiempoHr] [varchar](50) NOT NULL,
	[TiempoMin] [varchar](50) NOT NULL,
	[CodAerodromo] [int] NULL,
	[CodAerodromoAlter] [int] NULL,
	[CodAerodromo2Alter] [int] NULL,
 CONSTRAINT [PK_Destino] PRIMARY KEY CLUSTERED 
(
	[CodDestino] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  StoredProcedure [dbo].[uspLogObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspLogObtener]
(
	@CodOperacion int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [CodRegistro]
      ,[CodOperacion]
      ,[Tabla]
      ,[Usuario]
      ,[Fecha]
      ,[IP]
      ,[Razon]
  FROM [Aeropuerto].[dbo].[Log]
  where CodOperacion = @CodOperacion
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspLogListar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspLogListar]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	SELECT [CodRegistro]
      ,[CodOperacion]
      ,[Tabla]
      ,[Usuario]
      ,[Fecha]
      ,[IP]
      ,[Razon]
  FROM [Aeropuerto].[dbo].[Log]
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspLogInsertar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspLogInsertar]
(
			@CodOperacion int
           ,@Tabla varchar(50)
           ,@Usuario varchar(50)          
           ,@IP varchar(23)
           ,@Razon varchar(500)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    INSERT INTO [Aeropuerto].[dbo].[Log]
           ([CodOperacion]
           ,[Tabla]
           ,[Usuario]
           ,[Fecha]
           ,[IP]
           ,[Razon])
     VALUES
           (
			@CodOperacion,
			@Tabla,
			@Usuario,
			GETDATE(),
			@IP,
			@Razon
           )
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAvionObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:53:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAvionObtener]
(
	@CodAvion int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT [CodAvion]
      ,[Nombre]
      ,[Fabricante]
      ,[Serie]
      ,[CabinaTripulacion]
      ,[Pasajeros]
      ,[Longitud]
      ,[Envergadura]
      ,[Altura]
      ,[PesoVacio]
      ,[PesoMaxDespegue]
      ,[VelocidadCrucero]
      ,[VelocidadMax]
      ,[CarreraPesoMax]
      ,[AutonomiaPesoMaxDesp]
      ,[MaxFuel]
      ,[Motor]
      ,[Empuje]
  FROM [Aeropuerto].[dbo].[Avion]
  WHERE CodAvion = @CodAvion
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAvionListar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAvionListar]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	SELECT [CodAvion]
      ,[Nombre]
      ,[Fabricante]
      ,[Serie]
      ,[CabinaTripulacion]
      ,[Pasajeros]
      ,[Longitud]
      ,[Envergadura]
      ,[Altura]
      ,[PesoVacio]
      ,[PesoMaxDespegue]
      ,[VelocidadCrucero]
      ,[VelocidadMax]
      ,[CarreraPesoMax]
      ,[AutonomiaPesoMaxDesp]
      ,[MaxFuel]
      ,[Motor]
      ,[Empuje]
  FROM [Aeropuerto].[dbo].[Avion]
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAvionInsertar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAvionInsertar]
(
		   @Nombre varchar(100)
           ,@Fabricante varchar(100)
           ,@Serie varchar(50)
           ,@CabinaTripulacion int
           ,@Pasajeros int
           ,@Longitud float
           ,@Envergadura float
           ,@Altura float
           ,@PesoVacio float
           ,@PesoMaxDespegue float
           ,@VelocidadCrucero float
           ,@VelocidadMax float
           ,@CarreraPesoMax float
           ,@AutonomiaPesoMaxDesp float
           ,@MaxFuel float
           ,@Motor varchar(500)
           ,@Empuje varchar(500)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO [Aeropuerto].[dbo].[Avion]
           ([Nombre]
           ,[Fabricante]
           ,[Serie]
           ,[CabinaTripulacion]
           ,[Pasajeros]
           ,[Longitud]
           ,[Envergadura]
           ,[Altura]
           ,[PesoVacio]
           ,[PesoMaxDespegue]
           ,[VelocidadCrucero]
           ,[VelocidadMax]
           ,[CarreraPesoMax]
           ,[AutonomiaPesoMaxDesp]
           ,[MaxFuel]
           ,[Motor]
           ,[Empuje])
     VALUES
     (
		@Nombre 
           ,@Fabricante 
           ,@Serie
           ,@CabinaTripulacion 
           ,@Pasajeros
           ,@Longitud
           ,@Envergadura
           ,@Altura 
           ,@PesoVacio 
           ,@PesoMaxDespegue
           ,@VelocidadCrucero
           ,@VelocidadMax
           ,@CarreraPesoMax
           ,@AutonomiaPesoMaxDesp
           ,@MaxFuel
           ,@Motor
           ,@Empuje
     )
     RETURN @@IDENTITY
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAvionActualizar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAvionActualizar]
(
		    @CodAvion int
		   ,@Nombre varchar(100)
           ,@Fabricante varchar(100)
           ,@Serie varchar(50)
           ,@CabinaTripulacion int
           ,@Pasajeros int
           ,@Longitud float
           ,@Envergadura float
           ,@Altura float
           ,@PesoVacio float
           ,@PesoMaxDespegue float
           ,@VelocidadCrucero float
           ,@VelocidadMax float
           ,@CarreraPesoMax float
           ,@AutonomiaPesoMaxDesp float
           ,@MaxFuel float
           ,@Motor varchar(500)
           ,@Empuje varchar(500)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	UPDATE [Aeropuerto].[dbo].[Avion]
   SET [Nombre] = @Nombre
      ,[Fabricante] = @Fabricante
      ,[Serie] = @Serie
      ,[CabinaTripulacion] = @CabinaTripulacion
      ,[Pasajeros] = @Pasajeros
      ,[Longitud] = @Longitud
      ,[Envergadura] = @Envergadura
      ,[Altura] = @Altura
      ,[PesoVacio] = @PesoVacio
      ,[PesoMaxDespegue] = @PesoMaxDespegue
      ,[VelocidadCrucero] = @VelocidadCrucero
      ,[VelocidadMax] = @VelocidadMax
      ,[CarreraPesoMax] = @CarreraPesoMax
      ,[AutonomiaPesoMaxDesp] = @AutonomiaPesoMaxDesp
      ,[MaxFuel] = @MaxFuel
      ,[Motor] = @Motor
      ,[Empuje] = @Empuje
 WHERE CodAvion = @CodAvion
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAeropuertoObtenerNombre]    Fecha de la secuencia de comandos: 11/23/2010 21:53:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspAeropuertoObtenerNombre]
(
			@Nombre varchar(500)
)
as
begin
SELECT  CodAeropuerto,
        Nombre,
        Estado,
        Ciudad,
        IATA,
        OACI,
        Elevacion,
        SEI,
        Fuel,
        Operacion,
        Fecha
  FROM Aeropuerto
where Nombre = @Nombre
end
GO
/****** Objeto:  StoredProcedure [dbo].[uspAeropuertoObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:53:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Carlos Eduardo García Cabrera
-- Create date: 25/05/2010
-- Description:	Store Procedura para Obtener
-- =============================================
CREATE PROCEDURE [dbo].[uspAeropuertoObtener]
(
	@CodAeropuerto int
)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT [CodAeropuerto]
      ,[Nombre]
      ,[Estado]
      ,[Ciudad]
      ,[IATA]
      ,[OACI]
      ,[Elevacion]
      ,[SEI]
      ,[Fuel]
      ,[Operacion]
      ,[Fecha]
  FROM [Aeropuerto].[dbo].[Aeropuerto]
  WHERE CodAeropuerto = @CodAeropuerto
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAeropuertoListar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Carlos García
-- Create date: 25/05/2010
-- Description:	Store Procedura para Listar
-- =============================================
CREATE PROCEDURE [dbo].[uspAeropuertoListar]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

   SELECT [CodAeropuerto]
      ,[Nombre]
      ,[Estado]
      ,[Ciudad]
      ,[IATA]
      ,[OACI]
      ,[Elevacion]
      ,[SEI]
      ,[Fuel]
      ,[Operacion]
      ,[Fecha]
  FROM [Aeropuerto].[dbo].[Aeropuerto]
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAeropuertoInsertar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Carlos Eduardo García Cabrera
-- Create date: 25/05/2010
-- Description:	StoreProcedura para Insertar
-- =============================================
CREATE PROCEDURE [dbo].[uspAeropuertoInsertar]
(
		@Nombre varchar(500),
		@Estado varchar(500),
		@Ciudad varchar(500),
        @IATA varchar(3),
           @OACI varchar(4),
           @Elevacion int,
           @SEI int,
           @Fuel int,
           @Operacion varchar(1000)
           
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
INSERT INTO [Aeropuerto].[dbo].[Aeropuerto]
           (
           [Nombre],
           [Estado]
           ,[Ciudad]
           ,[IATA]
           ,[OACI]
           ,[Elevacion]
           ,[SEI]
           ,[Fuel]
           ,[Operacion]
           ,[Fecha])
     VALUES
           (@Nombre,
           @Estado ,
		@Ciudad ,
        @IATA ,
           @OACI,
           @Elevacion ,
           @SEI ,
           @Fuel ,
           @Operacion ,
           GETDATE())
      RETURN @@IDENTITY
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAeropuertoEliminar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAeropuertoEliminar]
(
	@CodAeropuerto int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	DELETE FROM [Aeropuerto].[dbo].[Aeropuerto]
      WHERE CodAeropuerto = @CodAeropuerto
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAeropuertoActualizar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAeropuertoActualizar]
(
	@CodAeropuerto int,
	@Nombre varchar(500),
	@Estado varchar(500),
		@Ciudad varchar(500),
        @IATA varchar(3),
           @OACI varchar(4),
           @Elevacion int,
           @SEI int,
           @Fuel int,
           @Operacion varchar(1000)
          
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	UPDATE Aeropuerto
	SET Nombre = @Nombre
	  ,[Estado] = @Estado
      ,[Ciudad] = @Ciudad
      ,[IATA] = @IATA
      ,[OACI] = @OACI
      ,[Elevacion] = @Elevacion
      ,[SEI] = @SEI
      ,[Fuel] = @Fuel
      ,[Operacion] = @Operacion
      ,[Fecha] = GETDATE()
 WHERE CodAeropuerto = @CodAeropuerto
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAerolineaObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAerolineaObtener]
(
	@CodAerolinea int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    SELECT [CodAerolinea]
      ,[Nombre]
      ,[RUC]
      ,[Procedencia]
  FROM [Aeropuerto].[dbo].[Aerolinea]
  WHERE CodAerolinea = @CodAerolinea
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAerolineaListar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAerolineaListar]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    SELECT [CodAerolinea]
      ,[Nombre]
      ,[RUC]
      ,[Procedencia]
  FROM [Aeropuerto].[dbo].[Aerolinea]
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAerolineaInsertar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAerolineaInsertar]
(
		@Nombre varchar(500),
        @RUC varchar(500),
        @Procedencia varchar(500),
		@Logotipo image)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO [Aeropuerto].[dbo].[Aerolinea]
           ([Nombre]
           ,[RUC]
           ,[Procedencia],
			Logotipo)
     VALUES
     (
		@Nombre ,
        @RUC ,
        @Procedencia,
		@Logotipo)
     RETURN @@IDENTITY
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAerolineaEliminar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAerolineaEliminar]
(
	@CodAerolinea int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	DELETE FROM [Aeropuerto].[dbo].[Aerolinea]
    WHERE CodAerolinea = @CodAerolinea
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAerolineaActualizar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAerolineaActualizar]
(
			@CodAerolinea int,
			@Nombre varchar(500),
           @RUC varchar(500),
           @Procedencia varchar(500)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	UPDATE [Aeropuerto].[dbo].[Aerolinea]
   SET [Nombre] = @Nombre
      ,[RUC] = @RUC
      ,[Procedencia] = @Procedencia
 WHERE CodAerolinea = @CodAerolinea
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspInsertarExcepcion]    Fecha de la secuencia de comandos: 11/23/2010 21:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[uspInsertarExcepcion]
(
	@Mensaje varchar(8000),
	@StackTrace varchar(8000),
	@FechaCliente Datetime,
	@CodUsuario int,
	@IPCliente varchar(30)
)
AS
BEGIN
	
	INSERT INTO
		Excepcion
		(
			Mensaje,
			StackTrace,
			FechaCliente,
			FechaServidor,
			CodUsuario,	
			IPCliente
		)
	VALUES
		(
			@Mensaje,
			@StackTrace,
			@FechaCliente,
			getdate(),
			@CodUsuario,	
			@IPCliente
		)

	RETURN @@IDENTITY
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspPlataformaObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:54:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Carlos Eduardo García Cabrera
-- Create date: 30/05/2010
-- Description:	SP To Get
-- =============================================
CREATE PROCEDURE [dbo].[uspPlataformaObtener]
(
	@CodPlataforma int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	SELECT [CodPlataforma]
      ,[CodAeropuerto]
      ,[Naves]
      ,[Pavimento]
      ,[PCN]
      ,[Dimensiones]
      ,[NaveMaxPermisible]
  FROM [Aeropuerto].[dbo].[Plataforma]
  WHERE CodPlataforma = @CodPlataforma
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspPlataformaListar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspPlataformaListar]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    SELECT [CodPlataforma]
      ,[CodAeropuerto]
      ,[Naves]
      ,[Pavimento]
      ,[PCN]
      ,[Dimensiones]
      ,[NaveMaxPermisible]
  FROM [Aeropuerto].[dbo].[Plataforma]
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspPlataformaInsertar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspPlataformaInsertar]
(
	@CodAeropuerto int
   ,@Naves int
   ,@Pavimento varchar(500)
   ,@PCN varchar(500)
   ,@Dimensiones varchar(500)
   ,@NaveMaxPermisible varchar(500)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	INSERT INTO [Aeropuerto].[dbo].[Plataforma]
	(
			CodAeropuerto
           ,Naves
           ,Pavimento
           ,PCN
           ,Dimensiones
           ,NaveMaxPermisible)
	VALUES
        (
		 
		@CodAeropuerto 
		,@Naves 
		,@Pavimento
		,@PCN 
		,@Dimensiones 
		,@NaveMaxPermisible
	)
	RETURN @@IDENTITY
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspPlataformaEliminar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspPlataformaEliminar]
(
	@CodPlataforma int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    DELETE FROM Plataforma
    WHERE CodPlataforma = @CodPlataforma
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspPlataformaActualizar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Carlos García
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspPlataformaActualizar]
(
	@CodPlataforma int,
	@CodAeropuerto int
   ,@Naves int
   ,@Pavimento varchar(500)
   ,@PCN varchar(500)
   ,@Dimensiones varchar(500)
   ,@NaveMaxPermisible varchar(500)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE [Aeropuerto].[dbo].[Plataforma]
	SET
		Naves = @Naves,
		Pavimento = @Pavimento,
		PCN = @PCN,
		Dimensiones = @Dimensiones,
		NaveMaxPermisible = @NaveMaxPermisible
	WHERE
		CodPlataforma = @CodPlataforma
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspPlanDeVueloObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:54:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspPlanDeVueloObtener]
(
	@CodPlanVuelo int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT [CodPlanVuelo]
      ,[CodAerolinea]
      ,[Destinatario]
      ,[Remitente]
      ,[Presentador]
      ,[Requisitos]
      ,[Prioridad]
      ,[Hora]
  FROM [Aeropuerto].[dbo].[PlanDeVuelo]
  WHERE CodPlanVuelo = @CodPlanVuelo
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspPlanDeVueloListar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspPlanDeVueloListar]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT [CodPlanVuelo]
      ,[CodAerolinea]
      ,[Destinatario]
      ,[Remitente]
      ,[Presentador]
      ,[Requisitos]
      ,[Prioridad]
      ,[Hora]
  FROM [Aeropuerto].[dbo].[PlanDeVuelo]
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspPlanDeVueloInsertar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspPlanDeVueloInsertar]
(
	@CodAerolinea int,
    @Destinatario varchar(1000),
    @Remitente varchar(500),
    @Presentador varchar(500),
    @Requisitos varchar(1000),
    @Prioridad varchar(50)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	INSERT INTO [Aeropuerto].[dbo].[PlanDeVuelo]
           ([CodAerolinea]
           ,[Destinatario]
           ,[Remitente]
           ,[Presentador]
           ,[Requisitos]
           ,[Prioridad]
           ,[Hora])
     VALUES
           (
			@CodAerolinea ,
			@Destinatario ,
			@Remitente ,
			@Presentador ,
			@Requisitos ,
			@Prioridad ,
			GETDATE()
           )
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspPistaObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:54:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Carlos García
-- Create date: 25/05/2010
-- Description:	StoreProcedure para Obtener
-- =============================================
CREATE PROCEDURE [dbo].[uspPistaObtener]
(
	@CodPista int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT	[CodPista]
			,[CodAeropuerto]
			,[Largo]
    		,[Ancho]
			,[TORA]
			,[TODA]
			,[ASDA]
			,[LDA]
			,[Pavimento]
			,[Designado]
			,[PCN]
			,[Franja]
			,[Rodaje]
			,[Estado]
  FROM [Aeropuerto].[dbo].[Pista]
  WHERE
	CodPista = @CodPista
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspPistaListar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Carlos García
-- Create date: 25/05/2010
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspPistaListar]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

   SELECT [CodPista]
      ,[CodAeropuerto]
      ,[Largo]
      ,[Ancho]
      ,[TORA]
      ,[TODA]
      ,[ASDA]
      ,[LDA]
      ,[Pavimento]
      ,[Designado]
      ,[PCN]
      ,[Franja]
      ,[Rodaje]
      ,[Estado]
  FROM [Aeropuerto].[dbo].[Pista]
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspPistaInsertar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Carlos García
-- Create date: 25
-- Description:	Store Procedura para Insertar
-- =============================================
CREATE PROCEDURE [dbo].[uspPistaInsertar]
(
	@CodAeropuerto int,
           @Largo int,
           @Ancho int,
           @TORA int,
           @TODA int,
           @ASDA int,
           @LDA int,
           @Pavimento varchar(500),
           @Designado varchar(500),
           @PCN varchar(500),
           @Franja varchar(500),
           @Rodaje varchar(500)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	INSERT INTO [Aeropuerto].[dbo].[Pista]
           ([CodAeropuerto]
           ,[Largo]
           ,[Ancho]
           ,[TORA]
           ,[TODA]
           ,[ASDA]
           ,[LDA]
           ,[Pavimento]
           ,[Designado]
           ,[PCN]
           ,[Franja]
           ,[Rodaje])
     VALUES
		
		   (@CodAeropuerto,
           @Largo,
           @Ancho,
           @TORA,
           @TODA,
           @ASDA ,
           @LDA ,
           @Pavimento ,
           @Designado ,
           @PCN ,
           @Franja,
           @Rodaje )
		
      RETURN @@IDENTITY     
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspPistaEliminar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspPistaEliminar]
(
	@CodPista int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	DELETE FROM Pista
	WHERE CodPista = @CodPista
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspPistaActualizar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Carlos García
-- Create date: 25/05/2010
-- Description:	StoreProcedure para Actualizar
-- =============================================
CREATE PROCEDURE [dbo].[uspPistaActualizar]
(
	@CodPista int,
	@CodAeropuerto int,
           @Largo int,
           @Ancho int,
           @TORA int,
           @TODA int,
           @ASDA int,
           @LDA int,
           @Pavimento varchar(500),
           @Designado varchar(500),
           @PCN varchar(500),
           @Franja varchar(500),
           @Rodaje varchar(500),
			@Estado varchar(500)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	UPDATE [Aeropuerto].[dbo].[Pista]
   SET [CodAeropuerto] = @CodAeropuerto
      ,[Largo] = @Largo
      ,[Ancho] = @Ancho
      ,[TORA] = @Ancho
      ,[TODA] = @TODA
      ,[ASDA] = @ASDA
      ,[LDA] = @LDA
      ,[Pavimento] = @Pavimento
      ,[Designado] = @Designado
      ,[PCN] = @PCN
      ,[Franja] = @Franja
      ,[Rodaje] = @Rodaje
		,[estado] = @Estado
 WHERE CodPista = @CodPista
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspMovimientoObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspMovimientoObtener]
(
	@CodMovimiento int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	SELECT [CodMovimiento]
      ,[CodTipoMovimiento]
      ,[CodAerolinea]
      ,[CodAvion]
      ,[Detalle]
      ,[CodAeropuertoOrigen]
      ,[CodAeropuertoDestino]
  FROM [Aeropuerto].[dbo].[Movimiento]
  WHERE CodMovimiento = @CodMovimiento
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspMovimientoListar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspMovimientoListar]
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT [CodMovimiento]
      ,[CodTipoMovimiento]
      ,[CodAerolinea]
      ,[CodAvion]
      ,[Detalle]
      ,[CodAeropuertoOrigen]
      ,[CodAeropuertoDestino]
  FROM [Aeropuerto].[dbo].[Movimiento]
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspMovimientoInsertar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspMovimientoInsertar]
(
	@CodTipoMovimiento int
   ,@CodAerolinea int
   ,@CodAvion int
   ,@Detalle varchar(500)
   ,@CodAeropuertoOrigen int
   ,@CodAeropuertoDestino int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	INSERT INTO [Aeropuerto].[dbo].[Movimiento]
           ([CodTipoMovimiento]
           ,[CodAerolinea]
           ,[CodAvion]
           ,[Detalle]
           ,[CodAeropuertoOrigen]
           ,[CodAeropuertoDestino])
     VALUES
           (
			@CodTipoMovimiento
			,@CodAerolinea
			,@CodAvion
			,@Detalle
			,@CodAeropuertoOrigen 
			,@CodAeropuertoDestino
           )
           
       RETURN @@IDENTITY
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspTUUAListar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		García Cabrera, Carlos Eduardo
-- Create date: 09/11/2010
-- Description:	SP to List
-- =============================================
CREATE PROCEDURE [dbo].[uspTUUAListar]
AS
BEGIN
	SET NOCOUNT OFF;

	SELECT [CodTUUA]
      ,[CodTipoVuelo]
      ,[CodBoleto]
      ,[CodAerolinea]
      ,[Impuesto]
      ,[CodVuelo]
      ,[Fecha]
  FROM [Aeropuerto].[dbo].[TUUA]
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspTUUAObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:54:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspTUUAObtener]
(
	@CodTUUA int
)
as
begin
SELECT [CodTUUA]
      ,[CodTipoVuelo]
      ,[CodBoleto]
      ,[CodAerolinea]
      ,[Impuesto]
      ,[CodVuelo]
      ,[Fecha]
  FROM [Aeropuerto].[dbo].[TUUA]
where CodTUUA = @CodTUUA
end
GO
/****** Objeto:  StoredProcedure [dbo].[uspIPAeropuertoObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspIPAeropuertoObtener]
(
			@IP varchar(30)
)
as
begin
SELECT [IP]
      ,[CodAeropuerto]
  FROM [Aeropuerto].[dbo].[IPAeropuerto]
where IP = @IP
end
GO
/****** Objeto:  StoredProcedure [dbo].[uspSalidaObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:54:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspSalidaObtener]
(
	@CodSalida int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	SELECT [CodSalida]
      ,[CodPlanVuelo]
      ,[Numero]
      ,[Placa]
      ,[ReglasVuelo]
      ,[TipoVuelo]
      ,[CodAvion]
      ,[Hora]
      ,[CodAeropuerto]
      ,[Turbulencia]
      ,[Equipo]
      ,[Velocidad]
      ,[Nivel]
      ,[Ruta]
  FROM [Aeropuerto].[dbo].[Salida]
  WHERE CodSalida = @CodSalida
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspSalidaListar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspSalidaListar]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	SELECT [CodSalida]
      ,[CodPlanVuelo]
      ,[Numero]
      ,[Placa]
      ,[ReglasVuelo]
      ,[TipoVuelo]
      ,[CodAvion]
      ,[Hora]
      ,[CodAeropuerto]
      ,[Turbulencia]
      ,[Equipo]
      ,[Velocidad]
      ,[Nivel]
      ,[Ruta]
  FROM [Aeropuerto].[dbo].[Salida]
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspSalidaInsertar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspSalidaInsertar]
(
	
    @CodPlanVuelo int,
    @Numero int,
    @Placa varchar(50),
    @ReglasVuelo varchar(1),
    @TipoVuelo varchar(1),
    @CodAvion int,
    @CodAeropuerto int,
    @Turbulencia varchar(1),
    @Equipo varchar(50),
    @Velocidad float,
    @Nivel float,
    @Ruta varchar(8000)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	INSERT INTO [Aeropuerto].[dbo].[Salida]
           (
           [CodPlanVuelo]
           ,[Numero]
           ,[Placa]
           ,[ReglasVuelo]
           ,[TipoVuelo]
           ,[CodAvion]
           ,[Hora]
           ,[CodAeropuerto]
           ,[Turbulencia]
           ,[Equipo]
           ,[Velocidad]
           ,[Nivel]
           ,[Ruta])
     VALUES
           (
			@CodPlanVuelo ,
			@Numero ,
			@Placa ,
			@ReglasVuelo ,
			@TipoVuelo ,
			@CodAvion ,
			GETDATE() ,
			@CodAeropuerto ,
			@Turbulencia ,
			@Equipo ,
			@Velocidad ,
			@Nivel ,
			@Ruta
           )
       RETURN @@IDENTITY
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspInformacionVueloObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:53:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspInformacionVueloObtener]
(
	@CodInfoVuelo int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT [CodInfoVuelo]
      ,[CodPlanVuelo]
      ,[Horas]
      ,[Min]
      ,[Personas]
      ,[UHF]
      ,[VHF]
      ,[ELT]
      ,[Polar]
      ,[Desierto]
      ,[Maritimo]
      ,[Selva]
      ,[Fluor]
      ,[Luz]
      ,[Numero]
      ,[Capacidad]
      ,[Cubierta]
      ,[Color]
      ,[MarcasNave]
      ,[Observaciones]
      ,[Piloto]
  FROM [Aeropuerto].[dbo].[InformacionVuelo]
  WHERE CodInfoVuelo = @CodInfoVuelo
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspInformacionVueloListar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Carlos Eduardo García Cabrera
-- Create date: 05/06/2010
-- Description:	SP To List Flight Information
-- =============================================
CREATE PROCEDURE [dbo].[uspInformacionVueloListar]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	SELECT [CodInfoVuelo]
      ,[CodPlanVuelo]
      ,[Horas]
      ,[Min]
      ,[Personas]
      ,[UHF]
      ,[VHF]
      ,[ELT]
      ,[Polar]
      ,[Desierto]
      ,[Maritimo]
      ,[Selva]
      ,[Fluor]
      ,[Luz]
      ,[Numero]
      ,[Capacidad]
      ,[Cubierta]
      ,[Color]
      ,[MarcasNave]
      ,[Observaciones]
      ,[Piloto]
  FROM [Aeropuerto].[dbo].[InformacionVuelo]
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspInformacionVueloInsertar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspInformacionVueloInsertar]
(
    @Horas int,
    @Min int,
    @Personas int,
    @UHF int,
    @VHF int,
    @ELT int,
    @Polar int,
    @Desierto int,
    @Maritimo int,
    @Selva int,
    @Fluor int,
    @Luz int,
    @Numero int,
    @Capacidad int,
    @Cubierta int,
    @Color varchar(500),
    @MarcasNave varchar(500),
    @Observaciones varchar(1000),
    @Piloto varchar(500)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO [Aeropuerto].[dbo].[InformacionVuelo]
           (
           [Horas]
           ,[Min]
           ,[Personas]
           ,[UHF]
           ,[VHF]
           ,[ELT]
           ,[Polar]
           ,[Desierto]
           ,[Maritimo]
           ,[Selva]
           ,[Fluor]
           ,[Luz]
           ,[Numero]
           ,[Capacidad]
           ,[Cubierta]
           ,[Color]
           ,[MarcasNave]
           ,[Observaciones]
           ,[Piloto])
     VALUES
           (
			@Horas ,
			@Min ,
			@Personas ,
			@UHF ,
			@VHF ,
			@ELT ,
			@Polar ,
			@Desierto ,
			@Maritimo ,
			@Selva ,
			@Fluor ,
			@Luz ,
			@Numero ,
			@Capacidad ,
			@Cubierta ,
			@Color ,
			@MarcasNave ,
			@Observaciones ,
			@Piloto
           )
           RETURN @@IDENTITY
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspDestinoObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:53:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspDestinoObtener]
(
	@CodDestino int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	SELECT [CodDestino]
      ,[CodPlanVuelo]
      ,[TiempoHr]
      ,[TiempoMin]
      ,[CodAerodromo]
      ,[CodAerodromoAlter]
      ,[CodAerodromo2Alter]
  FROM [Aeropuerto].[dbo].[Destino]
  WHERE CodDestino = @CodDestino
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspDestinoListar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspDestinoListar]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	SELECT [CodDestino]
      ,[CodPlanVuelo]
      ,[TiempoHr]
      ,[TiempoMin]
      ,[CodAerodromo]
      ,[CodAerodromoAlter]
      ,[CodAerodromo2Alter]
  FROM [Aeropuerto].[dbo].[Destino]
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspDestinoInsertar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspDestinoInsertar]
(
	@CodPlanVuelo int,
    @TiempoHr varchar(50),
    @TiempoMin varchar(50),
    @CodAerodromo int,
    @CodAerodromoAlter int,
    @CodAerodromo2Alter int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	INSERT INTO [Aeropuerto].[dbo].[Destino]
           ([CodPlanVuelo]
           ,[TiempoHr]
           ,[TiempoMin]
           ,[CodAerodromo]
           ,[CodAerodromoAlter]
           ,[CodAerodromo2Alter])
     VALUES
           (
				@CodPlanVuelo ,
				@TiempoHr ,
				@TiempoMin ,
				@CodAerodromo ,
				@CodAerodromoAlter ,
				@CodAerodromo2Alter 
           )
      RETURN @@IDENTITY
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspFacturaInsertar]    Fecha de la secuencia de comandos: 11/23/2010 21:53:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspFacturaInsertar]
(
		@Fecha datetime,
        @Monto float,
        @Descripcion varchar(100),
		@CodAerolinea int
)
as
begin
INSERT INTO Factura
           (CodAerolinea
			,Fecha
            ,Monto
            ,Descripcion)
     VALUES
           (@CodAerolinea,
			@Fecha,
            @Monto,
            @Descripcion
		   )
return @@identity
end
GO
/****** Objeto:  StoredProcedure [dbo].[uspObtenerCobroEstacionamiento]    Fecha de la secuencia de comandos: 11/23/2010 21:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspObtenerCobroEstacionamiento]
(
		@id int
)
as
begin
SELECT [CodEstacionamiento]
      ,[FechaInicio]
      ,[FechaFin]
      ,[Duracion]
      ,[CodAerolinea]
      ,[Impuesto]
      ,[CodAvion]
  FROM [Aeropuerto].[dbo].[CobroEstacionamiento]
where @id = CodEstacionamiento
end
GO
/****** Objeto:  StoredProcedure [dbo].[uspInsertarCobroEstacionamiento]    Fecha de la secuencia de comandos: 11/23/2010 21:53:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspInsertarCobroEstacionamiento]
(
			@FechaInicio datetime,
            @FechaFin datetime,
            @Duracion int,
            @CodAerolinea int,
            @Impuesto float,
            @CodAvion int
)
as
begin
INSERT INTO [Aeropuerto].[dbo].[CobroEstacionamiento]
           ([FechaInicio]
           ,[FechaFin]
           ,[Duracion]
           ,[CodAerolinea]
           ,[Impuesto]
           ,[CodAvion])
     VALUES
           (@FechaInicio,
            @FechaFin,
            @Duracion,
            @CodAerolinea,
            @Impuesto,
            @CodAvion)
return @@identity
end
GO
/****** Objeto:  StoredProcedure [dbo].[uspListarCobroEstacionamiento]    Fecha de la secuencia de comandos: 11/23/2010 21:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspListarCobroEstacionamiento]
as
begin
SELECT [CodEstacionamiento]
      ,[FechaInicio]
      ,[FechaFin]
      ,[Duracion]
      ,[CodAerolinea]
      ,[Impuesto]
      ,[CodAvion]
  FROM [Aeropuerto].[dbo].[CobroEstacionamiento]
end
GO
/****** Objeto:  StoredProcedure [dbo].[uspTipoVueloObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspTipoVueloObtener]
(
		@id int
)
as
begin
SELECT [CodTipoVuelo]
      ,[TipoVuelo]
      ,[Impuesto]
  FROM [Aeropuerto].[dbo].[TipoVuelo]
where	CodTipoVuelo = @id
end
GO
/****** Objeto:  StoredProcedure [dbo].[uspTipoMovimientoObtener]    Fecha de la secuencia de comandos: 11/23/2010 21:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspTipoMovimientoObtener]
(
	@CodTipoMovimiento int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	SELECT [CodTipoMovimiento]
      ,[Descripcion]
  FROM [Aeropuerto].[dbo].[TipoMovimiento]
  WHERE CodTipoMovimiento = @CodTipoMovimiento
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspTipoMovimientoListar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspTipoMovimientoListar]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	SELECT [CodTipoMovimiento]
      ,[Descripcion]
  FROM [Aeropuerto].[dbo].[TipoMovimiento]
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspTipoMovimientoInsertar]    Fecha de la secuencia de comandos: 11/23/2010 21:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspTipoMovimientoInsertar]
(
	@Descripcion varchar(1000)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	INSERT INTO [Aeropuerto].[dbo].[TipoMovimiento]
           ([Descripcion])
     VALUES
           (@Descripcion)
     RETURN @@IDENTITY
END
GO
/****** Objeto:  ForeignKey [FK_Destino_PlanDeVuelo]    Fecha de la secuencia de comandos: 11/23/2010 21:54:25 ******/
ALTER TABLE [dbo].[Destino]  WITH CHECK ADD  CONSTRAINT [FK_Destino_PlanDeVuelo] FOREIGN KEY([CodPlanVuelo])
REFERENCES [dbo].[PlanDeVuelo] ([CodPlanVuelo])
GO
ALTER TABLE [dbo].[Destino] CHECK CONSTRAINT [FK_Destino_PlanDeVuelo]
GO
/****** Objeto:  ForeignKey [FK_InformacionVuelo_PlanDeVuelo1]    Fecha de la secuencia de comandos: 11/23/2010 21:54:36 ******/
ALTER TABLE [dbo].[InformacionVuelo]  WITH CHECK ADD  CONSTRAINT [FK_InformacionVuelo_PlanDeVuelo1] FOREIGN KEY([CodPlanVuelo])
REFERENCES [dbo].[PlanDeVuelo] ([CodPlanVuelo])
GO
ALTER TABLE [dbo].[InformacionVuelo] CHECK CONSTRAINT [FK_InformacionVuelo_PlanDeVuelo1]
GO
/****** Objeto:  ForeignKey [FK_IPAeropuerto_Aeropuerto]    Fecha de la secuencia de comandos: 11/23/2010 21:54:37 ******/
ALTER TABLE [dbo].[IPAeropuerto]  WITH CHECK ADD  CONSTRAINT [FK_IPAeropuerto_Aeropuerto] FOREIGN KEY([CodAeropuerto])
REFERENCES [dbo].[Aeropuerto] ([CodAeropuerto])
GO
ALTER TABLE [dbo].[IPAeropuerto] CHECK CONSTRAINT [FK_IPAeropuerto_Aeropuerto]
GO
/****** Objeto:  ForeignKey [FK_Movimiento_Aerolinea]    Fecha de la secuencia de comandos: 11/23/2010 21:54:42 ******/
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_Aerolinea] FOREIGN KEY([CodAerolinea])
REFERENCES [dbo].[Aerolinea] ([CodAerolinea])
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK_Movimiento_Aerolinea]
GO
/****** Objeto:  ForeignKey [FK_Movimiento_Aeropuerto]    Fecha de la secuencia de comandos: 11/23/2010 21:54:43 ******/
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_Aeropuerto] FOREIGN KEY([CodAeropuertoOrigen])
REFERENCES [dbo].[Aeropuerto] ([CodAeropuerto])
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK_Movimiento_Aeropuerto]
GO
/****** Objeto:  ForeignKey [FK_Movimiento_Aeropuerto1]    Fecha de la secuencia de comandos: 11/23/2010 21:54:43 ******/
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_Aeropuerto1] FOREIGN KEY([CodAeropuertoDestino])
REFERENCES [dbo].[Aeropuerto] ([CodAeropuerto])
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK_Movimiento_Aeropuerto1]
GO
/****** Objeto:  ForeignKey [FK_Movimiento_Avion]    Fecha de la secuencia de comandos: 11/23/2010 21:54:43 ******/
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_Avion] FOREIGN KEY([CodAvion])
REFERENCES [dbo].[Avion] ([CodAvion])
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK_Movimiento_Avion]
GO
/****** Objeto:  ForeignKey [FK_Movimiento_TipoMovimiento]    Fecha de la secuencia de comandos: 11/23/2010 21:54:43 ******/
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_TipoMovimiento] FOREIGN KEY([CodTipoMovimiento])
REFERENCES [dbo].[TipoMovimiento] ([CodTipoMovimiento])
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK_Movimiento_TipoMovimiento]
GO
/****** Objeto:  ForeignKey [FK_Pista_Aeropuerto]    Fecha de la secuencia de comandos: 11/23/2010 21:54:48 ******/
ALTER TABLE [dbo].[Pista]  WITH CHECK ADD  CONSTRAINT [FK_Pista_Aeropuerto] FOREIGN KEY([CodAeropuerto])
REFERENCES [dbo].[Aeropuerto] ([CodAeropuerto])
GO
ALTER TABLE [dbo].[Pista] CHECK CONSTRAINT [FK_Pista_Aeropuerto]
GO
/****** Objeto:  ForeignKey [FK_PlanDeVuelo_Aerolinea]    Fecha de la secuencia de comandos: 11/23/2010 21:54:51 ******/
ALTER TABLE [dbo].[PlanDeVuelo]  WITH CHECK ADD  CONSTRAINT [FK_PlanDeVuelo_Aerolinea] FOREIGN KEY([CodAerolinea])
REFERENCES [dbo].[Aerolinea] ([CodAerolinea])
GO
ALTER TABLE [dbo].[PlanDeVuelo] CHECK CONSTRAINT [FK_PlanDeVuelo_Aerolinea]
GO
/****** Objeto:  ForeignKey [FK_Plataforma_Aeropuerto]    Fecha de la secuencia de comandos: 11/23/2010 21:54:53 ******/
ALTER TABLE [dbo].[Plataforma]  WITH CHECK ADD  CONSTRAINT [FK_Plataforma_Aeropuerto] FOREIGN KEY([CodAeropuerto])
REFERENCES [dbo].[Aeropuerto] ([CodAeropuerto])
GO
ALTER TABLE [dbo].[Plataforma] CHECK CONSTRAINT [FK_Plataforma_Aeropuerto]
GO
/****** Objeto:  ForeignKey [FK_Salida_Avion]    Fecha de la secuencia de comandos: 11/23/2010 21:54:58 ******/
ALTER TABLE [dbo].[Salida]  WITH CHECK ADD  CONSTRAINT [FK_Salida_Avion] FOREIGN KEY([CodAvion])
REFERENCES [dbo].[Avion] ([CodAvion])
GO
ALTER TABLE [dbo].[Salida] CHECK CONSTRAINT [FK_Salida_Avion]
GO
/****** Objeto:  ForeignKey [FK_Salida_PlanDeVuelo]    Fecha de la secuencia de comandos: 11/23/2010 21:54:58 ******/
ALTER TABLE [dbo].[Salida]  WITH CHECK ADD  CONSTRAINT [FK_Salida_PlanDeVuelo] FOREIGN KEY([CodPlanVuelo])
REFERENCES [dbo].[PlanDeVuelo] ([CodPlanVuelo])
GO
ALTER TABLE [dbo].[Salida] CHECK CONSTRAINT [FK_Salida_PlanDeVuelo]
GO
/****** Objeto:  ForeignKey [FK_TUUA_Aerolinea]    Fecha de la secuencia de comandos: 11/23/2010 21:55:04 ******/
ALTER TABLE [dbo].[TUUA]  WITH CHECK ADD  CONSTRAINT [FK_TUUA_Aerolinea] FOREIGN KEY([CodAerolinea])
REFERENCES [dbo].[Aerolinea] ([CodAerolinea])
GO
ALTER TABLE [dbo].[TUUA] CHECK CONSTRAINT [FK_TUUA_Aerolinea]
GO
/****** Objeto:  ForeignKey [FK_TUUA_TipoVuelo]    Fecha de la secuencia de comandos: 11/23/2010 21:55:04 ******/
ALTER TABLE [dbo].[TUUA]  WITH CHECK ADD  CONSTRAINT [FK_TUUA_TipoVuelo] FOREIGN KEY([CodTipoVuelo])
REFERENCES [dbo].[TipoVuelo] ([CodTipoVuelo])
GO
ALTER TABLE [dbo].[TUUA] CHECK CONSTRAINT [FK_TUUA_TipoVuelo]
GO
