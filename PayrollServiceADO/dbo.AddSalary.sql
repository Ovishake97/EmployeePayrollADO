
CREATE PROCEDURE dbo.AddSalary
(	-- Add the parameters for the stored procedure here
	@deptId int,
	@basic_pay int,
	@deductions int,
	@taxable_pay int,
	@income_tax int,
	@net_pay int
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
insert into salary values(@deptId,@basic_pay,@deductions,@taxable_pay,@income_tax,@net_pay)
END
GO
