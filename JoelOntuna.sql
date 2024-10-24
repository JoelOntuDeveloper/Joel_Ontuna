use Prueba_Joel_Ontuna;
go

IF OBJECT_ID('dbo.Items', 'U') IS NOT NULL
BEGIN
	DROP TABLE dbo.Items;
END
GO

IF OBJECT_ID('dbo.Users', 'U') IS NOT NULL
BEGIN
	DROP TABLE dbo."Users";
END
GO

create table "Users"(
	Id Int Primary Key Identity(1,1),
	UserName NVARCHAR(50) not null
);
go

create table Items(
	Id Int Primary Key Identity(1,1),
	"description" nvarchar(255) not null,
	isCompleted bit not null,
	deliveryDate datetime default GetDate(),
	relevance varchar(20) not null,
	userId int,
	CONSTRAINT FK_Item_User FOREIGN KEY (userId) references dbo."Users"(Id) on delete set null

);
go

insert into "Users"(UserName) values ('joel');
insert into "Users"(UserName) values ('jorge');
insert into "Users"(UserName) values ('pedro');
insert into "Users"(UserName) values ('ignacio');

insert into items ("description",isCompleted, deliveryDate, relevance) values ('Proyecto: ERP Bug: No se ven los logs', 0, '20241026 00:00:00 AM', 'ALTA');
insert into items ("description",isCompleted, deliveryDate, relevance) values ('Proyecto: ERP Nuevo: Dashboard', 0, '20241026 00:00:00 AM', 'BAJA');
insert into items ("description",isCompleted, deliveryDate, relevance) values ('Proyecto: ERP Nuevo: Dashboard2', 0, '20241026 00:00:00 AM', 'BAJA');
insert into items ("description",isCompleted, deliveryDate, relevance, userId) values ('Proyecto: ERP Nuevo: Ventana de chat', 0, '20241026 00:00:00 AM', 'ALTA', 2);
insert into items ("description",isCompleted, deliveryDate, relevance) values ('Proyecto: ERP Bug: Notificaciones no funciona', 0, '20241026 00:00:00 AM', 'ALTA');
insert into items ("description",isCompleted, deliveryDate, relevance, userId) values ('Proyecto: ERP Nuevo: Validar cédula', 0, '20241026 00:00:00 AM', 'ALTA', 2);
insert into items ("description",isCompleted, deliveryDate, relevance, userId) values ('Proyecto: ERP Nuevo: Validar edad', 1, '20241026 00:00:00 AM', 'ALTA', 2);
insert into items ("description",isCompleted, deliveryDate, relevance, userId) values ('Proyecto: ERP Nuevo: Validar email', 1, '20241026 00:00:00 AM', 'ALTA', 2);