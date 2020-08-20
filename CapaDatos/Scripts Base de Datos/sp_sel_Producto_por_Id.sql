create procedure sp_sel_Producto_por_Id
@Id int
AS
select  
Id,
Nombre,
Precio,
Existencia,
Estatus
from Producto
where Id = @Id
