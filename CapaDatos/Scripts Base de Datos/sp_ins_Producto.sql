create procedure sp_ins_Producto
@Nombre varchar(100),
@Precio decimal(10,2),
@Existencia decimal(10,2)
AS
	insert into [dbo].[Producto](Nombre, Precio, Existencia)
	select @Nombre,@Precio,@Existencia
