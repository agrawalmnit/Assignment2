CREATE PROCEDURE [dbo].[Delete]
@rollNo int
AS 
BEGIN
DELETE
FROM [dbo].[Students]
where rollNo = @rollNo;
END