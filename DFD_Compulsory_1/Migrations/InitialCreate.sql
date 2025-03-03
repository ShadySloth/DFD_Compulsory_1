﻿IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [Courses] (
    [Id] int NOT NULL IDENTITY,
    [Title] varchar(50) NOT NULL,
    [Credits] int NOT NULL,
    CONSTRAINT [PK_Courses] PRIMARY KEY ([Id])
);

CREATE TABLE [Students] (
    [Id] int NOT NULL IDENTITY,
    [FirstName] varchar(50) NOT NULL,
    [LastName] varchar(50) NOT NULL,
    [Email] varchar(60) NOT NULL,
    [EnrollmentDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY ([Id])
);

CREATE TABLE [Enrollments] (
    [Id] int NOT NULL IDENTITY,
    [StudentId] int NOT NULL,
    [CourseId] int NOT NULL,
    [Grade] int NOT NULL,
    CONSTRAINT [PK_Enrollments] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Enrollments_Courses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [Courses] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Enrollments_Students_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Students] ([Id]) ON DELETE CASCADE
);

CREATE INDEX [IX_Enrollments_CourseId] ON [Enrollments] ([CourseId]);

CREATE INDEX [IX_Enrollments_StudentId] ON [Enrollments] ([StudentId]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250224113120_InitialCreate', N'9.0.2');

COMMIT;
GO

