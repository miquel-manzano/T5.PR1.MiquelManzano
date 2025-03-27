IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [EnergyIndicators] (
    [Id] int NOT NULL IDENTITY,
    [Year] datetime2 NOT NULL,
    [NetProduction] float NOT NULL,
    [GasolineConsumption] float NULL,
    [ElectricDemand] float NULL,
    [AvailableProduction] float NULL,
    CONSTRAINT [PK_EnergyIndicators] PRIMARY KEY ([Id])
);

CREATE TABLE [Simulations] (
    [Id] int NOT NULL IDENTITY,
    [Type] nvarchar(max) NOT NULL,
    [SunHours] int NOT NULL,
    [WindSpeed] float NOT NULL,
    [WaterFlow] float NOT NULL,
    [Ratio] float NOT NULL,
    [GeneratedEnergy] float NOT NULL,
    [KWhCost] float NOT NULL,
    [KWhPrice] float NOT NULL,
    [Date] datetime2 NOT NULL,
    CONSTRAINT [PK_Simulations] PRIMARY KEY ([Id])
);

CREATE TABLE [WaterConsumptions] (
    [Id] int NOT NULL IDENTITY,
    [County] nvarchar(max) NULL,
    [Population] int NULL,
    [Year] int NOT NULL,
    [Consumption] float NULL,
    CONSTRAINT [PK_WaterConsumptions] PRIMARY KEY ([Id])
);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250327164618_Initial', N'9.0.3');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250327164847_SeedTest', N'9.0.3');

DECLARE @var sysname;
SELECT @var = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Simulations]') AND [c].[name] = N'Type');
IF @var IS NOT NULL EXEC(N'ALTER TABLE [Simulations] DROP CONSTRAINT [' + @var + '];');
ALTER TABLE [Simulations] ALTER COLUMN [Type] int NOT NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250327212834_SimulationsModelUpdate', N'9.0.3');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250327223500_FinalMigration', N'9.0.3');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250327233723_ScriptMigration', N'9.0.3');

COMMIT;
GO