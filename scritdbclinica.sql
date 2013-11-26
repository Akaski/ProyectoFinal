create database dbclinica
go
use dbclinica
create table Cliente
(
idcliente int not null identity,
nombre varchar(30)not null,
ap_paterno varchar(30)not null,
ap_materno varchar(30)not null,
ci varchar(30) not null,
direccion varchar(100),
telefono varchar(200),
primary key (ci)
)
go
create table trabajo
(
idtrabajo int not null identity,
descripcion varchar(30)not null,
precio varchar(30) not null,
primary key(idtrabajo)
)
go
create table DetalleTrabajo(
idtrabajo int foreign key references trabajo(idtrabajo),
descripcion varchar (30)not null,
costo varchar(30) not null,
idcliente varchar(30) foreign key references Cliente(ci),
primary key(idtrabajo,idcliente),
fecha datetime not null,
hora varchar(30) not null,
nropago int not null,
monto int not null,
)
select *from DetalleTrabajo
go
create procedure sp_abmCliente
@tarea int,
@idcliente int,
@nombre varchar(200),
@ap_paterno varchar(200),
@ap_materno varchar(200),
@ci varchar(30) ,
@direccion varchar(200),
@telefono varchar(200),
@resultado int output
As
if(@tarea=1)
insert into Cliente values (@nombre,@ap_paterno,@ap_materno,@ci,@direccion,@telefono)
if(@tarea =2)
update Cliente set nombre=@nombre,ap_paterno=@ap_paterno,ap_materno=@ap_materno,ci=@ci,direccion=@direccion,telefono=@telefono where idcliente=@idcliente
if(@tarea=3)
delete from Cliente Where  idcliente=@idcliente
if(@@ERROR=0)
begin
set @resultado=1
return 1
end
else
begin
set @resultado=0
return 0
end
go
create procedure sp_BuscarCliente
@criterio varchar(20)
as
select * from cliente where ci like @criterio
go
create procedure sp_TraerCliente
@idcliente int
as
select * from cliente where idcliente=@idcliente
go
---------trabajo---------
create procedure sp_abmTrabajo
@tarea int,
@idtrabajo int,
@descripcion varchar(200),
@precio varchar(200),
@resultado int output
As
if(@tarea=1)
insert into trabajo values (@descripcion,@precio)
if(@tarea =2)
update trabajo set descripcion=@descripcion,precio=@precio where idtrabajo=@idtrabajo
if(@tarea=3)
delete from trabajo Where  idtrabajo=@idtrabajo
if(@@ERROR=0)
begin
set @resultado=1
return 1
end
else
begin
set @resultado=0
return 0
end
go
create procedure sp_BuscarTrabajo
@criterio varchar(20)
as
select * from trabajo where descripcion like @criterio
go
create procedure sp_TraerTrabajo
@idtrabajo int
as
select * from trabajo where idtrabajo=@idtrabajo
go
-------DETALLE-------
create procedure sp_abmDetalleVenta
@tarea int,
@idtrabajo int,
@idcliente int,
@fecha datetime,
@hora varchar(30),
@nropago int,
@monto int,
@resultado int output
As
if(@tarea=1)
insert into DetalleVenta1 values (@fecha,@hora,@nropago,@monto)
if(@tarea =2)
update DetalleVenta1 set fecha=@fecha,hora=@hora,nropago=@nropago,monto=@monto where idtrabajo=@idtrabajo and idcliente=@idcliente
if(@tarea=3)
delete from DetalleVenta1 Where idtrabajo=@idtrabajo and idcliente=@idcliente
if(@@ERROR=0)
begin
set @resultado=1
return 1
end
else
begin
set @resultado=0
return 0
end
create procedure sp_BuscarDetalle
@criterio varchar(20)
as
select * from DetalleTrabajo where idcliente like @criterio
go
create procedure sp_TraerDetalle
@idtrabajo int
as
select * from detalle where idtrabajo=@idtrabajo
go