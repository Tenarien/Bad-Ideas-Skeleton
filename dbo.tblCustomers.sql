CREATE TABLE [dbo].[tblCustomers] (
    [CustomerId]         INT          IDENTITY (1, 1) NOT NULL,
    [CustomerFirstname]  TEXT         NULL,
    [CustomerSurname]    TEXT         NULL,
    [CustomerNumber]     VARCHAR (11) NULL,
    [CustomerAddress]    TEXT         NULL,
    [AccountCreationDate]     DATE         NULL,
    [AcountVerification] BIT          NULL
);

