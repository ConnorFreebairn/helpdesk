USE [Authentication]
GO

/****** Object: Table [dbo].[tickets] Script Date: 04/05/2019 07:59:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tickets] (
    [ticketid]     INT           IDENTITY (1, 1) NOT NULL,
    [affecteduser] VARCHAR (50)  NOT NULL,
    [message]      VARCHAR (MAX) NOT NULL,
    [status]       VARCHAR (MAX) NOT NULL,
    [comments]     VARCHAR (MAX) NULL
);


