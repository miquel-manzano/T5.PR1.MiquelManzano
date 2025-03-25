-- Crear la base de datos
CREATE DATABASE EcoEnergySolutions;
GO

-- Usar la base de datos
USE EcoEnergySolutions;
GO

-- Crear tabla EnergyIndicators (para el modelo EnergyIndicator)
CREATE TABLE EnergyIndicators (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Year DATETIME NOT NULL DEFAULT GETDATE(),
    NetProduction DOUBLE PRECISION NULL,
    GasolineConsumption DOUBLE PRECISION NULL,
    ElectricDemand DOUBLE PRECISION NULL,
    AvailableProduction DOUBLE PRECISION NULL
);
GO

-- Crear tabla WaterConsumptions (para el modelo WaterConsumption)
CREATE TABLE WaterConsumptions (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    County NVARCHAR(100) NULL,
    Population INT NULL,
    Year DATETIME NOT NULL DEFAULT GETDATE(),
    Consumption DOUBLE PRECISION NULL
);
GO

-- Índices (opcionales pero recomendados)
CREATE INDEX IX_EnergyIndicators_Year ON EnergyIndicators(Year);
CREATE INDEX IX_WaterConsumptions_Year ON WaterConsumptions(Year);
CREATE INDEX IX_WaterConsumptions_County ON WaterConsumptions(County);
GO


-- Combrobar tablas con consultas
SELECT * FROM EnergyIndicators;
SELECT * FROM WaterConsumptions;