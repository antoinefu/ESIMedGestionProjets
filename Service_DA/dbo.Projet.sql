CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Description] VARCHAR(MAX) NOT NULL, 
    [Fonctionnelle] BIT NOT NULL, 
    [Type] INT NULL, 
    [Projet] INT NULL,
	CONSTRAINT FK_Table_Type FOREIGN KEY (Type)     
    REFERENCES TypeExigence (Id)     
		ON DELETE CASCADE    
		ON UPDATE CASCADE,
	CONSTRAINT FK_Table_Projet FOREIGN KEY (Projet)     
    REFERENCES Projet (Id)     
		ON DELETE CASCADE    
		ON UPDATE CASCADE
)
