CREATE DATABASE NotesDB

USE NotesDB


CREATE TABLE [BlocoDeNotas] (
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](100) NOT NULL,
	[Descricao] [varchar](500) NOT NULL,
)



