USE [Authentication]
GO

/****** Object: Table [dbo].[Users] Script Date: 02/05/2019 10:21:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [username] VARCHAR (50) NOT NULL,
    [password] VARCHAR (50) NOT NULL,
    [loginid]  INT          IDENTITY (1, 1) NOT NULL
);


