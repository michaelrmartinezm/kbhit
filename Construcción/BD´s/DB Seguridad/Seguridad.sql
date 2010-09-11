USE [Seguridad]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 07/10/2010 03:38:57 ******/
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
/****** Object:  StoredProcedure [dbo].[uspUsuarioInsertar]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspExcepcionInsertar]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspRolInsertar]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  Table [dbo].[Excepcion]    Script Date: 07/10/2010 03:38:57 ******/
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
/****** Object:  Table [dbo].[Aplicacion]    Script Date: 07/10/2010 03:38:57 ******/
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
/****** Object:  Table [dbo].[Rol]    Script Date: 07/10/2010 03:38:57 ******/
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
/****** Object:  Table [dbo].[Funcionalidad]    Script Date: 07/10/2010 03:38:57 ******/
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
/****** Object:  StoredProcedure [dbo].[uspExcepcionObtener]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspExcepcionListar]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspExcepcionActualizar]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspAplicacionObtenerXCodigo]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspAplicacionObtener]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspAplicacionListar]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspAplicacionInsertar]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspAplicacionActualizar]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspUsuarioObtener]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  Table [dbo].[Usuario_Rol]    Script Date: 07/10/2010 03:38:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Rol](
	[IdRol] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioExiste]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspRolObtener]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspRolListar]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspUsuarioValidar]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspUsuarioRolListarXUsuario]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspUsuarioRolListarXRol]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspUsuarioRolInsertar]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  Table [dbo].[Rol_Funcionalidad]    Script Date: 07/10/2010 03:38:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol_Funcionalidad](
	[IdRol] [int] NOT NULL,
	[IdFuncionalidad] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[uspFuncionalidadObtener]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspFuncionalidadListar]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspFuncionalidadInsertar]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspFuncionalidadActualizar]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspRolFuncionalidadListarXRol]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  StoredProcedure [dbo].[uspRolFuncionalidadInsertar]    Script Date: 07/10/2010 03:38:55 ******/
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
/****** Object:  ForeignKey [FK_Funcionalidad_Aplicacion]    Script Date: 07/10/2010 03:38:57 ******/
ALTER TABLE [dbo].[Funcionalidad]  WITH CHECK ADD  CONSTRAINT [FK_Funcionalidad_Aplicacion] FOREIGN KEY([IdAplicacion])
REFERENCES [dbo].[Aplicacion] ([IdAplicacion])
GO
ALTER TABLE [dbo].[Funcionalidad] CHECK CONSTRAINT [FK_Funcionalidad_Aplicacion]
GO
/****** Object:  ForeignKey [FK_Rol_Funcionalidad_Funcionalidad]    Script Date: 07/10/2010 03:38:57 ******/
ALTER TABLE [dbo].[Rol_Funcionalidad]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Funcionalidad_Funcionalidad] FOREIGN KEY([IdFuncionalidad])
REFERENCES [dbo].[Funcionalidad] ([IdFuncionalidad])
GO
ALTER TABLE [dbo].[Rol_Funcionalidad] CHECK CONSTRAINT [FK_Rol_Funcionalidad_Funcionalidad]
GO
/****** Object:  ForeignKey [FK_Rol_Funcionalidad_Rol]    Script Date: 07/10/2010 03:38:57 ******/
ALTER TABLE [dbo].[Rol_Funcionalidad]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Funcionalidad_Rol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol] ([IdRol])
GO
ALTER TABLE [dbo].[Rol_Funcionalidad] CHECK CONSTRAINT [FK_Rol_Funcionalidad_Rol]
GO
/****** Object:  ForeignKey [FK_Usuario_Rol_Rol]    Script Date: 07/10/2010 03:38:57 ******/
ALTER TABLE [dbo].[Usuario_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol_Rol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol] ([IdRol])
GO
ALTER TABLE [dbo].[Usuario_Rol] CHECK CONSTRAINT [FK_Usuario_Rol_Rol]
GO
/****** Object:  ForeignKey [FK_Usuario_Rol_Usuario]    Script Date: 07/10/2010 03:38:57 ******/
ALTER TABLE [dbo].[Usuario_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Usuario_Rol] CHECK CONSTRAINT [FK_Usuario_Rol_Usuario]
GO
