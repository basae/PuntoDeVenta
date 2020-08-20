USE [Punto_De_Venta]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_Producto]    Script Date: 19/08/2020 09:44:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_ins_Producto]
@Nombre varchar(100),
@Precio decimal(10,2),
@Existencia decimal(10,2)
AS
	insert into [dbo].[Producto](Nombre, Precio, Existencia,Estatus)
	select @Nombre,@Precio,@Existencia,1

select SCOPE_IDENTITY()
