USE [master]
GO
/****** Object:  Database [Aeropuerto]    Script Date: 11/05/2010 17:02:13 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'Aeropuerto')
BEGIN
CREATE DATABASE [Aeropuerto] ON  PRIMARY 
( NAME = N'Aeropuerto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\Aeropuerto.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Aeropuerto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\Aeropuerto.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 COLLATE Modern_Spanish_CI_AS
END
GO
ALTER DATABASE [Aeropuerto] SET COMPATIBILITY_LEVEL = 90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Aeropuerto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Aeropuerto] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Aeropuerto] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Aeropuerto] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Aeropuerto] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Aeropuerto] SET ARITHABORT OFF
GO
ALTER DATABASE [Aeropuerto] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Aeropuerto] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Aeropuerto] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Aeropuerto] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Aeropuerto] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Aeropuerto] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Aeropuerto] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Aeropuerto] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Aeropuerto] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Aeropuerto] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Aeropuerto] SET  DISABLE_BROKER
GO
ALTER DATABASE [Aeropuerto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Aeropuerto] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Aeropuerto] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Aeropuerto] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Aeropuerto] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Aeropuerto] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Aeropuerto] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Aeropuerto] SET  READ_WRITE
GO
ALTER DATABASE [Aeropuerto] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Aeropuerto] SET  MULTI_USER
GO
ALTER DATABASE [Aeropuerto] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Aeropuerto] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Aeropuerto', N'ON'
GO
USE [Aeropuerto]
GO
/****** Object:  ForeignKey [FK_Plataforma_Aeropuerto]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plataforma_Aeropuerto]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plataforma]'))
ALTER TABLE [dbo].[Plataforma] DROP CONSTRAINT [FK_Plataforma_Aeropuerto]
GO
/****** Object:  ForeignKey [FK_PlanDeVuelo_Aerolinea]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PlanDeVuelo_Aerolinea]') AND parent_object_id = OBJECT_ID(N'[dbo].[PlanDeVuelo]'))
ALTER TABLE [dbo].[PlanDeVuelo] DROP CONSTRAINT [FK_PlanDeVuelo_Aerolinea]
GO
/****** Object:  ForeignKey [FK_Pista_Aeropuerto]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Pista_Aeropuerto]') AND parent_object_id = OBJECT_ID(N'[dbo].[Pista]'))
ALTER TABLE [dbo].[Pista] DROP CONSTRAINT [FK_Pista_Aeropuerto]
GO
/****** Object:  ForeignKey [FK_Movimiento_Aerolinea]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Movimiento_Aerolinea]') AND parent_object_id = OBJECT_ID(N'[dbo].[Movimiento]'))
ALTER TABLE [dbo].[Movimiento] DROP CONSTRAINT [FK_Movimiento_Aerolinea]
GO
/****** Object:  ForeignKey [FK_Movimiento_Aeropuerto]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Movimiento_Aeropuerto]') AND parent_object_id = OBJECT_ID(N'[dbo].[Movimiento]'))
ALTER TABLE [dbo].[Movimiento] DROP CONSTRAINT [FK_Movimiento_Aeropuerto]
GO
/****** Object:  ForeignKey [FK_Movimiento_Aeropuerto1]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Movimiento_Aeropuerto1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Movimiento]'))
ALTER TABLE [dbo].[Movimiento] DROP CONSTRAINT [FK_Movimiento_Aeropuerto1]
GO
/****** Object:  ForeignKey [FK_Movimiento_Avion]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Movimiento_Avion]') AND parent_object_id = OBJECT_ID(N'[dbo].[Movimiento]'))
ALTER TABLE [dbo].[Movimiento] DROP CONSTRAINT [FK_Movimiento_Avion]
GO
/****** Object:  ForeignKey [FK_Movimiento_TipoMovimiento]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Movimiento_TipoMovimiento]') AND parent_object_id = OBJECT_ID(N'[dbo].[Movimiento]'))
ALTER TABLE [dbo].[Movimiento] DROP CONSTRAINT [FK_Movimiento_TipoMovimiento]
GO
/****** Object:  ForeignKey [FK_TUUA_Aerolinea]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TUUA_Aerolinea]') AND parent_object_id = OBJECT_ID(N'[dbo].[TUUA]'))
ALTER TABLE [dbo].[TUUA] DROP CONSTRAINT [FK_TUUA_Aerolinea]
GO
/****** Object:  ForeignKey [FK_TUUA_TipoVuelo]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TUUA_TipoVuelo]') AND parent_object_id = OBJECT_ID(N'[dbo].[TUUA]'))
ALTER TABLE [dbo].[TUUA] DROP CONSTRAINT [FK_TUUA_TipoVuelo]
GO
/****** Object:  ForeignKey [FK_IPAeropuerto_Aeropuerto]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IPAeropuerto_Aeropuerto]') AND parent_object_id = OBJECT_ID(N'[dbo].[IPAeropuerto]'))
ALTER TABLE [dbo].[IPAeropuerto] DROP CONSTRAINT [FK_IPAeropuerto_Aeropuerto]
GO
/****** Object:  ForeignKey [FK_Salida_Avion]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Salida_Avion]') AND parent_object_id = OBJECT_ID(N'[dbo].[Salida]'))
ALTER TABLE [dbo].[Salida] DROP CONSTRAINT [FK_Salida_Avion]
GO
/****** Object:  ForeignKey [FK_Salida_PlanDeVuelo]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Salida_PlanDeVuelo]') AND parent_object_id = OBJECT_ID(N'[dbo].[Salida]'))
ALTER TABLE [dbo].[Salida] DROP CONSTRAINT [FK_Salida_PlanDeVuelo]
GO
/****** Object:  ForeignKey [FK_InformacionVuelo_PlanDeVuelo1]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InformacionVuelo_PlanDeVuelo1]') AND parent_object_id = OBJECT_ID(N'[dbo].[InformacionVuelo]'))
ALTER TABLE [dbo].[InformacionVuelo] DROP CONSTRAINT [FK_InformacionVuelo_PlanDeVuelo1]
GO
/****** Object:  ForeignKey [FK_Destino_PlanDeVuelo]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Destino_PlanDeVuelo]') AND parent_object_id = OBJECT_ID(N'[dbo].[Destino]'))
ALTER TABLE [dbo].[Destino] DROP CONSTRAINT [FK_Destino_PlanDeVuelo]
GO
/****** Object:  StoredProcedure [dbo].[uspDestinoInsertar]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspDestinoInsertar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspDestinoInsertar]
GO
/****** Object:  StoredProcedure [dbo].[uspDestinoListar]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspDestinoListar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspDestinoListar]
GO
/****** Object:  StoredProcedure [dbo].[uspDestinoObtener]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspDestinoObtener]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspDestinoObtener]
GO
/****** Object:  StoredProcedure [dbo].[uspInformacionVueloInsertar]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspInformacionVueloInsertar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspInformacionVueloInsertar]
GO
/****** Object:  StoredProcedure [dbo].[uspInformacionVueloListar]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspInformacionVueloListar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspInformacionVueloListar]
GO
/****** Object:  StoredProcedure [dbo].[uspInformacionVueloObtener]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspInformacionVueloObtener]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspInformacionVueloObtener]
GO
/****** Object:  StoredProcedure [dbo].[uspSalidaInsertar]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspSalidaInsertar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspSalidaInsertar]
GO
/****** Object:  StoredProcedure [dbo].[uspSalidaListar]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspSalidaListar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspSalidaListar]
GO
/****** Object:  StoredProcedure [dbo].[uspSalidaObtener]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspSalidaObtener]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspSalidaObtener]
GO
/****** Object:  StoredProcedure [dbo].[uspIPAeropuertoObtener]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspIPAeropuertoObtener]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspIPAeropuertoObtener]
GO
/****** Object:  Table [dbo].[Destino]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Destino]') AND type in (N'U'))
DROP TABLE [dbo].[Destino]
GO
/****** Object:  StoredProcedure [dbo].[uspMovimientoInsertar]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspMovimientoInsertar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspMovimientoInsertar]
GO
/****** Object:  StoredProcedure [dbo].[uspMovimientoListar]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspMovimientoListar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspMovimientoListar]
GO
/****** Object:  StoredProcedure [dbo].[uspMovimientoObtener]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspMovimientoObtener]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspMovimientoObtener]
GO
/****** Object:  StoredProcedure [dbo].[uspPistaActualizar]    Script Date: 11/05/2010 17:02:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPistaActualizar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspPistaActualizar]
GO
/****** Object:  StoredProcedure [dbo].[uspPistaEliminar]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPistaEliminar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspPistaEliminar]
GO
/****** Object:  StoredProcedure [dbo].[uspPistaInsertar]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPistaInsertar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspPistaInsertar]
GO
/****** Object:  StoredProcedure [dbo].[uspPistaListar]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPistaListar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspPistaListar]
GO
/****** Object:  StoredProcedure [dbo].[uspPistaObtener]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPistaObtener]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspPistaObtener]
GO
/****** Object:  StoredProcedure [dbo].[uspPlanDeVueloInsertar]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlanDeVueloInsertar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspPlanDeVueloInsertar]
GO
/****** Object:  StoredProcedure [dbo].[uspPlanDeVueloListar]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlanDeVueloListar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspPlanDeVueloListar]
GO
/****** Object:  StoredProcedure [dbo].[uspPlanDeVueloObtener]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlanDeVueloObtener]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspPlanDeVueloObtener]
GO
/****** Object:  StoredProcedure [dbo].[uspPlataformaActualizar]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlataformaActualizar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspPlataformaActualizar]
GO
/****** Object:  StoredProcedure [dbo].[uspPlataformaEliminar]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlataformaEliminar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspPlataformaEliminar]
GO
/****** Object:  StoredProcedure [dbo].[uspPlataformaInsertar]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlataformaInsertar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspPlataformaInsertar]
GO
/****** Object:  StoredProcedure [dbo].[uspPlataformaListar]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlataformaListar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspPlataformaListar]
GO
/****** Object:  StoredProcedure [dbo].[uspPlataformaObtener]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlataformaObtener]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspPlataformaObtener]
GO
/****** Object:  Table [dbo].[InformacionVuelo]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InformacionVuelo]') AND type in (N'U'))
DROP TABLE [dbo].[InformacionVuelo]
GO
/****** Object:  Table [dbo].[Salida]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Salida]') AND type in (N'U'))
DROP TABLE [dbo].[Salida]
GO
/****** Object:  Table [dbo].[IPAeropuerto]    Script Date: 11/05/2010 17:02:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IPAeropuerto]') AND type in (N'U'))
DROP TABLE [dbo].[IPAeropuerto]
GO
/****** Object:  Table [dbo].[TUUA]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TUUA]') AND type in (N'U'))
DROP TABLE [dbo].[TUUA]
GO
/****** Object:  StoredProcedure [dbo].[uspAerolineaActualizar]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAerolineaActualizar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspAerolineaActualizar]
GO
/****** Object:  StoredProcedure [dbo].[uspAerolineaEliminar]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAerolineaEliminar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspAerolineaEliminar]
GO
/****** Object:  StoredProcedure [dbo].[uspAerolineaInsertar]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAerolineaInsertar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspAerolineaInsertar]
GO
/****** Object:  StoredProcedure [dbo].[uspAerolineaListar]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAerolineaListar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspAerolineaListar]
GO
/****** Object:  StoredProcedure [dbo].[uspAerolineaObtener]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAerolineaObtener]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspAerolineaObtener]
GO
/****** Object:  StoredProcedure [dbo].[uspAeropuertoActualizar]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAeropuertoActualizar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspAeropuertoActualizar]
GO
/****** Object:  StoredProcedure [dbo].[uspAeropuertoEliminar]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAeropuertoEliminar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspAeropuertoEliminar]
GO
/****** Object:  StoredProcedure [dbo].[uspAeropuertoInsertar]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAeropuertoInsertar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspAeropuertoInsertar]
GO
/****** Object:  StoredProcedure [dbo].[uspAeropuertoListar]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAeropuertoListar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspAeropuertoListar]
GO
/****** Object:  StoredProcedure [dbo].[uspAeropuertoObtener]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAeropuertoObtener]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspAeropuertoObtener]
GO
/****** Object:  StoredProcedure [dbo].[uspAeropuertoObtenerNombre]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAeropuertoObtenerNombre]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspAeropuertoObtenerNombre]
GO
/****** Object:  StoredProcedure [dbo].[uspAvionActualizar]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAvionActualizar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspAvionActualizar]
GO
/****** Object:  StoredProcedure [dbo].[uspAvionInsertar]    Script Date: 11/05/2010 17:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAvionInsertar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspAvionInsertar]
GO
/****** Object:  StoredProcedure [dbo].[uspAvionListar]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAvionListar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspAvionListar]
GO
/****** Object:  StoredProcedure [dbo].[uspAvionObtener]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAvionObtener]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspAvionObtener]
GO
/****** Object:  Table [dbo].[Movimiento]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Movimiento]') AND type in (N'U'))
DROP TABLE [dbo].[Movimiento]
GO
/****** Object:  Table [dbo].[Pista]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pista]') AND type in (N'U'))
DROP TABLE [dbo].[Pista]
GO
/****** Object:  Table [dbo].[PlanDeVuelo]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PlanDeVuelo]') AND type in (N'U'))
DROP TABLE [dbo].[PlanDeVuelo]
GO
/****** Object:  Table [dbo].[Plataforma]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Plataforma]') AND type in (N'U'))
DROP TABLE [dbo].[Plataforma]
GO
/****** Object:  StoredProcedure [dbo].[uspInsertarExcepcion]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspInsertarExcepcion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspInsertarExcepcion]
GO
/****** Object:  StoredProcedure [dbo].[uspLogInsertar]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspLogInsertar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspLogInsertar]
GO
/****** Object:  StoredProcedure [dbo].[uspLogListar]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspLogListar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspLogListar]
GO
/****** Object:  StoredProcedure [dbo].[uspLogObtener]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspLogObtener]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspLogObtener]
GO
/****** Object:  StoredProcedure [dbo].[uspTipoMovimientoInsertar]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspTipoMovimientoInsertar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspTipoMovimientoInsertar]
GO
/****** Object:  StoredProcedure [dbo].[uspTipoMovimientoListar]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspTipoMovimientoListar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspTipoMovimientoListar]
GO
/****** Object:  StoredProcedure [dbo].[uspTipoMovimientoObtener]    Script Date: 11/05/2010 17:02:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspTipoMovimientoObtener]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspTipoMovimientoObtener]
GO
/****** Object:  Table [dbo].[Excepcion]    Script Date: 11/05/2010 17:02:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Excepcion]') AND type in (N'U'))
DROP TABLE [dbo].[Excepcion]
GO
/****** Object:  Table [dbo].[Aerolinea]    Script Date: 11/05/2010 17:02:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Aerolinea]') AND type in (N'U'))
DROP TABLE [dbo].[Aerolinea]
GO
/****** Object:  Table [dbo].[Aeropuerto]    Script Date: 11/05/2010 17:02:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Aeropuerto]') AND type in (N'U'))
DROP TABLE [dbo].[Aeropuerto]
GO
/****** Object:  Table [dbo].[Avion]    Script Date: 11/05/2010 17:02:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Avion]') AND type in (N'U'))
DROP TABLE [dbo].[Avion]
GO
/****** Object:  Table [dbo].[Log]    Script Date: 11/05/2010 17:02:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Log]') AND type in (N'U'))
DROP TABLE [dbo].[Log]
GO
/****** Object:  Table [dbo].[TDD]    Script Date: 11/05/2010 17:02:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TDD]') AND type in (N'U'))
DROP TABLE [dbo].[TDD]
GO
/****** Object:  Table [dbo].[TipoMovimiento]    Script Date: 11/05/2010 17:02:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoMovimiento]') AND type in (N'U'))
DROP TABLE [dbo].[TipoMovimiento]
GO
/****** Object:  Table [dbo].[TipoVuelo]    Script Date: 11/05/2010 17:02:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoVuelo]') AND type in (N'U'))
DROP TABLE [dbo].[TipoVuelo]
GO
USE [master]
GO
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 11/05/2010 17:02:14 ******/
IF  EXISTS (SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyEventProcessingLogin##')
DROP LOGIN [##MS_PolicyEventProcessingLogin##]
GO
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 11/05/2010 17:02:14 ******/
IF  EXISTS (SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyTsqlExecutionLogin##')
DROP LOGIN [##MS_PolicyTsqlExecutionLogin##]
GO
/****** Object:  Login [BUILTIN\Administradores]    Script Date: 11/05/2010 17:02:14 ******/
IF  EXISTS (SELECT * FROM sys.server_principals WHERE name = N'BUILTIN\Administradores')
DROP LOGIN [BUILTIN\Administradores]
GO
/****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 11/05/2010 17:02:14 ******/
IF  EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT AUTHORITY\SYSTEM')
DROP LOGIN [NT AUTHORITY\SYSTEM]
GO
/****** Object:  Login [NT SERVICE\MSSQLSERVER]    Script Date: 11/05/2010 17:02:14 ******/
IF  EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\MSSQLSERVER')
DROP LOGIN [NT SERVICE\MSSQLSERVER]
GO
/****** Object:  Login [NT SERVICE\SQLSERVERAGENT]    Script Date: 11/05/2010 17:02:14 ******/
IF  EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\SQLSERVERAGENT')
DROP LOGIN [NT SERVICE\SQLSERVERAGENT]
GO
/****** Object:  Login [NT SERVICE\SQLSERVERAGENT]    Script Date: 11/05/2010 17:02:14 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\SQLSERVERAGENT')
CREATE LOGIN [NT SERVICE\SQLSERVERAGENT] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\MSSQLSERVER]    Script Date: 11/05/2010 17:02:14 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\MSSQLSERVER')
CREATE LOGIN [NT SERVICE\MSSQLSERVER] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 11/05/2010 17:02:14 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT AUTHORITY\SYSTEM')
CREATE LOGIN [NT AUTHORITY\SYSTEM] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [BUILTIN\Administradores]    Script Date: 11/05/2010 17:02:14 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'BUILTIN\Administradores')
CREATE LOGIN [BUILTIN\Administradores] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 11/05/2010 17:02:14 ******/
/* For security reasons the login is created disabled and with a random password. */
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyTsqlExecutionLogin##')
CREATE LOGIN [##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'PÊâ%ñP(.6âteõÖá¾jûd	Ø[æþÛ', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyTsqlExecutionLogin##] DISABLE
GO
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 11/05/2010 17:02:14 ******/
/* For security reasons the login is created disabled and with a random password. */
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyEventProcessingLogin##')
CREATE LOGIN [##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'9ÌLC=å%ÐÔaàG<Ê¦äÙÐw~Ì 1ì3ü', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyEventProcessingLogin##] DISABLE
GO
USE [Aeropuerto]
GO
/****** Object:  Table [dbo].[TipoVuelo]    Script Date: 11/05/2010 17:02:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoVuelo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TipoVuelo](
	[CodTipoVuelo] [int] IDENTITY(1,1) NOT NULL,
	[TipoVuelo] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Impuesto] [float] NOT NULL,
 CONSTRAINT [PK_TipoVuelo] PRIMARY KEY CLUSTERED 
(
	[CodTipoVuelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoMovimiento]    Script Date: 11/05/2010 17:02:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoMovimiento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TipoMovimiento](
	[CodTipoMovimiento] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](1000) COLLATE Modern_Spanish_CI_AS NOT NULL,
 CONSTRAINT [PK_TipoMovimiento] PRIMARY KEY CLUSTERED 
(
	[CodTipoMovimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TDD]    Script Date: 11/05/2010 17:02:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TDD]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TDD](
	[CodBarra] [int] NULL,
	[CodTipoVuelo] [varchar](500) COLLATE Modern_Spanish_CI_AS NULL,
	[Aerolinea] [varchar](500) COLLATE Modern_Spanish_CI_AS NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Log]    Script Date: 11/05/2010 17:02:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Log]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Log](
	[CodRegistro] [int] IDENTITY(1,1) NOT NULL,
	[CodOperacion] [int] NOT NULL,
	[Tabla] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Usuario] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IP] [varchar](23) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Razon] [varchar](500) COLLATE Modern_Spanish_CI_AS NULL,
 CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED 
(
	[CodRegistro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Log] ON
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (1, 8, N'Aerolinea', N'UsuarioX', CAST(0x00009DA9010478D3 AS DateTime), N'"192.168.1.11"', N'Inserción de un nuevo registro en el sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (2, 9, N'Aerolinea', N'UsuarioX', CAST(0x00009DA901064311 AS DateTime), N'"192.168.1.11"', N'Inserción de un nuevo registro en el sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (3, 1, N'Aeropuerto', N'UsuarioX', CAST(0x00009DA901101F69 AS DateTime), N'"192.168.1.11"', N'Se trajo un dato con una busqueda por nombre')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (4, 1, N'Aeropuerto', N'UsuarioX', CAST(0x00009DA901101F6F AS DateTime), N'"192.168.1.11"', N'Se trajo un dato con una busqueda por nombre')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (5, 1, N'Aeropuerto', N'UsuarioX', CAST(0x00009DA901102413 AS DateTime), N'"192.168.1.11"', N'Se trajo un dato con una busqueda por nombre')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (6, 1, N'Plataforma', N'UsuarioX', CAST(0x00009DA901102A53 AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (7, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA002E15BA AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (8, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA002E15CA AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (9, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA0030F02E AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (10, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA00318D6C AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (11, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA00327439 AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (12, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA00328D6A AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (13, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA0032F37D AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (14, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA0032F37E AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (15, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA00342E70 AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (16, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA00342E71 AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (17, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA00343326 AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (18, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA003435A6 AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (19, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA00343A52 AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (20, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA00343A53 AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (21, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA0034416C AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (22, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA0034416C AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (23, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA003449C1 AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (24, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA003449C1 AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (25, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA00345100 AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (26, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA00345101 AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (27, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA003458E5 AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (28, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA003458E5 AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (29, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA0035DA77 AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (30, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA0035DA79 AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (31, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA0035E075 AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (32, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA0035E075 AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (33, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA00360629 AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (34, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA0036062A AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (35, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA005DBDBE AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (36, 2, N'Pista', N'UsuarioX', CAST(0x00009DAA005DBDC1 AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (37, 1, N'Aeropuerto', N'UsuarioX', CAST(0x00009DAA007F032B AS DateTime), N'"192.168.1.11"', N'Se trajo un dato con una busqueda por nombre')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (38, 1, N'Plataforma', N'UsuarioX', CAST(0x00009DAA007F05CE AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (39, 2, N'Pista', N'UsuarioX', CAST(0x00009DAF007AA418 AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (40, 2, N'Pista', N'UsuarioX', CAST(0x00009DAF007AA41B AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (41, 2, N'Pista', N'UsuarioX', CAST(0x00009DAF007B21B6 AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (42, 2, N'Pista', N'UsuarioX', CAST(0x00009DAF007B21B6 AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (43, 2, N'Pista', N'UsuarioX', CAST(0x00009DAF007B399C AS DateTime), N'"192.168.1.11"', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (44, 2, N'Pista', N'UsuarioX', CAST(0x00009DAF007B399C AS DateTime), N'"192.168.1.11"', N'Se actuzalizó un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (45, 2, N'Pista', N'UsuarioX', CAST(0x00009DAF007CBBE8 AS DateTime), N'192.168.1.11', N'Se obtuvo un registro del sistema')
INSERT [dbo].[Log] ([CodRegistro], [CodOperacion], [Tabla], [Usuario], [Fecha], [IP], [Razon]) VALUES (46, 2, N'Pista', N'UsuarioX', CAST(0x00009DAF007CBBF4 AS DateTime), N'192.168.1.11', N'Se actuzalizó un registro del sistema')
SET IDENTITY_INSERT [dbo].[Log] OFF
/****** Object:  Table [dbo].[Avion]    Script Date: 11/05/2010 17:02:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Avion]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Avion](
	[CodAvion] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Fabricante] [varchar](100) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Serie] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
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
	[Motor] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Empuje] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Imagen] [image] NULL,
 CONSTRAINT [PK_Avion] PRIMARY KEY CLUSTERED 
(
	[CodAvion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Avion] ON
INSERT [dbo].[Avion] ([CodAvion], [Nombre], [Fabricante], [Serie], [CabinaTripulacion], [Pasajeros], [Longitud], [Envergadura], [Altura], [PesoVacio], [PesoMaxDespegue], [VelocidadCrucero], [VelocidadMax], [CarreraPesoMax], [AutonomiaPesoMaxDesp], [MaxFuel], [Motor], [Empuje], [Imagen]) VALUES (1, N'A380', N'Airbus', N'Airbus A380', 7, 525, 73, 27, 18, 72000, 92000, 12456, 13000, 2900, 12000, 894, N'Pratt & Witting', N'78099', NULL)
SET IDENTITY_INSERT [dbo].[Avion] OFF
/****** Object:  Table [dbo].[Aeropuerto]    Script Date: 11/05/2010 17:02:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Aeropuerto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Aeropuerto](
	[CodAeropuerto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Estado] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Ciudad] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[IATA] [varchar](3) COLLATE Modern_Spanish_CI_AS NULL,
	[OACI] [varchar](4) COLLATE Modern_Spanish_CI_AS NULL,
	[Elevacion] [int] NOT NULL,
	[SEI] [int] NOT NULL,
	[Fuel] [int] NOT NULL,
	[Operacion] [varchar](1000) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Aeropuerto] PRIMARY KEY CLUSTERED 
(
	[CodAeropuerto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Aeropuerto] ON
INSERT [dbo].[Aeropuerto] ([CodAeropuerto], [Nombre], [Estado], [Ciudad], [IATA], [OACI], [Elevacion], [SEI], [Fuel], [Operacion], [Fecha]) VALUES (1, N'Aeropuerto Internacional Capitán FAP Victor Montes', N'Piura', N'Talara', N'TYL', N'SPYL', 282, 6, 1, N'24x7', CAST(0x00009D8D00000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[Aeropuerto] OFF
/****** Object:  Table [dbo].[Aerolinea]    Script Date: 11/05/2010 17:02:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Aerolinea]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Aerolinea](
	[CodAerolinea] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[RUC] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Procedencia] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Logotipo] [image] NULL,
 CONSTRAINT [PK_Aerolinea] PRIMARY KEY CLUSTERED 
(
	[CodAerolinea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Aerolinea] ON
INSERT [dbo].[Aerolinea] ([CodAerolinea], [Nombre], [RUC], [Procedencia], [Logotipo]) VALUES (5, N'Air Peru', N'20095844671', N'Lima', NULL)
INSERT [dbo].[Aerolinea] ([CodAerolinea], [Nombre], [RUC], [Procedencia], [Logotipo]) VALUES (6, N'Aerocondor', N'20103454786', N'Lima', 0x89504E470D0A1A0A0000000D49484452000001520000007F080200000032F2DDE4000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000206348524D00007A26000080840000FA00000080E8000075300000EA6000003A98000017709CBA513C0000B2EE49444154785EECBD05785C47B62D7C040D62665992C5CC2D35B7982CCBB22DC9B22DB6D86266B3C33461984C920967C2CCCCECC421276606C96256FF6BD769C94E66EEBD93B977FE2FEF1BCFABDBAF23779F3EA7AA36ADBDF62E3D3D4D1777E97F9766E0D20CFC47CD00C4FED2B834039766E03F6A06B8FFA8A7BDF4B09766E0D20C90837F69162ECDC0A519F84F9B814B627F29C6B93403FF71337049ECFFE396FC3FCDB25D7ADEBF9F814B627F49EC2FCDC07FDC0C5C12FBFFB825BF64FD2ECDC025B1BF24F69766E03F6E062E89FD7FDC925FB2759766E092D85F12FB4B33F01F370397C4FE3F6EC92FD9BA4B337049EC2F89FDA519F88F9B814B62FF1FB7E4976CDDA519B824F697C4FED20CFCC7CDC025B1FF8F5BF2FF735BC7C5D11CFE33AFFFE73F7DE982FFDA0C5C12FB4B62FFBF9A01483B174F32FF4FBD3205F1C71A711D7AFFD6F1477B5E763F97C4FE0FB60BFF90BBE4BF11549DC043F2FF997149ECFF18EB7B49EC2F89FDFF6A0648EC7FCFF863997A08E1BFD5D4E3E27F0C39FFCD6D5C12FBFFD5A6FF632EEAFF9F77F5BB649E8FFFFF58E392D8FFB1D6E38FB63F2EDDCF3F9A814B62FF3FF80B7FC86D73C9DAFFC18CCF1F7297FC0FB1FD2527FFBF7119FE900B7A49EC2F89FD7FF60C5C72F22F39F99766E03F6E062E89FD7FDC92FF211DB0FFB756413FAEFB1F8EFF679EE292D8FF3FB35497C4F5D20CFC5FCDC025B1BF24F69766E077CF80BA53EF1F0D7D4DD73F1CBFFBFAFF57E2FD5F5DE792D8FFE196E4DFBDE497AEFFBF9F814B62FFDF2B8EFFFD0CFF1BAE7009C9FFCFC6B1FFD75BCA20AEFB1F8E4BD65E97CFFF5FCFF0BFC3185F12FB4B62FFBF9A814B627F89AEF3BFDA40FF0EAD76E99AFFEE1980553750FFB3031FFE77DFCFEFBEFEA5D8FE774FD93FB18AFA9A0E0375075E31482FB2C2ECA5C1FFE2058750DDC3C5FD76E8697A3016BFD2C1C5B773096C24B6E2BDBEBA47A0ECE38781AACF40DDC30FFC9D1FBF2D4288EBE02E8C8B6F66F177357DDCD288EB61BABC1D435FC30FDDB3D0E3F0358CFCE32CD59F5D443BFFA71CDDC56D77D1B4D0F3622C3D02E44A77297A9C3E3D753FBDB2CFD03D5CB471D9ED75E18B3409AA3E7D35FFB18BEE93EEB68715C95EF4CADF3C7B905F2D075B9A5FFFBAEEDEF865A28BABBAF53194BDF47AD1E07581404543A8BC30042ABA37BCB2C17FA04337D4ED02DD6815A8690855ADC6CA6633F98561216F66A3D15246C34AFADB61296BE607FF49FEBBA60A1AB81486111B62150DA1BA59A0693488D30D8106FFD9CCFFB4EE4ED8BD2DE9355E6D61FFF073CE6F066CEF8B7738EDAEF80E2E01AF5DF4FA776AE5E2DDBEB45D2FEC5BF613EC17976649B79F2F9202DDA22F6DC2DF2BB9FF5E271FB72554B58B95ED78356062A39B14CC8B6EABD1D6E19F50A8A49DCAC5F771897D5C423F17DFCFC5B1C10B21F6192611A29EDCC8A5D673E9755C462D97D22854F699C5EE30956EC330966D33926FC1102BFA858A7E5E1130C95F521CBCD6207DC1C685DBE0E2F013F8AD2D9C661BA7D94143BD8BFE12DFAA9750A71F5F6F10578F2D828D82BD88816DC12B32DD1A277570C91D5C122F3F3AA1E5D772718BD39B2595C49690175AE814FE7EF89BC1DFE979F5D5B8FF7E3C1D8658419303E1C113E92B77E9292FD753EDD253E35671CFF856AB5E7C33867E5C33269989599F189320DF26546CD353F5729A6E1A24E73D5C622F97D8CF25F572295BB8947E2E790B97DC47FF9988E9C59D771AC4751A6A3A2F16572365AF48D54B37CFF408A7EEE5543D1C14341E016F64BDFAB23E3DF91603E516DCB38166C040D34F9F54751B2ABB058A4EB1BCD358D1612AE74797B962C054B1C54CDE8F612AEBC11F4D646D26F21626998D668A7A33459D99B2D6545163AAA8B29656B8456FF28928C5F00D2FF50F2F0D082B0D0A2D0D0E2D0E0E2E0A0B2A8A082C8A0CA01145A3106F82FD0A83FC0B03020AFD030BFD020BBD830B3D830B3D420B3D224BDCA24A5CA34B9C624A1C624BEC634BECA425D6B212334D99711C46B989A6DC5C5365A1AEB5503558291BCDA48D26D26693D83663698758DA6524EF33520E88D45BF412B03F7BF4127AC056C04409551D62250D0379ABBEBC9553B6731AB625923AB9E46EDA12B4D99AB1C418BCE5808EC0F48A347D22553FAE69AC18C08E35966D31920E88E47D869A5EC44D98731345BFB96CC0523A602EDD6AACD86AA8E0A5A09B8BEF24414868C37273CAA67F4DF2FFBD628F2784CC1B297939A1C7C62EBFA00B2F921026F664AB998EE4773F36168C1509001B4CF2F1AF89ED5C722B97D2CCA536E20D76182FEA46F27E483B2FF0B814C9FC92D95FF24A48F5322161CB4037A3B3FCCCFA5D907C5EF8B7E9C43EBE5E9F190498023C089E08CB0C212433C8BB270910A71E2E890D76E7BCAD5E52674C6875F2CF7B22BCD8333781B6C5A2265A12FB7E987492221589D0A2618455C19CF05A89DD1BBB02EF8918685A3198D984FDE43D20521CB0C69CBA9386A65327F9FCDD2674D38867230EFFC4467C3BBFA1E9B9945D9CA2535FAE1B82B83E7E18687A756A14AA44DD6D94BCC338698749E256E3B801135597A9BCDD4CD2641155EF18DBE02AA9778FACF58CA8F60EABF00B2DF70B290D0C2AF5F3DC10E4B931C4BB30C2B748E25F240B2A51059768428AE3438A92820B52430AD242366484ACC758199ABF26685D81FFAA329F2C8C72DF55953EABAA7DB26B7CB2367B67D57967367865367A6636B1D1B25C373A7CB231DA7CD6B4FA66B7F8AD69F4CFAE0B58B33928BBCC37B3D82FA3C03F737D60467E50E6BAE08CDCE0CC35219949011909819909FE2B12FC57C6F965697CB355BE394ADF7572FF0DB15025FE25A101A541819B0282CAFD43AA9687D738486AAC633763584A695848EB4CE575C6B27A7810D81B50BB1CD936CC242616AB0915D0C2C53770714D18FC96638A953C2343452F845920EF13C906D8806C0FD0DCC6D12242D71BCBFB8C65B4A5B18EFA9A01B285A4A021F3EDFA092DE4A7A81AFF8862CF5BFB45F3B828F6BC855CB4F61784845CF40E32AA7175024D3DEC2AA90C45177B78A8C36D46B21D62D92EA19C8640B1CB40C12C1EEF022C0D28D70BC69CB40C938A457F4CD32E56B52EF97878CFEB230CC88C3E5B15A69896069CB425EF9749328410169856620B069938D5166678D9205124F5B424F6BFB1F6BCC1BF20F6A4C55AB9A445B1271DC4BBDFBCD7C3E43391F98A086AA020129B99BE6B26C59784BFC021C42D314DB7A8ECE043EA3C9AA4462EA1515FDD62A86A3354B663E8AB68E8A9D9D654B7D150D1A0BFABDB30D8DFF97B587410A02312982F403A9AF9B49A765C50A06C1329DA0C943038D59CBADA50550DE3EC20ADF094940487174B82D7CBBD5627796466BA67AC754BDBE09156BC3CADCC3375B347FC80BBEAF265B22B97C9AF5D26BBD155799B8BE2CF4EEAFB1C95F7DBC81FB1923F69A178C642F9B285FA550BCD9B16716F5A2ADEB08C78CD3A04E3759BD037AD43DFB209E3C73B76117F3F3EB009FFC42CE07353BFCF4DE9F553B3804FCCFD3E360FF8D0C2EF23CBC00FADFCDFB70A7CCFDAFF5D9BC0776DFCDFB6097CDB26F43D1BD57BD609EF58C7BF619DF09275C2B336F18FDB253DE09878B3B5F25A3BF54E0775AF93A6D555D3E8A6C1CD6FF24AC9F2CE4CF45DA30CCC890ACEF50F5FB72C2ADF3666A3A9ACC4505AA22FADD493D51AC89B44B2363832E6B27E13055424C4BE89849F762673FEB1A018BC6747036B3DC0C656E6E4C21BC58731DAB8448C765A688CD42E2EA593DEE02F1AAC698B58D104830A91F9BD1E3EC529FFC277FEF9AFF0BB6449AE783F9F1C63DDFEE66DEC85A01A9F2781D7D48AD5756255239E0AFEA1B1BCC754D64F6E7CEC2ED3D8DD66314BE37238B1341169F5E4F663A4C0FE3793144196484E5864C56307BCC4AA7AC4CA2E2385CE3123A3ADE2E3499DD893E4338719838C30D6E0221700E20D2137506E1328C87FC610CB77C097E65FA195848A2D704F96E25E5D8CBD68F67FE3E15F085B70C3F1A41317A344B6272069C958698C0E2E85393890F9443C66259756C1A5D472898D24876AA8A12D42F90E0CDC151C04125AECB0647CB2964BAEA32DC2645E8057451B3F84F25608EDAF86B245A06C21C927FF0571412FBDD2A6EC344C68378A6F3192D598C756D845972D8B2CF6092F0C0E2B080F29880CCE0F0AC80A0FCC8C0DCE4A08CE5E1592BD2124AB2A30B3C537A3CF33799747C2F56E9ADBDD54F72C533EE0A67CC44DF18CABE4353BBF77ACBCDEB5F47ACFC2F33D33AF0F4DBC3F16FB7C26F2F9D624E47BA3B01FC5E13F8B230E88A30F0A638E8862F71B49F658447C621DFA8955F8C7D6E11F59857D601DF69E5528C6BBD6A16F5B87614005BC614BE3753B7AFFA14DE827D6C1F4955FBF7E6C15F2B155D0A796F4BAF4FE338BB0CFC4E15F8822BF10467F228AFA4814F5AE38EA2DE3A8574D225FB793BD602F7DD231F61167E95F9749FFE22EBDDB5D7EABA76AB767529F4F5ABB4F5A9D6F5AA97FFABAC015997019C2B2A4812BA382B22382734243D66166C2838BC2838B834237B94556C141B0976CB68BD96C13536729AD630E428389AAC958DD04DB66A069866A26EDA06EA58137A42998E427B570C94B8379859A56686D03459BBE148BD8210298F24FE06B7F2FB0FF5EB167B0870E0C83CCF363D1F62EE24C3A7889D77C64A9785F8859691E5222979585B8FDB0FCA6B23E0B698F656C8F556C1794026D71184048056F00317431026221B8CA10D46DFAAA1D064A480573105408DA31B6D1E04DB486C1073AEDC383253A3781D93D2860987138D5E4F6EBA97135B2F3089EE18398C56EB38CD96213BDCD3E6A8B43E436AB987E68161E1EFB0D5AB9048C5D00D87827907C13523A706D48C729A089C8A8D245101942E053F180BC47D0A897506B90B04990502A88AF3488AB23C79E028D7E3C237B2EE6F9E3F1931802925247C20F8713D1B8BA17A89B40D12D92771BC93A4D64ED7C506D246F132B5A44F2664365A3BEB2415FD1621EBFC35CB3D354B5D544D18D90DB5C5A6B17B3C935727D48D43A4548566640FA46EFC4CD1EEA9E65CA1DCEB2EBEC631F72563D61AF7CC251F584A3E209A7D8271C254F3B443C671BFA8663F83BB6419F58FA7F61EAFDAD78F9F702B77D062EBFE8B91CD473DDAFEFBADFD0FD67A1E78F22EFEF8CFCBE3509FACA2CE4639390F7CD22DEB6887AD542F2B265ECF396D267ADA40FD9296F724DBF7C79D62E8FCCEDEE2BB6B8ADE875CBE876CB68774B6F764D69589656E79656EB9E56ED9E51E59151E191B9C933B3C8276BA35F56A16F76A16F56B17776B14F56A97776995756B96776856756E5F2EC6A8FAC6A8FEC1A8FACCDEED9F5EEE903FEC9DBFDE377F9C55FE19B708D77C29FBCE36F5D1E7FA787E66E37CD3DCB547F75553DE8A2C478D845F5988BFA6FAEAAC7DC958FBBC91F77953DE5227BC651FE8C83EC197BC5938E8A479DE4F7B9C86E5E26BDC25DD2B73CB2C933ACDA33B8C453B6C13B2FC7AB3CDB7BD30A9FB264DFD238BF127940717450497878997F54299C2397D862FB9862ABD8228B98425349A9754C93654C3B9646445A18EAA0495FDD24503519C95B8C635BCC623AE0448865039CA497536CD74BD8CD02E1DF9D1FF9378BBD0EF6D421E13AC967C8272F06E46FF0DE0EEFD012AAA47B865F21E43AE094225828482355A3B192B01F231545DD5C02739279DF7ED14FE6116F88282FF624F924F340E9767009FCD8C6C5636C59C40E79C927B1678A89D7565D0CC7E2C105DDD0F9F94A600A4C07C5F659C5F4D94AFAECA3FB2C63C9A1B818155F5A928BB5F285478BC32474C0DD800302813793756118CBBB98E433A5403E1E1FC2C0016904B22888AB15C455230E02D600DF6431B4231D7791FE22E49269CF0E4E3DC0A9B673AAADE4A7201C50F71AA9BA8D959D46B12DA6B10D66B03F925A2B498D4D748D6D548D6344955F647568585544E8A6D890527570415AD0BA5CFFD5A53E2BDAFCD2B779265CE7A6FCB3B3EC5187A8676DC35FB109F9D83CE8A0D0FFA4BEEF0903DF43865EFB059EDF0B3CBE15B87F2574FB4244E34BB1FBD722F73D421A7B851E5F1A797F64012B1DF1BA75E44B3651CFD84A1EB593FCD55176A793E25A7BD9654ECA2D2E9ACE65F14D6E09B56E0935EE49C5CB33727CD667FA16A7FB16A5F81424F8146ABC0AE55E1B63BD0B62FD8BA3034A23033785056F0A09AE080EA9080AA9F409AF740C2BB5892CB1892CB58B28C17BA7B012E7D052D7D012AFF00AEFF0729F50421902832B0243CA83822B42830B437CD3227DE2253E0932EFC478EFC454CFA4551E49B9CB12367966547BA4352C4B697149EE7049E97149EE774DDFE19C7C95A3E64607E56D76AABBEDD50FDAC53D6E1BF7AC8DE6795BF58B8EEA679D144FBACA1EF690DEE71573976FF4AD019137FA2BAFF55A7D9567E1659E053B3D370E786FE8F659DFE69BDFE49F57E5BFB62C60CDC6A0D579C1D9D9D0A7212B3382B33202D7667A15AEF0620A22A058195C280FD9A80ADAA80EDC981450A4F12D56075649239B7C24CD404F00221A24FD2B32FF6F77F21964C522F9C58407833175830F4B74181EA21DC0E00964DB0166B01898570AFCD6873D67E60BCE6D4A25975CC1256FE2924AF51337093510FE4644046CB0948C2E56279F994F68FDCAC026F770A93D5C0A06CC29B3A800E1F9A08B448534CB85EC91A21D3E85ADA40BAF1652722E1017404AC967D181828408B040061006A933DD13FD5DE789DF642EF99C1FFEC8901B4431BF1E72087F0F708DDF84210C7760FEFF52C0CF806286E103A7202804973293F65BC46CB394ECB090EC164B768BA49709E4BB0DD43BF5E2B7E925F61B24F508933A058A5A536995BDA4DC33B22224B43C36B85C13B869855F6E81AFBAD62BA2DD236AA76BD46D4E318FDAC6BE6A29FFC84CFA958974AF48F29D28EA3B51C41EE3B0CF4D423E310BD963ECF70B677B92B33AC9D99CE0EC8F71CE0738B79F38CFAF0DFC3E310979C732F2457BE9DF5C94F72DD7DCE91B7F4B40CAE5612BCAFC52738256AE0A5C91E19F0E204DE69F11E9BF2230302B282ADF5752E02E2B729497D8C84B2D949B4C95E596B20AB7C87AEFB0C6E5614D1E614DCBC29A9DC39A1C429B6DC35A1C62BA6D63BBAD637B2DA584789BC86920E3204CEE32486B31486D334C6D11A6B489525AC4C96DC6492D466A38D5E45A9BA91A2C154D968A062B7913868DBCD94EDE6CAF68729037392B9A97C95BDCE5CD9EB2C6659135F0CFDDC32B3DC2CB3DC3CABDC2CBBD232AA15CE4DE65891E2589249965E97E9B32034AD70494E607141678E5557AE6B678ACDEEABEE65AF735B7B9AFB9C763ED43EEAB1E724D79C425F11197F88BC7632E9A479C548F3A62281F7150D070943D6C2F7FC246F19C48F5BC50F39491EA5133F90396D2BF5A491E60E37E6BD91DD6F26B5D927A03566D085D151596E6129B699D548CA0F80F67ED75624F124592CF273921F69010960E5D4CE3D356D6893D61981472B37FC52EE7F3F388D811B7A7205EE525BF9A097F259C5E88BAB102EE31803A1A40E9FE1EA85B8AD8C92F2007988F081681404201682C26577477887B809C5BC576D8C474584ADBCDE494928046A0B01FD741A40D65C40F1E4AE0D1047AD27FB6AB2454127319FAF934040FCB89157D907933297C07C432A46EE090538A88C036C03FBB38B876F056908783739480FB419601082881C9980A33590F641E026F197DA585E44A63C94EB1742BA58894BDA69A2E2B4DAB83A6C94355E31951802854ED9FB7D237B7C833AFDE23AFC33D6F876BEABD7E314F78FABCE8EAFDB69DD757A6DE3F0BBC4F71DEE739DF492E6082F33FCFF99DE27C7FE1BCBFD5F3FC54DFF313038FAF8D7CF618FB7E6DEAFF9959F04796916FDB485FB0573EE69C78ABBDE632E7A476D7B40AB78C1CF7F4148F74A5477A884F96474CB19DA2CC5E5161A3AAB2D6D498C56D364D68102501F46AE0129B289AA5B8A6834BEBE2D209DD106A3ACC156D664801AA3A4D555D481698687AC571FD885938A47BE1CB6068B6729AED34E20077030663AB433E20036890E8C240C62B9E86417C9B611C0DA1A60D193803F5567DF54E7DCD767E2088C340E80715C9C5E1B25B58C292A2240C03798F6D6CA74B748793A4C331A6CD51DAEE286D758E6DF4903478865484046E92FB94A47914E4B96C2C71CCAFB6CF6FB45DD5EB9C3CE0ACDCEAA2DAE9A2BCC2457D8D8BE60617F5CD4EEABB9CE3EE758ABFDF51F3B083FA6F0E9A271DE29E71887FC12EFE2DEBE477AC925FB38B7FD941FDA293FC2527D91BF6B237ED646FD92A9FB7553DE4967643C8DA9AC8D5CAF0B465D2749BE4A23FACD82F5259C8A1E5291C4CAED498F10E429509406EE3E2DA98ECB5718A3A4E55A7A769D04F68E2125B68FDF89583CDE72910849353425E97FF50EF10D0D866A81EC0A0C4D5220F84106C15A1CDC8731828EA3004F23AC23F154D6279A358D68CB0D608C9025527A011234D3FF2A8C89418C8FB0D645B9088D6576C07508F9495617C977E52971E9C9164E67203214F6CE032DAB90CECCE4E82DC706FBCB4C33D8170C21788EF3448E8D22394019933F68C78C30FE6F8D01F816EAA3B291B8C504D01177D804BDCCA2503CE85374EBA808F1D6C247D500150074CE6B117AFE6D4D7719A2B39CD2E065E74EAA99A292C97D71B282838D75376E929210CBB38F5E55CDC4EC3845E517CABB9BAC14156B53CB2242C78BDDA67D5CA65A9359E998893AF774DBFC725E309C7B4E76D535EB54C7AC74CFA99C8EB5BA1CB4FC2650744EE470CDD4FE8BB9FD6733FCD791CE59C8F722E8738B7FD7A1E08CB7F32F6FEDECCE743DB88BF2E8BBBC62B7D87577AC7F2B4EAE5E9EB3D3356F86469FC73A28236048515C342BA45D53947373B48DAED255DD06222B8A6C09FF9815C806E74182A3B91E7D70DCA6CB1A16C3788079C51A14FA3523FA11A03BA1E4C0A2EA11E60874EB6F9108FA96FACF86FD14A065E8AFFD110293AA16A69B963FB39D900ADB87A27B945AA1DA2C42BB8A86EBC11245DA5AFDECDA97672B2AD9CA2878BA91029CB4DE26A3949A9B1AACE221E8C8346EBB8363088C01DB29136DAC7D63BC4D439C6D43A4B6A5D24956E92527749916754914F64917F4401A0D0C8E00D31811B90238CF7C94FF6CA5BE1B56EB5677E8EE7BAFCE5F9EB3CF3F3FDF3F382F2D786E4E48664AF0FC92A0D5A51EFB3A2D363E580CBEA7EE7B52DAE1B8B3C4B12422AFD62379BC737E927B5F114B8DF3BFEBDB1FDDFD3D798E43356134B26F1F9241DB6CFF310544D7AC846C26B8D6F314868D74BD4890A178F5C0885D90C48DF21906D1749778A64DB19A24EFC1C984D18498055E6D2368BD81647559B93B2C545D9E8A2A87393D7BAC96BDCE5359ED22A9FC84ADF480A02914FF68CDAEC1E5DBF2CA6D145DAE2AAEC7654F6582B7A2D147D609290D3A8DC222263C254127655521BC1AA00D8D25AB954968C259B0FDB82747D3F9788040CAC0D907C0AD77594C48B19818B62AF23D5E1A96974EA2980CD007E1FE092B670A90334C0A8A14807A80124BFDF32867C01E014500764E45557EB2BAFD557612F5EC60C147EB797F088F80ED8311671B4029067E87DA7B1ACD129BAD82F22373A3C373524A72030BBC53BF372F7D43B9DE39F7054BF6623FFC832E64BB3C86F4DC2BE1307FF200EFC59E07B887384BB7E9C733EC62D3B6CE07140E8F583C8F76B63BF8F4D03DFB10879C52AFC299BF0876DC2EFB50BFFB36DF8E5AECA755E19F181798AE0755121EB83C20AA0591C62CA2DA535C6CA46043E444F20D001F6134A6A372923D5563D551F3FF4897D44E22D50F4E279318C14086D2E443D803921E42CA6C3807F57CD25557389C862602C4ABE2EE7B2888C2ADA88FFC306004B8659D2807E67840B1D798CE595292E03C62994F508A4DD0632964857F7C3780004C1ED09E2B71A25EDE662BBB930188F6DC689971BC6F599AFEA1467D4192456410199AFE834826F12B3999337B1887211ABA22CDD62E28D8F1F5908097712DE227C4670932CA44DB6B18D0E31F52E31F5EE9206F80BDED18D9E927A680AC7D84D0ED2524779B1AB6CA377CC8688F00DCAC00D197EA52BBD2BD3BC6BE5014DBEE19D5652645BB01F0674A4AFDF29F9FF5EB16701EDC564DB0B6A09E9623D25E58A0DE33AE0C8F143A486E125EA121B784316980236650F5EE90D40291A036C6C059909344C5EBF42B92E8BAE5E1E55E113B12920AC3828784378607E74408ED46FADD22F5BE39B15E79395E89D95EA9995EAB13279F9AA04CFD56AEFB572BFDC98C0FCA890C2A09022EFD062B7D0628040B6E1655611E59611E5C6D195626503705481AAC140556FA86ED0871B022C0DC9150D7C10208800F07881C786DECD29B76367E0892813A6E2F331702C3B0C123AF18AB1C4F3257440DD46CE0EE834C8DCA60C70E95BB8F45E2EB59BE29DB84E080CEFF0C30121C981CCA76CE312B789143BCDA53B8DE53B05102138FC49BBB8941D5CEA162E11F41B887DA3B1AADA56B6C92DB6D84BB2511A9C5DE19FD1EF1E0FF7F20E47E5E336B2B7CCA2BF360AFD59E87F44E873DCC0FD989EE3113DBB9F0D6DBE13597D636CFDBDD8FA88BEF5713DFB4306CE3F08DDBF30F27ECB2CF0299BC87B9C64D7BA25F47967D4FA67E507AD490BC99387E48787ADF78E2AB28CD96424AB427ACF585A6306060B08B3F2162BC41A724A4CF0A4261D1301FCB6380A64180B03AFA4A921E48C83D8255477C301C4D4417991FE4A68A149C6205E03C23196AFD6C9CF12159258833A5213E350C0D7237DA7A2B436862E31C6A7C4746970960C870627254EEFB1B86279BD505E2752D4031E126928A966A86EE2F097F856A3F8368290D52D56293D18D8069CA29A93957361459CAC9658A7A0E5495B45C9DB994DE207C15214CC32B8074F87C7644A8D9E14F9630CFC9DE2DC452632A35A51260F11AB99B41E432CDF2C526D1668AA44EA0A734585BD144E53EDF2887AF78856A7C876F318A245126B8B30E97F05D5FBB78BFD2231768994B648FF669B9E4D0DDC6C44D194B4406EC9286E9B50B353A4DC2A96F59AC4769947B7DA44353944D4B984D5BA85D6788682F255E51B56ED175EE31F511B19569E18B27145504E5640CEAA8035C09CD7FBAE2AF25E091876B337C85B19ED1EE93D1E29031EC95BDD9276B827EF744B86ADBBCC2D65977BCA768FD401CFF45E9FCC2EFF95AD41D9357E2B3705AC2A0ACC5A1FB42A3768D5EA2064A1D7A485AD5346964B22ABC2C3CB83434BFD428ABD428A3C428B9DC34B9D626B6C650D083B1175138390687348136C03B912FA0BAE26936A8A5F2E16F845469D8E7C4EA42EE80E783429DD44C6A060A1958F7778A780B94B00F0FAB864106921F65BA0FBCC14DDD00864FFC15F26A62D1C846E4E566F125BE91A551C1ABE2E3964755EE08A4DFE69DD1EEA87DC94AFD845BD6315FA8949E0F7429F837A6EA738C741CE7688B31CE2CCCF7226273893437AA63F0BCCBE175B7E6362FF8D79C0A7966140E39EB18EBEC73EF62A2779877B7CA94F6A86FF4A6948AE6F54216C9189A2464F5DCF69C03C03D40A4C94C924B3667876634DBB295E19DA827D0C6A237C371E10C1E3430010BF90D843E6491E78FE621785D9CC6761F20969479CCF427DC22F1879E902599BD2AE7C10CEA76659769612B4C45C50F62EB5FD58E426320222288998A524368836CB466227D26386CACD1802551DE06111D862EA1AB08F2C539B8CD4955CF87ACBB86AB7F4566B65A5B9A4C428BAD420B2D226A5DF44D36DB3623702404EDAC9C576EA25005960642D964EC3B2129B5305F27F2BA936224A6FE129551445F21C67DE1C3266041B58742C779B48DD062D0357972621A5894B69E0921BB824B237226513792ED0A40035E8E7581EEA8F99C063A4342A08B9F09C14F1C20250700BF1C09398CA5ACC639A2DA39BC431D81CD8E5A08BB60B158D5631B56E91E52121C572FFFC14CF356BDCB28A5C33AB5C321A9C57B4B9ACE872C9D8E590748FA3F251BBA8C76CA31EB78D7ACA3AEA19ABC8172D225F360F7FD322EA5D8BE80FCD223F358BFAC234E22BD3F03DA6E15F9B45203FFC91298D0FCC42DE370F79D712C40F627DBC6115F2AA4D0892522FDA853C6F17F6AC5D2806C0D59B5CB2772FCBDFE694D3ED98D5E4B0B2D269E5C66559D99EABE37DD74605AEF70A2DB08BDE6422AB358C6BD14BED3548EF87B5A1D8524DCE0BD92E482F93FF8BF90BBCB263A50A48041020877C24989EC8A2D945D7DA80F8A96800F5928208A221237B0FBC13D94DD87C4C0ECBE1432A78BC4AD32852D5C11AF88717039F5BEF99D9E69A728383FA111BD92B96D11F9B857E2EF2FC5AE8BA57E0F2BDD0659FD071BFC0FEA0D0F6B0C0F69081F561439B63060EC70D5D8F093C8E0A3C8F187A7D6912F590ED8AAB5DD66F59965FE7B96E9D4F5E42D0BAD0C87C3769A1496C01A72CE134955C5CCD850007669939AE645755CD9CBA91833A88ABE3E237EBC7A390A1D620BE1A1403715C8591A6C2585D61A4AE3500D502681C0DF07F1787AAEB221231231102EEA1B14897D2954B2CB22117C59E493E0D38E1BCFCEB29B75F3CE07FE9066531B773EADF0CC081D86CF821685BF22F0C121A0C359B0D15E59CCF4A41441EB72C41DF2BC5CC2F83739019B9684C3C5670B6D966A1AD9CDB26A3981EFDD85E51D22EBDE4DD5C32435829DC8312245615312CE22B31096CDB33D2876E2C113AB73235D1CF4105003244DE97660361119429E2973A8A62C0B6A2EC151B780F4409DC8D7896B5D1E8F6D81F91AE837BE26BE374DC755D7E9EE1F63071716415C5B256C8BC6D74B353648B73549D4354994B74A14F644154C4FAA4D0DC9CC035953E2BDB3D52777BA4FEC9251EF8E7FD94F6503D456952D5CB8EF2776D233EB60EA5011A966518D2C29F6098877D6812FCA149E847C6343E360AFDC438EC1363C87CD8DB46416F1A07BC65E4FFB6D8FF3D23FF0F8C023E31F2FF54ECFB99C0F30BA1E71EE172A497BF137A805E82F1B5C0F74373F9EB1609AF98AB9F33573E6EA9BADF467DBB7DDCD5AE493DEE69555E196B7D57A903D68404E70118778A29B391559B481B29928477A7E914817DBDE8F0F3C2BF98EA239937567598A85A8C55B516D272D7F0B2C0A04D31FE15B10195E12195CB232B2DE04C22820501311D590CF26FC9135621686CA21D105F0B8B642D2B07DF2326BC202320A73620679BC78A3B1C344F5BC5E2C17F10061C33F43E65E07190B33FC8591FE26C0E73B687F56C0EE9DB1E32B4FF45E8F883D1B23D261E9F9AF9BD6719F2AA65E4B316918F9B47DF649BB4C965E30AAF5A8D6F7554608D5718D1CB8C949B69238220881C2A522AF08DC9BC13BC0AE4129C3FA074A0FD192A18DB0C6545092D7A3CB908B50C54C24456D4485507004C0CA5003A30C848FC00FC490338280631FCF90115B034163DE725179ACA342E0C5D31E2E25FE001A9B6FE66E829B7FE66E82BB6F2037F674C2D56ADC47C0DC3F8264355AD4056AAAEBDEE4F2FFF74DFDBFBEF79E9DBFB9FFBE2AF4F7EF8FCEBDF3EFAFCDE47DF1AB9ECFE839E49DB1CE380C57698A5ED2437241A282F2A9A78B1474882FFACD34BA826E98591A39CCBE280DB420430F6CA6AAEF81C01893D493E9C269A3A1A44E9857287BFC3A78D18690F2E00A0EEB826C49B083F61FFFF98E45CAA06D3D5D8E82AC030352C5787C1C4DE58DA6A1DD3E212DDE629E95486D694C3F776925DE62CBBD159F6176286443F6B1BF9AA75D8FBB6E1E05D7E68138CF1816DF0BB76C1EFD807BFEC1CFEB073F43D2E527048EE7496DDEA2CBFD15971BDB3F22A57D555CB932FF74CDDE595B1C33B73ABF78A7E9F957D3EAB68F865F5FBE12FE93B3DD3AE5A9EFA278FA43B9725DEE71CF788ADFC696BE92BD6316F5B493EB6927C6E11F59579C437A621DF8ABDBE37F2F8C1C8EB3B63AFBD263E5F83E96D1E08EFE079FB98079D1437B9C66D5F96DCB42CB5D42D237759A6DA3B6759742D02161E40E233FC3A6E2223BD139B5DBD28F3CA0E24909D94953ED1C532FF2210B92ABCAB2B7D6AD6FA54C8034A5C6240C5ABE0D2AAB90C68FA46F8058ED1ED0ED11D860A541F355A4B6B0222CA5202376EF25EBB63D9CA3FDB25BE60ABFAD02CFA5B71D03EA1F74143B7C3FACE870D1C318E183A1D337039A5E77296731EE25C063997D39CFB01CEEB4B41D02B26917FB189D9EEACA8F08C5F1990AC084B0D8ECC718DAAB28E26CFCB4C42B430D0CB450A54F5E9E855BA9A42B6A66CE85C74AA0E64B5B4405E049A2DC2386207F176186038D50B8228053082389130E0B471D968A1C1AC3A8F482FD61A2F05EDF8094AE8F283C7E1966675B18682C03C1A3ACA16BC653660C3F9A1B9A07097FC2C56218685E8D247F58B723B5E71E762E453D5E02C5619C514565DFFD40F33DAD35AEDA0563BA6D54E6AB5B35AEDC882F69456FBD70F4F58C56E348E29D48B2C348E6B84E12556A5CE69670917BEC88A6A4F74251E17157AF0D596EC559780C07BC6C6C5886B43F6C720BE8758554AC295A9324F4EAC505D10817807D10A79CA845C107EB15800FEBBC0FCDF17DBEB0A45740FB6586AF65F374BC42AF2210DB68B8E7B0354863422AC16597B5809F3D846E7E8FA0049A324B62937ACEC3AF7C4BF39443FE51CFB9C8BEC2517F9CBCEF2171DA52F38C43E6113F5A84DF4FD76517FB18FBECD2EFA4F0ED1D73A446D7791367BC65779275778A7947825157825E57BA6ACF64ACBF05E91E49315E7B75AEE9723F5CF05B017E5BF36820D49C0BA98805C99EF5A8DF7AA14CFAC951E2B72DDD20A5D53AB5CD29B9D537B1C537738A55EE9947CBD43D24D767177D8CA1E768C7ACA21F825FB90B76C833FB20EFACCDCFF0B9380CF4C02DF15F9BF6912FAAA95E47950539D34F73BC5DDE5A8D9E99E9AE5958D4294E0908D5EE1852E91E536B135E68A16587E86DB5350837C0FB23BC82644059728FDD7A785E6E6FAAC6874C9BCDC65CD9D1EEB6EF55CD7EB999DE39D191CBED64255C4480AC4D847D1F8B2A83AE4C33CC24B83420AE3FDF2367A64F73BA743E05FB552EF3193EE33083CC6799DE45C4F720EC7399B237A1607F44CF7EB9B1FD27738A4E77254CFFD88BEF711FDC0FDA2886F4D64283E79D03AE92AA78C1A8F95A97E5981E16BACA4EB0CE20AB8A4728AD561B81085E19E55DD5838A009D88280BB45D25E712C0D91B44724EBC2002D1C6139112E619F153DFA32D4E1F62113865C170A84F595BBF554BB5126CCA9D840421128148481B766BA414FB75497C680BD5E7E0025416215180195CAEB90022A9D5AACECA01A4A5637C1CC239C111A780393C8D001D8493298A87EA3C05818D720D2341861106F870D550B9C32D4C0216F6728DF2A52A282B0C74CD96226DD64199D7FC74B7BCE30993F37BB30B1A03D373A3AA7D59E5FD0FEB2A0DDF9D4C79C5F92755C9999BA52ACAA41F98D7122A56F58DA62892EA98BF329B772A19E5F57D88FC84E57F4B14430A5D88D61964073552858EE154B7BCC24BDA6D17DC6D103C2980164A9B9788412284201800FF8B683CFDAF0B3B1D4CCE26256E852051AFBA32ECAD651D77E9F92A0225380C6DBE895412C9442A792F22E80F03C3EC9A78E08CC44E5304AAF95DB0C555BB184E4EE0201C232C4A386044E4B27165B18DB681D55ED1B59AE8A29CB516C6A94155EE19F7EB367E275CB93767B24F77AA4A3A6B2C26BF5469FBC6C9F0D29FE452AFF124960595820312BFD438868E92F29F58F29F49314F848002C6F581E5DE02A29B28F2DB791D55AC8EB97AAB82D14B556F26A38E156B27AE457ED63EB80C9B949AA96C754784757F848AA03623607C5D405456F0E8DAA0D8FAC880C2D41E6392A705D6C78813A64FD2AFF1C30BA079665DCEA9CF237FBC4976D35AF99C4BE6F2AF9CC42F2A565C4D7E6C17B4C7DBE35F6F8C4C2FB25D7C8BB3D6276B8C7567A28D3BDD2228372DDA2AA81FCE953650B26A1CD595E931051581BB0F6468FF407DD92EE71933FE618FDB669D8E7C6819F5B7ABFE9E879FF72DF2DA11285AFCC35669D002E62CA6EB166AB95B2D5515914265999E5A1EA58A6BAD93DFE3127D56BE6111F0B02F61AF81F34F43FA4E77B94F339ACB71C427ED0C0F680A1E96103E1613DD161CEE617BD65DF8BFC3EB38C7AC55173EFB2E41DAEE955CBB2D29765C7FA6EF00B2B7192A2C8BC4E185FCF2561404E58DD282B91C67E02D246A40625126C8B75CDC48CE8622697C0673C11B933543AD96D98D0AF4F1B83516854F0B7298647C1BFBE0A05FCBAAAA745F225B3753A5E0D952101C6076B188500002C4D941DC62A205BC4AB03A66DA4680013095817DB428B8D0316CD29234AB17DA5413002B1478C4DD827AB66A3AA649ED02D52365071971A405D0B2E05F005B7841BE3A29B8C5291A8A750D44CD36712B3D95156E9A9D8F0E3A9E97393D37364E327A66686B4DA29BC3F3DABFD51AB5535DD2952568B95201A3573D21A23C0997268163E0F0DDC0A4821AB6B860BA0A41A1B22D56B9A451A3005C113015BA409CEF9A2FE5A446DA98C1F770E854B85B7008608E7862F8C57358AF3510DCD7A4F40E808DD4478D5214C68334EC0A3D50BE1F3C34D800B8018102889A6C7301E2279C13922A237C5327C852833C0FF92D8634E2F883D2B95EF12C8DA310C3014984D2AD8C68D1A208F0D3E3C28109A7E6C2012FB38883DBC3BE836728460EDADA26BBDC3CB6242F25343D6AC0BCA2CF549DFE49556E095B9D67775B27F9E22A82034B4DC3302CC87265B29B1D6018DC27D802A014547A019809F030C56A0DE2C5456632030235409080D69447844A06D619A809462011A082FA19E1308A860C7302FADFC26C02C5358A5ECE4432C40C1B82C38BF18C0E780383A476D06921FEFBB3E77F9EA9A652B3A9C13AF764BBEDD25EE1127E50B76D1EF5A047E61ECF9A3C065BFC0F95BCEE653A1F3EBD63E8FB8865DEFA96AF34ECDF75EA3F42F0C046B25B6D1565AE71EBD491D9C57E19D799D73D223A05ED9293EB28C3E220C3867E87C4C68F49D99F01D3B8BFB96FBD605262BC38B2C235B0CC3BB9D839A3109CAC8151BFD636F748D7CCE2A1830E497E6413F8AFDF61B781DE6DC0FC3C80BBC8E1A2C4795CB3E3DA79FF46C7FD6B73968600D0C6F8F65E05B56E17FB38AB8C556DAEB1457E29E9EE0B5CADF37775954054AC11090EB0ABF78588B78537CED3DB611F18E21692CABDACBBC36789B0C88A6FE22C40EC41024221EEEE45D4D36B7AC740FC12A495D2F95EE53D1814EF0582A94F8D7AC3D09E35F12C191AC3D4C8598CA84BA4DA4DD467200FE5856A44EEB20AE10125D7520B6358F02C07651B48C9545FA137A0AB7DD849B619E333627888CB08DD8E584AB33C79E169AB8DBAA564AB280304206B08F6409F447A442E448858002D8873A0523FF9C84756DC3B3DAE9D91938F8F373A767A7CF42F8A7B5D3E7B5DA374F6B4D1198849781FAC5C5026169314AEEC50CF0710A2FF37AA88AE73B9750CA96386988EF404F4280A6230E119ACB3B4ACC41E0CBBDA0AA20F9D4AF814A429044643380CC71232583A1A1C862F3190D9A40E85CE0BE22E2680249C53A6212D8BF522A91C49E480A545A0EA5CCC49ECA4F3027FF8AD85FDC3DEAA266128B6DAD88EAA019D0D76C256E230D54BC5C81A19F806AA13E62ADC1B78740D2A460D9B6421D80790A27DF27AC2C22201F4E786070AE4FE87ACFB002B7F022C7C84DB6D155E631B5C6580C390A8C19F542D68A549FA9ACCD42D60ACE269610791A5D792FDA6068DAD0C6001B8EF69FAE3A05BBB00338B350B9996690A5D9F5E207A01101B989496B7609704BB49FF04920AB7825A52046224ADD8A72281B499B5D74BD9DA4D221A6CC2976A38B2CD7439A1D1893258B5E911D9A5AEB9FB4DB4DF31707C58BD6F24F4D25BF08428F18F8FF2CF2D96BB2FC2B53CF0FCC7D5FB68CF8AB7DDC80338AC3364843CBC01702B9C03FB24219BA69BD57E12EFB0D8F9BADD8238A396CE0764020FCC5401F12FBB149C4BDEE1BAB96D704F96CF6F6A9CE762FE9705F73FD32F963D67E7BCD020F087DBE15077C6D12BCD734F42771D0016EF941CEE1A881DD6143AB43022B2076C8D2EDE7FC7EE222DF3592DFE19AD0BB3CA9C63D21D73D31D17B6554709E4F5489A3BCD63CAE955C090A14F967C7005980175DC2B796728DD44346DDCB5A1551DB8FC5BC0C75F56183B594A09E28DDC441C0C0CCD3D6D445B98B95884BD46CA26952C69B8FC6795E731C7C43A26320718B81377015994877626904F8D7B86EE6422FAA156816F0A348B3D0AD32B1671E32D5B12FA2656C7F2F967E5366911A2261B7309348AB0CA0019B013E33AE0CD2546C87583D00BF8C5B96D173C353E388E7E7E761E427A7CFCC2DC0C39F393D3E0CB17FE4AB61CE67AD4052610E1B1655218A6BC71D920F4293C6BA425D182C3F4737093303B8AE9B0D6AB800E77709AA6462CF6728D9201F7E00E13D7240D8CC4406E7FB20E02621B4C8142661A0C90F7D008E8C21B0553C3EB15D315D707310466D819F0551679D7F58632B1D0BFEC28AFC3E6B4F6C30660458ED175F420B1886512698B463307634CA5AB772683E01A434FE322E0E63B11B0CD5DB6176F0F7EDA492E3768AD4DBACE45DCEB1CDA0CDB9455658C46EE6BD200657F01A7491A8076C46D50C0A2AC81546B25A33592D38B6D82EE04E9367813842833E47DD78435A1C4E266E8046AF9E12215CB3B17C339282B4D209405F07E0756343B31C1BDC906E3DD2B5D807B879F8A894FBC58CC3CBB2886DB38C693393B7C2F21BC293048A9EBE995B51C325140B35054EF28DE151792BFCD76CF25CD9B32CF34FF6692FD8A5BE6FAEFCCC386CAFD0FB809EE331CEEE981EA82F5EE0C9DCE390D8BD7CED3AFF2245F0A68070B46AD91C1250B9D2A5A4CD76ED7D168A774DFDBF35B6FF496CF79DC0E71D13C5AD56D92DF6EBF35CD797B8AFBB66D9AAA79D1290A1F8D1C0FD38B7EC04E7B64F7FF977026FB8EE3F88BC0F182C3BCCD9EFE74C0F72160704F6A0CD7E6E16F9BA99F251D3D4ABEC56E579AE9107E58407E57887E423AB6FAFA8B6486C3101DD1D5D9F28890DE9A2DD40A68F75C2A37E01B4112FEE18C7236DB4CAD4C60F9A91AF53E61BA5C00A418474BDCFD8EE8791874E5742BAE03DE15FA14AF0015E1A51988CED488EF7A2D8EB38D7A01B821E6FA8227A2CD887ACE7C45626DB4C3875D7C775F87437454C17FA172E35324CE85E6A71B714D9EA48937C8B21CA1440E0F97689C8DE0DE88104859C22E8F7F25E90322D10ADF8AC7D79CFF088563B343903699F9A3D8FD769EDFCD1A16184FA9D77BCC205E521CF629DD02254D4C38693CC43D951C933BB67B2B76439987281CBC92C399959563B40E5DB4B6948BE27E2C51020A6946FB981D65A3A63C6F0C2C50270B2A3989CC50FF034504A87B32588C7C6DE4935A61A3438432CA66B7243111949FE621FB7DFEBE4B318AC113D30F08A7085C109E42C915D0596039229D8E0FC80FA94F7602A39CD4EAA6F07C180FC677E13E0F3981D56521207DEF865802B4C9503D6F22E4B745F23B629B00362A47149DB88A3827E6F20B1212820AA1678B284D320396488017341F5124089A9C304313D95842D515A980A2AA8A81EDB143108881308F5D141916E033FC1DF8C12CDCF5AD82B8C0FD385A42670ABDD9CA24D4FDEA8A740C2A9890D6A6F40FB86E7CF207F9E32A09FDC6394D069AE6C708CAEF40C2D090A2A94FBAE5BE59553E79175FDB2B4671CD59F9B87FC6CE8F20B67F633273AAAEFF893C0EB1323C9331649D739AEA975CF4FF12B415B384749B17F64EE46DFB86BDD62DEB48DFED026E64167CD15AE8995B6CA3A7BD53556318F5844BC6D19B8C7D8FB08E7719873F946CFF51B433754AD1FD1733AA06F0B82DD7EA1CD519123483827B8E53F72216F18CB6E764C42B7A9D5817992C862DC1B728A22E847F21511E3200C06E8C583C940D760F0C9CFA4A993F780A04A8D3A969A17EADA7EE958714BA2ABEB71C8479B4C8AC87B4AE88703451C5596B3D0B5F1E1C50CF687D6145A7E1B137BC2A2741D042932673038A5AFFA39C5160EAD53547C4733E62D9215E173726C5D581D07390BB4224485622E246B0144C1055C7AF064A8E5216B9DC2B02E9E2A0A4B4B1D44165BD9F0778EDB431184A24390BA13D737507489621A5CE31B0ECF6BCF01C69B9C9ED5CE4FCE8D4F69E780E49F9E26842F2063B3656C99B1A44424A9B482DE8C6D34C42E2553C13F23641252CDAE0C0D4877C5BC6BB2D23B39507D617240EBA28722E1A4AA0AC4EDE495902A242387FB244C047E413BAB5C68E6FD5936E7F815CC0366891E8727B992FF4F956CD08FD8ED8C9500894BD8C14037D2B08B9569BAA9F857203DCC2352AF205DE095350621B1D70527F23E92762A87EAE76D2FFD13693B88313D1B75055177507BC6F87E016A4E7842ABE6321A44D506CB6280B23EEA9DBA0E96A4B4A01D59704E8D1F8953C51A69B0B613A92D7A692D8669B8FE16BDB81D8671C49F17AB7B8CC16657F7E13DEB75A5EB8A813C1395A6C90910665A9994251F734279C1AD203F0A93AB7B160A0831A1882A41DE62E413C045703DBA80FA1AC8B671D21D9C1CF77619393289A866859BD381E013C893B57CB3BBA43C36AC28CF3FAF63F98A5B9DD4CFD844BC6FEEF99DC8E130677996B33ECF2D3B6610F089291A482420CDBE2124273C26DF37263B2E5053E525BFC5510D8F609B4B6283A3A27599FC1AA7F057CC3CF6886DBF1599FE6C600EC13EC5798059B0C7C4F3A0C8F598A1FD517DF383FA663F0BAD7F3476FBC93CE20333D903A6097D56A9ABDC568685E482D42D06A11D5E2B15F9A05526539DE4516312807EB3364F8954F50037D548D30B1CDB18054EE4B891155A743E212A7CDB46A62078479427CFB04A3543140EC5A3F16327A15080AC2072D21A83980AB3F856D3F876713CA5A3987542B04DDA99ED455EEC59E1A3AE3A53D74F85EF6E4056844485690A5DC521B6327EA84710DFC9437D42798D48016A1D784D20FF1100CE5A7A221E413B06A2D92EEECFC5D41AA90C2838F21768EB4390C020402B0B3C1AD62E650BE523629AB8A092ACC63B90B7833F0F3F7F5A3B3B313B3E3C3309B187FDFFF6B4965B9EE49AD860165BA51FB9C92E632B27691080AB831B86CE8205829342D69E1237C2840E63D477EB5AEBF151091419AB14A46241E8359DD833262FC11FE40451704AF4364AF4A2BA14D801C39E2035D8693AAF8779A39846C084D0E6AC6F17541B335ABCC64418BB28F6BFEAF8BA5484FEBB20BD456B4F32CF5A622E262DC8C118C06DE1E644093D2671801F51E8562794D7EAD8ECF21A81B44A2CAD06A10D192C13651B7AAA5253576871527B107526EDAA6D4269BF31B2444811B12C111AC200EC21BA25EBD8C168F0981AE25491BDC21B791BFA0D803182BA3A3365933958CDEA0ED3B81E9455009EA5C20FE500DEA3D68AAFCA1026F6E827766349D028CA44D360AAA93356D723B583FA1F4C1F3C2B44BC206343AF192B2AC5B23291A24CACA8C43D9BCB3B2DA55B2D632E3343356BECD50651BBF4637751030F388AD4F6902AF0911F7250D52E43D155C88600FF1CA5CFAA42DF953B7D121F592E7BCF6CF92F02DB41CE6284B33C6168F7A3B1EB7B56BE8F3B4AE017B4B8A3704D93E3AD2C5B1EDFE89ED2EE98B4D342F63747E97B367EFBCCAC0E181B7E6BCA7D6324D82F703C2CF4DC2FF0FE49E8FE9D91E38F46F647853610FE9F0DDCDE350EBCD339AEC927333938CF3BACC03AAA4424DD64A0AEA68A2639D0B86DA85F4070CE41EB51AFD506E0F6E2C47A51422DFA9781FB2D56D6A172064086591CE1F6D4BC95977CF2CC598C9D00E2302359F19D8BA88509D2F260C56D318AEF43F7383D49956174B9A9B4C24A5161252D35971458C836814C8E3D0085C848B2D8B2B4D789C1C5CCB5AEE930AB53A0E642A0B252F714EA66CDA3DC2CE38B7870279788D2831D82C43E30E44DD4F566F272B3D862D4E45BCACB4C659B44B11506D25AF2DAB049100FA305E3A2B5BF60EAF9D0004D44E1D9291A0D659BA1358C9435E04A19C8AA38EC4C22D2361B4BEB04411BAE7EF8735875083940FCA9D9B139EDD4F0E4382FF6773CFBB13060B56D5CA37D320A789ACCE029C83AF4114EF355C028078E43D0DE86FB318CAD3491575AA8AB512201CCDF40514B9E230054F8957C4CB4D8159AC8BC8B624F76280100610F32BE902034923197D74064109F22F225CE0250F0F86EFA5710BDE49B8D6515169A2A634539DAF8219BC0FC0BA863F8DA84A9F3D67E89E970B1A4FFBED89E074816B38524F38B0103E50C8090196B5A4D9575A6F08222368842D61806AED20F5DAD1792CD0565E9FB670AFDB3C481D9C6417926211B4CA32B30CB801C50BBC20A4E77D288DF0657D344D6692AED3493A1D0BAC342D94E43DD8601A9A6601E054F51555C4439175ACE851473811BB9A07C839075E2B07CD3888D66D185A6B1E514C6CB5B5182CA48A0D0C4BDF0FC0DE5C47541F728A0FDA0641863D3488BCD6289762A961689E428A8AC06990CBE0C09BCA44014B65610BCD2287CB57144BE595499B9A401CD732C63510973A5A9EC4A23F96E23F5762AD7855B2BAFE7A2377111855C689E28689549C00AE3C06CF3A0B5B621B95E21AB15FE69EBDDA537FBAB5E700ADC6BE2724CCFFC0C677252CF68BFC8F45B1397AFEC35CF3AA45EE91ADFB20CD582AA5E97B81B9CE31EB597BF6BE10FD93E22323A2CD2FBDE447FAF91789F81F54154BFEAB9FEC2397ECDD97D2D74FEDECCEF4BEB484089373827AC754D0C0ECD41770A227552B532F15B85F2365B459F7D6C8F7574AB69589530B04018B4CE387C9D7974BE9D72A3953CDF243A4710BEC630344718B91E8EAB89BC1AC441CAC5AAB16FF81434937C127BC6BD67C5AD7CD32156F8D80785681059C405AC35085C6D1595BF4C51E8AEDCB04C9E6F16BCC22424DB287CBD50B209F3432112CC60023C2396E25E6CA6485D6235649F05D12546511B4D23D79B44AEC71B5174916174191753C529A85A098E2E9C2F236939FED5247895B15FAA9B62BD93749D55541E564718550831A3A29A78329B4BBDDB96F2D5782384AE8F6B3190551B4A4AC4D11BCD6336D8290B1D3525A2A83C61D406B1A4D85251E9A0ACB609CF7FF3DB61F0738626E616B4F35353B0FA531333D3534CEC2B076E43DF2B2EB0D82E7D3BA215221423458D6894D1CF2193942F90560AC2D60BB00D82575A85AF72526EB095E69B46AF1346AE33882CD08FA9C00E84CFC2ABA4C5B6717CDD0EB112004209E40D3090C6923293F00D26A17946C139C2903C41E806616429194EC5663319FDAB386C03369B7B7CA14DCC1A2CA220BAC824AEC53819986B0F27695EAA70E703FB2542D1BFE2E49390AB7A2C565FC3C93B380938CC5B0489032C3F81EC48A37E6409E7BF46DF37C32E7AAD3CA7B176EB6D57DDFBD24D4FBD7FFBF39FDCF5E267773DFFE95F9EFDECA607DE6CDAF6E78CC27E1F6511E712EFA8AAB101961B865639BD5CC64E5A63303D93FA61724D1290DEAB13C75439C6355B469638CBAA2C83F2856E59CBA2CAB32B6FEDBAFA8D6BEFDB7BF7F387EE7965DF2DCF7DB1EBDE974B7A6E0C4B2F33F64F10F8A7994B8B4C41CCC066953489332EE3A4ED5C2CEABA064C927A0D62B06C2BED14C59651ABCDC2565847AC14F8255844669946E5582A0A851139BE59CD9C774A546EF3963FBFF8D887076E7FFEF3A4D22D9C6B12B77CB5C7EAABF0D45C64331EDC20B91BFC6D2E229FF34F378E5A1B945557D07DFBF50FBC75FF73EF3DF2CCDB8F3FF9C11D7F79ADBCF366EF9432FDB014E3408D2C22BD3A20E5668BC8778D838F59049C3675D92B107C6F6AB987F3F84A10FD8185EA2D4BF5DBA6B2B78C23DFB50CF9C8CEFF435387AF8D6CF70BED8E00991712507F86B33ACB999FE4CC8FEBD99DD4F3F9C130FA79B3F82BEDD2D72FCF8E0ACC45FB0A1B4DA528BEC60085E8B23AA3A401DBF85D4ED25E07FF123387343B141DAEEEDE79EDD37F7BF19B373E39FCEE9E631FFE70FAEDEF4EBCFEFDC9673E3FBCFBFED752AA77D849F3389F0C805588568CD59D362B2EE77CCA2D565FCBC5020B604D2F902103355855035415E5281648C80756700E89FE19F5D5973D78D3939F3CF9FE2F6F7F77E6A39F063FF8E1ECCB9F1FFBF3F35FD6EC7ED003A5B26EA9FA9272EB8C7E4EDA2040A021C54558B6450660A505BE86A9AC2C32AF4B53D81D9355A9CCDD9C54D42ECF6D92AE6B0BCDE90ED87835175C6C81C6AA91EB396755F6E6CBEF7BE18B27DEFCE6CB83636FED39F9E6DE73373EF169745E37E7BB920BCE3305F30F3511E9A84D84340254465133F28B08D95AACD0BA232087F34A0FCF69EBFFF30B78EA777F3AFBD68FE79EDF7B76FBFD6FC5ACEBE25C54EEB282E0F8A243E7E0DB6B676666B40B10F6B1D92924EDE791CA83CF1F8C9E4E811B2D332FE7221B517567947E19F60344C02C0DDE7E8D28B60AEACF2C2C27AB66F74D8FBEF3FC073FBDF4D10FDF1E1DFDF087936F7C73FCC94F0E74DFF65CD8DA76BD90355CE05A3D49B97DD6162EA2D22C7D0B1C648242C04404C61C536521AF704BDA9C5C71956C6D5BDCFA4E4D7E872ABF2372557352C5E592FC01CBA8F5A6A16BC5BE190377BEFAD757F77EFCE3A98F7E3A79DBD31FCA366012B2E0735924F149FB0B6DAC1800077F67A9ADF3EFCDDB93EE4770DB639076851EA615340C6480626BCDE31B04911BC1584CAFDE75FF6BDF9D9CD1F119E11A4171628C22589AD322173A86742842A605EDF929EDCE3FFD4DBDAE9D734F0C2EBE92434923CC384177AC0A35BA86C02749B9555CAD4B7CB555C81AA1B36A43CD954FBFFCCBD1D3C49C2022C5AC76728E2E7E76410B1EC5D979EDB109ED731F7E97DF7AB9382895F3C9344B6C364AE9D3475616FA0FD0204223593DE79E74EFBBFB0FCD6B8FCC698FCF6B8FCF6A0F4F6B7F1E27D2E5F3DF9CD15B2E7790AC7AE0CDEFCEB1E8EED49CF6E8AC76FF8CF6CB51AD67563BE79F679939609CD1234E6BE3E4455C649673EA86C61BFFFAF989B161C6DC1C9ED24E60B72C908338746EE6F48CF6C779EDD6373EF5DED46E2EC9F1754FEF082EBDD521E33951E4FB06CBBE34B6DA676EB38FB30555F62761D83E61F4612EEC20E7BD57E8F8B599D517C6267BC51644B0E3C0ABF73ECA799EE39C4F835A2FB6DF6BEA864283C7CCE3FB9CD6ACF42E5A1E5E25946E16116964B31174A8A41241355AE559A386DC655DB8ACA47FDB5DDFFD303C37AF5D98D74E4F6B27261666E6C983C54260F60E8DCCE049E1D6BEBF7FA4E1EA0739CF146B902024355C748375E6D580660DD376717210C2DB85E9201D55893595D6897586A14546C16591D9DB9FFDF4DC9E935A4C17668027B1F2034202F388CBEE9BD0DEF0DC1E5708BF6BA24B56AF29843FB6C13065AB61F2163A0722AE039DB6DD13ABF69CD52239CE5F01DF3D3B455FC7A2B4DDF1A65D7C35E7939E5281DF3A820B9E1AD7421CC767E9953E33ABFDF0D04CE72DCF739EA98E49CD4224C022805910168000D0347D2B0260BDE852CE3D25786DDB754F7C720C7B4FAB3D037C6E9A7EE8D814DDFC8171EDF65B9EE42CFD2B9A2FC3B40C0E8D6A6726B473C3DA85D1F9E9C1F9F9F99905ED075F1FB10B5B63863027A2D900F81C5CA198564ED66A97B99D0BD8009D1299DFBFF5CFAF7E76780677852B0F8E6B41EC1B9FC057B5930BDA9323B89C16CCBFBFBCFEBDBC68401495CFC13F8D6B324FEEE5A2EB283A4EDECE2170906EB28B2DB8EDF9BD3F8D682147B814E6046822EE19F3F3D257675D24D9AADC46E8BBEF4ED23FE12730F0E6D34353BD77BFA1179C67A669D28BA923DF7EF1481FB2FF3C3BE05FA5EB20AF780527E931CFBD95F3AF1027F759267772C1B9E2A83C65510FA4053747723846E4063C2DFE6F7A7E01CFCDDF1CFE32313E3B3E323D3D813D483BEFFBA3E33E9A7C33493E2729325AC1BA44E1CEB2AF43146A927399F5AA3E2E6035E793A25EDFF6E6D7274E4F30353CA71D1FC7DED5CECFD105F9ED0BC4957F83E9FEE2F0B91B1E7F47109AA9272944650507F43EA94F3F0355B1086EEB39FB285EA44F4C9132E23719EEF9F894B661DBF5EED1C95F1F1DE577F04F474E9F9A9A3FA9D51ED16AF7829BB5F96A045168026595B099F34D15072774DF7CEFFE618AFAF0D37008D9E36AC7C1EA607F99D5CE4C6A2786B5B3D8BB3FCE69CBB73DB63CA852EE53BBCEB9F032E7D50FDB283EB50BFED1C4713F67F28B81CD5726BE5F9B841ED40B39C4797E2334FB4AC4ED33D13B2A100F724E67389F5FB87024E18F70A13FEB057D6011F457E7D02E6FC5AA90B490C80D7631303228F9465B881D26295772819B1D92B6D8C4349886941804E7E776DDF6DDA9C9F33373346FDA8519D2B7B05B9097A9E111E05698CB7912FE05DD3C9C9CD5F6DEF99C4944AEB9AC1234551340D312245F060C904CD1349AAD68E1A4EB6D92CA2C63F35D64C537FFED0708E199199A404C0296747862667462766C6A76641CB6527B6E427B6A92A6FAB8567BCB339F48729A38BF0C6358DDD806412A00AD1E30BB2CE23BC4910569153B4ECCD045703F98B9D1D1E1A929DC9B7668561B9A566C27C9EAB9E56F50D05814DC3AFE3E8BCFB1D53F3F49BF8EF582EAF18DDB681AB5C128753B17DE6696730B175C03A4067E2F178AF825BF9CECD139DDFE1CA78BE3EBD3F373E3A0D94F2C6027E03AE5F503F73EF43C696D28C89961EDE419EDC2B0767E6C6A7A16B3B4F3FA870D96A7EAC1438905CCB1DD64C5E5E6E9DBE0E4727E6B816574DEF6E27BFB277127B80E363CBFF9B10516F037780D0B33131313A35373FCDD7E716A6E65E395980D735595053475648D2879AB2154494C23FAE79A07A47C796C0E028F09E1F7128C25DE1F3DAFBDE1EEA7A31272DFF8F467C802E9BE2968A7D1B1F3E7F0315CB666F7FD0872E1745826A333052FF67CA3DAC5A35FFE75B157EF1464DDC8494151E8D543E7A0F456CE3B7943D79F8ECD69CFCC6A479919E19F797E6A6E72744C3B373D3D35363636323131B68019E5E77461766C7090948256FBE8EB5F9847AC3488DA689681A40510F5012E19B93DE4D8B06005287E6CBAEEB1AF4E4C6316F09C6050CC6AE7904705D03236737E646AF0ECC8C939ED04CFA01C191F9C9C9FC5E680606FBAEC5E13D9462EAC90D891689B099206A80BEA7A9FC48DB8D489B13946BDA43D343C3E756E7CEAD8F989F4BCA2D73EDE8385C10F1D397986B605B357D8B5573EF111E7978A98D039A55E14B25ABEA1F5B94FBE3F3F3B0F291A1F3E363974543B3FAA9D9B1A3D077BAF3D3EA23D3336BAC014E0E8F8C1D1E9715222E7B5A51D4F5A3815F93B159405550CB8653EB44CF3A67DC0576656DF19997F6584B2BFC0235C0878F500ED7FD4E74E88B93302C179CEFE14E7F3837ECCE742CD47E2C467AD9376A2C5A42F42861417D96AA1BA9803A996A0F5DD5CFC359C74A74DE60D066175F631557661399D373FF9E59989D30BD86A50405393DA31C8E0AC164A60706212BA686C7AFA1C8B5D67A666264F9F3D333A89CF9039DAD87F0BE27F0784F1C1E09F5ECE85B698A4EEA0438154655689459C474C76C3EE6F4F6A8F9DD74EE121A7742B4E8A9CFEA7537F64E866C84BC66C1F1925E17FE5CB83CECA755C6C19F1C9919A418A21A6D106C52ADE9957DEFF3AA6083B671ED3A8C5849DC50EC1F53EFDF2275F69CA357F7DFA18EE9EADCBC8C4E4D0D0907601423F3F31367E7E746A686201F61FBF72FD7D2F709E0962242C52118BB599ADD86D20C5B95A083112EAAE7CF0C4BC0E9C1F9F999F421A1E3A700134BCF179EDDCD991918959FAF5034706CF9D1B47A65E3B3BA99D1D591883CEC7FDCCC0A9C4AEC82AEE17FAADB1C8D8CEC5B69B655D4EF89CDF3AFBF8CD4EAAE2C73F3A728AAD37AF95E6E616468687C691E64770303F313F7A7A66F83452817844DCFFF9E905DCED9B3F9E561574E905ACA4F805244278A372CAB4BBC695276C6C3E33C714F114968DD4DB34F40E36FD82367763D5EBEF7FC5EB02FC109BEFE993470FE12FAF7CBEDF2430DD217EB381A41AC1C2D2D17D3AB1D701B4C411F8FDE45CCAEBECE0A23A85283C5CB9C34A5DCD79266DEABFE9C818D3F770E0498D92CCCFC18FC46D620F40C8B5B3783736353939CBFF69766672042AF0F0A15F4E0F8D620AA2D6341846E4330A1D129E5BA1536C33AFE0FC80CF15375CF5385F02750E66647E6670E6FCA9C993235AB02946CF6B4746B5A3D80F0B34DB24F9740BF353F86F68BE6F46B4CA8A1D5CE83AF314821E38592381BDE11B37F55D4FE67D8E9F35665BC686B061F7FEF4CB5D0F3E8C0B9D199DC03F917AD1CE1C3F0E2740FBE329AD9B247799AC2424AB9BB394C5156DFD6E88F601FC95858953DAA953DAD9735AC80F9C1016DDE0D7C96200069A469878563B3174E6E4101EF38D6F6743933A9C7D3646FB15A89C524143BE3C40F398BBC74756F6BF705EA7B9A0335CD859CE7F907318E4C4E7F5B9B386DC61813138BF5F1884BF649470A3E3EA9A808D41613976B2F576B11BAC64056275399576E2BC14EC45D88A141022B7992099EC9B71E3236F602BC028626506B523E7B5C3A3789D1B1C99C18EC20CE136F91923CB4FAE008DD9D169A2A11ED36A2D22B30D03D7DB6806ACE2AFA03E73B19D4852E0B838CE5B9EDBBE93B7CC63A3DA13478667A767E6E72617E6A7D82B791373733393D388C3B41027DC037EE3F0B9614CD7A1C189FACB6F077C609A814C41BB48437DF51CD1FDCE37F3C35FC6215E489569E7A11F104B8F41ECA726E79F7DF1AD3B1E78ECF42449CCE991B1D1495C8C960CFF8ADFC21A9141C5928DCDE3FA07CFCD730E515669035C4413F0089BB43EA7E41643FFCC4DFDB71D1D67373CAD9D9CC2C77105F6BC0BCC07620F8EEB9C3E739EB74A5313934C298CCDC3DA9366A3B53E30A40D88AFB28C2EE7A26A8D32B622D7C34595582BCB1CE5790810B0B823704626E78647476666309F74936C0BD1ADD2D5E62E4CF2D4DCECC9E1097CE5CEE73E310BCF32961483ED6B0CB197741923CFEFAADC72D3032799319F05AA38475F9F9B1CD3CE2F8C8E4D3CF4E89370A9F043B8ABB36707A7A6F0297A80F3F3DAD8D5B540D02D348D46A09644212DC51F24C7930274CDE997C0FCDF87E4135C09531C50ED947DB9B1AC0A40A23CAF019A98A00FF276A13AA74787CE4E401EC9AA6B87CF8F0F0E0E4E4E4E42DC27284E5A98246F7C667E616A616162760E8A423BB8A0CD6BBBDE08C82D156CF7A01EC34AD3631C51ED28ADBAE5896FF79DA6053B78F4DCC828DC31387733230B23D8CAC3DAA941EDD489794004D0CE63E7874F4D4C9CD5CE8DCF2F207AA54D8D15EBB9F31523C9064B540120B714DF6E8152DFA035CF7CF803AF9231AB43674F4007C3F3A01D3F4937736E0431A3F6D4999353932313233089F3078E4FB4EEBCC7DC3BDD555A62E493B3B6E1F60313DAB3586338F36383DAE1A3B016DAB921EDECD8CCE0F991A189A129DA257876FCE7FCB143DAD1B3D84778E273C373D8D1CDD7FFCD5E5A681F51E01656181D5393E095D91B247DC0C9F71BFD80D35CE0192EE02CE785187E90B33CCD098FEB19FE6268FA8DC0E93DC390BF98A971CC43584C899E06FDE4A8BD17726300B729674BA4D46E2E0DD9E02E2EA6C620B6E8FA673F86BB8E879A18398110F8DCF4D099C97398A869ED0C267F78E2FCD9C153E706F174A4DA66A746277093F0091626C7A786CFCE4D93C1EFBE51CF2BDB0E54FCC85E23C54EB3B86D2259AD20726DDAE601FC2B56E4E77D07F94886C7BD68CC8D42F231FFB3F333D8D97CCC353C333D3A4B71042DCAFCDCFE91792E648581BA16D8BE697C27287166926A4F4D1524E72C4087D9F1192850C03E538330C8D01CDFFC7414D27E761C3205A77E7E646C6870886293A9C9D1D111980312ACB1E979DCC1D0B4167EAF995F1C7A637111F54ED9BBB9E00DC2805529A57DC07DC82C4C923381EF8E8F9C19193A093B8F259A9C1A81351E3C7314C699E60B367662164E0413A589F99961FA0C2EBEA07DF8CD03D6611BAD64755C64A5BEB24E282BB7901706AFA8C2ED1E1F816423EA844A9A59989D387DE2F0C830C83EB861EDF0E4249E820F286670E1D1C189F1F33445BC361CD7A6566C31085A258AAD360524A104DFA4D3D02FF9D3FDE750EA8719631674065B7E6AF80C7C8723470EE13A0839E86A5007D8BBD35343635398FDEDB73DC9D9496C131B295D8AA212BEDB0FCBC2F2DD2B755DDE75FCBADF09E9110347D169BB62A75E4499ADA25CEC9BF0C92F8398D351B8B10B3353C3A7E0BB334DC9074E74EB1489B187E443E8B3737343B393604190004F0E0F4DCF1E9DD0EEBAFF6DA47CB948F43602E9ADDE565621C0E1045BEE25719CD70E217CC425C66717E0868E8CC18F20653135737A7A0E1FC06517436BDAC43035105FC484D89D2F7E3BE2A8283597958BA2CA6C135AEDE25B3C126B3EFAF1D4D0E434E68BE97BDE4D981A3E7F66626A7C620E520137922E393B85906CECF4E993FB86B59C45A07B7CA549687E74CE8EAF4F69CF21C05880B3310D97463B3F3C3174E0ECE0A191F97142F5983681088DCF201C4308C076DAE0C8FCE9B373A3F0B1B5CFFEF89375C63A616A05DAB9DBA55E6FEA57A70CCF6BF4897BC62AEA07812F68BC47392BD06F7E10DBFD2470D86FE0042AEECF9CF79BC2B02B1C14D2A854E3B87C7DA40F28734EFD2450318AF3128D63FA71588A55CC661765856D64D6D65B1FE1C3C27D8750243A3B3D390583CCDC2E263AFC1E5C1C93786838B48B013FFCA671EDEC8FC3C3809DAD22361806568B23FB0C23FB6D9376635D628AFB4F305FE6A783FBC97D3D7F7E0A7A0D80E0CCD98599A185D991B9F949C007BCC09F1987FB4FF236383981BCF7B991C1F3E3E4F2C494F542F98269835CAC15B27A5EEB8A7AFF7A9C79D14CB621E1C390FFD1D905FC855F5C6C95E3678E9E3B0F3F1A86EEFCC8282CC52CF00A82B2A6E7F0498AFE28709BF790ADE282D62FCBB9DA585E6B23DF641698F6E52178CA30F270956747CF1EC716652B8EB8667C640A3B657E0E9B08C6085103FB181FA89C3B0BF77E0A8F034EEE10A257ADB6E1EAA78481453839DB7DCD3640710E091516112B5FFBE618EE90C4FBDC692DCA73C7CFCE8DF30EC23CA2D173F80DDE024D69CF4E123AC05CDD99D9B9C9C9B9A9B3135039DA6B1F7CC3C0274D1C5B6142E9FAED5C4C835B7CF161A08C4C554DC1609007042F12DE317925C3C3D0445A4464702BC80B60D7FFE8D0B8577229321DE02C10D95182AACD2BF9166F3C6947971DBCC0B581D8FFE6FCED8B8AE72FB804178E7FECE2A4CDD028CEA0C73969FA6E7802882B5CA3C9D111065DC0A24F8F8FD344E36E5EFDE440FBAEBB5499A5AA8C8DF5BD97BFB7E717EC180C483E7D607270661E269322AEBA6BFEC6856D449F16EB942DD6B232F3A0153935BB892F814744C8088F9C459073C39324AA0BDAAF7F3859B2B93F323E2FAFAA7BDF20C91B2694FC4C9A67520AC3C81AB0B03C28BDD1515967A36C4155BF6978595AD9AE13304B582A0838E6717E62E2DC515AB0D909C4798363B453B1797157C00806CF9FC166F24EDD601B576818B21256FAEB335AF8B7F05CC9D9C4CF4C4D229A9F9985734F68C2CF005D484F413D8F01C9C1EFC099A6A8078E257E6E7EEACCC4F9435AAD731EAAE83721DFA3977293B1E63AEB88DAB8D0FC9D5E292F3844ED35463B6ACB1F0CADBF15D97F6BE2F693B1E74903CFA3FAFE9F0BA2AE719007CAD3B9B4F5D4E2862A0EB672682025DB6D24DD6D15BBD549D6E11C5962E2A26CEFBB6E788CD4CDD9E173982CA85758709A346042001819DC0854F92CA2A3694A88F04A6076767A627C18E239333F71681031BBF6FD83A316117966D19B1D93761903C1F22FF34C6BFC698A166B700AD7989F43DC009F0E467D013F47CA84E683AD3B79BC4C624F4F4C8CCCD176C76C20FE83D09E9999EFBAE765CE2BC332B1491853650FB6956BE65D2FEC23CF1E0C58325F83F30460CD0384401E04527572640CEA18112E7E627074689A40B1A99151985392523E25716C083B437BF0F484C835D6066424194EAAAE31F04EBDFB994F28F6C48FCF433D9CA588077330358AC812AB4C898679E45FC8560325387DEA18E6620CBFC6EB9AD949382F730BF3E759B38D8CFA1BF5C3CB894D242DD70FC9360E59F1D68F4324D2C0EB11C64E9D9F1F3B03F99C9B1E1B1A1D8323C16731F045044D3C8E88907E787C0C32CF87156460B4DA97BF3822F24FB5435735F426033131A24A5DD87D9A05F6B434703520F0F3F016C7B4B353B3B30497622A78376B64727610B3A4D5C6575FA6179A6B970E93DCCC29BA0499D752CB03905CA98F3359FB7F20F64BA7BB2E1D0ECB37B45E3CACEAA2BEB7FC019D60C8C610E5CE2371F3DE932CF4C1928C4E4DC34D5A983D7B9EA2383C67C3EE87F59765980515EA7BE47848CB0D6DC2DBB6FD098E14CF791C03D00BF0660ADB00AEB9B6FE4F8F231D6091D84EA63E7A434872E94138F16C5DA7C7090598238894F616A6A36DD7EDA6CB956E31F9A6FE2BC57E499E49595F9C80B84D11AE360DD503277FF6FC2C00F559F8216B6BAE15FB97DA68761B4B7A6CC24ADB763E403003A61DD7C23D0062183B37370CC076668239008746A6B15A906128ED0353F3573CF21C1790E282DA1BA79817BF06A600CB0D19C1FE84188D43D9C1BAE1968E4F6B9FFFFAC4FADE5B57D55F3670CD3DC70729D0C0F2C02E912C40AD4C8FC23A61ED612D61EEF4A545C42988683689DB6DAAD8E612D5A80AC969F58A7BD53AEAB030E01475BF81D8BB7C6E62FFA3A1FD117D8FE35CC4A3A69AA8E86C2EA5100D15517A650446706CB711E055F45D9102726FE202B323D22B262922D44E9E1B1C0506A29D383A71727C064D220058108CF4D8BBFBE0BD2B3674C415F5A46FEA39314DDB9160CB91F139E0A4E49ECC431E4ECD6B7F98D47AA6570B25C556A04287AC0758F0F6BE91A179A4279198995E98C2BA21A043A24B7B6A8CD6F491D7BFABEEBF4DB6B66E55CDD6AF4ECD2FE5F3C80EC032930B009703E0B8F6E657F60A638AC0F03192563AE2782FAF2C4C3592BBA43B1766A7CF9F809AC7DA0C4D4D9E989E3FCA140DFE657082F261CCAD9B1919456A6514F66012600F4B18E127F014DFEF1F1639A98411E54E993B38EFD58ABC36186AF288B1DEC00899CC634500E2F16A1A7EDCB35FFEF2FAA1E103E49ECE4C0F1F9D1D3B3B3F47A1F930EE981CD82928A2F36393A0E88B257968D4013E9F4D5C15E7107BCB539FC2E9C35E4758A3456A747C14E1372CC7B1416C29ED739F9DACDDFD586CDECEF8D22B6F7DFA136C8203E767C618E6393F4740F7FCF404EC016CC7E979AD4D789685A24C3FA6DA76F5959C7DEA3D2F7D757C8890119A36842FF814DC82296CA179183CAC236E1ECFF5CB59D21A98BA6B5E3E88668A9C1CDD1CDB408B30C9DC494550AC38574743FED5E16EC47D24486FB115115544F16D1EF9836B744735F2E7B7EB5A7CB2A3975722B5DE6C91DEE9B7A6FFE1774E7CF8EDD8C8A416BE11960402805B01EE3D70D71B6E710D3631E804DEE91C378092551367D9CEEBEE05F0706C740161183DD51C6C05269FB6C2FAEDF770A11BCD342DF6714D465E2977FCED3D3CDBE8D4C22C96607E627AE2DCFC0262669AD01D773F6D1999856355389F357671AD70E0393FD5E31F7D4D3B16D334373F3E0A8B0D6F0241C4C4F89C7645F14E03AF224BF515968AADA6DE6B9E7BEB27728C74B6099FC240F60661C7C4C824A9FF4F0E0D55EEBA35BEB26BE7A3AFC37A9BC5AE328CCED70F5FB3B2F172EC12C26AA0ADA7996A5F9801C48267016BA0A8F366475981C0779565F83A2BFFD41D373E0A13811F9980D8CF9C67C8100C2D4155F01D15C55BC02A43DD2B18E046715BF51438B5A6C725AA343D20EB7A87B8778DA30E73FEC738B72F8C6D3F3121CB7F9C731FE2229E17C7C54564EB2516A2C11EDAAA827E2790A01BDF8008290F942721E00FCFBAE5A90F91A99B878F020BBF30716EE1EC69ED10026EDC368467DB5D4FBBC41572CE4A71CC06C3F0B5067EA9F5573D70705C0BAF11D6698AA498000B9231CCC369ADFFDA56FDE8F586D262E3D8FCD21D7701DBA45583699C9B59189F9A1A5F181CD66128A5FDF7BBA92B40C1D4F34A17F865C417F782138187A5CB2E50D610D2B724F60F7C745C145D288EDD045EAD89A4D827793336014491F7C1E0211104B9303D34357E6A7E0177B26F44DB76F93D6B4A76B56FBD07896198BA89696C31E4D51834CED278E3542DA37DF4B9CF854E89A6B175200E8A0273AE7FF83D0AE420F7E38340D067864F8E8FC077A67BC665FFF2CAE7B1799B7D32CADDB36AFBEF7B8E80FC85217C66669AE8F7583EB6A3B0B3E1EA6B1FFBF067CE3FD320B119042D53D90604E49F1CA0908D0C11ED25283438F133D86FD8CC4F7E7CD824688D515809E757661850E89F52F6E12F677804F5FCF0281970A8214092F02C58C18F79701AA8A286D22AAAABF15EF3E9C171FC3803664609C2829D07FC070F6B41FBFD2FD0B1DAEFCF682B7A6E4E2EEE29EEBCF1A739ADCF4624020B51596006FA000A4952C0CC676766FC57E3BF11FB256BAF6B7D79B1D843B58007861E89610526319B3897247DB74413DF24F5FA8ED54D575FFFF45737BDF88B6F2600C9B5EEF1DB6C63DA9DD050D535C1CA2DE2DA5BEFC14CE906FCDEE921483E527A4059A336E0ACE846304C8441C5F2D5CD7C2264627A617292C095B109CA8A6173BCFEF3A0516436222BF314565DABD96A8124EDB2F47B9EFF16F971FA0E302B96DBA78427DBEE491BB6087C0BEC127659293ACDFDD3A126E1063080053780D43FD4CACC0C1CDCB1E963C3DAA73ED867E497C82D8F1785ADB15216838C208CCC3553148384F7E27767C81145AC070F6D7E7C6614923C7FFC0C9567EEFAF3F362DF34674D8D2028DF09A90D279924BD74CF7EA07ED80C235A0079C0C8E6117610480D6BAF2ADD660812317AAD80EC44E513BD9061BBA8AAC8A075059E19D739293F368D3C688233E4ACBF30363FC6D90C729EC739C9D36671D9A1E976AA3C617C8D10F9C89816A1B413473B9824F619A2C74B547E446117FC268AD3A18A883501C8736810B02374CD94B6E7FA0704DE712631EB41E1764C6F8319E702572D4FAED87B5E8BB89A4725F840F4FB53DAF77E99BDF9C59F42376C034F810B4297D0C6977F38877FA2B817C6677E02960D6A1596074F3470C79BFA3EABCCA38A6DA4E5CB12EACC23D67176D14F7E08E49BC41EAB3047760A5A05067F0670FD635F0C72C1EB2D953556CA2A41706ED9D6FB2084100066B581578FC1E422761A9E2572CBB39FFF641B95062AAE7D503E077674EF55E709E91B9D98422CCD641E3FB1002887F2BBD5DDB78ADC57D8A201767871D4DA6E780AB4D4F3B3943C03DC38053AD5FC899129809DB73FF7B1436C365074C3E0552002F9AEA878FBE34F59883A353242801E6691A9132465F1A0DAE2FE5B39CF0C71529738A1C92226F7DED7BEE4B71B9E0D020C3C0BA12DC520B3DAE73EDDE718BBD65A5A6C2EDF6C8D030E23CB39E7988EABEFE0BD2A9011486FF262CFE8129840D3A0344B7909A21EB4EE705BD909F21821620BF39363432CA4076B083FA53D374699FCC7DFFD8173938A7C13390FF5F28452BDA0D55C543927D92C4CEE15A7F6E3940E14E4E1BD61221520FFE3F11BB1A76E2A8BD69E177B7688B28E75CF6C3EEA22BAB85503DC4A90DEDA713C001A8C38A476B9A6B5C3EA9AC94A9084E3BC57E887AC1386151A8796A13585C06B9D475C55CD8EBBBE3B083C959E0748C6A9D1713C159299D8434840BCF1E5291C9CEE8CAEE3C8BBB8ADF9DB9BBF60D2CF8C30B862FC3CD07E827099D867B75EC6D9C75AA6B4E03905A0348536D14168F6A97F7D661F2D02361A5683C17FC085785F2EA96000A75C38266F35082996AEA9C175002C63F901E492CC43FA81EE219A842A3DAB7591E61906AE764868C4490F0651E5280140B72951C4BA35ED3740CAC9A71AA62082F97E53A3930424BCBEE78449602A98A141B9BBCC14F5769A468FB84ABB90D4B7BE3A48C92B8261B07586A6C7014751C200D63EB17237C41E9515C671147761DAC115B79236BB4755E3FC9302FFCCBB5DE41F3A047F686EFB8391CD10E73CC2F91CE1625EB08CAB08480890AC308FAF4302097463A43CD0CBC818D975B83C91ABAF7EEA233C3D0020CCF2DCD9217892708A4F69E74E2F685FF9EA983D0204BF349B843A8BE45630AC101440F8ED136A1EFAF4DCBD6FFD72FB735F566FBF33B5B8336A65B58B24DF327CBD9E5F0E1790671059A217BAAEFDF697C95D21C2D93029EBF951CC1E6F365FF9E6943868AD5154857352878DAADE35B91587DB09BC92AFBCEF153811880366E7B1D494B5210DC0C4FE9E774E70DEB9A866B155579B85E7DDF33A05F6E8624120004CFD2CC574E7C770F35A10277C92D68B83B3AC624ADC558D4EE105450DBBB03766B5B81AE27DC27D96AC37D2F261A9352681F9F69ACDA2D0753BEE7903B3717A8805DEB3A30B938840670647296D0632A267520948F22692C265196D2E999DC6A159B7DDFBE802CCC0C23C9C45A8075EECE7C61057D3A6F58C2F415EC0145C83A84DAAD2DE1F066929C980E17A73139348CB4F8F81A9810789CA2E439B3DFBC43A1BB4240CDCE4B57ABB4568466E75E769445C70F22943388B1F9A67094E1E78C6FE81D83BE0A8A5A00DEB2F7BEC24395FA8F6453244976105F2CFFBD19F1D1FB78E4C77506F5C96560D17CC5C5E68AAAA1027B459AEDAC52A9150868CB2C25623A430F996A4FF70E8C49E9DFAB8745A0BEFE45F107B5DA5DE92AB8FB60A2877474FF81EA3B47EB08B400344F981099ABA876DC4D9609C470AE7166F2B2D885DDBD57BC30BAFEE19010D16260E73373A3678F21C98944C0763BD40759E9F0195F52FCF7E2B0C297748BD8C0BAA0DC8E8C7DC01231F1C05F084CF4DCF62CD68332FBCF9CD4F02EF18A3C82C2E3C8F8B2AE3020A508DAC1755691753FCE41B070825617303F8033FC14F18340DC8CCB631E536CA26CE23FDB27B9FC2DC8DB138134432285F4C28E813F81E0C4EF8CA7AE3B08D2EE9FD5C48352A4CAC522EC7114896EA6E41C0CA17BF39455B93A829935860E07FB8B5D3A3149EC8F35BF4FC32B189398F5C63343C95D65BC4140BBC349F1F1825158D7BC1A766911E43468652416086C697EF14459518CA1A61EA51598856EA828406715C374A864D540DFED282D2A0849BDD833EB0449F2CC749CE638CF33FCA49DEB450F579C5AA42E3AD55D50669DB387410A0D23716D587AEF5CEAE81DDA69C0A9BDFF9C161B830901C68994373DAECC6AB0D0256FAACE9E3607C62EAC051E7A4ACFC3EB4C831B5592F682DAA5990F2350ECF7550565A49AA4CC22B04A1E52E29BD369A26A7B89A577E4464CC7C28080F6282994138ED7C2C90DD7A856178A11DC8D4E1D55C50A9A9BCCE38AAD8D027ED8A7B5F85D8C3C4CF139F8E22352C25E1F0C0AE9FFC81F3DD88680E7C328FC44D1F1F615456C8260F7BCF9E879AC07FE28FD73FF82A67ECBF2CBD034C617158B559F0C64D5D3722A23E3D0C1D4A681E8408461688034CC287C767CCC3F3AC63CB7150BC55E4DA2F8E134270F63C12C9F0DE011101B2D01E393F854F36DEF038E7960431B34C681548EB05B1B5A87579F8E977A62741C39FC35DE23E904D0421172806B9D64746053E2BA0D3711839E79377EB0B9F6033000844B8313D3D343F0B8502B77C1ADFBAE6E1674541892EE9B586B20A986E4C32B8B7268129155DBBF1AF84C09D3DC7EE67163F04DCF2D4B476CF692D203DD3E87C2B7515C869D7BEF0232E8E3080C17684E563AA812EE3A90FCE6AD5A5EDA2A82C97CC7ACE37D321AB5D4F5A6A860A74341A849C87A3277FA715D296E8C6856C6E6CFDFF56EC59FF1CB2F98CE2D76596B59B8BAEC5CF58A4F4D924F519CBEAF5224AB9880DA6CA12FF75EDF93BFFFCD067077E1825AA33B4265807D067276688EB08FF0DCE1EA3D2CF229DAF85CF323F037265F7752F1845D4E985A200A6B4FF2E9A53B87C84DE91874FCEFEC808A0CDD95393534FBDF7F9735F1E7CECD3A3CF7C3372FF07A75EF959FBD007C710A47D777C94201D0C426091E983762400E78B6367FC53CB2DA28B8CC38B858159DF9C01BA8E9D05391F9B9C8714031F266E0F76D8EB7B87B0156C91038FA87759733327453DE9D5A8AB17495AD15601FB1BF8D8085063ACC7EC048C1E6F6450C8C1B9283C56769AE0D02B59AB69FAE5905E41F8467B49CEB7A79014C2560647FF1C89FDC228A56DB45AD05923F33A10D952B12A9DA30AEA6B058E91205662E2762EB94F2FAE26449251E919F6B2B5D731C1B2516E394E9B3DC1457C66117BA35BF81A3FB92D4AFDD85AA0001325311608B802321AFEF4306E127745CECEC9B3A00960BF0ECDCF63F29FFCE2B4414036F2A3008D20F0566BAFA31637A93BC090334D1B80BFA617550EDCCE2CAE11456CE0F6A35B99A914558F9DCEA90306218540B0097283EA9D9F013B9DD0AE29F0D9E7A1F23E387CCE246A251D23A51E00C48850C53AA9DB09D19F6BC203AFECC5EA53868D001706B640EC1728E1DA70FDEB82C81A7B75A3BEFFAAB4CAED3F8F325891778B684C9C3E8BC9D61E1AD52E57AEB39014A05805A5936E2B76734EE93BEF7A091F66843A8032B4AB203CA01F01CDBEE1F9CF518569874E10812BA53975A4A6892E8815C327290F88E5C33D7F7C6CDE39AE5C2FA2181BD82A73372AB5B8A83A00014FBEF205CB0691EDE0EF83E795E109EE7EFC1D439F2C1BD4C34735D8296A51A3417A611C538287025B092A11FC1E8AE01C623290F4E12237D864535F7087F537A22E13855E5D57DE02B0806E1A5B1AE80B91D6E887A0839EFCF4885170A69964BD694C915352C3CB3F931244E283E750CFCE218945711B2EFEF5792DE7ADB24FABE122D6D964F709E1F3861470EA064ED6804356B9A81AD43899C00D8CA9FBEF4CFDE239991C2B62FF953FC03721BA18CF5F22FA502FBE901AF3B85E8F95BB2D25B586DE6BED220BD677DC76E3D39FEE9BD41E66D022CD3820F569AC0542E951E8373C894EE5CF8320013B0E907B6A61EE3C684C8707B5D2D53DC691B03C75A611956FFC4C54798A9AA01D0906875D1D9D1E3D86D7D3A70F63EF9D9F206C8C4937C57543E3C05B4157181D9D3C393E0AA407BB02B49E33E35AD4C6CC3FF5F9D7D6D1D9701151E71BB2A29E624822614C4C2D8C212B8C09C5D5B084F040D677DC641C516018B319CDD2B968F472B8920BE970CCBE937358BBF3CFAFE25BE0089250D12FCF8C4F129C83C7ACDC79170A8ACD115A875539AC83B2E8461B56B0415545FDA0E24237B06506720983A013FBD7BF3BEDAC2EC1A1712852A6262AF12829ADD0A77366D035751797BE13673C1BABF2E3FD5577DB867E23F43E6CE07982F338C5F9FD601AF6B07360A5A7CC15165BDA8E3E25544D29AFB149AAE37CE3DEFCE90C79208459CCCE9E3CCD43DE676748EC132A2F87AF6E9F3EC00597B37E32DBB8A07AF1CA6B519804FA3A3AB4C06543330CF4811425F582D98A56CD38970EE7499BA27EDB63E55FDEF8858C1BBC1604DEF0F031BD1383FC966DBFE5113C3EFA4CE09AC6A99773D2362EBC06618E7968CE77A7C90E13A304180A7053883D8A591688FA2E2DB85A2C69C061DB42FF95DBEF7A16934F460D469E8234FCFB14185398F0BB9FFB8C73D178A4775A614EA25A459266A3D08D1FEC03CC857CE8F8B9D38708D09B27E3CC8BFDDAAE9B0DC237D8E01C2B2FCDD57F7D165B8E12188C43010A066418AE109C843FBFB55F1F0530E06EADB88C0BAE13266EB74DDDEA202F7FE9FD1F78780E6E09D24BA42758C6F1DCD4C2C6E6DD28803596549B44D614F63F08DD81C7072F6386C007D01A6189E9EE1F79778F302805276719E3743D9484A3143FB2012521A6A1A97F7EE2A5C367A006096980870F9491025836873BEE7BC32864958DACD02C2A3FAEFC72081139AAD323F3F3E3888CA6A6A94B376E06FEF2CAA6DD7689E5B0AF9CBC8653B708566CE122AB8C32B71924F52098E7613C72F563EAA00510E7FF4FD6FE7F127B3EC8E70798FD26CA4E1B9C348E1CA64F764DFF3D9FEF23C9816605664570D2DCF8A9F15353E068CC1E9D99D93F317B6C709E98DEC45443B27B0EF9116850D8665433E31BC47BE55C528DA39B9C52B6F867B5FF38AE3D374F911E0936583DE388FF2133C0D0819C8FCD90E584BF0F133AA49D18D44E82147EE2E8E8772354478776E6676666917B3A07CEE898760CFCBB3B5FFF401898E1A2AEB68B2E59BDF96A5A25F23C0961C28A62194E0ED10EFBEAF8829E67B285BCCA32B14714BFD510DDC862FB85E89C13D2622E6B00707A168B4BB9F07964B609A763FEE8C1496D4C7E9B30AA8003C52A63073511D36CB7CCBA8A0B5A97DB71334C00C1CC044D8F6B41E1981F47D215DF7AE4DD9F50892D56D41AA1D0103D5212D15CB80E876151272F887DE6955C26BA89D58584AFEE76563E6311FAB9D86B1FE70230FFA049C02BB6FE9DCB6203226B38498731AAE2D019465A699758C1792A20992462445946E918246D6E021B1322A1D50236832BCB85553BADBB89EA1DD43BC428A9400734D4234635A0AB0C39FCD43F87751344A30874CB937518829D11550ECF1F120511425E96211AA43647C7C1922449F35F592D882916256E13A4A138B7CF3865270E9C400D8F6F5235296C96E5A4B41DA54B88BB04140BF70988DB10271AC6375987E73CFB094A1F099C1F1D3F31338DBD3D8ABBE6556A71CF6D38F595F3DF48A72A69B6A0D7554066C7D7C70070C15812E193BC45721E89D902B3E0BBB2C130AAD8425E2E581EFBCBD034E8315826B0E2E84666A9080EF77C6846EB91524B65FC5175681342B78D0989A88CCEEBDB7F861298E72788B88147C5C69A5A1899D24EFE7C6E2C24BDD84AB1890B2AB08BADBAF7E55F1090B3CD303B3282100A8EA98E7BD273CB139C5BB23E3ABEA62361CE1A60A5ED80D81B78297F3A09920405F6A00891B58783394D3014EC58D1B67BF5FC56D8CB8B2C22723674DF46A02C260400255190A64046C45D41D37D767CD22D11D6A2D42CB5D3780568BC68FEDF4B47A1F207AB2B7186179D50C4E37904E6A3E3D87F1FDBFF83EE3AFCA18B889CD5ED5478206B46C33020C6FA38F008BB21A6C129B155E093F9E0AB48EEEAB83A8C4E00CB368EF4FDC41C1E0AB70BFF0B6F8839F8CDCF87F898135603F80EB6C0C81C2682F0F99B1F7B57CF73A5038AED438BCB2FBF07FA0F9F1F9E26B214AD199294F3A3603E11C914B439989CA9B149B032112BC28A0E1FD78E01F83C3BA43D09830F8A3010F619D4E49056A04DB4AEFF7A3BE5267489E56C35CF7D74EA2CCA75896C4F4A7774089030A37642E3DEF9A25150B635DA6C47548913FBD1258A93B4E20D1754A1DC742D6C109619028C98937C9605AA2DC34A3CF2DEF736D25C53458518985CD216437096A57DE2A4AD4034AF7DFCE3137C2905E2EB85A9C941DC0BF1FFA0D1066E7F8EF35B69954C8DCDB8F07AE3555702D2A3C38FD11D0DBD90E0CA66EC42488563303296A76F7353BC601BF48DD8958EB8315EFE91A5FFD5AE71B1510D5C78AB793A3ED62250567081691935FD3435C04011DC4C41ECC1F120A586E9FDE2E82CE79868052C40DAC1E120E7B42B48E055036808437DFBE52DC689D4BC09924F7D201168A0A393AC958BA9472103179AE3975189150191063CF3B9F1732C449F055581887AE35AF3E8F568622F467314D50EA3B4ABD0C8C4217D4018BC7E43DBCD646C01A4438830C718709EA16EC127FB798CF3C947DF1404E1F6516B31B7E7E19E10623B3C3D45CEDAB909AAD138BEA0B58DCC7354B18EC92099463503125FDB7C337E174428DA6C70D8A74FC1B3C68D41713CF7D95193B0B576494DFAA16B7DD46BE064121201880E73807DC2261F9785AAE25CE36D93DAC478769C57197FB951F24E3474D8D079F3300A75C680535209037C55CCE3045876DAA997BEDC6B2F5B652A2B318ED9B44C51BAEF2C2827E449C18F03ED873C8F39A24A609662733B456125381ECB10EB28E9C4C178FA693BD1542764C5A6A368CA45A543B3D363E701B5C2088ECC118D07F4030755A9383CC73BAD967396BDF8E529600A949B387F661E303E4809E313C87CE2716E7FFA63A3B0B5C2987274FB46076A52D9D4AD88B5CD8F032AFC5FA7EBFEFE9F7848EFBF127B6A87226F865142A5A181A24D8033DBE27BD088D230B6DC206CCD9E31561D8D2C36919350A2780A370BFA1366E4CC08284B34CB2F7CF8E555773FE01A12BDE3CA3F8D1E47A50A9FF4A0906884F26813676766B26B77715EAB2CD4E8105476ED53AF41CD237333460E0445D1107530C6F9FC283898849DF25614AF443E230B875229F2429900E3F2C4ED646813228E80BC4ECE37CF45D91C99DEFAEE9E61100A69F68128C310015705D40F92D3B47665E52E51E01A73751D684868B9458897A2D9149D64224AD6F7FF05CE19196DDE5345FA8A893D7EE2FE37BFE5BC120CA30AA95942141AFE3499A45D06FDE8A8DEF4F237A7F9040F0A0F411C447110F02164B3F60F6B3D128ACC401A4D68334967FD4F63D1E9991A48A395101AFE7128474DA5C35B9DA33A028336E6F9A5DEB42CE26DEBE5BF18BB1C122FC3B1D3B7DAAB6441D5A2981E137456536CB64C6DE0FC93B7DDF524F953C0AC802BE10ED1076A6A1C3ED5C884F6D6C7DEE5DC33B9A04ABBD5D791E42B7AAD736E406708617CAF59528FA1B45A24AF4190629DDA6D82026A6AC6D869B1E632A374442B85C2A835F5D7DC47933986A965956413E719184B75297FFBF80C52A7224492123CC2762E0AE5A84D5C70117A4EA13B0DAD113E4760C8ECF4E8E8D933406969FD0B3A6ED00F2EB2C679B8C1EBD3CAFA715D480FC23DEDC2B9F9591020A650D488B57BF39769AC0802016359337AD7E3B40CFD8035573EF016ED20D063A07C1151CF9DC2B72019F8AD6B1E781BBF6B8E036A82576555B4F33B047974F2D921F640C2311B5AED836FFD280E5DEB9CD1C3F91641B33BE6DE863C285A803CF8C677F80AD618E12752C090F69185F313F3678617C66E78E2052E30C136B99E0BC94B2EEA07258272B8C4796675CC54094A1BF287B35A87D8122EA0543FAAC338F14A413CE6F032F81428FDEAF8D3C3FCFDD01602F16666020B85AD080FE5C617BF378EDE80A4BD83ACC0D42FE9C7338C870F9307D500879838A054738310257AE566B4AB02FA48E77950075E74CE421311483E1ABAFD4B62CF9F3AC6237617AB00EA362F6D443F693D749E4437B5A83A9B942DD82842C5C6A67B9F81A282863B37736A628ABD85D3B5303F3C8CBA16EDDE63DA96AB9E93E5EFF44DEBB0895EC7597ABC093A0D1E080919A8F73900F544FC46AF84FD23A38EB139C8DE99C81B901E7FE9FB1FC758452D987984961369727E64621A11C4DD4FBF75EF6B5FDFF3E6BEDB5FFBE9CE377E7EE88323F7BFF9D35DCF7CF297A73F7CFCCDEFFFF6E681075F3A79FFF3A71E7FFEE8434F7E77FF339F3FF2EEFE2D8FEDA143C2A31BADA2EB52F2B71E45E10E56884A0180D5B2B4CC3CF205DA4FF78DD98467037E47371E80DB8609A031B5808F651257AB1F99D7FF979720AECC4D0573037B080123637169B54D57DD6314BAC228A6D82C1E3DD5D00B08FDCF4062CDCF6DBB01CD39F83C2DA86F8C9C4A25A8D876F0F051046A93D4C8A1D75A42AF7E129A34A3C91C7A48F758C8DA4DE5681308D0748B58B6DB32668B6D6475647076AD4FEC5FDD83BFB1F0DA6FE8FA95C1F27B6DD52AAF1207E556F4050463CC6E45331792FADA5E4455F02AE0E8002505B78C22531EFEA868BFDA30ACC022150D05A9039429CE698CA84112844EB3F45AA91FBC067520FA81597A21395C600E175E6008DD17B8C134B3CB4056C805253DF4CE37789039068643EC47CF9CC48EC7F340CFEEF8F33B5651A538C3CF34751BFC23948EB9AFDE29085EB75C5DC234054DEFF04918E4D99141F8C55A9853441C2EF2F546924A14DB729E69D73DF426312D209CC03E88D7374AF46B060F6DFDEBBB9CDF6A9BF8161C6A84A310908A1707A57F718C247C867845335AF02620F6E86D3B45A9BE9CBA6B85FEB9A80D330C5B83F2358680C36C306097660381384165D73D4C81345AF1B9ACDC8AA36638BF4D76495DE66159205CD3565B981A8599214633D2CA701B47E051AC6CE8873F6591D4C005E5D46DBF8352252C71C828FC6475F8477BF1B313B651A5E6D12D969A5D96381822A8DE2603EABB960BC87CF99BA374DBC8644298A9DE690684141415C0034CAABB0ECD699046150566A0AD103123C849037792B19E2791EA237EFAE9295485445AA08B96BC111DCD2930013513834E1340B1CDFFA9D893B557E03CDD0E940758E08C9E48B497E8E302F333FB6E3CA0D5BE73ECC0B1F9732384929C45444DA00C735D066E784DECB58173DDC0F9569AA15BB6FFFAE0D4FC7330AD982CAC2CE61E348F4904E5085F669EFF628F28200B89221324A2620BBE3A075C8ADC43E8849911380E1442817BF2CDF1C9A0F44D9C57AA4052A82F41EA2E1F8DCA8D634BACA4C55611F996BEAB9C434BCCBCAB0D9CCAECBD2B96079739FA659BF8AD3292D621AD6D9BB4D324B4B2A8EE06E033B46654FF8C82062246428FA27CEFD6C73EE05C35CEA9CD68010E99A763615025826641B212FDF0D5B7BFF439EE9DDA25F3623F7F41ECCBFAAFD7F7897788AF12C59470218536896DD6E8E8E09DF5D407BF10D841C696E9EE39DA21007261C4D6B6DF60895E7780E2D1E407ED1CA56DC2B45D1464E21826391AFBB6D26106384F52BE432CDF86A3785C22362407C76F0B90E1F8BD1F0C967FA3EFFE84A33AC5A370B96AC04CDA2890551B693659AAF37F1826823DC5B963309B686A80A09E4A0EF0FFB2363419851520E18CA60B1648B3E1F85A455D703E3CACD4177F98FCF234F8304777DDFB62E9B63BD49BB67AAF448EAA044434E3F476D3B80AE0C6EFED23509DED6F686152C45811107720F69A75BD3620D84694217D8B564856891D36EACDE6E1B97D373D413619730DF2EC39D8AF4938F1B80854E13DAF7E672D2D40910C1C2B7DEFD42F8F52D10E5834A85524877181B610F6083693BAFC722E649DA91A5D3D9BA15990580DCC28C604420553BA1EE612155FB308AD517E3679744CEBADAA3409C371E39B4D241BFFF2DCFBE46751E100207F66F021C9F394CFBBFC2F4F5B4764A145A27EC80687E44E514C2DE7B3BAEB4F8F106676EA246A72B04DA7501640903375C80763DF343CC54455C6C5561A466CD879F32344CF616A87883A104DF20E482CEF7DE16BCE2DD34ED6090EB8A9AC5F18DD64A16A1447AFCF6AB9FA1770D06942004482720779068997720A1F9ED23A26D518E2E0B6C43A7DAFA4AD373F4A0ED128A8B8D333E7C164236F145B0791F04B1F1F03BA6929AF0574C2BACEA23724BA54A3B10A9D43C7A81FBFDFC9E74FE7586A86C91FD649DEBFB2152DBE80F1A2E38F4542B7A1A45E1CDBA81F92FFF671E24662E1CF2C209103458E3607C3238C6698B061ABD0A7401452E7B9F206C7F4AB4DD03F3B787DD3F5771E1B1D9D1E62112139EF906C902EE1A5CDB65E7F9B2010270D7419CB7B6C5535FB710009623C82F140B5C326A33C14E285EF87B436927CF421452713DC0F1C103421440917201C04086853EB29AB77966E7594ECF08AE9F589AE778F2C0486A707D843D123C0C94AC1654FBDFE0B96E9C4595021887E0D1E351A4B11D4C0DC4ECE6F857532CA159B887A4CA14D8371520B8E3A0645EFD18F0EFE5AECC13C21CE141EA5ACF73ACBB015CBD36A6CD5E581AB7B50EFC5B9A5E5B7DFCC324C5481330A748DD5819C1E2523F6D6BE095044888C15522C06A72A1D11200E934227C22D684789E35C1140C1E023398CC6FE581133751772753E51D91B43521F72907F2E08F841B8FC556765B6FB3A9FE8765B19F5FCE522D606AD6F052C06F489F9B5A8241B072A4E7C38802A0BDA0DA56DA2E03C341D3543775A49E5B2157D6868CBB9A8739BAE3A88720456A78D35C1ED5101A956FBDE196DCD7D5F0AE25B419B1705A67C7F6E1641D308AA6EF8B288054A689D189EC5E733CBB70ABD123D93375BC5D5B9AD1EE0BC579984E64464D610971182064715328F0CFC7900DD5A24FA8F2E6863D6778BA237E2AC4891B4D43DA1049F24934914206473C1B18799A5ACCADE3170A20BD1C5D4505E03C9470F721C325FB9E3069ED543778001A99EC38EA3F0E3952F8E8B7C90EA6BC5B94966D2B2A7DEFF09DA619CC07228780600339B0C5D78CB232F19792903326ABC52EA2C25C586417951399D27192B8E0EBC21A77D1E7119EAC4F9ACC847DF1DE11C952038A1DD301AF5DD7AFF8B8C55CF189E948483BF0EC3318BFB78E4CDEF0C97AFF049DB6A23EB714DD816B86A879E77864948CA6B3F1CC75C91FA870413B57E08B5D0B8193C4BC5158FE8476E10482BE07D8803D2DEDB7B0AA67E0ED5BBD028541EBD802809B0E8C9716D79DF6D46C16B2C540D6483E93401C83C064E16C4D94DBA7EA4BF43F2F9D8FE1F8A3D1D02A1A02E9C466895175D6FAAE98041E682CA251B76E38EF79F0411065E085601700F52EFB4AD5FDD7B9E7349F15EB1D304F1AA6F19903F2EACC87B75C39E3174D821F4134A0F6A1DD039A3DC915797B8A9C134BA4A3FB4DD4CB973797ADF11941881D4307A9282B7C971F0317800F69B335A0036E816AA175D8303AAD02110A9662814474D75F8EA3637599EC86705F8CF26E16DA6DE2526EEAB5D2273D0B611544A5423E94B3B5078779674E8C2F018166802728BEE057015098D1FD722B18F538DF564D5D4359D001268D30E93D45EF4CF455FDDC73F3D4662BFE4E413E18CC41E027DFD432F1BF969F4BD1280C17A245408BDD34232EA90B8221FF83C25D101E160B9A96BE01C09D59AF69B399F2CBDD84A113A1CA28D249D79402DDC592F043A4C921D1CCA9F91409511A671DDE6B23A9B982275E8DAAB9D92DE328DFA59BCFC3D07C9866579DEC19B5DE44DD6E8AB13B65A51B303624FD420DAB47832340941208D9A52A0A1DA3BEF7D9A734F764C430B832693D872D794069859790EE532A97B01031D91DC9A989B3B31024A1A059C2BB73E09EE0D1A695A84AFFE92510DA7A90E647496027B921F5E4D3CF7E92F9C53B855D42AE7641075D658C66C300E48D97B467B70903C02D64FEC3C7631500620DDF8FCAD2F7E856C9F505E86730A41F55FDF7B0B710A51564DC2709E188CAC2C1FED011EFCF804588F660975FA68E6A9AAB30659DD23E1C1773E478088DC0F6E006113F567220632B9EE7D373FABB7BCC022B60F0772E3195FFC1CAC5CE67C929B023F7F123550F83844F9A31F4E88DDA24CFD125C65EB8DFD33C2B35A5EFD063C3E5696CB438F0062A9FC8FE8B330E9FD573D007700AC30F38CDD30E60F3EFD2E2619311E407FF42342FE7E8A8C31D5CF7E7C70C401ED77FD0A9D646D5691E8E793E12059DDF9A73F2360C156615E1FCA36312164EDF19F7B4FCF9B45E77251450056000F7925941EC674904E9945AA8B1C09D8F9092A363C3AAD0DCDAC3642DBCC38743AC71180EC1C11D6489F52EC4B67DDFEF306FF7F107B551B0821400ED1791AE71092D8FB165FF9E05EF25901C79D40721878E72052457CC6A5E99AC7B865A9A63195201B856EDC6E10B182F38DB9F9F5D70F6A474ECC21FDC65A67CE5011EA69EDCC09EDF49783273D53F26CD1C73B7ABB2866B767CAD69FCE4E60CB52543F3B3587F6657C953DC34B62733A0C03D69AC76E5A96D2661583F6B859A9255B9E7EE7676C05400BCFFD78E08E8F4F5CF6DC2F55973FB6A1FDFA84E24661582287F40F8E0156B6CA8AAE1A864607004DE58290E269D09E08FCD36A9FF8F86761509A193A342A596B2A1CC680D68B7103A2E4016A9C2E29BFEB55321D8B624F483E5C3C5EEC81D5C7AEAE360B4A85DFA8BF4CA1CC6DFB743F7992E87F3441257D646448ECD9E4DCFFC6F74062711C3ACE33345F89B6EA6D88B105F0BAE998373AB305781E9D8208CA734A33527A3877086DA4D16BC93CB63E2CB0A4D575D593B6CA9FC56E1F98FB577AE40506562F031D50596920DD105ED87380B53999801246A7C77924C0206854FA0247F1F4D95981573AE79B0BB75614B19E13072B3774A0F0EE04C21C6C5E683FF8560BA3E3C327C1A1C46CBFF9ED313067D19BC546D56811B2F6B54F0F93F8C074534F0B901AD1C88CD2B1987630F9A5D90586CBA3F4FD922C62D6F9A657DCFEFCA778521EC8A4C707327BF608D61D10EFB119ADFF0A9C9250648ADE9BEA4ABDA8BC3B5F47DA951AA4906747311F6C07F92C90939A6B9EE482D78A35D568E68F16E660FBA303F7F723D4FC83074A216DAC95039C8E39DC9634A7DBD0AFC654BA4DA4EA4778FFF2D7149850752A79E414FCC0E5803C6121401EABDF7A839F2A478416B91D377C79427B0600044C0CC04F38D5C83D909660DE1A04FA9C569E5A632AD98C0C880932204E2B1E7CE25DC09AE3E304304FCDA3561FA1D510669B520FF3DADC969BB8659996611546FEEB3CE41B076E7E00774B77C8EAB8A99014F925600D3313209EB75F750FE79B0ED3827EBEFA514579ED379DE38397190403AC4FCC0231FC7185D77F386327CD315596E1884B3A6903E7CDD0C90568A44167E0219BC39F38F03B062FF6141E2CA27ABA62BB253F1F0650DA88B32E50C06C246DE07C367C7674114C475C06D99918420E1B770988A2EBFA875121601ABADA3C62952040E39994FDCCB7DF1D27AB3E738E2AA966468E138D8482C37988BDF6C6E75F340C8C472EC712C7CB04B73B2A9AF71C1D41968755DD515C0A8D8EFC17A616B2F4C8ABDF3804A7DB046798FB2459786BD694757FB58FDA0682B98F6E9AC7A8C70D41F7FB1952F2C49E83CBB336192456719A5ACE2F77E0BE0F0847261B3435318124CED4E80CB27DB4E403773CC9B969AC9301C20F7029DB49E65370D6CD163AE40069CBE0925D0F7DC6907CE21B50C728587B1636E3EBC7C7C9C7419545C2BADAE73FDC87BEBD58FE93A8212056156515D023015B03982D8E5289CEED1047150A649B4D5301FB37500E06271C20AF160B7543620F3A30897D5A3B97DEAC9700B1AF07928A1344C4B236F7D0AA5CDF9C5BDD13BF35F67C57E8DDBC3C2F3AB8DA39A6DA20BAD038A10A54D0E30889A8D818370A063C6151040A4D0FA1B32276FE87076637F4DC1393D3B5AAEECA3B9EF9EC14AB14268342DD9AA6507346D5CAE887A59D3F74FC5478723E1752EAB4EA3ACEBFD02860CDAB608133AE1B6A8A5802952AA848B0F92ABD43A7EA2FBF31A9B4B9FEF23B7F1AA64A447A720AAA6750AA343F06A097806EA8C84E14563BAB6CD3DBD10AD94459651491FB056A038990CB785CC4BFA090E4E4C802641BA54A62690917538EE4028E57310B5D8F8ED1F839E81A3E1784FC0B067E0BEC4FAC3B4E5E1086D619C9B78813B720F079690F89FD3028597C73533CE338BE3A83EA37DC193264284CC293A0292D9F00226F0EBB639C1C42962262C9A671ED91135A5BFF95E6B2261374AA89417FE7D537DFFB321E7E8CB5DF84FD9AA67946BA919AEAE35270E83AAE7B2261C34076C5CEAF8F50B528BCDBF1F9F38C72373B3E3644CD2016E6519FFFFC7BDF0B3CD4D68A2A8430E8722B8A2CB8EAC177F168AC6F27BE47702CE5B3D865B7DCFD0CE7976CACAEA066B0381B86CEB7C4013B7D38E205620FF8F977083CAF1D78B15FEA9EAF3B2A4C7750291D5947B95C650B9D0D2EABC5D11C7A411BBF678C7678E0941F9E458A7804D402740BC2DFD0C8BAAAB9579991BBA6AC71EBF57FFE79700A55E8B8EFB37394FB221D816F219382BAF8692AB86DBDE56F3839038F8DD605D6CA06D3E0352F7CF823166618AA179B127B687C82A549E83D5EDEFDE0F35B6EBFEFAAEB6E7BFBFD2FE0DED1024D8109343A3F7E583B0DDB33FFDDD1215CF6A0566B1C99AB17952FD0549825D772EEEA17BF3F8B3945FB04B86EB323D857639353A40730C1091BBB4DC3D659C0014EEA45FF6632F880D313FA4449FD5C44AD4542EFEAAEBF62C39D9F22E796E04046991C1E866E199F9E1941CB07B04AF99E6CF8093CD759F451980739E13C9021EC1FFCC4DE73DAA61B9EE3EC12500D8A001EA03D8BAAF8C358D902C4D161924037E0E4D3215F68490A9B1F87C3D8FA2C80D86B7AAD622B2342B29A3D35EF9B457C662EEFF3CC578694A3DC0D945E01920221EB8EE17670972759911BE1CA67C7713633D51C4D0D0E4FC05B0149093743EE079416DC578676D19A200086A23C4DE503B8FF966D37A131138E5E42BF079C9987932DB6DCF13C09068A44A96C690CFC734C1DEB084C4AF304A3DF305144EA6BE2FCE869CCCC2CDA07A293C23C903CB25A90B157BE1D023B18390EE7B55772E155C6811B57145D0EF1233882AAA389900B723B7431DE7D7274D45AB2D621A9418062326997B1B2DBD03DE3EA3B5F22953AAEEB7D87B809576662AFBDEFF51F4C71EC44D4261C5888CECB86EAF217F69C40DD0BE50818A906623F8D1EC194C69B1A3D7F661AFD5C61E16728197E8C35F6C48F9E25047276960A7EB14928B08711BFE785CF4DC2565BC537D29968B19596B1259119958C5C04E006510355138F4CC3576080250015E68CF0596482F8A11FA7B01D0E4F8F614B526DF1C40C1984EF4FA3FA03EE49A12D4F7B8BAEB29314BCFE0D912C698331E6DFF9B34728F2622D3AF23AAE31085F6D44071CB1B3EE7487911100A73BD27351927FD7F156107B3A906CF128DC8B1AEB228450778B40EB8FA981705A6A3673CB33A9D0995C578A9EE8C6E8DEC0BF991819C61DD2341F39A1ABB4A39D414E13F572A17FC09201C6047E0F7EEE82165E5F446E3BA01DF324C0D7E0819739290B76DFF51C40425C1EC58FE7D1C081A0CCF989E1C1E15360DCC1488DE177A897209F42E1FF471D72CE8D9FFC01F828EE69FFA836B5E63ACE35DD29ABC7485D69AA2EF6482B452D10568BBADCC0BEE1EB0B6363E343A08EEE3D3AE91C9D6B1C56608303B070449102B93478505D08BC91BD47165A5FD6E296DE7184358466A72042AC50E0C2538A461750FBA9DB366370ADC7A647C022446A7B7C9658B9E7A6278F20F3ABD576DDFA02E79CE892D20D18963C793AE36DA9B1217F263CCEEADB02B1078CCF013D82C1C7C169715B4CA27758497720C12E52567A48B20B02135FB052BC6791B0CB737D52408183BCCC307933B933011BFE74D3877447E8BC74FADCA9133FCD507A6508AA679A0AB798D264C12ACBA2D380489E3F33347C9EDAC880F38DB4304CDFD5F7BF21F050F9AD44FF7F9C7AB2D514959BA1F9A85423330BEF5E3B7FFAC47E2A22E61D9905EA11035184CCE061D16E634ED75983762D5AD00105E465FE0730C9DD139C535AD95946F5364903E6DE6B9B7BFF029F84B8AF08EDD1B403C615DDA2A8DE4D7BC773EF72CB14A89C3555F71AC55F258AEDB60C58FDC42B7B289044A4C63AAF535F4660BDD35AA092C57D7799456FB4C12940A80747C22C32FF9A475FC37AA147252167E7D1F5020D3626C0114171049A5EE970BBE9B913E7A954E9F8D83CB8BDE766A17F50C841EDB1C7060F8F31CA50CD15F7A0A135A20C34B130965783A8E79B5AFDF181B1E1E959EC1FF067A1D979154A102FB5E623B630113C66C7D0DD178A8CA79E4178E7E74E8F4D53A21164D290CC2ECE7BA3A5AC5B18D68C849FBBA62920B1920F5E18D882FD49DDDC085C04276A58EB9BB6490FC05662339DF649F5EFFC19843AB3C11FADF32F8CFF5AECE9E4CD2E724A23CAAD12DB6C31B34E29107BF24674FD46D1C66F8288AA0C02851E45831AAC0A5C9F7D47D1D109893A94D932581B7A1F1131AAA0D0D808342FE2C3CEDAAB4B31A79CB4CE28B91BC88D494C89747DCF813154B6E9FA9981BACCB7D6E66B15F93744B2C3AF8EA1CF03D54BC193A64E6D6809C544505DB095F35DED9AD98723474CE300356566B75D0DD9C3BFB28C280248B2D8A8D5C15F1E79E31BBD650936B26AFB64F0F09BE89C1FE0A289BDE039227909CE3CC41E4D5A6E79F27DB247BA638F29BD70EAF801B62858219400A1E7F420FA6A611B631320D137344305DB649DD030F3BA879028B69096EB85972F997AD6D25477F4FAA2D8C3DA7791D8D3A99E10FE25B1DF85532571949DB334674D50CA03B6AA97AD922EF35897EABE76B9B4D424B50EE100D8533149EDD835675123421B079ED0D0D838C013A48B501241DD07D144044E169592537753B8F4A434B12EC7CFCFA0E531D4D843EFE3848E78E3F01C78E0F8453460841940E100B74CF3EEFE51E862607E6CD1418F1B01418BF59F24C412EDE85055C54CDD045AA18C8E9DA54E6414A751F50E1053ABD04C5B79318E15314B007DAD1B84134BFFCC079EFC088950F06E581F652C37DA1F8EA11D0826AD62E026ABC85C3B758B29C06AC936BDD0465F75C9B78788FF83AF60E178CA2F7C78AC0824363CA3D12CB2C8269ECE90E2144D5C4C71FBF50F203D817F858E60C914441C48489C6241072A5EA1B8A96A180F70687072DFA911DEEFA0BA2C60C910394CE0FCC281E179E9860E2E2457A0A183ABE850CA980A340541E36DF29BE6C145A5AE9EB8CEB9D1E1D3E7091661FE1355CE31E9A56EC2B010E7068F1F3B8D399E85F63C3AA3CDACBF9E735DE1B5F232714C9BA5B2D75E05624B695AF1160A9AC0CC21AECAE81C1DC233737E7C0A41D08B7B8EE9F926122692C44E0AFDBF16FBA583EF2FB2F674D46E2751C7259BCD135A2C71CC90C7CAFBDE3F3638A33D3B780EC68279DF64910162C11C506D9DCE0DA0643B72367B0E0CBDFDF98F1413C0E125076682687C54B4A87DE9DBB3E6F2527420856DC14909044E48AB70A0C7ED2F7C0B6581B585228557340956FE285024A2314F8D8D8F8D40CC28E94391292E0BD606D282CCD544A3F0C8B56DE69212BBC436118E8252D5DB2637A0C2FCB247DF225A11D60ADF8171999B472D37F60496B7E1F27B0D7C563826B45983871B8DD35450CDCA0E12875A953680B56A0AB6825F9E734C166FE38E0D51D80A570D0F8D161E88D6A6590F2F1629D30EA090729EF4013E7F78465B77F99FADA2D7A035A00192DBCA561CB60D534FE7C3F3624F81163BFE51E7E433B1C74909107BE0FC9A2D2631386C0FF8226A2AEA6CE4EB13C356DCE018FF885DEA15CBF3329D5706C94A4C132A0D92EA4C929AF55C57BCFADE39220B903709DDC67C312838FCFFD4F289750D64943236009FCFA129383024DC273C963B5EDB0B036BA1D9648A7651920A3AEC2869179C1D9BD44E71585E6EEB75FB0659BFEAC173E7874EC392F365CDD31343549CC30EAAE00500490EDEF7C65F811ABEB9F7F472CD462755A9207C03D841D4C75ADE228CA9C42116DF1D216C852453272A482550E00084283AB3DA3438D728BC4A20E93488DD218E6ECDAADA05D63DFF79682F40E9A47ED851195F1F5E40C6DE3CBCC428A61E3D4B505F002E43684619FE896E838079C69842A4CE6600274990A73AA7FDF908C5FF0F3DFFD6E3AF7E80790042041534866E1CE097CE11D28E96FE36F28D4259250E7D021043B5A7923A9CC9E59E5C7B18DD6EC09C9B9E45E8C7474B4BA7BF20E29B40EF425493CF117882C103BAD881385809F94B9C8D87FE145C60B910ED126209AF15F9AF7DE4AD037CECC0BAAE61CD6832A1B9F0C5AD77BFC0F9A698E3D86210CCC171E2C59EC2709DD9607EFEBF68ED9134FA47628F6A2D3A52A215C70922610E16270AB9E22BAEE0F39014CD32DA3D5E51330F0B8FBF1C3D4B012D222BA8EDD73E3F64ED29BBF1AFCF12EE8D7ED9646D818212FE87F6268F7E7692F35B0340CB38FB6AAA42517451AB80E022AF8C66828C79E48631AB3105B05F6706119FB2B08A3978F8399CB8829C297EE8C749ED5B47B5E06998C970C0282A67C1236CC629CBA8123196AC7BE7E83CF9E2B8550A9E500D44054098D083C88BACAC338D2C3695358999408A51DC023A3A52682863C4516DEA76F3E47EF4DB40F39375F5DBD1141CBF45DC4CE2ABD0CEE3F3C7E4274F4D9F1A1C4617C7A119B25747E7B41F1C198F2FED429745F451471B021C26090D02C40E32BF7898243BBD974E98C75A523F73A4EB49EC71F23448C189F8E416D3D85D18EC586E10548B2223B23BDCD26E725E714D4061BE5B7684AC442C2DE0E2AA05494D9C534672C9559F9FD41E62628CD87A64044813A33E8DA1FC60787E068E379A1BA3B9E3107F8A238FC90104EDFFEB2B5C60BA654A2D07D2515C83612A31F671B6346821E689DD8288226E79E20D8FBD87966F0C1F633C65BEE330C0276A6943EC7F72F8E70927277E1E12AE67B50FBCFB8BABA618F5A4C0AB101EE3F056ACB5E58A1DA07BAD69D8C1C7C0BC70EAF6D2029D29F2C5C12987B0B522BF3C71F8669B84DD22C56ECEB3F8EA07DFA699471CC5024B04F89472634DAC77DDF692B3A4CC3AAA1A6427B1A2478C63A4A32AF43C94CF7FF43DBE827D089ED8491C5882A60DB3B367CF0273D4592608D5DD4FBCEA1E19FFC657FB89AB330C8220ED4F4045D400132DB75EFE0AA7E51922BF8322054C08523C68552C6F0355647DEB955F1F38CD822A841220F6CD11DB1B81E404D5056190A70E4EDAD8347E1D07C69C426EFB80D65C5AE240A5B2C57AD2263D191DF78CA438C86C68E9BD6F5C7B143D19F0ADD161247D71E4267F9410BE1891D76A1899679BD161888D411BE6FF5AEC178384A5B3B2104230B1C7A15C29BDA8CA062DD74C55AF1F908D1E525F1F3A8F69A534EF08A519F82584AAC65FB0A2EF7C7BB6E7BA47ED433338EB089C85C8F69E6E75217AF8CF23F3DAE7F769E980E1881AC31557D1A17ACA3E939557D021C4FE39E12B2AFFF6FA97FCF58F8F92D7C02F332EC23BCFF80BFFAF00A53F3838D979DFFB5C402EBAA353C30F4D2FE614CE39D26F5C444164E156A4F7307D442E02DCCDC784EC2FAFFE32651EBDD15ADDC885D7A22A439CB403A75992D8AB3B442968D745D529381ED75CDDE8AC2E33F24D4A2EE9FD603F8AFEB46077D013B15B026B18C444BC21C89041CD3F8F6877DEFFAA83723DFA7021EDAF175E609944E7190A41A1A79345F843C8A0AD81CDA0BB092FF6448BD689BDEEBCF73E7DD536C8BC18D61E151749EDFAF1E5CBA3730BBCB2FA97AFD91154B46EF99AB0D822516C21A7A911A67509A2AB0D4336866DE8BBE3BD9FF0BC086AA088757D47188EC777CAE6A1473E260704FAF5A0D65EB916C47BFBCC2664A75D8BAE45C0C5C1F1413A43D18F09218831A20CB6DA33B9A2E9EAFB0F4FEA52D060C2D0011214C6922FC6A742798187D2F9E098B660EB7DDCB224B06B1112A3FF0A6D1E45330820546BEC967EE5636FC0FAE12681061112C07F97B96C373DF6A9C033D34151EF91B1DB123CFFC85E6174E3DB07294B770CFE239BE473F3F310787C18FF995D7DB55578B1A5A4CE3AAECF20A6531F7DE6952DF6D28D21698558087C003786A5C1604539BC3BA605ABEFF627DE34F3922AF236E336E8D7A94E84B628D03E7C06EA01E7EDE1FEE98631FFF22D5CC26528ADD18BDF82F3BC0D7C53AAB6DEF2C13E7412D40178BC7162301E2A4F17C0C8D4C5F4680438AEDDF9C8379CB906AD13E135D341E3F256DB35D7A0EE830E020D5A1F5BBCE304DB39F85D5E65E09E79AA22640007B10A634B8CD10E04479E109EC78B3D23D4C5F1497B3A7DF85F89EDFFFE5460B62F11E08109843386DBC00DC2E18146E045C3270F59876620D53BEFFAE0200AA068F130B0D8481DE3CDDD2FEE6DBCF2E188AC067D8F2457659993A234A70527DC7EF7D06B5F3EFCEA67188FBCF1F5836F7D7FEB2B3F6C7B62AF75E60017D344F5AAE957B2AAD53E1C606EAC6E1005ADF48D2F28E8B8EED1F7F6C172224246DB70FE57B051002EFC3CA6FDE8F0EC9F5FFC6A7DDB75CE6A9CCD94C94557E154706AFB27EBB2C7F9798115389F10B99C84C65BEE7CEFE82D2FEF7DF4FDC377BFB0E7A1577E78E48D7DB7BFF8E50D2F7C5579EDD3A8A9B244DA5CD26AA8C6E9CBA0C7C3BD07A4D76190D0894391810C73927A98299470E3706561F0EA659AB2F65B9EFFE8B81607FD01A9E27739B2F718689EF1F01BDF14775D8D93B6F4835620ED0C52976D6A8739BA0C23038A9E160A76B61F3F68F198D8438563C4D3116588FC61ED297EC33FA1B7B9729B9974B7301646064780A3366EB34D4C417C60FEA6808D75C1252B7DD6F94A8A4C34559CAA1E15D7E6097D622402FD731DD26BCBAE7FF8E59F87C09D84CD025F86153ED12E244225DBE28726B5773EFFC1BAF66BAC62565B6B4ACC136AB8D00D86281157347238233479AB106D8EA4DD00F371D635A4C8153DD4BC571A0667A39AF8CF2F7F0D500AFB925C6ED6B91CDB14871890E330A3BDFBD51F53AAAF41A72A788538D7CD251B27BA6D4626C8043DDEA26B6D57E23FEBE1E2DDFFF9A16FC7B4EF1D1AFAE4F8D81727A73F3B3CF9E551ED674780E16B57D6DEA4EF9B67125D6B06783514E7F6760714DEF2CE71ED6727E73F3F39FDF191F37BCE4D7C7E6CF8EB93539F1D9F7FECA393916B7ACDA3AA4C24E0F0F6EA49E95073D3E43E606F02FF94F84D5B9EF9EA3416088D0F707B472668E0CD43AFEF51E4D679A8F3F5BDE36AAE7EF4AB11EDABDF0F7D7D62EE8B43236FEF39FCD5A161B4F87A6BDF947706351D11A38B164E0154C0FDD949DA50D983B4AE5D1C75F280AB78ED23EFFD8CAE0A4C959C4239E8AC16F12FA61CE3E8BCF6A94F8F976DBBDB270D64FE622EB4D61C45B27828150E4DDD0568939ADEC5D6E84BCB375CF6C4BB27B4E88C04AAF27747C6DEFFF6C4A7C716DE3A30F7FA21ED65CFEC35929601F0E64022C6994E1779F8FF47624FC75F2F1D91C71B7C2406FB7148B010F16D4C03CE57B248457853659FDE61A52A170465A3922938BB6D65F3CDB99D7764D4DD10BFE9720759B1B3AA0204551B7905CA06D05DD356DD208C005777B569D84AA17F12867978268E8BE782577338113DA202C79E72095B05385635B209559F88CD7068194AA671F4223A34237DE29B5127DDD89B5CB92BB7F3C6FCEEDB526A2EC37F86AC6EB5C3E1761E492096A39ACD28A59D88AE32F016FB0CA09B235B2CD37619A01A2CACC826A91E479773DEA92651EBC4A1B9E8CD4C8DDF2272D0FC980B5B0FB22A785DA8E5364E46E51CE4B39DEE07AE94AC4190D841ED87654DC68073E475C8F0A1DCDA3EA1910BCAE596A5288B77A98AB7AF69BD694DEB9FD26BAF88CE6D73516E340DCD300B5D09E20A4A710D62AB2C923A4468841AB5993811F02370D2761C55B33324F637624F602CC41E143D76083900C57E88BD896CA7508A82EA2D5C0AF2B44DE0B78544946444966F88AE4A0C2B718E2D354E6EE6A2AB895918DD6697BA1B5FC7F14C5C68AEADAA5099D351DE7AD3F6EB9EBCE981B7B7DDFAE4B58FBC71DD236F355FF3405AE5D6C0F40A64C8F4033250046124DF049F8B8ECAC5ADE218A644547411EB13DAD350D92DD2F450A9B5A2D97E453F4A21D09D4218BAC633A96A5DDB9F76DCF9FC8D0FBC7EC33DCF5FF3E7E77AAE7B22AD6C872B9A40466D44B1BD505AA3276DA042B1583A079D7CC6D8262AEB8A010CD16D95D2629F58E218BFCE3422D35696E320CF0780E7105B641F5BE6852C86E7DAE599DBC4B266F41416F111754CBDADA6D6343CC72DBED42C6285833C1BC32D6EA39D341F47419B44958B25754269AB50DD4B4DE6A15BE54D6245A5B5A6920B5885855ED57A63C7ED2F6EB9FB151C74DB71D353411995F6B275386D1E2D522D95A5D6EA0A2B5519F885EE0965D611D98E92B5DE094502EF44574D8528B2105C156A2A83723705966C9B41E20E4ED66914DF034B00571FF09EB5B4103DF6721AAEB8ECCEE76E7CE0D59B1E7CED9AFB5EECBEE131A021C1AB1A2D63360AC3F3D1B3C040D2E480C6F5BE95289BA109011763058EAC81D3DE84D3816CD39AEC12ABB0E17136BC53F41A6F4D218E39B35797D9C651AD873E70C4C40E205F0680D87E1DD8C3DAF39D2FFF0553CFC8B9AC97CEAFC45ED7619B9C4FFE241D7804C8F361A05E050C0AA1AC1A7DF205924D82E832343CD78F80375B64A68492AE3355D61B2B1B918A17ABA8B004AF40E94D55383EB5D24C558181F7F80B00525D42823C0B38C0F44308A7E19CC3A7102B50105A2592E2FA2506910506E1EB0DC2D761DBE18D20B240282915CBCA8D943526EACDC6712814A7B087AE4089B17E44E9C88D430688C0AF469FBF5A1A2A807C8DC0D58C94CDE8066BA4AA3056D38104223A3304C775E3A8092693F4E084B4E19A94D4D4B515E4FB8B9058E2F6F074A64A1CA8580B23A91FB61ECD30D1FE19754166F2520B658599BA06BFCB7FF1A2230771655EE679B1EFA2E3AB50F6C35B7BD6C69C3173755FA1934C945B8C64DB840A1CCEBD854EFE467D7E7C3D283A01619B22838AFDC34BE9444774F5A1E371B688E53B8C65DBC49AAD82381C6CDE248AAD4056D22870AD41401617B8127DD738BF555CE01A83905C61F806B0868C50CB85CFD09CD0A18BB8DB45CA06A0873E408FA48394D45245D7349DB607952A70D21A1C538FE679A8B413F8671BF8641878A58BFCB2F05B261145A6D22AACBB50DD49E10CCA45E0A7D06035FCF8A39A4E22142019A6AA46E347DC3F8685A2D64201455F6F216F3443A1A782F60CB601FD1C0541B4166088A2D9091AD19A2B2AD04FDE425162AE28C37BAC02FD1CEBEC4EF74FB38AD18E233A0D959B81ED51D5167AD184E47181AB399A8A6CFDD05CB44511CB80B0D688549B512107DA3F207AEC647174A95174314E64C3AB50B20926816646D7429612AE78CFAF111C753DEC6D55B38962B3596CA949449E5120CE6B48417B5F9C3C691CBC1A8D098D624AD049053BC158DD49A083A20FD55604EEB0B674782EF674CDFA384D54532F56D71AAB300FD556F24A0C902F3133F80BAD0E32081756E7C289157CD5DDFFA5D8B33BE31BEBEBC49E6904927C7E00DB142474515643D386A9C109393008E80C87F7100CCC0BDB2E24843C6A4D3A854911D8A6FCC07B1DA3901DC1CB6B165EA8881A94D8C9AE8F141AC4929185940DC89D0A959BF106DB1AC350D542B444B40A2566224F62C7F253569C9AB1A8B0FB71E8177E117D63208494F3A4E742861C12A5AA17A837E3CAB06686715BF435DB75624F81B74EEC179B08931C32106EF13831B6FCFCC561CCF9D84737340DD04168B9C118106C812F04F34BEEFDA2A9E7C57EB179296E9E3F8A9CD714983A0355BF588ECA3CA62CE070A1BE20BE1D841F87983AB7A86A87589037E093E30AA0FA6C3392ED3296EE12AB77A3C103DA721AA17A5F8E4D5987CC9F9EBA961481B20503BD7A21424CF761D7D2E0CF42BEA845326D4D5614D44EE2C7EE47D731591752D26281AFCD5F0D3F612ADF6C26A9348BAD42874953752B4A8F61D348E6A149119C6390E403D4E8E6C51E0BC7EC07ED130C16DA40CB7481D1B0A4651876C57422F21AF11D868A3E91BC4F2CEF162BDAC4CA0658056C06EC04AA5F806EE5CF71E03529260419D0C44E84696421F92D870F2B368B2084CACD300338F7DA28B11D7BCC30BE93D228EA36782286005F10C9AADB504DC80FBCC74D2E4E0E1D20879FA3740C5552F462510C13A85C05C8317A2B5BC0BD956DB292965ACACBCDE555D047D812B8A0613C3618D428C41EE46B52A384A0F14FA74376B0755B75D2019BCAB409992B5523B63D23D4D0C65E54CA4B62AF2BB9FB5F89FD3FE924E82841A456812DF36D3D164BF4499777F25B56075C414E00D4E9066FE278284257DEB7A8AEA8631F7F520F71E04979B7B287E45D9A5ED00431807F08C05A4B20160DCAD40DC849C6D443AE6046789D424A91490E760FBF814817624E196C8689C605713FBBE9550DA5D340657C717D90139DD8937522A48D25D5488FF0D9355E595C781626FFEC933D82C401FE66D0CC88D692F8D238A59BFF0A363A03F074181E0FE32DCE0005F64B6BCFCE2359EC56CCD682B8D2D05FA8C0850AA3EBD04944B4B32997AE6CC7316C9828DAE229D8EBFD00FF20F3189C743BA7D8A6A71CC0B7D04B1BE7C9A22D1F0EC34555BF20619B219A85C56D814C125F48D90B1F9E9FA8C557DA94E425A121AF92F6372FF68B6BC12F37357520EF035583F15B50632F4CD88AEEBD40A4CD346D60701B61A5F08C7864354AC1FFA1D8B7E9ABDAC918A8B75D3488AD84B134B1EC244F96CB4437CE840E1C1FA22FBFCC50BE535F31809A3376050CF8148BF033155374D18420EA81D8E33DFD05BB14F8548F616217286790730C61122C4A379DB14DFBA79B88AEC852A3D9093F18F2025E365A8C411130E54ED2BEB439E13092D853250CB6046964EC4CE4B9A04A502703A6AD89A6192A03E6102B451767653334A52C4D434A564D6BCD101C047DD80318BC626589F3A5029B5F1D4BC59F4ECFDC04561A7B51813DDBA5FF1AA4F7BBBE463F4FEC3DFE953D18E21F7E901CF27B7D494ED0548CB9A9E4DC2E0E06653323AF8B1DD8B4EA06CD971257236AB0EE87A8EB235B21DD00F847EA96F9CCF8A13EFD38D4AE34926AA4C9A28216FE70DF0B6A957C3F0ACFB878883D4032F2E1C9C540ACA5D9AEA7DA812D085CE0A25C3A2FF68B5AF6572A8C5F6F6684A9E1013F03174D02DEEB649E97FC8BA49D374AE4E3F162CF8F0B62BF685A9993A5E6657289C0CB8E2163F346D2881D8336EC10FB788A6B40474744C0C911AA6C25FC49D66728EB05FEC425C200B2C9C4DF51048D817F852A41B0AAE0632232EF18FC6FF155807C68C6DB529D9D21AD8D65C563A2FF1FC600E5B4A8D90306B93F86CA76268DE802CC2F0D561CA69E2D3DCDD54579669A2B68DE5DBA8143D36900C2805266E4683CE692D893B5477790DDFA8A2BF595BBA1E098FFC864802696DF696C7725E06161EA79B1C75CF17A0A5BA59B066E0C4A99F432EE101DDFF1CA2FDCA29282D2E107E92CAC2CF61E7F4AEC9205D61961082D5B56F6611526168A83606FB8FDD4BE12403D06FD05BFA2DB187C78C87C610A9379F89DF1352EF6A4D866E6A78B3F9DFA57CD6F7ED5FFE6D762FFAFB2F4FE27B1BFF8788C25FDCA4B1D4BF2A1F72BB3C917B9226C4968BDD95AEA4C37DB3AB4183AB15FB2F37C74C03B54B4A8F184F32D6A5F9D0AA4BFA34BB9B293269A172D5EEC13FAF5588CC402077C9D72E0BC355E44CBE12E62300B40F7835F673C197C1865EDAA6DFAAA1DF44A25EEA0D0F0A69ECFAB2D2ECCD2357FE5B4E357701BD8829801665B8087250E50174A1D094FE70AE99A17F0ED09175F79CDCDB400AFFB74609E4EF133EDC0AB451634913A63669F99236C567C17F20CC94F205C807792D9EE27838CC48491BC9F3C05F80820FCE1BB780F7706E28A410E08321768C6B478FE398B5C2EEA92AA6B9AACF348757A0AAA931581E061F919D6357BC0C589D645B244E28498089FE1EF8457793A995FDC66BCD82F493BA68B47552E063B17D522CD580F16C840B18B5FA30B5D2178D9D3E90B169D515C00EF003E02D6025B883736CC2B24698777C020005E11E026C91DD8429FD4655878A9E355155D90CD3F09AA2E38651C768AA8D11309DFE2BD03BA8D45E542FA8506555BC06588EFA181CE96E4CD319CE822B76E094A5BDCAE8B61205D936A342ED0BA5814ACFBFCAF2BED743DAFFF3DD6FE0290A0B35D345F6C42691FE074071647E98ED75BACEFB9A08FD1F89DDFF1BC6E638FB7E8CC50F8C4068F9DE83C05902E30C8EF62D38A79542132E4838825876749B360BD9BF5E21B75D4459DAFC1DB0D027816936424C6FCA6D139F078A3137B48FE16327D34B94CECE30195F1A101DDB30ED4FC4DB283C520BA5D457698B7C64B9888CE136392C36B77DDABAE5E8A02199DCFC647F53A508A3F5C94B903B8136C17F8DBC670111570FB31759816DDEE274B0EE83B81541EE240C23571121E74016A7855FD66F27EEA7102502085ADD46FC6E22A2CBA97BF31268BB19B6E93F1F14EAB417C1B867E7C075B713A8C8CDCA50B382556840980CEA3D11903DE245C347A196769D1A5BFA0A0792768695A742E0F421243D55628324380B5F85130A6B1E5A8CF2F7E0B26171A84921DA4C2B00379958DB645E40FF26B0109C4B7E88B70C84908F15D226232E1D7A924DEB02D1A129DD8B30BEA24560745E91CF2A575C757F8E895B767D0740903487BB35FC476253967F5334B208E0E3B671A969CACC5E2D7455BC5FB8634397CE0A32374F2E0DAD2581428B2226C57FF4B797B9D30B02F2FE995250E806E67E89C553E46C51CF15E531BEAFE08A7414A43DD444A91F9303C0EC143118451AB09A863D69894373F7859E2659EB7D2CC14EFE2E26107609498630FD4940652CAE43B21DC62A37B11448016C7EA7632115D2C4ED2B918100FAC04C41E82810E36F51405681098312F4B577E0847AE0F9130526580CD695741F53099BF20F62CA0C25718D042B8031F9BF14FC75C477EE03D627BDC2ABC3BF223165788D43C0FD82CBD2E6199BC1EE49D760C66FCE1DFB2C1B2FAB80D4C29C06AEAB725EB122A98D8C7ED00CE87209C3653522338F9A8C33340BF80C45A0E6D1EE1E56A88016611D36D2125034E7A59877DD03DE8017D40D73072772F8E2A795DB33874D68FF4A62EA9C1006743552D41A10C4E6313A20B04163D1DD858E817C63EA49F0054C6324F71D01124A8BCAC5245B36E9BF1DC649EB3C40F5E39920160D06CBF50B1054F2D024E010E95BA0D478651FFE9F816B231F02E1946C0FCB56DD0892C42A17C13DAC330371BCCAB36C211D9860494A3DB990C1AA04D850F28B0B55A0C94CD18F4178A55B1F1F8C194F2A2B2D695BE21A50D83C7FBF398495A74E63890BE631E1F39176CF5D52DE8CB68A0A8A30221D81EE868442ECC8A60C529AA62C0CD4550D46239DD2284CC8B3D5FB5C5D404B9603A0C4FC7E9E64DE9BF22F36463FE29B1E721075E3B2660407142EF769005B808A2D715F35D24F9E4A692D853ECCDE718753A98CF0BEA1E86A1E517C49E647E5107D16748DA21ABCA36DDD0213ABCE5E7E96E8CE5426E3C73D568306BBF9826D1893D8F8E2E893D381E540F0794AB9F6CD7220AA873F261ED99B9F8B5D85F907C5DB84875514CEFA24B39F37D9895E0C76FC49EE754E9B0D9C5A920B1274483177B9DA9D771F80055F29DB64CE570E3D9D3C501DEEF672E3DF9B4D068107B3D70B613EBB8B4660EE7A801BB52779ACBBB495310140FFC9C94325E29A3015083596C76B7BC755D74552E48FEA2CBCDF21ABCD680D88B34E85D5D6FA469402F00226B2B29414087B44241F3F10EF93B0C52813D20849CC49EE4EDB762AFDBBEBC71664A96DCAB8B33324C2A16C55E8D27229917C6352D893D0C389FAF85A706ADCD8B100544EA76EC165ED7F04A8761B73428EF83BBC2A2F0B7C4AF11AEAC334B6C73EACC1B6FDB7480395B5F468F435080A092AE464F477DE941F7D241CB3CA040312F7B6ABA6191A6C910ED157562AF9B6D127BD6036F51ECF944E9A25682F160F18B2E0BC6502A5D2A4D27F6BA8E1A8B41E8BF2EF6FFD437170DF56FB0C40BBEC7C57E086FEA2FB67B7CA078B143722162E15DF78B66FC1F7D4CC72C5872432E7C86973A5D10715148427FE1E7E882BCFDFA361693944BD5EF17C54E4BAA94A506795D7B91A3F5CF78564CFE792DB0F4FA9B4958F2B09816B878E8BE423E11CB892E1D3D7C01B0D415F32C82112CD1CD58003A7C8EC735FFDE3F5C442B7FF38B4BFF7951A2E8C21516A1C7DFC6A8173CB8BFC399179FFAEFE7EABFE906F3FFB573072B08C3501045FFFFAF0593360D755144784FE6ECAB49EFE47652858C557EFCA6356EF67C8CAE9364E6DF46F35DE0B86C5C7959A2FBF6786E422FEBF096E97EEFC7575D57D758D5EBBC8A6DE1AD97BBF1DC7FEF7047CFAF669EB35D4A4FB10F6BCE63ACB797AF91E6775BFAFBA73E9D93FF644DBB060104FE9600ED1F6D767EF594F53D087420407BDA23104780F6719177681B73A825407BDA23104780F67191D7F68CD13B10A03DED11882340FBB8C83BB48D39D412A03DED11882340FBB8C86B7BC6E81D08D09EF608C411A07D5CE41DDAC61C6A09D09EF608C411A07D5CE4B53D63F40E04684F7B04E208D03E2EF20E6D630EB504684F7B04E208D03E2EF2DA9E317A0702B4A73D027104681F177987B631875A02B4A73D027104681F17796DCF18BD0301DAD31E813802B48F8BBC43DB98432D01DAD31E813802B48F8BBCB6678CDE8100ED698F401C01DAC745DEA16DCCA19600ED698F401C01DAC7455EDB3346EF40E0058B419BBAD3160C930000000049454E44AE426082)
INSERT [dbo].[Aerolinea] ([CodAerolinea], [Nombre], [RUC], [Procedencia], [Logotipo]) VALUES (8, N'Star Peru', N'20118763086', N'', 0x89504E470D0A1A0A0000000D49484452000000720000005608020000009C82550A000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000206348524D00007A26000080840000FA00000080E8000075300000EA6000003A98000017709CBA513C000000097048597300000B1200000B1201D2DD7EFC0000244B49444154785EED7807505B5B96ED05936DC0C6D9D8381BE71CB031180C06DB601B274C5496101984C83983C851A09CB38444461249049133181C5E7ED333D33D33BF677EA8DF3555FD8F4C77CF4C8FDDBFFA95DFABF7BA50AD529D7BEEBD7BEFB3F6DEEBDC7B8D8C42B8D0C6EFB3330068DDC0676700FAEC16370C1A046083851F83810D5A7F140DDCA07583D65FCEEEBA51AD1BD5BA51AD3FC6F6FA0BB2B921021B22B02102BFA086FD3142DD10810D11D810811FA3B37E413637446043043644E017D4B03F46A81B22B021021B22F06374D62FC8E686086C88C02F4804CC439850300F0A954008A97128CF2498B129846504E319858A8C605C30038588A150AE118C6C1242350B9080F10F80C1200C78F9C8BD7FE1D40F70F473B9C514D06A582DE04E6814C231701AC281607C28586014CA3286B18D82855008DF084E3702E320D96789FB53147F16E33F0B2380BB3FC411C206E33F1CC2845030A856B6318261381B228440ADC10586A20EE57C027FB18A41AAFE53A9FE205A3FE5F7AF9DFF21DDF6B154FD45BF8023D0EC10203784690C63022A21C3210F0A121BC1F9109205C138069508029CF2213850838FE353747F30FE1F11FCD9E11FBDFF970B3EE5E217340F813C18C379A0D937853036C101C56C40B1A1DF03C1800B21B880CA4DC15C9320AE411FE0B4CFB2B63F11BD6E0D04F059CCFE7C8C18683581F34D611C03B3083E20D434946E8BA4EF44355AC298069145F04D105CCB50AE59286B13820AA8FF3860BC4D3F2A3EE5F7AF9DFF5C41FE45BF90319C0F683501CF2E309E3142641CCAB581510FE2689E994DC7A338E6703104E799A03816708E199C6B8C64038A3F8A4F716A300EE7FFE9AC21850881195208FE01FEFBD9F5998FE0137E3F15CF679BFF41F140267081198CBF2918ECFE02082101FC6E87379F89A4C692996E69223BA40C6C56C628A629926704174228D127C3FD94FBFF46AB394A6481160380C13AB3EBA47F92D075CBBF2C5A2194D822B4CE2D3EFB4576F5F534B6355E650B933F494C127233FD6A34A628916580D014C587D00CD3600584E55BA2041648BE3982F767B0420B41456FC309B761B97638CEAE08C1F670DEEE68890D8E6F8DE2D8C7B6EC8B94EC40336C82EA77C01BEF94F45E2BEAB543B1EDD0FC7D51A26D28F64E9C683B866F87A16DC3F2F747097745884CD04263B4D01CCED882649B233866181E101F90067394D850EF70AE05926B81629B62689BD02CEB608109426A841298833D368C6B84118152D80C6742083A84026D213445B24CB16C206B9B116C6324DF320464546C0113DA860A4D31225058261806B0691ACA3343B1CD316C7318D7D0C1688E65A8C0022101DE4D51CC0F61904D308D26A1723394DC32946F0D6359A21846182684611BA179E67081059C070059C3A58F5309641AA68C9C9B5A4D7A9E2F3C1D25C6A5BDD4099230B45E33B46A4B08D70643DF8CE6EC44CA6C10344B04FF3FC30A2900003336FE3527E324AE85BD0731D43331DC2B49D253B1DCEB19CAF371BC1DFEA46B4932CF42CDF564F915A2E47414EB3251E05DDAE392D5E980A0384630DD0B7A4EE07997890AE76CE5DEA0EA5BA90AB7E2FE1DE162A0F8D628EE1638DBB06C18DD0A6D482A9804716F46F1AD80342198D621421334171C82DAB78273B606D336C3583B8344E6C8163B84740B866786E36C46B0AC42991608910D5C698E68B2C4D06DE00C5334CB1445B784D34CB1CCAD084019CF1229DA8A10DBC24560BC1925B4454AC0C00A4DB7868B2D1042607F0BACD504A982B02D96F04E3304D312C906B1016C067B0F826F05135885FC811C685B203BA908C99157F816CCBA44D2DDD3C827898282ACC72B6DF004C190295EBA350C549C1C3CC05AA1D85668AA25C2B0862D6801F8FFD3C00AC9B3F1CE3806AB7E90ADB81543774FE25C0D6F388FAE3A87AEF24A62F8E54A9C239B2F61EA5E9474FB976BCEA26A763DCE742552EE24708EBE2A061787D6F6398654DE88A60556779D8795FB17B7226833C7E214E00D1094B33582678D6D0179051C19D844F2AC517C1B34F8E78242DE19AC32C772CD7134732C673396678D6399E2D99B91924D5881355C04EE0535BB0DCEDE81166D464BCC00FB18F1568C045830C10BCC712213240FC289B6C1C5DB105233141718076D678C014E397B61DCAD605FC2098D22C556188E1DE8125C9B49A46257147F27866E8B66DB627880872D08810D42BC0D29D98614D9A244EBB4403628517C4E384D5CE65CAA3F88ACB9935C7DAF48402DBCF5BDFC314F34E299D3E4942D3E14D3638BA3D9225A6C301A1BB4602B56B40D27B6C508D701420465B2EF45C10958956368990B81F13857763C20FF2C9C743B9EFA284B184619B911413E1E501C52DDFFACA4F34408E96A44D34958C1F1C0924BD8FAE7254AAF74EEF160926368B96FBEE432BA32A0B4DD402B41099E3D6C513C1B247F335A6A1726DA82E400EFB63831588C354668C83756B41DD56213C6B4C1524018801A3B5065065264D65840107F7398C41ACBDF0A28C6493663044061B6A025BB10425B047B0B8EB71318418B37E3A53B50922D18D95624D71EC6DB899518454BCDF07CA0519BF1FC7D70D99E201E20CE3C46B53FB83AC82B3C139101CF61EE886ADB8C935BA0259B71B2CD61229051907510D53A20B33099674C06939241A4F41F4B90B96564E43726F5557A7EC73BB5D0565FC66D7848526C0B5759E3E93648B965980AA82758218041463F002C032CF85A7ACBF978FED66705D79378DE85ED17A29A5DD2C4F78B3ACEC6304EE0292E192D571304E7221957E23917A3299EB98A6B44E6C1D0EA7351CC1B299C4B04DA9D2C95238EEA002B3F8327DF2F6CF520F5ED8D51581AF227D8192E04F9DF8611D86185DBF162E0DAE0F103B3A0556DC2A43BF022BB08F1E670957978BB7984C222426A1229B788EE30C2CB4DB0121B14605F66819399E15B2C633A2D22DA6C71F2CDE1C22D1192AD18B92556691AA1348F6E318A529AC728C1A4254E6C8E956F852B6C91522382C232A26527426586531E815517DE0A1CF47C414EADF3A9D05B27746CC2484D8068E065DBA3445BC3D9B6E17CEB700333001048E31174734D59384B5477BD78FC6E72736BD5A32F9AECDE34EFFD42F9AC55C284550CED8F53EE8F54EC0F936C8F079B896467B818AC04000CD6C7DBC38417B3BBCEA4288F46B19DB2DB6E67B77914A93D8B35CE59AD27E305A71344774AFA9DB23BAEA4B4DCC9EB74CD69F52AE9BE91A9BC9ADAEA9CD375355DEC942DBF99D37D25B5FD1C51E49CA9F22CEA76248841FEB746C9C1D607927D22A9ED24B1F56452FBB104C55182FC6882D23E5202B6B83DE1D26D78F90EB0CD46B5EE8E921D21081D53846712794712992712C4A7D30C57DA45775A46A8F64508CFC68B4E24490F27B48053275224C7099243496D7B93DAC00E7924457C264E7C82203B982C3E98263C4454DA4774EC0E531E88E21F4CE21E4C551C48103C7C9E51EB135996DEE455A33910A3BC1C4B3B19CBB78F92EEC44BF6860BEC23F82054BB2829D81200A0537102EFE4327295DF8CE0319F17D3D4E4B7586DFF7DE5A6F715C6DFD2B62E738384CCB8E2A698AC9A327C49834F1EDB81D0BA375A0ED804FCEE8992AD03CC1CC0B30F85B30EA09A770654EC09AA3C866E3A194673CB6EBF57D07502DBE4105A7B2A82E58867009C8DE11C46934FE1E96723F82730F47B851DBE957D47D0D443083AB8E66602F76555FF8D4CD50E2C0F30B513D1EC80A638C6088E626827C3996763B99753A42EF95D6EC5BD97925B0FA041334AB746B6DB6305FE7E39455EF81ADFF046DFE84ADF30D2637C5D283123A6C6AFA0F3568A10E69750711F53F63CAAE66144C3437C830FAEC627BA3CBA9C145D56ED81653C44553E89287B94447A91528C4C8A2394FA14897C894D71F7A39BBCFD8B624A1079ADD7E3A54788B2BDB97D4EE8A62C97D00A6F78712AE56969F71E82C22E4C720027D91B26DE1E29DDFD019013A189509A5B518D1E2ABFFC9BE6DD6F58475FD7DA7F5709BDA9DBF4BE76FBBBE693F394138B7C8F6965124B48C691248E293D07E3547B23A4FB2265F651F2F57F8758E5AEC06A638FD4AD4F0AEC5F951D09AAB0F54EB3BA9B78F015E915A9E32CBC7CC7FD94EDF733B63EC832754F36BE9368F3286FDF93FC9DBE8556EEA901D5FDAFAAFAB63FCC83AEC59BB810ECDC63F1CDC358F6E2A904E56E2CD7FA49A9897BF2A6BB29FB9EE5EF7C926D733FC9F84EE49E97794FAB064269B397E2047671BCAD04D5395463E945DF719BDD33DB76CEEF3D3C73F8E8DC4E8739CB2DFD472F2A0865C2A4B2DEA317D68CAD26771D1873BC3076F4D4D0FEA37DC72E6A90C89E509876EBFEE92DDB96F7EF9E39745A7FE0C4F416EBE9A3173BC33264F8E4BEBD8E8B26567311C905BC6987EC6128A6735BBC34C0337CD2EED082C58EB9D8FC0CFAC0EEEC76B3E8D6FD919D072294F671AAF53A83F6C7F5D8137AF612DA1F2693A464945A55DBCF7ABC5469F765A5F97BD93D6D1745C1CC59AABBB0ACF06E568FDFADE8027DB787283C16DDEA10A9391CD77A2C4A703841BE0F4537764B876EC5DD886565B67E11CB9BF3CE3588A96334FB51C9805B4EDF85A4F6EBD9ED07910DA6B789A657F181A52AA278D935A3C529ABE77676E7BE1779C63751BB9E679BF9669A5C8BF54CA2E677AFDECD51ED4171215F12E4423881A82D695F0B6D183E8E6782AC185D82BB4537E6767DEF94DEB2275CBD37B1FB049EC43DECB20C998C5E3AD34F97C3287D710184A1EDBBE6209359679FA19CD2D15D87264DEC4750A1CD2DA3AF4A940159D2A779D2F00C01E7FAA35E33E385B31707689258C644F28B0CED8EA3A32626AB576E8E0523A76D1C466C8D5FE792E2796BF609BDB684CE7D09D2F89BFED35616B35B2DE649B450D6E49EE4AE7DE1B283092D87A3A587088A83B13200E8505C8B0341793856759C208A2D4ED5735FEAC589E3D4B3FFD47C6A4A9B2B9694B430227A2841F3E4336B2DD832E9D2E9D4BE5D041590A1C3F14AF090EF489001FDDA83E15878674237636DEEA75D8FA27A664AFC48DDCFAA07FDAA74CEA9925331C29344E5C914F9567F92B133C1EE1E319A3E182F5BBD9C28768C15DBBD2C872EC04E8514231A87CF47D1A1ABD1079F65E677ACC29A460FA0E89047B6B17BF2F1D0720267E27149B77D48BD891B71BB67AC7FBE2C4EF4FA52927C7B927C7F32CF1B9DAED87F65D6DC4E77D979ACA4B924A3BED1F5E19011346D6533F50A3E9C10ABDD6635B079EBDB4781F27C723E2237CF3F2D2D9D929E42E69FBC3E6BB169E1F0297519B3A8849EE71B38B0C5767A97FDEC73D8E493A75A8BCDD3F68EC38DAC57C2A99DD1B25D710AA7386EA3D3B331D34D4B478E4C50A54F29433BE25A0EC6288F1155C7E264870CB42800A093606D44C999B88E1DC4C16B6964458DCFA8226782E7FE1DFDD44407B1455ED0C608D7B0E356699EBFA1D8CDB75545B2674FA4F61F88E39D48131F4AEC3C95D8768AD8712AB5F318AA61DB933CA33B71462EB1666E846D3EE917C29A5094C91775DAF389E213492A873891D573127433DEE1495A8678142F5A718C666D0DAC86EE246E7F9012431F2FD3FCFA12AE69936B92A54B7458E3408672F534AEC9E84E06C8D68E0709F67E69565E29D06DC28157A531743D8139EA53D8763C5AB89FA87148550407A575ED38BE646636B66DD7C4D95B5D071CF5DB1C46F61D5507C452480A56006ED4DC76668BB56E9FA3DEE1B87EF7BED13DFB3A8290B2D4F2EED3D7C78C219DFDD1E903A727771F555B6E9FB47718492961D1DA5437BC46376D7E77E57EA740798F39BC33BA7D57FAA01BA64970CC7512B298BAE9D12AD578D4F7EF8B6D39416C778C571C27B61C4B94837F00E86C9AF46CA2E40CB1FB6872EFF1141E3EB7A485895EA6DE58629F79CBBC34D612A5E347CFD35CDFCA300B6CA76F690EDD1A4150DDC441A2F444AAF4647AEFE9D4F6D344D5F9CC8E7BF9ADF7F2DB6F24898F639AB7FB1541372337DDC4BBC431337BDE7A147783CBC0866BE5570E5D8BB90C2FADEA9A0FA24C1C42938D3CD3A11BD187FC0B034A3A5F95A91DE1D5902BD1C429DE258A523DF077B7098C4DCE44F3DB047702C52353BAF34529742B618F5F6E8A682E4BB1742B597096D8722575F048962AF251ECE096EDCBB626733E7E9288F4EA104205B6243B8709AF697F92236DBC746706B2983F7D69B8B03A2F8B191F579D1C5B9F90CB2B0ECBD2ECDE336B613AED1E2C8F4C6D3BED3A646435E2B073B4B4924753C91D2E4F40D0F2DD871D9D6A6FC5BC4D569F43C1302224B767CFA11963533D32B9B24577B3A2073C5F9F4BED384F509D495639A6B4807F00E8529AEA6266C7F9F4B64B191DE7D364D7D3BA2A4998E586335FCAFCDE316EAED1CFBD6D0958A2EC5C613ACF7525BF6D3CF05EEACB6EEBBF5B310A72723E557D3EBBF30C51BC33B4EA76BAF04955FFABE6C94795C3176379A0608DAE61DDE21879EAF70F4A7B2EA5B63B847321B74CE87CB86F2297AC5DF3C850997BA41A2AF151DE91A052875705DB9F65EDF02FB2F22B80AEC7EEF14A4997CEBB1068D065FCB67BC979ED6B318A77A723D9A61E59D08D08C7809C82EEF72FEB74E793541753064EA5090B5C83964D2C2777D88C3508923ABEB850DA77296FF04CF1E8D1FCCE27B8EA8E4347A64DA0715767BDAC2DAA59F7A240145C2887952B725FE0878C8C96B66F59C929CB9CF87B04AAAC75D7992908D2DFBCA6CBCDD63D78ACB380E6F71C9A48CEAEAA538427D3D283730447AF4D1B410BBB766BAB9461BC8173F9ADE7129557333AAFA5765ECEEC3C97A6BC98DE0E00DD4CEFBA52A476CA6AB998AD76CEEAB896D5169BDBD047BEF50F0A98BE2DE74DEDDE6F456E8B628FF795D6EF442FDFAAC2BF6CDCB5A8ADCE90CC5C4BD35C4AE9BC92DF7D21596CED5760E69960E7976B1F547120A4C6F6510EA015BC38453167C259E3EE59ED5753DB8FE2D946AE8956CE8941059DE982B1C381E5D045F469781D9E358FA04C7815B5BB15777856F61E8B646EBA93687D87E09DCC3F8BADDDE4127DF0657E99F63B187B067C58D8FEB412A8B3990B0ECF1A21B67EED9CA3B99839E89DC2A69CF55EDD64397DF4442FBB1BCB5D384F6C3995DD7A32ADFD7C412F26B45A6BE3B8606E35BBEFB0EECCADE1A357C60E1C1D3E735E83C20D3E099C33B6D51F3BDE4BA90F557D7991C06B767EB9646C3D6DB567223C4E4BCCEB72B83C0E59CDD9394C9C701D3E7553BFFB887ECBF6C10B1774B1F9654DBA7B559DE7329537D3DAAF67B65DCFEABE91DD733DBB15ECCC009073B6D6A9A8CB25B7F54A5E2F7838BF99DDFA20A7BBB61AB12C7C30D8439A613C5BA35E7FD311F645D3C9AF2A76BFEB8E59E3387F297AA45277BDAC9FB89EABBE9EDF03BE8F9C8D911C43D51D86D7DA0796EF0FAA3881AAF7CC5284D48F44B2E77C4BD4CE19ED37402B10F9E09ACBE1ECA0CA81C0CA4EF0367512551D58D54794BD7D56D5772B43E152D8E54AD25E48329802227B2B967F29967326927C375D9028987F5CA976CFEB3E172D3D89655C8C24DFCB156079735EC5FD4E39CAE769EC129F68D9DD002922B984D3EB53DF7B2D5F75275F792B5FE99AAF0DC6D5B3BCA2A4BE088A5F18D517AEF0C6CAEF85481EE179A90DCD981CB193BF0C91D1C0EEF16E583C97A7098C22513D5F2A5C0239D165858DCA94547E9D6F88C0C94375E9A1E2E683D687CF05E1E9B9E5AC58D6F8A38A1EA7DC7640A5474ED7ED3C4379DDCE55BB1674DDCEEF01805C4A87C09B0FF862E451DA7BA7B4DB296FF2529136A124BF8FED3C270FD6B4344C355D7E2F7D382D09FCBE62DB0AF7D69A36E55DE381251D2D46B8E054D27BB3A0173CF07B9366FC2A077D4AB57EE57D218D6301B53A58D35860DDD0BDEC963B399DEE45FD6EA57DAEC5AD8FAA35FEB5A3CF2A755E85AA07E53DFE0D03FE55EAFBB90AF76CA547618F4B811AC0AD48ED57A57959D1F7A25CEF533EFC82ACF3AFED7A5ED4E651A070CBEDF22AD6FB968F83F6F7ABECF02DEBBA5FA805DF189D0A7B7D4A871F350E3E2DEF7CD038E00BEC17F4FA95686E15A83C4B27EE94773EA9EB8693BB031B87B0F5CA00B20EC9EB0FAE6FF525F77B341A027859ADBEDF30F8A841F3BC507DB55CFBA0A93F903AFDBC78D0A7B1F776E3A457FD70408D0C55DD8E6AEE8A64F7C299D3771BF46E25BAF3151AD7BC7ED7FC3EEFFC1EF04A79BDB4D73DBFF76E610F881F00F2226900EE95AAFF84F5996A4A4A273D7451829F14A09669F6BFA2DF5EE5DE5BA9375E16B97FDD7C66A5BBA8A463C1AD507BB7507BBF4CF7B8A8C3BBB4F73EA9EF4159BF57692FD8A3DC8ABA00DC8BBBEF168DB8170E0378148FDE2B1ABD9B3FE49E3F70B760D095D477BB74F066C9905389FE66C9C42DD2B83369C499A4732B1902702D1971291E76291E752D1CB9533072277FF86EBE1EDC7BB7A0EF43DC3D06CB259ABB24AD4785FA4EB9DAA36A0054FA9554F9E30ADDCB72DD8BE2BE60CAD0E3B22EF025FE7E8EEA49A9E64161976771BB739EEC41AE32B8BEFF61810C64EB5583DA23577295C0BE912C84D77563A9832FCB3B3C32C4DED9CAA7A5DA67C59AFB992A9F523578F5B893A9B89522F62AE8F025691E9569C1C09FD483634C3FA9D082C5DE2BEBF324F582850312BCCBB48049C8A7A21FE06179DF9FB03EF3A256535855D9CF0E5CE0BF98A39E5A9107CFABA9A3B48BDF3599BC53BE127688701CBD6785CEAB6CF85EF9807BB5E64EF9805BC5A047D5D0BDCA21AF8A21EFF29187E5A38F2AC77CAAB4A0489FD6AA5FD6770535B4C11A5B1064199A2C8B6F142790E549D48E34A63A83AD4D63F6245194098D120259154B564590DB51E4AE50B236A0B1F765C3E0F3C6213FF2E063F2B06FDDB84FCDF4FDAA69AFCA718FCA91BB953AF7F2517752BF5779AF57B1EA6622C5374FF0BC501250A240D769FC492D1EE9B407457CB70CC68DA8FA7B44CE4D74C3BD74B65FAED8238E4CA0EBF1E4415730992AB447D63E4C6361C9DAD0BA1EF754864B32CDB758EC95CB3E1B56E816D7185CA67A92CD77C257BAC793FD8B64CFF3C557312464B53A59B21CD2A07B58DCF9B8B2EF71793F68D6C7A43E9F8A41505ED0B35ADD3A9ED60C02FCE9F06EFD5450B9AAAC3E7190875AA39C7ACFBBF84567FE3CFDF8BFD49F9A1EE94E95AD3DADD5FAD40F3EAED2BF2AEF7B56A709ACD3C0EAD598868E58B232B549924FE597D1B855749688992361E7C8B9D92A6E463B3FAD479CA295A4F449928778917A51FCA43C79A1357BA9237BB13563561A3F25C04F089FEB052F4705C1437CB88E831D64450E306274F478212F97CB2BA4B0ABAA59F402863495D61DDB3C14491E43D42D07D52CF8D7CFFA54EB6FE7A83CF25BBC73C5CF8A14D1E47154C500BC6A005E33FCACA0E37EBAC83385E51AD71058A67C5A287F5EDA4594BD0FAED379A4F21F1788BC33688179CA588A3EBA79CCBFA81D7CD87C5EDCE257207523363FCE13FB93542F4B958115EDC1559D2F4A5A1EE502534C64635F826431A479E44955EFE3DAA1C735238FAA869ED48CF8D7E95ED40C404071D611D0A003F88FC3BAC95775E3E8F2E16A7ADD00D563857AE08DE8C10AEDE0923458323A8EE3CE05D574FB37EA026A87898DAA7C1ABB99574FE3D6B078157C41B14C94DF26C9EE92A6774B5215A2821669895C5C2E16560B8464A188251071B942413DABBE81DDD0C8696AE65319022A93DFCC64D73198552D8C1C1533BD8395D0CD09EF63078F709E4E701E4E733CDFB09D56394E4BDC5BF3FCBBD3A247E3A2572322D49010C715E6D10495357C5E01AF2781391AC59A4553A770AC0504889032164A9D086C1C09AAD705D6F6FB152BFD2BDA93B913E87A2D8A368C64815795BEE0C63E6483368E0136835E245D174AD585D246822923AFEA07829B86D18C3104551FDA340C6B1EC1B1A7D18C8980BAFEA086413865144DD5A218BA40B23690A2031BC00BF2B07FF3284040633F0004A70C7F14210D1368FA10BAEE4B74933A8FD6CC6695B1F9640EB5862C51664BA6D0643DA6490F6E04D6B379F26621852E613789B9D5220949D49A27D2A48A86E385E331FCA948C672246B09CF5AC43066E08C09387332843D11C41C7BC55A7CC9587C4E9B0578499F0D62CC06D3A743E993A18C15187319CE5E44716670BCE908DE448C603C8EAF277114956C1199C5E4B26A5A9959BD2CFC28EBD538D36785EDBCCABEF5867D6B8DE735270CD04913E5A2129EB4B94CA42E100FC573C7C2F84B28E117819CB540D652207301CE5A8533165F350C03E2421A0610CDA3C8E60974D3149C3E0A00088551C760543DE01143190DA38DC29B8630F431344D0F06A18D8348CA088E39010EB1D47E64735F28B9176428B44907CEC29B07614D03FE8DC381CD7A288CA1FF2842B92308765B146308469B44531688CCA508CE7B1CFB6D046B369A32886D1A4283BA604CE0586351CCA974E66C18F73596BD0CCA044B9FC151A77194096C931E431E85D3C610F409146D02491D4751C6B19429001CF867EA01308C510C631800C718C2D386C2293A4CD318BA790CBCF522A9D308DA1C8ABA80A62E61A84B21B43518ED3582BE8465CE47B0666238E3F1DCE1049EAE82C9A4B16AE44C828EF67C8176EB1DEDFC5794935FD31CDFF2EF2D729F4C89C306E4F932712343246990F4960BFA097C5DA26422863F132D5CC371DF84325661DC7741CC552C75228C3E856C1E039588A419A20221219A3448C6249C360E80664D63D83328E614980108A582F1329C3A1FDA3C8D00CBA1CF20C923E8E6112479288C3E0E4573263E0EE12C8A331ACD198CE6CE46B326631963488E0E25D261387A0263289E3585E72F84B147A3794338F6208E3B80678E86B3F4E1EC513C7704CF1D0AE7E9C2F9830078CE58185B1FC11E8B628F47B3C7E3D8E3F1EC71227B2296390B10C39E5B47346B368631134B077CE9A3B9EB188FE28C45B3C762596371ACB170DE5438773C9C07EC0FE139FA08D65404E097F11A2D9A079F17A2F92BC9DCB942DE600D97CF10540A443993B4C7538DB7BF605EFB867EEC2BCAA1EFD817BF62DDFE92F7704211DD2F49EC90978A142C4A8BB252A92E560DE62B8772244B99A2C524FE6282F0759CE86D14FF4D387F0D144A0477269C331DC69AC432C6419DE2D953EBC030A622B90B319CF958D664024B9F219E4817EA0A5BF43CEDA874681A8AE74F1104D37F063099CA9888112EC50B4663F99304E998C199589FC59D8E12CE2771E65379B30992F128BE2E493093C45B8EE72F11049309C2298044E114513099C89F0648E64DA70AC793F9FA44FE789260029C02960D1E4533608628182708F504E138900B703B8881C89F4EE24E107913C00298FF007DA2702C4938162F18FBE33533E032702F51A0270A8753B833099C19F029329ABF14255E8D10AC4689DEC548BE48958C95A9466BF95201B756CB4B1AA23D5DA0BB2C53CF7D4339FC1DE5E0DF511DBEA31DFB8679758DEDB9C87D3527C4B6A9CA54ADB5D236AAA45BCAEDE9A474689BBB740D1DC324D54C75D7524DF77259EB2C1897B7CD0154B4CF37AA279ABAF5BC8119F9D08C7C60583B353EBA38BEF0D5FC6FFF5EFFBBDFCE41E9B2E9CF824CE9F447F1598CFF002349B28564E9429A742953B692235FCA6F592854CE95A8A6798A46A9ACA24D9436C0474D33BDDFD02E7CDB64FF0F8D76BF6EDEFB8FB443BF619FFD0DDFF9D7E207BF51BCFAA756CC3F77467EAF2DF8D540E93FEA2A7F3554F5FD70CDF723F5BF1A6BFE8769C6FF9D61FF6E81FDBB15DEBFBF15FDFBD792DFFF9DE2F7BF6EFDFDBF74FCEF7F7DFDBF7EBB02E529173E0B40DC1FC56731FE038C642917B394CB39CA95BC9695FC96A542E522A0B5503593DEF13EAB7DB5B07DA1B2758CDCDACB54B5095452498B68809738CC4F1A172580E7BC1579ECBB96A86F5A23BE6F8BF88D26F65FFA08FFAA4BF9B7E18C7FD367FDCF89BCFF3355FCBB59D2FF5866FCF36BEE3FAF49FEFE4DDB776FB5EFDFEAD6DE8CADBC19EF9D7FA39D5B834ADB97FE2A903A963F8ABFCA08B8F873D9F9A4DFCED7A59DAF4BDA0D283560A5A46D11A050F51540B1EAEB92D66F4ADBBE2D6BFFA6BCE3DB8ACEEF2ABABEACECFEA24EBD46D62CD2B4934CED30AFAF5FD0AFEDEA6DE9E96FD30C766887BBFA467B06C63483E37DBA89FEAED1F1F691A9B69159F9F09270688DD5FFB659FBAE51FDAEA263B5BCFD3554DDF3FA6F1255DD2B7FC46A45F76A65CFDA3A28EDCB4D1DCB8D1D4B759D2BD55D2BE05459F76B1220A1FB6D4DCFBB2A35C0FB4AF59715EAAF01CA345F576ABE01A8D27C53ADFDB65AFB754DEF37B5DA6F6A345F97F77D5DD6FB55A9E68B52F5DB929E37C5DD6B259DABC51DAF2BD46BE53DAB508D7AF5B3A0B667F5A3F82CC67F8091BAEE65B0CFD4F6AC0080DB6B356BD59AB700868116E07555EFEBCA0F28EF33A042B358A159AED2AC27E06D65CF3B50BCD55D5F180ED5AF3F64C8B071D5AA97EA7B96EABA172BB54B865B7A16AAD58B60BE41FD1A800C1CA91701FE6669FD90E3754ED701AAE74D95FA4DA57A11C0C0851A9C5DADEF0678D3D0F5A652B35A65A0DBC078AD76B94E03B00450D3FB064C02BAAB342BB59AD77F8076B9BE63C580AED7C0426DCF9B0FC6DF817CD4A95F03A79F8DD61F50503FF22D86A5FE91D395EA9EE50F5AB74EDC5AADA16C0D5D5FDBFD7E1DEB4A080A13A0C28035433B6BFE78A5C19401060B1F50A736147E9DF64D4DEFEA87925F26F52D91FA40B60C97FDCDD20A24D220941FAAAC46B3F4A1CA0C5C7C282E0300E3E014A8DC0ACD0200284FD0E01F7A7C65BD84D751D3B308F09FABFE83CD554302FE48714DF75A5DD71A28F9C6EEF7EB89FC9BA5F5476E85FFCF86B441EBE7D9B1FF2C8B1BB46ED0FA999E057F027DD8A8D68D6ADDA8D69FA0D17ECE2E36446043043644E0E7DCA13F416C1B22B021021B22F01334DACFD9C586086C88C08608FC9C3BF427886D430436446043047E8246FB39BBD810810D11D810819F7387FE04B1FD3F37E8AC6531F54E980000000049454E44AE426082)
INSERT [dbo].[Aerolinea] ([CodAerolinea], [Nombre], [RUC], [Procedencia], [Logotipo]) VALUES (9, N'Lan Peru', N'25667651998', N'', 0x89504E470D0A1A0A0000000D494844520000009F0000003E080300000002853999000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000206348524D00007A26000080840000FA00000080E8000075300000EA6000003A98000017709CBA513C00000060504C5445FCFEF9C9CFD3526891A8B0B9153776B2BAC1A5201B6A7E9D97A4B7BCC2C88C9AAE283469C81A06D7DCE1502E50324C7E0B2B6BE4EBEB153471113270DDE3E4762739F2F6F40E2F6A102F6CD9DFE038315F0E306F7C8EA9112F74FFFFFF193976C2756DBF00000501494441546843ED97EB96A23A10852104B9350683362848DEFF2D675702129B84E3E5D8F60F33B3D6CCE2221F7BD7AE0A81FADB2BF8DB78EAC3F79C411FFD3EFA3DA7C073777FEACFA71F97B728FB36FDB84CC40D846FE3EB44999FFF5BC1B7F1A9288C2F0272796E1BA79AEFE26BFA300C59A714E775D749255892B37AA9E79BF8A4C8B2304CABAA9520EBA3B0DC9549CDFF0A1FE76908C00CA2C55958EECB721F89CA81F78EFD0B1C6D18F048C1B0347FF63D77980B397FDB5F293B294412131E0404A1864C9CE279F8EAD613262A0F3A796D846C71E8BA76E822971EB256822C1D17F8B48699DB5B7A9C4B3F86E5EB9D2867C6AECA98D311C63A0B5A1F12CB7292A24FE32CC6CA46C61080652E1A6F235CF249550EC1D0B7CE5BB80A7132AAAC931D0B68D90ED5E9300CA97D91B99E8B348E23E22344637118F6D2FD2C7DCB928FAB237EBD5FFE3A5D5ED1938780592F0C3E7DCC02EC3C7CAA066064002F16B3766DCCB9F84A2F5FC5BE870038A59AABAB263E1CFC9E01CF3E3EDE68056742CC10F4E895E5F2D7AB9F84BB43F00D98545EAA4BEB77DC6940A3046F7D7C4A35221F1D3625180B775F9990EFD18F5739942DD90E25985CFCD7FAA5747052907BFDA50A61D06FAC41AA3FB6527CCEFA93DEFAEB18540A58D5836F7709B8D62F82F308496FDA98AE52473E704AAA7E4E08140CF3F54DD61DFAC93A03585AD5E4F210B5A3C35ABFA8AA12B02324E46F473ABBF91A06F54601B5C3F326C6598577D41F741BA05BAD3A8DC246878D7E67DEF410F05B1FF5EBC7556EF02E1109ED5EB044BC5D3FCAAEEE3B5C5631D521BCA235EAA724010E3B00723F9FB4E41BBB4CBE1A909BF5E39C5C0D65D5364D25F6F87F6E049CF42340BC0100FD7C52A446BE24199B3426C99DFD85637E38FA738354048160199C89226A41C64BA35F4C335956094202409D7357FDB5499412217A329B1C0ED9DA36FF56FD5A41EEA695D8D1B0D0036308B5C35ABF5807972324E883CCC7D7314D970BF4945644661267FDDC4B1FAE3FA9DDDDABBA49767AEDBF2915D4BB66FD0CE0000529494BFD7891937CACD0858B5947805916AD7DC7F9E72F9F96EE68248C1ECA63354B20980C5BFAC1622A83E148F959F2752C02209B3E84BA0970EA04AE42F4E6F7D2D625DEB615473C369E8DC0C7356D64C8615B3F004AD41E46A0830FF2A5516FEDA55A91434118BC92604FFD05FB71631B96311A8A8CF5C8B04779836D95CEB0D1EFB2679535B519877EBC4EA23C29ECADDE592568D0AB2DDAB53FA5705A2B6F601AD63C72B5114DA433DC9D892F9BA609A5B877F2A1DE20DEF5349392D15695BE333DCBE56F86EFA9791D4321C263B9B7DC357D19478FFB889F5979DCA79645BCEA8F65B9FBB1C3E52A498AE55E00359965B97F8F70C3F791185FEDE77EFD4A0AFB2455EC6271217E7CB7E84B78452951AE4F4B7DDEC5675FCC95D49F3EDCF10B38A649C67F2C246AD64B42FB02DC4BFD817C5069E6DF64DDA09FB7361E39A19B962A4EA7ED69BB3D9D0A5062CB957813FC8B7C1AAD386D0F87CDE66B5C9BCD617B927C2AA1E51BFF169F566D6B917D7D6DBE36661DB6C51DF97DC4B5F57BB46E361B90201BDC1DD7A9B82B1FFF27A1F1D4761464C5383ACD832829EFD0CF24C1D24D3B69427BF37A51FD4D6C87390987C3895ACACD64E6C297F01526A55348BF28A4D449EE857B09DF1C059D4D63E92368AFD4AF30D93433E201D92E55F0127F01447F1F576D2ED297F0DD9981B5CB3F7CCF89F9D1EFA3DF730A3C77F7A7FE3EFA3DA7C07377FF03B39232FD50F4E4E20000000049454E44AE426082)
SET IDENTITY_INSERT [dbo].[Aerolinea] OFF
/****** Object:  Table [dbo].[Excepcion]    Script Date: 11/05/2010 17:02:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Excepcion]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Excepcion](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Mensaje] [varchar](8000) COLLATE Modern_Spanish_CI_AS NULL,
	[StackTrace] [varchar](8000) COLLATE Modern_Spanish_CI_AS NULL,
	[FechaCliente] [datetime] NULL,
	[FechaServidor] [datetime] NULL,
	[CodUsuario] [int] NULL,
	[IPCliente] [varchar](30) COLLATE Modern_Spanish_CI_AS NULL,
 CONSTRAINT [PK_Excepcion] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Excepcion] ON
INSERT [dbo].[Excepcion] ([Codigo], [Mensaje], [StackTrace], [FechaCliente], [FechaServidor], [CodUsuario], [IPCliente]) VALUES (1, N'La función o el procedimiento uspLogInsertar tiene demasiados argumentos.', N'   en UPC.Trabajo.KBHit.BC.AerolineaBC.RegistrarAerolinea(AerolineaBE objAerolineaBE) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit.BC\AerolineaBC.cs:línea 38
   en UPC.Trabajo.KBHit.frmAerolinea.bnGuardarAerolinea(Object sender, EventArgs e) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit\frmAerolinea.cs:línea 79', CAST(0x00009DA90102E799 AS DateTime), CAST(0x00009DA90102E7A5 AS DateTime), 0, N'"192.168.1.11"')
INSERT [dbo].[Excepcion] ([Codigo], [Mensaje], [StackTrace], [FechaCliente], [FechaServidor], [CodUsuario], [IPCliente]) VALUES (2, N'Estado', N'   en UPC.Trabajo.KBHit.BC.PistaBC.ObtenerPista(Int32 codigo) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit.BC\PistaBC.cs:línea 69
   en UPC.Trabajo.KBHit.frmDisponibilidad.InActualizarPista(Object sender, EventArgs e) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit\frmDisponibilidad.cs:línea 155', CAST(0x00009DAA002AB36A AS DateTime), CAST(0x00009DAA002AB378 AS DateTime), 0, N'"192.168.1.11"')
INSERT [dbo].[Excepcion] ([Codigo], [Mensaje], [StackTrace], [FechaCliente], [FechaServidor], [CodUsuario], [IPCliente]) VALUES (3, N'La conversión especificada no es válida.', N'   en UPC.Trabajo.KBHit.frmDisponibilidad.InActualizarPista(Object sender, EventArgs e) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit\frmDisponibilidad.cs:línea 153', CAST(0x00009DAA002BA762 AS DateTime), CAST(0x00009DAA002BA764 AS DateTime), 0, N'"192.168.1.11"')
INSERT [dbo].[Excepcion] ([Codigo], [Mensaje], [StackTrace], [FechaCliente], [FechaServidor], [CodUsuario], [IPCliente]) VALUES (4, N'Estado', N'   en UPC.Trabajo.KBHit.BC.PistaBC.ObtenerPista(Int32 codigo) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit.BC\PistaBC.cs:línea 69
   en UPC.Trabajo.KBHit.frmDisponibilidad.InActualizarPista(Object sender, EventArgs e) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit\frmDisponibilidad.cs:línea 155', CAST(0x00009DAA002C095F AS DateTime), CAST(0x00009DAA002C095F AS DateTime), 0, N'"192.168.1.11"')
INSERT [dbo].[Excepcion] ([Codigo], [Mensaje], [StackTrace], [FechaCliente], [FechaServidor], [CodUsuario], [IPCliente]) VALUES (5, N'La conversión especificada no es válida.', N'   en UPC.Trabajo.KBHit.frmDisponibilidad.InActualizarPista(Object sender, EventArgs e) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit\frmDisponibilidad.cs:línea 153', CAST(0x00009DAA002CB85E AS DateTime), CAST(0x00009DAA002CB860 AS DateTime), 0, N'"192.168.1.11"')
INSERT [dbo].[Excepcion] ([Codigo], [Mensaje], [StackTrace], [FechaCliente], [FechaServidor], [CodUsuario], [IPCliente]) VALUES (6, N'La conversión especificada no es válida.', N'   en UPC.Trabajo.KBHit.frmDisponibilidad.InActualizarPista(Object sender, EventArgs e) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit\frmDisponibilidad.cs:línea 153', CAST(0x00009DAA002DCA5C AS DateTime), CAST(0x00009DAA002DCA5F AS DateTime), 0, N'"192.168.1.11"')
INSERT [dbo].[Excepcion] ([Codigo], [Mensaje], [StackTrace], [FechaCliente], [FechaServidor], [CodUsuario], [IPCliente]) VALUES (7, N'La conversión especificada no es válida.', N'   en UPC.Trabajo.KBHit.frmDisponibilidad.InActualizarPista(Object sender, EventArgs e) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit\frmDisponibilidad.cs:línea 153', CAST(0x00009DAA003068A9 AS DateTime), CAST(0x00009DAA003068B8 AS DateTime), 0, N'"192.168.1.11"')
INSERT [dbo].[Excepcion] ([Codigo], [Mensaje], [StackTrace], [FechaCliente], [FechaServidor], [CodUsuario], [IPCliente]) VALUES (8, N'La conversión especificada no es válida.', N'   en UPC.Trabajo.KBHit.frmDisponibilidad.InActualizarPista(Object sender, EventArgs e) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit\frmDisponibilidad.cs:línea 153', CAST(0x00009DAA00326348 AS DateTime), CAST(0x00009DAA0032634A AS DateTime), 0, N'"192.168.1.11"')
INSERT [dbo].[Excepcion] ([Codigo], [Mensaje], [StackTrace], [FechaCliente], [FechaServidor], [CodUsuario], [IPCliente]) VALUES (9, N'La función o el procedimiento uspPistaActualizar tiene demasiados argumentos.', N'   en UPC.Trabajo.KBHit.BC.PistaBC.ActualizarPista(PistaBE objPistaBE) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit.BC\PistaBC.cs:línea 98
   en UPC.Trabajo.KBHit.frmDisponibilidad.InActualizarPista(Object sender, EventArgs e) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit\frmDisponibilidad.cs:línea 160', CAST(0x00009DAA0032745B AS DateTime), CAST(0x00009DAA0032745B AS DateTime), 0, N'"192.168.1.11"')
INSERT [dbo].[Excepcion] ([Codigo], [Mensaje], [StackTrace], [FechaCliente], [FechaServidor], [CodUsuario], [IPCliente]) VALUES (10, N'La función o el procedimiento uspPistaActualizar tiene demasiados argumentos.', N'   en UPC.Trabajo.KBHit.BC.PistaBC.ActualizarPista(PistaBE objPistaBE) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit.BC\PistaBC.cs:línea 98
   en UPC.Trabajo.KBHit.frmDisponibilidad.InActualizarPista(Object sender, EventArgs e) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit\frmDisponibilidad.cs:línea 160', CAST(0x00009DAA00328D74 AS DateTime), CAST(0x00009DAA00328D74 AS DateTime), 0, N'"192.168.1.11"')
INSERT [dbo].[Excepcion] ([Codigo], [Mensaje], [StackTrace], [FechaCliente], [FechaServidor], [CodUsuario], [IPCliente]) VALUES (11, N'La conversión especificada no es válida.', N'   en UPC.Trabajo.KBHit.frmDisponibilidad.InActualizarPista(Object sender, EventArgs e) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit\frmDisponibilidad.cs:línea 153', CAST(0x00009DAA00355779 AS DateTime), CAST(0x00009DAA0035577B AS DateTime), 0, N'"192.168.1.11"')
INSERT [dbo].[Excepcion] ([Codigo], [Mensaje], [StackTrace], [FechaCliente], [FechaServidor], [CodUsuario], [IPCliente]) VALUES (12, N'La conversión especificada no es válida.', N'   en UPC.Trabajo.KBHit.frmDisponibilidad.InActualizarPista(Object sender, EventArgs e) en C:\Users\curacao\Documents\Michael - NoteBook\UPC\Año 2010\Diseño\TrabajoFinal\v1.7\UPC.Trabajo.KBHit\UPC.Trabajo.KBHit\frmDisponibilidad.cs:línea 153', CAST(0x00009DAA00356497 AS DateTime), CAST(0x00009DAA00356496 AS DateTime), 0, N'"192.168.1.11"')
SET IDENTITY_INSERT [dbo].[Excepcion] OFF
/****** Object:  StoredProcedure [dbo].[uspTipoMovimientoObtener]    Script Date: 11/05/2010 17:02:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspTipoMovimientoObtener]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspTipoMovimientoObtener]
	@CodTipoMovimiento [int]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspTipoMovimientoListar]    Script Date: 11/05/2010 17:02:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspTipoMovimientoListar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspTipoMovimientoListar]
WITH EXECUTE AS CALLER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	SELECT [CodTipoMovimiento]
      ,[Descripcion]
  FROM [Aeropuerto].[dbo].[TipoMovimiento]
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspTipoMovimientoInsertar]    Script Date: 11/05/2010 17:02:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspTipoMovimientoInsertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspTipoMovimientoInsertar]
	@Descripcion [varchar](1000)
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspLogObtener]    Script Date: 11/05/2010 17:02:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspLogObtener]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspLogObtener]
	@CodOperacion [int]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspLogListar]    Script Date: 11/05/2010 17:02:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspLogListar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspLogListar]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspLogInsertar]    Script Date: 11/05/2010 17:02:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspLogInsertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspLogInsertar]
	@CodOperacion [int],
	@Tabla [varchar](50),
	@Usuario [varchar](50),
	@IP [varchar](23),
	@Razon [varchar](500)
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspInsertarExcepcion]    Script Date: 11/05/2010 17:02:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspInsertarExcepcion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspInsertarExcepcion]
	@Mensaje [varchar](8000),
	@StackTrace [varchar](8000),
	@FechaCliente [datetime],
	@CodUsuario [int],
	@IPCliente [varchar](30)
WITH EXECUTE AS CALLER
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
END' 
END
GO
/****** Object:  Table [dbo].[Plataforma]    Script Date: 11/05/2010 17:02:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Plataforma]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Plataforma](
	[CodPlataforma] [int] IDENTITY(1,1) NOT NULL,
	[CodAeropuerto] [int] NOT NULL,
	[Naves] [int] NOT NULL,
	[Pavimento] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[PCN] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Dimensiones] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[NaveMaxPermisible] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
 CONSTRAINT [PK_Plataforma] PRIMARY KEY CLUSTERED 
(
	[CodPlataforma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Plataforma] ON
INSERT [dbo].[Plataforma] ([CodPlataforma], [CodAeropuerto], [Naves], [Pavimento], [PCN], [Dimensiones], [NaveMaxPermisible]) VALUES (1, 1, 30, N'pavimento uno', N'pcn uno', N'dimensiones uno', N'nave max uno')
SET IDENTITY_INSERT [dbo].[Plataforma] OFF
/****** Object:  Table [dbo].[PlanDeVuelo]    Script Date: 11/05/2010 17:02:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PlanDeVuelo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PlanDeVuelo](
	[CodPlanVuelo] [int] IDENTITY(1,1) NOT NULL,
	[CodAerolinea] [int] NOT NULL,
	[Destinatario] [varchar](1000) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Remitente] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Presentador] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Requisitos] [varchar](1000) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Prioridad] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Hora] [datetime] NOT NULL,
 CONSTRAINT [PK_PlanDeVuelo] PRIMARY KEY CLUSTERED 
(
	[CodPlanVuelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pista]    Script Date: 11/05/2010 17:02:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pista]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pista](
	[CodPista] [int] IDENTITY(1,1) NOT NULL,
	[CodAeropuerto] [int] NOT NULL,
	[Largo] [int] NOT NULL,
	[Ancho] [int] NOT NULL,
	[TORA] [int] NOT NULL,
	[TODA] [int] NOT NULL,
	[ASDA] [int] NOT NULL,
	[LDA] [int] NOT NULL,
	[Pavimento] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Designado] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[PCN] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Franja] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Rodaje] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Estado] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
 CONSTRAINT [PK_Pista] PRIMARY KEY CLUSTERED 
(
	[CodPista] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Pista] ON
INSERT [dbo].[Pista] ([CodPista], [CodAeropuerto], [Largo], [Ancho], [TORA], [TODA], [ASDA], [LDA], [Pavimento], [Designado], [PCN], [Franja], [Rodaje], [Estado]) VALUES (2, 1, 2460, 45, 45, 2460, 45, 45, N'Asfalto', N'17/35', N'20/F/C/X/T', N'Longitud 300 Ancho 60', N'24/F/C/X/T', N'No Disponible')
SET IDENTITY_INSERT [dbo].[Pista] OFF
/****** Object:  Table [dbo].[Movimiento]    Script Date: 11/05/2010 17:02:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Movimiento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Movimiento](
	[CodMovimiento] [int] IDENTITY(1,1) NOT NULL,
	[CodTipoMovimiento] [int] NOT NULL,
	[CodAerolinea] [int] NOT NULL,
	[CodAvion] [int] NOT NULL,
	[Detalle] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[CodAeropuertoOrigen] [int] NOT NULL,
	[CodAeropuertoDestino] [int] NOT NULL,
 CONSTRAINT [PK_Movimiento] PRIMARY KEY CLUSTERED 
(
	[CodMovimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[uspAvionObtener]    Script Date: 11/05/2010 17:02:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAvionObtener]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspAvionObtener]
	@CodAvion [int]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspAvionListar]    Script Date: 11/05/2010 17:02:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAvionListar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspAvionListar]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspAvionInsertar]    Script Date: 11/05/2010 17:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAvionInsertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspAvionInsertar]
	@Nombre [varchar](100),
	@Fabricante [varchar](100),
	@Serie [varchar](50),
	@CabinaTripulacion [int],
	@Pasajeros [int],
	@Longitud [float],
	@Envergadura [float],
	@Altura [float],
	@PesoVacio [float],
	@PesoMaxDespegue [float],
	@VelocidadCrucero [float],
	@VelocidadMax [float],
	@CarreraPesoMax [float],
	@AutonomiaPesoMaxDesp [float],
	@MaxFuel [float],
	@Motor [varchar](500),
	@Empuje [varchar](500)
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspAvionActualizar]    Script Date: 11/05/2010 17:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAvionActualizar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspAvionActualizar]
	@CodAvion [int],
	@Nombre [varchar](100),
	@Fabricante [varchar](100),
	@Serie [varchar](50),
	@CabinaTripulacion [int],
	@Pasajeros [int],
	@Longitud [float],
	@Envergadura [float],
	@Altura [float],
	@PesoVacio [float],
	@PesoMaxDespegue [float],
	@VelocidadCrucero [float],
	@VelocidadMax [float],
	@CarreraPesoMax [float],
	@AutonomiaPesoMaxDesp [float],
	@MaxFuel [float],
	@Motor [varchar](500),
	@Empuje [varchar](500)
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspAeropuertoObtenerNombre]    Script Date: 11/05/2010 17:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAeropuertoObtenerNombre]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspAeropuertoObtenerNombre]
	@Nombre [varchar](500)
WITH EXECUTE AS CALLER
AS
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspAeropuertoObtener]    Script Date: 11/05/2010 17:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAeropuertoObtener]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspAeropuertoObtener]
	@CodAeropuerto [int]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspAeropuertoListar]    Script Date: 11/05/2010 17:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAeropuertoListar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspAeropuertoListar]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspAeropuertoInsertar]    Script Date: 11/05/2010 17:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAeropuertoInsertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspAeropuertoInsertar]
	@Nombre [varchar](500),
	@Estado [varchar](500),
	@Ciudad [varchar](500),
	@IATA [varchar](3),
	@OACI [varchar](4),
	@Elevacion [int],
	@SEI [int],
	@Fuel [int],
	@Operacion [varchar](1000)
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspAeropuertoEliminar]    Script Date: 11/05/2010 17:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAeropuertoEliminar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspAeropuertoEliminar]
	@CodAeropuerto [int]
WITH EXECUTE AS CALLER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	DELETE FROM [Aeropuerto].[dbo].[Aeropuerto]
      WHERE CodAeropuerto = @CodAeropuerto
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspAeropuertoActualizar]    Script Date: 11/05/2010 17:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAeropuertoActualizar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspAeropuertoActualizar]
	@CodAeropuerto [int],
	@Nombre [varchar](500),
	@Estado [varchar](500),
	@Ciudad [varchar](500),
	@IATA [varchar](3),
	@OACI [varchar](4),
	@Elevacion [int],
	@SEI [int],
	@Fuel [int],
	@Operacion [varchar](1000)
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspAerolineaObtener]    Script Date: 11/05/2010 17:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAerolineaObtener]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspAerolineaObtener]
	@CodAerolinea [int]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspAerolineaListar]    Script Date: 11/05/2010 17:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAerolineaListar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspAerolineaListar]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspAerolineaInsertar]    Script Date: 11/05/2010 17:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAerolineaInsertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspAerolineaInsertar]
	@Nombre [varchar](500),
	@RUC [varchar](500),
	@Procedencia [varchar](500),
	@Logotipo [image]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspAerolineaEliminar]    Script Date: 11/05/2010 17:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAerolineaEliminar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspAerolineaEliminar]
	@CodAerolinea [int]
WITH EXECUTE AS CALLER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	DELETE FROM [Aeropuerto].[dbo].[Aerolinea]
    WHERE CodAerolinea = @CodAerolinea
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspAerolineaActualizar]    Script Date: 11/05/2010 17:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspAerolineaActualizar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspAerolineaActualizar]
	@CodAerolinea [int],
	@Nombre [varchar](500),
	@RUC [varchar](500),
	@Procedencia [varchar](500)
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  Table [dbo].[TUUA]    Script Date: 11/05/2010 17:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TUUA]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TUUA](
	[CodTUUA] [int] NOT NULL,
	[CodTipoVuelo] [int] NOT NULL,
	[CodBoleto] [int] NOT NULL,
	[CodAerolinea] [int] NOT NULL,
	[Impuesto] [float] NOT NULL,
	[CodVuelo] [int] NOT NULL,
 CONSTRAINT [PK_TUUA] PRIMARY KEY CLUSTERED 
(
	[CodTUUA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[IPAeropuerto]    Script Date: 11/05/2010 17:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IPAeropuerto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[IPAeropuerto](
	[IP] [varchar](30) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[CodAeropuerto] [int] NOT NULL,
 CONSTRAINT [PK_IPAeropuerto] PRIMARY KEY CLUSTERED 
(
	[CodAeropuerto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[IPAeropuerto] ([IP], [CodAeropuerto]) VALUES (N'192.168.1.11', 1)
/****** Object:  Table [dbo].[Salida]    Script Date: 11/05/2010 17:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Salida]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Salida](
	[CodSalida] [int] NOT NULL,
	[CodPlanVuelo] [int] NOT NULL,
	[Numero] [int] NOT NULL,
	[Placa] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[ReglasVuelo] [varchar](1) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[TipoVuelo] [varchar](1) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[CodAvion] [int] NOT NULL,
	[Hora] [datetime] NOT NULL,
	[CodAeropuerto] [int] NOT NULL,
	[Turbulencia] [varchar](1) COLLATE Modern_Spanish_CI_AS NULL,
	[Equipo] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Velocidad] [float] NULL,
	[Nivel] [float] NULL,
	[Ruta] [varchar](8000) COLLATE Modern_Spanish_CI_AS NULL,
 CONSTRAINT [PK_Salida] PRIMARY KEY CLUSTERED 
(
	[CodSalida] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InformacionVuelo]    Script Date: 11/05/2010 17:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InformacionVuelo]') AND type in (N'U'))
BEGIN
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
	[Color] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[MarcasNave] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Observaciones] [varchar](1000) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Piloto] [varchar](500) COLLATE Modern_Spanish_CI_AS NOT NULL,
 CONSTRAINT [PK_InformacionVuelo] PRIMARY KEY CLUSTERED 
(
	[CodInfoVuelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[uspPlataformaObtener]    Script Date: 11/05/2010 17:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlataformaObtener]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspPlataformaObtener]
	@CodPlataforma [int]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspPlataformaListar]    Script Date: 11/05/2010 17:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlataformaListar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspPlataformaListar]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspPlataformaInsertar]    Script Date: 11/05/2010 17:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlataformaInsertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspPlataformaInsertar]
	@CodAeropuerto [int],
	@Naves [int],
	@Pavimento [varchar](500),
	@PCN [varchar](500),
	@Dimensiones [varchar](500),
	@NaveMaxPermisible [varchar](500)
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspPlataformaEliminar]    Script Date: 11/05/2010 17:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlataformaEliminar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspPlataformaEliminar]
	@CodPlataforma [int]
WITH EXECUTE AS CALLER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    DELETE FROM Plataforma
    WHERE CodPlataforma = @CodPlataforma
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspPlataformaActualizar]    Script Date: 11/05/2010 17:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlataformaActualizar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspPlataformaActualizar]
	@CodPlataforma [int],
	@CodAeropuerto [int],
	@Naves [int],
	@Pavimento [varchar](500),
	@PCN [varchar](500),
	@Dimensiones [varchar](500),
	@NaveMaxPermisible [varchar](500)
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspPlanDeVueloObtener]    Script Date: 11/05/2010 17:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlanDeVueloObtener]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspPlanDeVueloObtener]
	@CodPlanVuelo [int]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspPlanDeVueloListar]    Script Date: 11/05/2010 17:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlanDeVueloListar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspPlanDeVueloListar]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspPlanDeVueloInsertar]    Script Date: 11/05/2010 17:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPlanDeVueloInsertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspPlanDeVueloInsertar]
	@CodAerolinea [int],
	@Destinatario [varchar](1000),
	@Remitente [varchar](500),
	@Presentador [varchar](500),
	@Requisitos [varchar](1000),
	@Prioridad [varchar](50)
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspPistaObtener]    Script Date: 11/05/2010 17:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPistaObtener]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspPistaObtener]
	@CodPista [int]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspPistaListar]    Script Date: 11/05/2010 17:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPistaListar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspPistaListar]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspPistaInsertar]    Script Date: 11/05/2010 17:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPistaInsertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspPistaInsertar]
	@CodAeropuerto [int],
	@Largo [int],
	@Ancho [int],
	@TORA [int],
	@TODA [int],
	@ASDA [int],
	@LDA [int],
	@Pavimento [varchar](500),
	@Designado [varchar](500),
	@PCN [varchar](500),
	@Franja [varchar](500),
	@Rodaje [varchar](500)
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspPistaEliminar]    Script Date: 11/05/2010 17:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPistaEliminar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspPistaEliminar]
	@CodPista [int]
WITH EXECUTE AS CALLER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	DELETE FROM Pista
	WHERE CodPista = @CodPista
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspPistaActualizar]    Script Date: 11/05/2010 17:02:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspPistaActualizar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspPistaActualizar]
	@CodPista [int],
	@CodAeropuerto [int],
	@Largo [int],
	@Ancho [int],
	@TORA [int],
	@TODA [int],
	@ASDA [int],
	@LDA [int],
	@Pavimento [varchar](500),
	@Designado [varchar](500),
	@PCN [varchar](500),
	@Franja [varchar](500),
	@Rodaje [varchar](500),
	@Estado [varchar](500)
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspMovimientoObtener]    Script Date: 11/05/2010 17:02:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspMovimientoObtener]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspMovimientoObtener]
	@CodMovimiento [int]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspMovimientoListar]    Script Date: 11/05/2010 17:02:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspMovimientoListar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspMovimientoListar]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspMovimientoInsertar]    Script Date: 11/05/2010 17:02:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspMovimientoInsertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspMovimientoInsertar]
	@CodTipoMovimiento [int],
	@CodAerolinea [int],
	@CodAvion [int],
	@Detalle [varchar](500),
	@CodAeropuertoOrigen [int],
	@CodAeropuertoDestino [int]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  Table [dbo].[Destino]    Script Date: 11/05/2010 17:02:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Destino]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Destino](
	[CodDestino] [int] IDENTITY(1,1) NOT NULL,
	[CodPlanVuelo] [int] NOT NULL,
	[TiempoHr] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[TiempoMin] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[CodAerodromo] [int] NULL,
	[CodAerodromoAlter] [int] NULL,
	[CodAerodromo2Alter] [int] NULL,
 CONSTRAINT [PK_Destino] PRIMARY KEY CLUSTERED 
(
	[CodDestino] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[uspIPAeropuertoObtener]    Script Date: 11/05/2010 17:02:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspIPAeropuertoObtener]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspIPAeropuertoObtener]
	@IP [varchar](30)
WITH EXECUTE AS CALLER
AS
begin
SELECT [IP]
      ,[CodAeropuerto]
  FROM [Aeropuerto].[dbo].[IPAeropuerto]
where IP = @IP
end' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspSalidaObtener]    Script Date: 11/05/2010 17:02:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspSalidaObtener]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspSalidaObtener]
	@CodSalida [int]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspSalidaListar]    Script Date: 11/05/2010 17:02:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspSalidaListar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspSalidaListar]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspSalidaInsertar]    Script Date: 11/05/2010 17:02:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspSalidaInsertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspSalidaInsertar]
	@CodPlanVuelo [int],
	@Numero [int],
	@Placa [varchar](50),
	@ReglasVuelo [varchar](1),
	@TipoVuelo [varchar](1),
	@CodAvion [int],
	@CodAeropuerto [int],
	@Turbulencia [varchar](1),
	@Equipo [varchar](50),
	@Velocidad [float],
	@Nivel [float],
	@Ruta [varchar](8000)
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspInformacionVueloObtener]    Script Date: 11/05/2010 17:02:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspInformacionVueloObtener]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspInformacionVueloObtener]
	@CodInfoVuelo [int]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspInformacionVueloListar]    Script Date: 11/05/2010 17:02:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspInformacionVueloListar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspInformacionVueloListar]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspInformacionVueloInsertar]    Script Date: 11/05/2010 17:02:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspInformacionVueloInsertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspInformacionVueloInsertar]
	@Horas [int],
	@Min [int],
	@Personas [int],
	@UHF [int],
	@VHF [int],
	@ELT [int],
	@Polar [int],
	@Desierto [int],
	@Maritimo [int],
	@Selva [int],
	@Fluor [int],
	@Luz [int],
	@Numero [int],
	@Capacidad [int],
	@Cubierta [int],
	@Color [varchar](500),
	@MarcasNave [varchar](500),
	@Observaciones [varchar](1000),
	@Piloto [varchar](500)
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspDestinoObtener]    Script Date: 11/05/2010 17:02:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspDestinoObtener]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspDestinoObtener]
	@CodDestino [int]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspDestinoListar]    Script Date: 11/05/2010 17:02:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspDestinoListar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspDestinoListar]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[uspDestinoInsertar]    Script Date: 11/05/2010 17:02:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspDestinoInsertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[uspDestinoInsertar]
	@CodPlanVuelo [int],
	@TiempoHr [varchar](50),
	@TiempoMin [varchar](50),
	@CodAerodromo [int],
	@CodAerodromoAlter [int],
	@CodAerodromo2Alter [int]
WITH EXECUTE AS CALLER
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
' 
END
GO
/****** Object:  ForeignKey [FK_Plataforma_Aeropuerto]    Script Date: 11/05/2010 17:02:24 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plataforma_Aeropuerto]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plataforma]'))
ALTER TABLE [dbo].[Plataforma]  WITH CHECK ADD  CONSTRAINT [FK_Plataforma_Aeropuerto] FOREIGN KEY([CodAeropuerto])
REFERENCES [dbo].[Aeropuerto] ([CodAeropuerto])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plataforma_Aeropuerto]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plataforma]'))
ALTER TABLE [dbo].[Plataforma] CHECK CONSTRAINT [FK_Plataforma_Aeropuerto]
GO
/****** Object:  ForeignKey [FK_PlanDeVuelo_Aerolinea]    Script Date: 11/05/2010 17:02:24 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PlanDeVuelo_Aerolinea]') AND parent_object_id = OBJECT_ID(N'[dbo].[PlanDeVuelo]'))
ALTER TABLE [dbo].[PlanDeVuelo]  WITH CHECK ADD  CONSTRAINT [FK_PlanDeVuelo_Aerolinea] FOREIGN KEY([CodAerolinea])
REFERENCES [dbo].[Aerolinea] ([CodAerolinea])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PlanDeVuelo_Aerolinea]') AND parent_object_id = OBJECT_ID(N'[dbo].[PlanDeVuelo]'))
ALTER TABLE [dbo].[PlanDeVuelo] CHECK CONSTRAINT [FK_PlanDeVuelo_Aerolinea]
GO
/****** Object:  ForeignKey [FK_Pista_Aeropuerto]    Script Date: 11/05/2010 17:02:24 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Pista_Aeropuerto]') AND parent_object_id = OBJECT_ID(N'[dbo].[Pista]'))
ALTER TABLE [dbo].[Pista]  WITH CHECK ADD  CONSTRAINT [FK_Pista_Aeropuerto] FOREIGN KEY([CodAeropuerto])
REFERENCES [dbo].[Aeropuerto] ([CodAeropuerto])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Pista_Aeropuerto]') AND parent_object_id = OBJECT_ID(N'[dbo].[Pista]'))
ALTER TABLE [dbo].[Pista] CHECK CONSTRAINT [FK_Pista_Aeropuerto]
GO
/****** Object:  ForeignKey [FK_Movimiento_Aerolinea]    Script Date: 11/05/2010 17:02:24 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Movimiento_Aerolinea]') AND parent_object_id = OBJECT_ID(N'[dbo].[Movimiento]'))
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_Aerolinea] FOREIGN KEY([CodAerolinea])
REFERENCES [dbo].[Aerolinea] ([CodAerolinea])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Movimiento_Aerolinea]') AND parent_object_id = OBJECT_ID(N'[dbo].[Movimiento]'))
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK_Movimiento_Aerolinea]
GO
/****** Object:  ForeignKey [FK_Movimiento_Aeropuerto]    Script Date: 11/05/2010 17:02:24 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Movimiento_Aeropuerto]') AND parent_object_id = OBJECT_ID(N'[dbo].[Movimiento]'))
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_Aeropuerto] FOREIGN KEY([CodAeropuertoOrigen])
REFERENCES [dbo].[Aeropuerto] ([CodAeropuerto])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Movimiento_Aeropuerto]') AND parent_object_id = OBJECT_ID(N'[dbo].[Movimiento]'))
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK_Movimiento_Aeropuerto]
GO
/****** Object:  ForeignKey [FK_Movimiento_Aeropuerto1]    Script Date: 11/05/2010 17:02:24 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Movimiento_Aeropuerto1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Movimiento]'))
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_Aeropuerto1] FOREIGN KEY([CodAeropuertoDestino])
REFERENCES [dbo].[Aeropuerto] ([CodAeropuerto])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Movimiento_Aeropuerto1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Movimiento]'))
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK_Movimiento_Aeropuerto1]
GO
/****** Object:  ForeignKey [FK_Movimiento_Avion]    Script Date: 11/05/2010 17:02:24 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Movimiento_Avion]') AND parent_object_id = OBJECT_ID(N'[dbo].[Movimiento]'))
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_Avion] FOREIGN KEY([CodAvion])
REFERENCES [dbo].[Avion] ([CodAvion])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Movimiento_Avion]') AND parent_object_id = OBJECT_ID(N'[dbo].[Movimiento]'))
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK_Movimiento_Avion]
GO
/****** Object:  ForeignKey [FK_Movimiento_TipoMovimiento]    Script Date: 11/05/2010 17:02:24 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Movimiento_TipoMovimiento]') AND parent_object_id = OBJECT_ID(N'[dbo].[Movimiento]'))
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_TipoMovimiento] FOREIGN KEY([CodTipoMovimiento])
REFERENCES [dbo].[TipoMovimiento] ([CodTipoMovimiento])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Movimiento_TipoMovimiento]') AND parent_object_id = OBJECT_ID(N'[dbo].[Movimiento]'))
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK_Movimiento_TipoMovimiento]
GO
/****** Object:  ForeignKey [FK_TUUA_Aerolinea]    Script Date: 11/05/2010 17:02:25 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TUUA_Aerolinea]') AND parent_object_id = OBJECT_ID(N'[dbo].[TUUA]'))
ALTER TABLE [dbo].[TUUA]  WITH CHECK ADD  CONSTRAINT [FK_TUUA_Aerolinea] FOREIGN KEY([CodAerolinea])
REFERENCES [dbo].[Aerolinea] ([CodAerolinea])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TUUA_Aerolinea]') AND parent_object_id = OBJECT_ID(N'[dbo].[TUUA]'))
ALTER TABLE [dbo].[TUUA] CHECK CONSTRAINT [FK_TUUA_Aerolinea]
GO
/****** Object:  ForeignKey [FK_TUUA_TipoVuelo]    Script Date: 11/05/2010 17:02:25 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TUUA_TipoVuelo]') AND parent_object_id = OBJECT_ID(N'[dbo].[TUUA]'))
ALTER TABLE [dbo].[TUUA]  WITH CHECK ADD  CONSTRAINT [FK_TUUA_TipoVuelo] FOREIGN KEY([CodTipoVuelo])
REFERENCES [dbo].[TipoVuelo] ([CodTipoVuelo])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TUUA_TipoVuelo]') AND parent_object_id = OBJECT_ID(N'[dbo].[TUUA]'))
ALTER TABLE [dbo].[TUUA] CHECK CONSTRAINT [FK_TUUA_TipoVuelo]
GO
/****** Object:  ForeignKey [FK_IPAeropuerto_Aeropuerto]    Script Date: 11/05/2010 17:02:26 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IPAeropuerto_Aeropuerto]') AND parent_object_id = OBJECT_ID(N'[dbo].[IPAeropuerto]'))
ALTER TABLE [dbo].[IPAeropuerto]  WITH CHECK ADD  CONSTRAINT [FK_IPAeropuerto_Aeropuerto] FOREIGN KEY([CodAeropuerto])
REFERENCES [dbo].[Aeropuerto] ([CodAeropuerto])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IPAeropuerto_Aeropuerto]') AND parent_object_id = OBJECT_ID(N'[dbo].[IPAeropuerto]'))
ALTER TABLE [dbo].[IPAeropuerto] CHECK CONSTRAINT [FK_IPAeropuerto_Aeropuerto]
GO
/****** Object:  ForeignKey [FK_Salida_Avion]    Script Date: 11/05/2010 17:02:26 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Salida_Avion]') AND parent_object_id = OBJECT_ID(N'[dbo].[Salida]'))
ALTER TABLE [dbo].[Salida]  WITH CHECK ADD  CONSTRAINT [FK_Salida_Avion] FOREIGN KEY([CodAvion])
REFERENCES [dbo].[Avion] ([CodAvion])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Salida_Avion]') AND parent_object_id = OBJECT_ID(N'[dbo].[Salida]'))
ALTER TABLE [dbo].[Salida] CHECK CONSTRAINT [FK_Salida_Avion]
GO
/****** Object:  ForeignKey [FK_Salida_PlanDeVuelo]    Script Date: 11/05/2010 17:02:26 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Salida_PlanDeVuelo]') AND parent_object_id = OBJECT_ID(N'[dbo].[Salida]'))
ALTER TABLE [dbo].[Salida]  WITH CHECK ADD  CONSTRAINT [FK_Salida_PlanDeVuelo] FOREIGN KEY([CodPlanVuelo])
REFERENCES [dbo].[PlanDeVuelo] ([CodPlanVuelo])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Salida_PlanDeVuelo]') AND parent_object_id = OBJECT_ID(N'[dbo].[Salida]'))
ALTER TABLE [dbo].[Salida] CHECK CONSTRAINT [FK_Salida_PlanDeVuelo]
GO
/****** Object:  ForeignKey [FK_InformacionVuelo_PlanDeVuelo1]    Script Date: 11/05/2010 17:02:26 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InformacionVuelo_PlanDeVuelo1]') AND parent_object_id = OBJECT_ID(N'[dbo].[InformacionVuelo]'))
ALTER TABLE [dbo].[InformacionVuelo]  WITH CHECK ADD  CONSTRAINT [FK_InformacionVuelo_PlanDeVuelo1] FOREIGN KEY([CodPlanVuelo])
REFERENCES [dbo].[PlanDeVuelo] ([CodPlanVuelo])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InformacionVuelo_PlanDeVuelo1]') AND parent_object_id = OBJECT_ID(N'[dbo].[InformacionVuelo]'))
ALTER TABLE [dbo].[InformacionVuelo] CHECK CONSTRAINT [FK_InformacionVuelo_PlanDeVuelo1]
GO
/****** Object:  ForeignKey [FK_Destino_PlanDeVuelo]    Script Date: 11/05/2010 17:02:27 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Destino_PlanDeVuelo]') AND parent_object_id = OBJECT_ID(N'[dbo].[Destino]'))
ALTER TABLE [dbo].[Destino]  WITH CHECK ADD  CONSTRAINT [FK_Destino_PlanDeVuelo] FOREIGN KEY([CodPlanVuelo])
REFERENCES [dbo].[PlanDeVuelo] ([CodPlanVuelo])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Destino_PlanDeVuelo]') AND parent_object_id = OBJECT_ID(N'[dbo].[Destino]'))
ALTER TABLE [dbo].[Destino] CHECK CONSTRAINT [FK_Destino_PlanDeVuelo]
GO
