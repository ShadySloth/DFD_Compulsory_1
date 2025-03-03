BEGIN TRANSACTION;
ALTER TABLE [Enrollments] ADD [FinalGrade] int NOT NULL DEFAULT 0;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250303083632_RenameGrade', N'9.0.2');

COMMIT;
GO

