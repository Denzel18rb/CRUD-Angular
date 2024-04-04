USE CustomerDB;
GO

CREATE PROCEDURE DeleteCustomer
    @Id INT
AS
BEGIN
    DELETE FROM Customers WHERE Id = @Id;
END;
GO
