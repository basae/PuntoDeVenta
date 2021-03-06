USE [Punto_De_Venta]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_Producto]    Script Date: 27/08/2020 10:37:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_upd_Producto]
@Id int,
@Nombre varchar(100) = NULL,
@Precio decimal(10,2) = NULL,
@Existencia decimal(10,2)=NULL,
@Estatus bit = NULL
AS

	UPDATE Producto SET
 Nombre= ISNULL(@Nombre,Nombre),
 Precio=ISNULL( @Precio,Precio),
 Existencia= case when @Existencia is null then Existencia else (@Existencia+Existencia) end,
 ESTATUS= ISNULL( @Estatus,ESTATUS)
 WHERE ID = @Id
 SELECT @Id

