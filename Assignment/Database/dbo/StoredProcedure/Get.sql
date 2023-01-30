CREATE PROCEDURE [dbo].[Get]
@rollNo INT
AS 
BEGIN
SELECT Name, familyName, contactNumber, Address
FROM [dbo].[Students]
where rollNo = @rollNo;
END