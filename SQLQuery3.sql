CREATE TABLE [dbo].[Rental] (
    [Id]                        INT           NOT NULL,
    [CarId]                     INT                 NULL,
    [CustomerId]                INT               NULL,
    [RentDate]                  time              NULL,
    [ReturnDate]                time            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);