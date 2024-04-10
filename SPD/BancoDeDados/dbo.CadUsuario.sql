CREATE TABLE [dbo].[CadUsuario] (
    [nome]       VARCHAR (50) NOT NULL,
    [email]      VARCHAR (30) NOT NULL,
    [nascimento] DATE         NOT NULL,
    [senha]      VARCHAR (15) NOT NULL,
    [confsenha]  VARCHAR (15) NOT NULL
);

