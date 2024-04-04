USE CustomerDB;
GO

CREATE PROCEDURE GetCustomerById
    @Id INT
AS
BEGIN
    SELECT * FROM Customers WHERE Id = @Id;
END;
GO
