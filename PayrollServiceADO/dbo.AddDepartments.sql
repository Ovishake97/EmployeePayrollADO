
CREATE PROCEDURE dbo.AddDepartments 
	-- Add the parameters for the stored procedure here
	(
	@dept_id int,
	@deptname varchar(30),
	@id int,
	@address varchar(30)
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
insert into department values(@dept_id,@deptname,@id,@address)
END
GO
