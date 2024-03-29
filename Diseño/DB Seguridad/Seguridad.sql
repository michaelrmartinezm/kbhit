USE [Seguridad]
GO
/****** Objeto:  Table [dbo].[Excepcion]    Fecha de la secuencia de comandos: 11/10/2010 17:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Excepcion](
	[IdExcepcion] [int] IDENTITY(1,1) NOT NULL,
	[Mensaje] [varchar](8000) NOT NULL,
	[StackTrace] [varchar](8000) NOT NULL,
	[FechaCliente] [datetime] NOT NULL,
	[FechaServidor] [datetime] NOT NULL,
	[Usuario] [varchar](30) NOT NULL,
	[IPCliente] [varchar](23) NOT NULL,
 CONSTRAINT [PK_Excepcion] PRIMARY KEY CLUSTERED 
(
	[IdExcepcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[Aplicacion]    Fecha de la secuencia de comandos: 11/10/2010 17:23:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aplicacion](
	[IdAplicacion] [int] IDENTITY(1,1) NOT NULL,
	[NombreAplicacion] [varchar](100) NOT NULL,
	[DescripcionAplicacion] [varchar](300) NOT NULL,
	[TipoAplicacion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Aplicacion] PRIMARY KEY CLUSTERED 
(
	[IdAplicacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[Rol]    Fecha de la secuencia de comandos: 11/10/2010 17:23:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rol](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionRol] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[Usuario]    Fecha de la secuencia de comandos: 11/10/2010 17:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](20) NOT NULL,
	[Contrasenia] [varchar](1000) NOT NULL,
	[NombreUsuario] [varchar](100) NOT NULL,
	[ApellidoPaterno] [varchar](100) NOT NULL,
	[ApellidoMaterno] [varchar](100) NOT NULL,
	[DNI] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  StoredProcedure [dbo].[uspUsuarioInsertar]    Fecha de la secuencia de comandos: 11/10/2010 17:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspUsuarioInsertar]
(
	@Login varchar(20),
	@Contrasenia varchar(1000),
	@NombreUsuairo varchar(100),
	@ApellidoPaterno varchar(100),
	@ApellidoMaterno varchar(100),
	@DNI varchar(10)
)
AS
BEGIN
	SET NOCOUNT OFF;
	INSERT INTO Seguridad
	(
		Login,
		Contrasenia,
		NombreUsuario,
		ApellidoPaterno,
		ApellidoMaterno,
		DNI
	)
	VALUES
	(
		@Login,
		@Contrasenia,
		@NombreUsuairo,
		@ApellidoPaterno,
		@ApellidoMaterno,
		@DNI
	)
	RETURN @@IDENTITY
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspExcepcionInsertar]    Fecha de la secuencia de comandos: 11/10/2010 17:23:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspExcepcionInsertar]
(
	@Mensaje varchar(8000),
	@StackTrace varchar(8000),
	@FechaCliente datetime,
	@Usuario varchar(30),
	@IPCliente varchar(23)
)
AS
BEGIN
	SET NOCOUNT OFF;
	INSERT INTO Seguridad
	(
		Mensaje,
		StackTrace,
		FechaCliente,
		FechaServidor,
		Usuario,
		IPCliente
	)
	VALUES
	(
		@Mensaje,
		@StackTrace,
		@FechaCliente,
		GETDATE(),
		@Usuario,
		@IPCliente
	)
	RETURN @@IDENTITY
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspRolInsertar]    Fecha de la secuencia de comandos: 11/10/2010 17:23:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspRolInsertar]
(
	@DescripcionRol varchar(100)
)
AS
BEGIN
	SET NOCOUNT OFF;
	INSERT INTO Seguridad
	(
		DescripcionRol
	)
	VALUES
	(
		@DescripcionRol
	)
	RETURN @@IDENTITY
END
GO
/****** Objeto:  Table [dbo].[Funcionalidad]    Fecha de la secuencia de comandos: 11/10/2010 17:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Funcionalidad](
	[IdFuncionalidad] [int] IDENTITY(1,1) NOT NULL,
	[NombreFuncionalidad] [varchar](100) NOT NULL,
	[Referencia] [varchar](300) NOT NULL,
	[IdPadre] [int] NULL,
	[IdAplicacion] [int] NOT NULL,
 CONSTRAINT [PK_Funcionalidad] PRIMARY KEY CLUSTERED 
(
	[IdFuncionalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[Usuario_Rol]    Fecha de la secuencia de comandos: 11/10/2010 17:23:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Rol](
	[IdRol] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Rol_Funcionalidad]    Fecha de la secuencia de comandos: 11/10/2010 17:23:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol_Funcionalidad](
	[IdRol] [int] NOT NULL,
	[IdFuncionalidad] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Objeto:  StoredProcedure [dbo].[uspExcepcionObtener]    Fecha de la secuencia de comandos: 11/10/2010 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[uspExcepcionObtener]
(
	@IdExcepcion int
)
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT
		Mensaje,
		StackTrace,
		FechaCliente,
		FechaServidor,
		IPCliente,
		Usuario
	FROM
		Excepcion
	WHERE
		IdExcepcion like @IdExcepcion
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspExcepcionListar]    Fecha de la secuencia de comandos: 11/10/2010 17:23:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[uspExcepcionListar]
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT
		IdExcepcion,
		StackTrace,
		Mensaje,
		Usuario,
		IPCliente,
		FechaCliente,
		FechaServidor
	FROM
		Excepcion
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspExcepcionActualizar]    Fecha de la secuencia de comandos: 11/10/2010 17:23:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[uspExcepcionActualizar]
(
	@Mensaje varchar(8000),
	@StackTrace varchar(8000),
	@FechaCliente datetime,
	@Usuario varchar(30),
	@IPCliente varchar(23),
	@IdExcepcion int
)
AS
BEGIN
	SET NOCOUNT OFF;
	UPDATE Excepcion
	SET
		Mensaje=@Mensaje,
		StackTrace=@StackTrace,
		FechaCliente=@FechaCliente,
		FechaServidor=GETDATE(),
		Usuario=@Usuario,
		IPCliente=@IPCliente
	WHERE
		IdExcepcion=@IdExcepcion
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAplicacionObtenerXCodigo]    Fecha de la secuencia de comandos: 11/10/2010 17:23:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAplicacionObtenerXCodigo]
(
	@IdAplicacion int
)
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT
		IdAplicacion,
		NombreAplicacion,
		DescripcionAplicacion,
		TipoAplicacion
	FROM
		Aplicacion
	WHERE
		IdAplicacion=@IdAplicacion
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAplicacionObtener]    Fecha de la secuencia de comandos: 11/10/2010 17:23:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAplicacionObtener]
(
	@NombreAplicacion varchar(100)
)
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT
		IdAplicacion,
		NombreAplicacion,
		DescripcionAplicacion,
		TipoAplicacion
	FROM
		Aplicacion
	WHERE
		NombreAplicacion like @NombreAplicacion
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAplicacionListar]    Fecha de la secuencia de comandos: 11/10/2010 17:23:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAplicacionListar]
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT
		IdAplicacion,
		NombreAplicacion,
		DescripcionAplicacion,
		TipoAplicacion
	FROM
		Aplicacion
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAplicacionInsertar]    Fecha de la secuencia de comandos: 11/10/2010 17:23:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAplicacionInsertar]
(
	@NombreAplicacion varchar(100),
	@DescripcionAplicacion varchar(100),
	@TipoAplicaicon varchar(100)
)
AS
BEGIN
	SET NOCOUNT OFF;
	INSERT INTO Aplicacion
	(
		NombreAplicacion,
		DescripcionAplicacion,
		TipoAplicacion
	)
	VALUES
	(
		@NombreAplicacion,
		@DescripcionAplicacion,
		@TipoAplicaicon
	)
	RETURN @@IDENTITY
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspAplicacionActualizar]    Fecha de la secuencia de comandos: 11/10/2010 17:23:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspAplicacionActualizar]
(
	@IdAplicacion int,
	@NombreAplicacion varchar(100),
	@DescripcionAplicacion varchar(100),
	@TipoAplicacion varchar(100)
)
AS
BEGIN
	SET NOCOUNT OFF;
	UPDATE Aplicacion
	SET
		NombreAplicacion=@NombreAplicacion,
		DescripcionAplicacion=@DescripcionAplicacion,
		TipoAplicacion=@TipoAplicacion
	WHERE
		IdAplicacion=@IdAplicacion
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspRolFuncionalidadListarXRol]    Fecha de la secuencia de comandos: 11/10/2010 17:23:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspRolFuncionalidadListarXRol]
(
	@IdRol int,
	@IdAplicacion int
)
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT
		RF.IdRol,
		RF.IdFuncionalidad
	FROM
		Rol_Funcionalidad RF, Funcionalidad F, Aplicacion A
	WHERE
		RF.IdRol=@IdRol AND 
		RF.IdFuncionalidad=F.IdFuncionalidad AND 
		F.IdAplicacion=A.IdAplicacion
		
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspRolObtener]    Fecha de la secuencia de comandos: 11/10/2010 17:23:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspRolObtener]
(
	@IdRol int
)
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT
		IdRol,
		DescripcionRol
	FROM
		Rol
	WHERE
		IdRol=@IdRol
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspRolListar]    Fecha de la secuencia de comandos: 11/10/2010 17:23:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspRolListar]
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT
		IdRol,
		DescripcionRol
	FROM
		Rol
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspFuncionalidadObtener]    Fecha de la secuencia de comandos: 11/10/2010 17:23:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspFuncionalidadObtener]
(
	@IdFuncionalidad int
)
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT
		IdFuncionalidad,
		NombreFuncionalidad,
		Referencia,
		IdAplicacion
	FROM
		Funcionalidad
	WHERE
		IdFuncionalidad like @IdFuncionalidad
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspFuncionalidadListar]    Fecha de la secuencia de comandos: 11/10/2010 17:23:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[uspFuncionalidadListar]
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT
		IdFuncionalidad,
		NombreFuncionalidad,
		Referencia,
		IdAplicacion
	FROM
		Funcionalidad
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspFuncionalidadInsertar]    Fecha de la secuencia de comandos: 11/10/2010 17:23:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[uspFuncionalidadInsertar]
(
	@NombreFuncionalidad varchar(100),
	@Referencia varchar(300),
	@IdAplicacion int
)
AS
BEGIN
	SET NOCOUNT OFF;
	INSERT INTO Funcionalidad
	(
		NombreFuncionalidad,
		Referencia,
		IdAplicacion
	)
	VALUES
	(
		@NombreFuncionalidad,
		@Referencia,
		@IdAplicacion
	)
	RETURN @@IDENTITY
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspFuncionalidadActualizar]    Fecha de la secuencia de comandos: 11/10/2010 17:23:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[uspFuncionalidadActualizar]
(
    @IdFuncionalidad int,
	@IdAplicacion int,
	@NombreFuncionalidad varchar(100),
	@Referencia varchar(300)

)
AS
BEGIN
	SET NOCOUNT OFF;
	UPDATE Funcionalidad
	SET
		IdAplicacion =@IdAplicacion,
		NombreFuncionalidad=@NombreFuncionalidad,
		Referencia=@Referencia
	WHERE
		IdFuncionalidad=@IdFuncionalidad
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspUsuarioRolListarXUsuario]    Fecha de la secuencia de comandos: 11/10/2010 17:23:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspUsuarioRolListarXUsuario]
(
	@IdUsuario int
)
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT
		IdRol,
		IdUsuario
	FROM
		Usuario_Rol
	WHERE
		IdUsuario=@IdUsuario
		
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspUsuarioRolListarXRol]    Fecha de la secuencia de comandos: 11/10/2010 17:23:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspUsuarioRolListarXRol]
(
	@IdRol int
)
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT
		IdRol,
		IdUsuario
	FROM
		Usuario_Rol
	WHERE
		IdRol=@IdRol
		
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspUsuarioRolInsertar]    Fecha de la secuencia de comandos: 11/10/2010 17:23:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspUsuarioRolInsertar]
(
	@IdUsuario int,
	@IdRol int
)
AS
BEGIN
	SET NOCOUNT OFF;
	INSERT INTO Usuario_Rol
	(
		IdUsuario,
		IdRol
	)
	VALUES
	(
		@IdUsuario,
		@IdRol
	)
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspRolFuncionalidadInsertar]    Fecha de la secuencia de comandos: 11/10/2010 17:23:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspRolFuncionalidadInsertar]
(
	@IdRol int,
	@IdFuncionalidad int
)
AS
BEGIN
	SET NOCOUNT OFF;
	INSERT INTO Rol_Funcionalidad
	(
		IdRol,
		IdFuncionalidad
	)
	VALUES
	(
		@IdRol,
		@IdFuncionalidad
	)
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspUsuarioValidar]    Fecha de la secuencia de comandos: 11/10/2010 17:23:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspUsuarioValidar]
(
	@IdUsuario int,
	@Contrasenia varchar(1000)
)
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT
		IdUsuario,
		Login,
		Contrasenia,
		NombreUsuario,
		ApellidoPaterno,
		ApellidoMaterno,
		DNI
	FROM
		Usuario
	WHERE
		IdUsuario=@IdUsuario AND Contrasenia like @Contrasenia
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspUsuarioExiste]    Fecha de la secuencia de comandos: 11/10/2010 17:23:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspUsuarioExiste]
(
	@Login varchar(20)
)
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT
		IdUsuario
	FROM
		Usuario
	WHERE
		Login like @Login
END
GO
/****** Objeto:  StoredProcedure [dbo].[uspUsuarioObtener]    Fecha de la secuencia de comandos: 11/10/2010 17:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspUsuarioObtener]
(
	@IdUsuario int
)
AS
BEGIN
	SET NOCOUNT OFF;
	SELECT
		IdUsuario,
		Login,
		Contrasenia,
		NombreUsuario,
		ApellidoPaterno,
		ApellidoMaterno,
		DNI
	FROM
		Usuario
	WHERE
		IdUsuario=@IdUsuario
END
GO
/****** Objeto:  ForeignKey [FK_Funcionalidad_Aplicacion]    Fecha de la secuencia de comandos: 11/10/2010 17:23:25 ******/
ALTER TABLE [dbo].[Funcionalidad]  WITH CHECK ADD  CONSTRAINT [FK_Funcionalidad_Aplicacion] FOREIGN KEY([IdAplicacion])
REFERENCES [dbo].[Aplicacion] ([IdAplicacion])
GO
ALTER TABLE [dbo].[Funcionalidad] CHECK CONSTRAINT [FK_Funcionalidad_Aplicacion]
GO
/****** Objeto:  ForeignKey [FK_Rol_Funcionalidad_Funcionalidad]    Fecha de la secuencia de comandos: 11/10/2010 17:23:29 ******/
ALTER TABLE [dbo].[Rol_Funcionalidad]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Funcionalidad_Funcionalidad] FOREIGN KEY([IdFuncionalidad])
REFERENCES [dbo].[Funcionalidad] ([IdFuncionalidad])
GO
ALTER TABLE [dbo].[Rol_Funcionalidad] CHECK CONSTRAINT [FK_Rol_Funcionalidad_Funcionalidad]
GO
/****** Objeto:  ForeignKey [FK_Rol_Funcionalidad_Rol]    Fecha de la secuencia de comandos: 11/10/2010 17:23:29 ******/
ALTER TABLE [dbo].[Rol_Funcionalidad]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Funcionalidad_Rol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol] ([IdRol])
GO
ALTER TABLE [dbo].[Rol_Funcionalidad] CHECK CONSTRAINT [FK_Rol_Funcionalidad_Rol]
GO
/****** Objeto:  ForeignKey [FK_Usuario_Rol_Rol]    Fecha de la secuencia de comandos: 11/10/2010 17:23:35 ******/
ALTER TABLE [dbo].[Usuario_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol_Rol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol] ([IdRol])
GO
ALTER TABLE [dbo].[Usuario_Rol] CHECK CONSTRAINT [FK_Usuario_Rol_Rol]
GO
/****** Objeto:  ForeignKey [FK_Usuario_Rol_Usuario]    Fecha de la secuencia de comandos: 11/10/2010 17:23:35 ******/
ALTER TABLE [dbo].[Usuario_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Usuario_Rol] CHECK CONSTRAINT [FK_Usuario_Rol_Usuario]
GO
