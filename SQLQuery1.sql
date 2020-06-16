CREATE DATABASE  ParcialFinal;

CREATE TABLE Recaudos
(
	NitAgente NVARCHAR(11) NOT NULL,
	MesReporte INT NOT NULL,
	VigenciaReporte INT NOT NULL,
	TipoEstampilla NVARCHAR(15) NOT NULL,
	ValorImpuesto DECIMAL NOT NULL,
	IDContratista NVARCHAR(11) NOT NULL,
	NombreContratista NVARCHAR(15) NOT NULL

);

ALTER TABLE Recaudos ADD CONSTRAINT PK_Recaudos_NitAgente PRIMARY KEY(NitAgente);

ALTER TABLE Recaudos DROP CONSTRAINT PK_Recaudos_NitAgente;

SELECT * FROM INFORMATION_SCHEMA.CHECK_CONSTRAINTS;


SELECT * FROM Recaudos;
 

 CREATE OR ALTER PROC insertRecaudo
 (
	@NitAgente NVARCHAR(11),
	@MesReporte INT,
	@VigenciaReporte INT,
	@TipoEstampilla NVARCHAR(15),
	@ValorImpuesto DECIMAL,
	@IDContratista NVARCHAR(11),
	@NombreContratista NVARCHAR(15)
 
)
AS

 INSERT INTO Recaudos (NitAgente,MesReporte,VigenciaReporte,TipoEstampilla,ValorImpuesto,IDContratista,NombreContratista)
			 VALUES(@NitAgente,@MesReporte,@VigenciaReporte,@TipoEstampilla,@ValorImpuesto,@IDContratista,@NombreContratista);

GO


CREATE OR ALTER PROC selectRecaudos
AS

	SELECT * FROM Recaudos;
	
GO