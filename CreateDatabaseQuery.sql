CREATE TABLE [dbo].[Product] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Name]  VARCHAR (255) NULL,
    [Price] VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Order] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Price] VARCHAR (255) NOT NULL,
    [Paid]  BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[OrderDetails] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [ProductId] INT NOT NULL,
    [Amount]    INT NOT NULL,
    [OrderId]   INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([OrderId]) REFERENCES [dbo].[order] ([Id]),
    FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id])
);




