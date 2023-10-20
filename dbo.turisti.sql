CREATE TABLE [dbo].[turisti] (
    [Id_Turist]    INT          NOT NULL,
    [Nume]        VARCHAR (50) NULL,
    [Prenume]     VARCHAR (50) NULL,
    [Email]       VARCHAR (50) NULL,
    [Telefon]     VARCHAR (50) NULL,
    [Data_Nastere] DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([Id_Turist] ASC)
);

