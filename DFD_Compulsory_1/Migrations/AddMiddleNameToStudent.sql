BEGIN TRANSACTION;
ALTER TABLE [Students] ADD [MiddleName] varchar(50) NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250224114343_AddMiddleNameToStudents', N'9.0.2');

COMMIT;
GO

