BEGIN TRANSACTION;
ALTER TABLE [Students] ADD [BirthDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250224114917_AddBirthDateToStudents', N'9.0.2');

COMMIT;
GO

