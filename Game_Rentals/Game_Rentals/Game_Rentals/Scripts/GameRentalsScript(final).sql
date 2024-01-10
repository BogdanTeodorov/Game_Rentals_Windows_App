-- Drop Database if it exists
USE master;
IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'GameRentals')
BEGIN
    ALTER DATABASE GameRentals SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE GameRentals;
END

-- Create Database
CREATE DATABASE GameRentals;
GO
-- Use Database
USE GameRentals;
GO

/*
	Drop FK Contrains on Many-to-Many
*/
IF (EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'dbo' 
                 AND  TABLE_NAME = 'Rentals'))
BEGIN    
	ALTER TABLE Rentals DROP CONSTRAINT IF EXISTS [PK_Rentals]
	ALTER TABLE Rentals DROP CONSTRAINT IF EXISTS [FK_Rentals_Game]	
	ALTER TABLE Rentals DROP CONSTRAINT IF EXISTS [FK_Rentals_Customer]	

END

GO
DROP TABLE IF EXISTS Rentals
GO

/*
Accounts Table
*/
USE GameRentals
GO
-- Drop Table if it exists
DROP TABLE IF EXISTS accounts;

-- Create Table
CREATE TABLE Accounts (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    UserName VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL
);

-- Insert Users
INSERT INTO Accounts (UserName, Password) VALUES
('JohnDoe', 'JD@pass123'),
('AliceSmith', 'AS#pwd456'),
('BobJohnson', 'BJ*secure789'),
('EvaWilliams', 'EW$1234'),
('CharlieBrown', 'CB&pass567'),
('BobLee', 'bl123'),
('GameRentalsAdmin', '123456');




/*
Games Table
*/

DROP TABLE IF EXISTS Games;

IF (EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'dbo' 
                 AND  TABLE_NAME = 'Games'))
BEGIN   
	
	ALTER TABLE Games DROP CONSTRAINT IF EXISTS [PK_Game]
END

CREATE TABLE Games (
    GameID INT IDENTITY(1,1),
    Title VARCHAR(255) NOT NULL,
    RentalPrice DECIMAL(10, 2) NOT NULL,
    Genre VARCHAR(50) NOT NULL,
    ReleaseDate DATE NOT NULL,
    Description VARCHAR(MAX),
    Rate CHAR(1) NOT NULL,
    CONSTRAINT PK_Game PRIMARY KEY (GameID) -- Custom name for the primary key constraint
);

INSERT INTO Games (Title, RentalPrice, Genre, ReleaseDate, Description, Rate)
VALUES
    ('Red Dead Redemption 2', 9.99, 'Action-Adventure', '2018-10-26', 'Western-themed action-adventure game developed and published by Rockstar Games.', 'M'),
    ('The Witcher 3: Wild Hunt', 19.99, 'Role-Playing', '2015-05-19', 'Open-world role-playing game developed by CD Projekt.', 'M'),
    ('Grand Theft Auto V', 19.99, 'Action-Adventure', '2013-09-17', 'Action-adventure game developed by Rockstar North.', 'M'),
    ('Cyberpunk 2077', 24.99, 'Role-Playing', '2020-12-10', 'Action role-playing game developed and published by CD Projekt.', 'M'),
    ('Call of Duty: Modern Warfare', 9.99, 'First-Person Shooter', '2019-10-25', 'First-person shooter game developed by Infinity Ward.', 'M'),
    ('Assassins`s Creed Valhalla', 19.99, 'Action-Adventure', '2020-11-10', 'Action role-playing game developed by Ubisoft.', 'M'),
    ('Final Fantasy VII Remake', 9.99, 'Role-Playing', '2020-04-10', 'Action role-playing game developed and published by Square Enix.', 'T'),
    ('DOOM Eternal', 14.99, 'First-Person Shooter', '2020-03-20', 'First-person shooter game developed by id Software.', 'M'),
    ('Spider-Man: Miles Morales', 9.99, 'Action-Adventure', '2020-11-12', 'Action-adventure game developed by Insomniac Games.', 'T'),
	('Space Explorer', 7.99, 'Simulation', '2022-07-20', 'Explore the cosmos and uncover the mysteries of space in this simulation game that lets you become an intrepid space explorer.', 'E'),
    ('Mystery Mansion', 4.99, 'Adventure', '2022-08-15', 'Solve puzzles and unravel the secrets of a mysterious mansion in this adventure game that promises suspense and intrigue.', 'E'),
    ('Sports Challenge', 4.99, 'Sports', '2022-09-05', 'Compete in thrilling sports challenges and experience the excitement of victory in this engaging sports game for players of all ages.', 'E'),
    ('Super Racer', 9.99, 'Racing', '2022-10-10', 'Feel the adrenaline rush as you speed through exhilarating race tracks in this high-octane racing game suitable for all racing enthusiasts.', 'E'),
    ('Medieval Kingdoms', 4.99, 'Strategy', '2022-11-20', 'Build and rule your medieval kingdom in this strategic game that challenges your leadership and tactical skills.', 'E');
/*
Customers Table
*/

-- Drop primary key constraint in Customers table
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_NAME = 'PK_Customers'))
BEGIN
    ALTER TABLE Customers DROP CONSTRAINT PK_Customers;
END

-- Drop Table if it exists
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Customers'))
BEGIN   
    DROP TABLE Customers;
END

-- Create Table
CREATE TABLE Customers (
    CustomerId INT IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    MiddleName NVARCHAR(50),
    DateOfBirth DATE,
    Email NVARCHAR(255) NOT NULL,
    Phone NVARCHAR(20) NOT NULL,
    CONSTRAINT Unique_Email UNIQUE (Email),
    CONSTRAINT PK_Customers PRIMARY KEY (CustomerId ASC)
)

-- Insert Sample Data
INSERT INTO Customers (FirstName, LastName, MiddleName, DateOfBirth, Email, Phone)
VALUES
    ('John', 'Doe', NULL, '1990-01-15', 'JohnDoe@email.com', '123-456-7890'),
    ('Alice', 'Smith', 'Marie', '1985-05-22', 'AliceSmith@email.com', '987-654-3210'), -- Added Middle Name
    ('Bob', 'Johnson', NULL, '1978-11-30', 'BobJohnson@email.com', '555-123-4567'),
    ('Eva', 'Williams', 'Grace', '2006-12-01', 'EvaWilliams@email.com', '789-456-1230'), -- Added Middle Name and Adjusted Date of Birth
    ('Charlie', 'Brown', NULL, '1980-03-05', 'CharlieBrown@email.com', '321-654-0987'),
    ('Andrew', 'Lambert', 'Robert', '1995-08-20', 'ALambert@email.com', '987-654-3210'),-- Added Middle Name
    ('Bob', 'Lee', NULL, '1988-04-06', 'BobLEE@email.com', '321-654-0987');

	USE[GameRentals]
Go

/*
	Drop FK Contrains on Many-to-Many
*/
IF (EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'dbo' 
                 AND  TABLE_NAME = 'Rentals'))
BEGIN    
	ALTER TABLE Rentals DROP CONSTRAINT IF EXISTS [FK_Rentals_Customer]
	ALTER TABLE Rentals DROP CONSTRAINT IF EXISTS [FK_Rentals_Game]	
	ALTER TABLE Rentals DROP CONSTRAINT IF EXISTS [PK_Rentals]
END

GO
DROP TABLE IF EXISTS Rentals;

-- Create Table
CREATE TABLE Rentals (
    GameId INT,
    CustomerId INT,
    RentalDate DATE,
    DueDate DATE,
    ReturnDate DATE NULL,
    CONSTRAINT PK_Rentals PRIMARY KEY (GameId, CustomerId),
    CONSTRAINT FK_Rentals_Game FOREIGN KEY (GameId) REFERENCES Games(GameId),
    CONSTRAINT FK_Rentals_Customer FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
);

-- Sample data for Rentals (You can adjust the values as needed)
INSERT INTO Rentals (GameID, CustomerId, RentalDate, DueDate, ReturnDate)
VALUES
    (1, 1, '2023-01-01', '2023-01-10', '2023-01-05'), -- Example Rental
    (2, 2, '2023-12-01', '2023-12-25', NULL), -- Example Ongoing Rental
    (3, 3, '2023-03-10', '2023-03-20', '2022-03-15'), -- Example Returned Rental
	(14, 4, '2023-08-10', '2023-08-20', '2023-08-25' ), -- Example Rental (Overdue)
	(9, 3, '2023-12-02', '2023-12-12', NULL),-- Example Ongoing Rental
	(10, 4, '2023-04-05', '2023-04-15', '2023-04-10'), -- Example Returned Rental
    (5, 5, '2023-12-04', '2023-12-14', NULL), -- Example Ongoing Rental
    (6, 6, '2023-12-03', '2023-12-13', NULL), -- Example Ongoing Rental
    (6, 1, '2023-01-02', '2023-01-09', '2023-01-08'); -- Example Rental

	SELECT * FROM Accounts
	SELECT * FROM Games
	SELECT * FROM Customers
	SELECT * FROM Rentals