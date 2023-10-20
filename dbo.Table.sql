CREATE TABLE tranzactie
(
	[idTranzactie] INT NOT NULL PRIMARY KEY, 
    [valoareTranzactie] FLOAT NOT NULL, 
    [codClient] INT NOT NULL, 
    [codServiciu] INT NOT NULL, 
    [dataTranzactie] DATETIME NOT NULL
)
