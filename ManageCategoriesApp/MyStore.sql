-- Create the database
CREATE DATABASE MyStore;
GO

-- Use the database
USE MyStore;
GO

-- Create the Categories table
CREATE TABLE dbo.Categories (
    CategoryID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(15) NOT NULL
);
GO

-- Insert data into the Categories table
INSERT INTO dbo.Categories (CategoryName) VALUES
('Beverages'),
('Condiments'),
('Confections'),
('Dairy Products'),
('Grains/Cereals'),
('Meat/Poultry'),
('Produce'),
('Seafood');
GO