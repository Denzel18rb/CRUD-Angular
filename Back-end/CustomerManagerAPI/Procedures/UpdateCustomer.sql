USE CustomerDB;
GO

CREATE PROCEDURE UpdateCustomer
    @Id INT,
    @Name NVARCHAR(100),
    @Email NVARCHAR(100),
    @Phone NVARCHAR(20)
AS
BEGIN
    UPDATE Customers SET Name = @Name, Email = @Email, Phone = @Phone WHERE Id = @Id;
END;
GO
