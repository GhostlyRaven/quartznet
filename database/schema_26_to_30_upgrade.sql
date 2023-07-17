/*
Upgrade Quartz.NET schema for SQL Server database 
Migration from 2.6 to 3.0
*/

--USE [database_name];
--GO

ALTER TABLE [dbo].[QRTZ_CALENDARS]
ALTER COLUMN [CALENDAR] [VARBINARY](MAX) NOT NULL;
GO

ALTER TABLE [dbo].[QRTZ_JOB_DETAILS]
ALTER COLUMN [JOB_DATA] [VARBINARY](MAX) NULL;
GO

ALTER TABLE [dbo].[QRTZ_BLOB_TRIGGERS]
ALTER COLUMN [BLOB_DATA] [VARBINARY](MAX) NULL;
GO

ALTER TABLE [dbo].[QRTZ_TRIGGERS]
ALTER COLUMN [JOB_DATA] [VARBINARY](MAX) NULL;
GO