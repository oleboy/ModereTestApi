CREATE PROCEDURE [dbo].[GetClassRegisterByClassId]
	@classId int
AS
	SELECT c.ClassId, c.ClassName, s.StudentId, s.FirstName, s.LastName
    FROM dbo.ClassRegister AS cr
        INNER JOIN dbo.Class AS c ON cr.ClassId = c.ClassId
        INNER JOIN dbo.Student AS s ON cr.StudentId = s.StudentId
    WHERE cr.ClassId = @classId