
CREATE PROCEDURE dbo.AddEmployee 
(
@id int,
@name varchar(30),
@start_date date,
@gender char(1)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into employee_details values(@id,@name,@start_date,@name)
END
GO
