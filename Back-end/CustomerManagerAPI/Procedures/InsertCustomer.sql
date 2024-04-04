USE CustomerDB;
GO

CREATE PROCEDURE InsertCustomer
    @Name NVARCHAR(100),
    @Email NVARCHAR(100),
    @Phone NVARCHAR(20)
AS
BEGIN
    INSERT INTO Customers (Name, Email, Phone) VALUES (@Name, @Email, @Phone);
END;
GO
