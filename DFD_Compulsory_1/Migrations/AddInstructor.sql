BEGIN TRANSACTION;
ALTER TABLE [Courses] ADD [InstructorId] int NOT NULL DEFAULT 0;

CREATE TABLE [Instructors] (
    [Id] int NOT NULL IDENTITY,
    [FirstName] varchar(50) NOT NULL,
    [LastName] varchar(50) NOT NULL,
    [HireDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Instructors] PRIMARY KEY ([Id])
);

CREATE INDEX [IX_Courses_InstructorId] ON [Courses] ([InstructorId]);

ALTER TABLE [Courses] ADD CONSTRAINT [FK_Courses_Instructors_InstructorId] FOREIGN KEY ([InstructorId]) REFERENCES [Instructors] ([Id]) ON DELETE CASCADE;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250224115648_AddInstructor', N'9.0.2');

COMMIT;
GO

