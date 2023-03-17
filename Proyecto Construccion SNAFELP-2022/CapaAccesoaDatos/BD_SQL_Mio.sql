--Codigos SQL--
--Creacion de tabla SQL-Server

DROP TABLE [dbo].[Persona];

DROP TABLE [dbo].[Administrador];

DROP TABLE [dbo].[Jugador];

DROP TABLE [dbo].[Arbitro];

DROP TABLE [dbo].[Campeonato];

DROP TABLE [dbo].[Campeonato_u_fechas];

DROP TABLE [dbo].[Acta];

DROP TABLE [dbo].[Fecha];

DROP TABLE [dbo].[Fecha_u_partidos];

DROP TABLE [dbo].[Equipo];

DROP TABLE [dbo].[Marcador];

DROP TABLE [dbo].[Tipoalineacion];

DROP TABLE [dbo].[Alineacion];

DROP TABLE [dbo].[Partido];

CREATE TABLE [dbo].[Persona] (
    [id_persona] INT NOT NULL PRIMARY KEY IDENTITY,
    [nombres] VARCHAR (100) NULL,
    [apellidos] VARCHAR (100) NULL,
    [cedula] VARCHAR (100) NULL,
    [fechanacimiento] DATETIME NULL,
    [telefono] VARCHAR (100) NULL,
    [nacionalidad] VARCHAR (100) NULL 
);

CREATE TABLE [dbo].[Administrador] (
    [id_persona] INT NOT NULL PRIMARY KEY IDENTITY,
    [nombres] VARCHAR (100) NULL,
    [apellidos] VARCHAR (100) NULL,
    [cedula] VARCHAR (100) NULL,
    [fechanacimiento] DATETIME NULL,
    [telefono] VARCHAR (100) NULL,
    [nacionalidad] VARCHAR (100) NULL,
    [usuario] VARCHAR (100) NULL,
    [psw] VARCHAR (100) NULL,
    [puesto] VARCHAR (100) NULL 
);

CREATE TABLE [dbo].[Jugador] (
    [id_persona] INT NOT NULL PRIMARY KEY IDENTITY,
    [nombres] VARCHAR (100) NULL,
    [apellidos] VARCHAR (100) NULL,
    [cedula] VARCHAR (100) NULL,
    [fechanacimiento] DATETIME NULL,
    [telefono] VARCHAR (100) NULL,
    [nacionalidad] VARCHAR (100) NULL,
    [numero] SMALLINT NULL 
);

CREATE TABLE [dbo].[Arbitro] (
    [id_persona] INT NOT NULL PRIMARY KEY IDENTITY,
    [usuario] VARCHAR (100) NULL,
    [psw] VARCHAR (100) NULL,
    [puesto] VARCHAR (100) NULL,
    [nombres] VARCHAR (100) NULL,
    [apellidos] VARCHAR (100) NULL,
    [cedula] VARCHAR (100) NULL,
    [fechanacimiento] DATETIME NULL,
    [telefono] VARCHAR (100) NULL,
    [nacionalidad] VARCHAR (100) NULL,
    [licencia] VARCHAR (100) NULL 
);

CREATE TABLE [dbo].[Campeonato] (
    [id_campeonato] INT NOT NULL PRIMARY KEY IDENTITY,
    [nombre_campeonado] VARCHAR (100) NULL,
    [fechas] INT NULL 
);
CREATE TABLE [dbo].[Campeonato_u_fechas] (
    [id_campeonato] INT,
    [id_fecha] INT
);


CREATE TABLE [dbo].[Acta] (
    [id_acta] INT NOT NULL PRIMARY KEY IDENTITY,
    [fecha] INT NULL,
    [partido] INT NULL,
    [marcador_acta] INT NULL,
    [equipoa_acta] INT NULL,
    [equipob_acta] INT NULL 
);

CREATE TABLE [dbo].[Fecha] (
    [id_fecha] INT NOT NULL PRIMARY KEY IDENTITY,
    [partidos] INT NULL,
    [numero_fecha] INT NULL,
    [fechainicio] DATETIME NULL,
    [fechafin] DATETIME NULL 
);
CREATE TABLE [dbo].[Fecha_u_partidos] (
    [id_fecha] INT,
    [id_partido] INT
);


CREATE TABLE [dbo].[Equipo] (
    [id_equipo] INT NOT NULL PRIMARY KEY IDENTITY,
    [jugadores] INT NULL 
);

CREATE TABLE [dbo].[Marcador] (
    [id_marcador] INT NOT NULL PRIMARY KEY IDENTITY,
    [goleaequipoa] SMALLINT NULL,
    [golesequipob] SMALLINT NULL 
);

CREATE TABLE [dbo].[Tipoalineacion] (
    [id_tipoalineacion] INT NOT NULL PRIMARY KEY IDENTITY,
    [nombre_alineacion] VARCHAR (100) NULL 
);

CREATE TABLE [dbo].[Alineacion] (
    [id_alineacion] INT NOT NULL PRIMARY KEY IDENTITY,
    [tipo_alineacion] INT NULL,
    [jugador_alineacion] INT NULL,
    [equipo] INT NULL 
);

CREATE TABLE [dbo].[Partido] (
    [id_partido] INT NOT NULL PRIMARY KEY IDENTITY,
    [equipoa_partido] INT NULL,
    [equipob_partido] INT NULL,
    [marcador_partido] INT NULL,
    [arbitroprincipal] INT NULL 
);









ALTER TABLE Campeonato ADD CONSTRAINT [FK_Campeonato_fechas] FOREIGN KEY ([fechas]) REFERENCES [fecha]([id_fecha]);
ALTER TABLE Campeonato_u_fechas ADD CONSTRAINT [FK_Campeonato_u_fechas_id_campeonato] FOREIGN KEY ([id_campeonato]) REFERENCES [campeonato]([id_campeonato])
ALTER TABLE Campeonato_u_fechas ADD CONSTRAINT [FK_Campeonato_u_fechas_id_fecha] FOREIGN KEY ([id_fecha]) REFERENCES [fecha]([id_fecha])


ALTER TABLE Acta ADD CONSTRAINT [FK_Acta_fecha] FOREIGN KEY ([fecha]) REFERENCES [fecha]([id_fecha]);
ALTER TABLE Acta ADD CONSTRAINT [FK_Acta_partido] FOREIGN KEY ([partido]) REFERENCES [partido]([id_partido]);
ALTER TABLE Acta ADD CONSTRAINT [FK_Acta_marcador_acta] FOREIGN KEY ([marcador_acta]) REFERENCES [marcador]([id_marcador]);
ALTER TABLE Acta ADD CONSTRAINT [FK_Acta_equipoa_acta] FOREIGN KEY ([equipoa_acta]) REFERENCES [equipo]([id_equipo]);
ALTER TABLE Acta ADD CONSTRAINT [FK_Acta_equipob_acta] FOREIGN KEY ([equipob_acta]) REFERENCES [equipo]([id_equipo]);

ALTER TABLE Fecha ADD CONSTRAINT [FK_Fecha_partidos] FOREIGN KEY ([partidos]) REFERENCES [partido]([id_partido]);
ALTER TABLE Fecha_u_partidos ADD CONSTRAINT [FK_Fecha_u_partidos_id_fecha] FOREIGN KEY ([id_fecha]) REFERENCES [fecha]([id_fecha])
ALTER TABLE Fecha_u_partidos ADD CONSTRAINT [FK_Fecha_u_partidos_id_partido] FOREIGN KEY ([id_partido]) REFERENCES [partido]([id_partido])


ALTER TABLE Equipo ADD CONSTRAINT [FK_Equipo_jugadores] FOREIGN KEY ([jugadores]) REFERENCES [jugador]([id_persona]);





ALTER TABLE Alineacion ADD CONSTRAINT [FK_Alineacion_tipo_alineacion] FOREIGN KEY ([tipo_alineacion]) REFERENCES [tipoalineacion]([id_tipoalineacion]);
ALTER TABLE Alineacion ADD CONSTRAINT [FK_Alineacion_jugador_alineacion] FOREIGN KEY ([jugador_alineacion]) REFERENCES [jugador]([id_persona]);
ALTER TABLE Alineacion ADD CONSTRAINT [FK_Alineacion_equipo] FOREIGN KEY ([equipo]) REFERENCES [equipo]([id_equipo]);

ALTER TABLE Partido ADD CONSTRAINT [FK_Partido_equipoa_partido] FOREIGN KEY ([equipoa_partido]) REFERENCES [equipo]([id_equipo]);
ALTER TABLE Partido ADD CONSTRAINT [FK_Partido_equipob_partido] FOREIGN KEY ([equipob_partido]) REFERENCES [equipo]([id_equipo]);
ALTER TABLE Partido ADD CONSTRAINT [FK_Partido_marcador_partido] FOREIGN KEY ([marcador_partido]) REFERENCES [marcador]([id_marcador]);
ALTER TABLE Partido ADD CONSTRAINT [FK_Partido_arbitroprincipal] FOREIGN KEY ([arbitroprincipal]) REFERENCES [arbitro]([id_persona]);

INSERT INTO [dbo].[Persona] ([nombres],[apellidos],[cedula],[fechanacimiento],[telefono],[nacionalidad]) VALUES ('','','','','','');

INSERT INTO [dbo].[Administrador] ([nombres],[apellidos],[cedula],[fechanacimiento],[telefono],[nacionalidad],[usuario],[psw],[puesto]) VALUES ('','','','','','','','','');

INSERT INTO [dbo].[Jugador] ([nombres],[apellidos],[cedula],[fechanacimiento],[telefono],[nacionalidad],[numero]) VALUES ('','','','','','','');

INSERT INTO [dbo].[Arbitro] ([usuario],[psw],[puesto],[nombres],[apellidos],[cedula],[fechanacimiento],[telefono],[nacionalidad],[licencia]) VALUES ('','','','','','','','','','');

INSERT INTO [dbo].[Campeonato] ([nombre_campeonado],[fechas]) VALUES ('','');
INSERT INTO [dbo].[Campeonato_u_fechas] ([id_campeonato], [id_fecha]) VALUES ('','');


INSERT INTO [dbo].[Acta] ([fecha],[partido],[marcador_acta],[equipoa_acta],[equipob_acta]) VALUES ('','','','','');

INSERT INTO [dbo].[Fecha] ([partidos],[numero_fecha],[fechainicio],[fechafin]) VALUES ('','','','');
INSERT INTO [dbo].[Fecha_u_partidos] ([id_fecha], [id_partido]) VALUES ('','');


INSERT INTO [dbo].[Equipo] ([jugadores]) VALUES ('');

INSERT INTO [dbo].[Marcador] ([goleaequipoa],[golesequipob]) VALUES ('','');

INSERT INTO [dbo].[Tipoalineacion] ([nombre_alineacion]) VALUES ('');

INSERT INTO [dbo].[Alineacion] ([tipo_alineacion],[jugador_alineacion],[equipo]) VALUES ('','','');

INSERT INTO [dbo].[Partido] ([equipoa_partido],[equipob_partido],[marcador_partido],[arbitroprincipal]) VALUES ('','','','');



DROP PROCEDURE probando;
EXECUTE sp_name;



