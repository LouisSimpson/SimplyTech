CREATE TABLE [dbo].[tblOrder] (
    [OrderNo]     INT          NOT NULL,
    [DateOrdered] DATETIME     NULL,
    [ProductName] VARCHAR (50) NULL,
    [QuantityNo]  INT          NULL,
    [OrderPrice]  DECIMAL (18) NULL,
    PRIMARY KEY CLUSTERED ([OrderNo])
);

