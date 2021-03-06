USE Futurama
GO

SET IDENTITY_INSERT Actors ON

INSERT Actors (Id, [Name]) VALUES (1, N'Billy West')
INSERT Actors (Id, [Name]) VALUES (2, N'Katey Sagal')
INSERT Actors (Id, [Name]) VALUES (3, N'John DiMaggio')
INSERT Actors (Id, [Name]) VALUES (4, N'Lauren Tom')
INSERT Actors (Id, [Name]) VALUES (5, N'Phil LaMarr')

SET IDENTITY_INSERT Actors OFF

SET IDENTITY_INSERT Characters ON

INSERT Characters (Id, ActorId, [Name], Species, Planet) VALUES (1, 1, N'Philip J. Fry', N'Human', N'Earth')
INSERT Characters (Id, ActorId, [Name], Species, Planet) VALUES (2, 2, N'Leela Turanga', N'Mutant, Human', N'Earth')
INSERT Characters (Id, ActorId, [Name], Species, Planet) VALUES (3, 3, N'Bender Bending Rodriquez', N'Robot', N'Tijuana, Baja California')
INSERT Characters (Id, ActorId, [Name], Species, Planet) VALUES (4, 1, N'John A. Zoidberg', N'Decapodian', N'Decapod 10')
INSERT Characters (Id, ActorId, [Name], Species, Planet) VALUES (5, 4, N'Amy Wong', N'Human', N'Mars')
INSERT Characters (Id, ActorId, [Name], Species, Planet) VALUES (6, 5, N'Hermes Conrad', N'Human', N'Earth')
INSERT Characters (Id, ActorId, [Name], Species, Planet) VALUES (7, 1, N'Hubert J. Farnsworth', N'Human', N'Earth')

SET IDENTITY_INSERT Characters OFF
