create procedure sp_sel_Producto
AS
select  
Id,
Nombre,
Precio,
Existencia,
Estatus
from Producto
where Estatus= 1