

USE EventosDiscograficaDB;
GO

CREATE TABLE Eventos (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    ArtistaPrincipal NVARCHAR(100) NOT NULL,
    Fecha DATETIME NOT NULL,
    Precio DECIMAL(18,2) NOT NULL
);
GO

-- Insertamos 3 eventos de ejemplo (nota que NO ponemos el ID porque es automático)
INSERT INTO Eventos (Nombre, ArtistaPrincipal, Fecha, Precio)
VALUES 
('The World Is a Vampire Tour', 'The Smashing Pumpkins', '2026-11-12 21:00:00', 75000.00),
('30th Anniversary Tour', 'Korn', '2026-08-05 20:30:00', 85000.00),
('The Island Tour', 'Gorillaz', '2026-10-22 21:00:00', 90000.00);
GO


SELECT * FROM Eventos;
GO



