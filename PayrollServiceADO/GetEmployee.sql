USE [payroll_service]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeDetails]    Script Date: 11/4/2020 7:03:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[GetEmployeeDetails]
(	
	@name	varchar(150),		
	@Base_Pay float,		
	@start	date,		
	@gender	char(1),	
	@phone_number	int,		
	@address	varchar(150),
	@department	varchar(150),
	@Deductions	float,	
	@Taxable_pay float,		
	@Net_pay	float,		
	@Income_tax	float		
	)
	as begin
	select * from payroll_service
	end