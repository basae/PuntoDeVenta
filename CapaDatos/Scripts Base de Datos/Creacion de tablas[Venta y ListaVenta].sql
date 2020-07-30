create table Venta
(
Id int primary key identity(1,1),
FechaVenta datetime not null,
Subtotal decimal(10,2) not null,
IVA decimal(10,2) not null,
Total decimal(10,2) not null
)
GO
create table Venta_Lista
(
Id int primary key identity(1,1),
Id_Venta int not null,
Id_Producto int not null,
Cantidad int not null,
Subtotal decimal(10,2) not null,
foreign key (Id_Venta) references Venta,
foreign key (Id_Producto) references Producto
)