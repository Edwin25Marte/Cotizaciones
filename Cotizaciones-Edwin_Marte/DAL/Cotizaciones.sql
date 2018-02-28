create database Cotizaciones

go
create table RCotizaciones(
	CotizacionesId int primary key not null,
	Fecha varchar(10),
	Comentario varchar(100),
	Monto decimal
);