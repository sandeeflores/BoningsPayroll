SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Philhealth_Table]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Philhealth_Table](
	[bracket_no] [int] IDENTITY(1,1) NOT NULL,
	[salary_from] [decimal](18, 2) NULL,
	[salary_to] [decimal](18, 2) NULL,
	[salary_credit] [decimal](18, 2) NULL,
	[employer_share] [decimal](18, 2) NULL,
	[employee_share] [decimal](18, 2) NULL,
	[total] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[bracket_no] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CashAdvance]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CashAdvance](
	[ca_no] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [int] NULL,
	[ca_date] [smalldatetime] NULL,
	[amount] [decimal](18, 2) NULL,
	[deduc_sched] [smalldatetime] NULL,
	[created_by] [varchar](30) NULL,
	[date_created] [smalldatetime] NULL,
	[is_paid] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ca_no] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SSS_Table]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SSS_Table](
	[bracket_no] [int] IDENTITY(1,1) NOT NULL,
	[salary_from] [decimal](18, 2) NULL,
	[salary_to] [decimal](18, 2) NULL,
	[salary_credit] [decimal](18, 2) NULL,
	[employer_share] [decimal](18, 2) NULL,
	[employee_share] [decimal](18, 2) NULL,
	[total] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[bracket_no] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SetDepartment]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[SetDepartment]
	@dept_code varchar(10),
	@dept_name varchar(30)
AS
	
		INSERT INTO Department
		VALUES(@dept_code,@dept_name)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateDepartment]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[UpdateDepartment]
	@dept_code varchar(10),
	@dept_name varchar(30)
AS

	UPDATE Department
	SET dept_name = @dept_name
	WHERE dept_code = @dept_code
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DepartmentShowAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[DepartmentShowAll]
	
AS SELECT * 
	
	From Department
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectAllDepartment]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[SelectAllDepartment]


AS SELECT *

	FROM Department
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectedDepartment]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[SelectedDepartment]

	@dept_code int

AS SELECT * 
	
	From Department

Where @dept_code = dept_code
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SearchDepartment]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[SearchDepartment]
	
	@dept_name varchar(30)

AS SELECT *

	FROM Department

WHERE dept_name LIKE @dept_name + ''%''
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteDepartment]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[DeleteDepartment]

	@dept_code varchar(30)
AS
BEGIN
	DELETE Department
	WHERE dept_code = @dept_code
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Generate_Position_no]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[Generate_Position_no]


As Select isNull(count(position_no),0) + 1 As position_no
	
	From Position
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CheckPositionNo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[CheckPositionNo]
@position_no int

as


delete Position
where position_no = @position_no
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PositionShowAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[PositionShowAll]
	
AS SELECT * 
	
	From Position
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectAllPosition]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[SelectAllPosition]
AS

SELECT *
FROM Position
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectedPosition]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[SelectedPosition]
	@position_no INT
AS SELECT *
	FROM Position
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SetPosition]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[SetPosition]
	@position_name varchar (30),
	@dept_code varchar(10)
AS

	BEGIN
		INSERT INTO Position(position_name ,dept_code)
		VALUES(@position_name ,@dept_code)
		
		SELECT @@IDENTITY
	END
	
	' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Department]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Department](
	[dept_code] [int] IDENTITY(1,1) NOT NULL,
	[dept_name] [varchar](30) NULL,
 CONSTRAINT [PK__Department__7C8480AE] PRIMARY KEY CLUSTERED 
(
	[dept_code] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeletePosition]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[DeletePosition]
	@delPosition VARCHAR(4000)
AS

DECLARE @sql NVARCHAR(Max)

SET @sql = ''DELETE FROM Position WHERE '' + @delPosition
PRINT @sql
EXEC (@sql)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[agl_temp]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[agl_temp](
	[no] [nchar](10) NULL,
	[tmno] [nchar](10) NULL,
	[EnNo] [nchar](10) NULL,
	[Name] [nchar](100) NULL,
	[GMNo] [nchar](10) NULL,
	[Mode] [nchar](10) NULL,
	[inout] [nchar](10) NULL,
	[Antipass] [nchar](10) NULL,
	[DaiGong] [nchar](10) NULL,
	[DateTime] [nchar](22) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[agl]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[agl](
	[no] [nchar](10) NULL,
	[EnNo] [nchar](10) NULL,
	[DateTime] [nchar](22) NULL,
	[Status] [tinyint] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HDMF_Table]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HDMF_Table](
	[bracket_no] [int] IDENTITY(1,1) NOT NULL,
	[salary_from] [decimal](18, 2) NULL,
	[salary_to] [decimal](18, 2) NULL,
	[salary_credit] [decimal](18, 2) NULL,
	[employer_share] [decimal](18, 2) NULL,
	[employee_share] [decimal](18, 2) NULL,
	[total] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[bracket_no] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Payroll]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Payroll](
	[pay_id] [int] IDENTITY(1,1) NOT NULL,
	[payroll_from] [smalldatetime] NULL,
	[payroll_to] [smalldatetime] NULL,
	[payroll_date] [smalldatetime] NULL,
	[gross] [decimal](18, 2) NULL,
	[total_deduct] [decimal](18, 2) NULL,
	[net] [decimal](18, 2) NULL,
	[created_by] [varchar](30) NULL,
	[date_created] [smalldatetime] NULL,
	[modified_by] [varchar](30) NULL,
	[date_modified] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[pay_id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[performance_table]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[performance_table](
	[performance_id] [smallint] IDENTITY(1,1) NOT NULL,
	[date_eval] [datetime] NULL,
	[rate] [smallint] NOT NULL,
 CONSTRAINT [PK_performance_table] PRIMARY KEY CLUSTERED 
(
	[performance_id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Logs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Logs](
	[log_in] [smalldatetime] NULL,
	[log_out] [smalldatetime] NULL,
	[date] [smalldatetime] NULL,
	[employee_id] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Contribution]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Contribution](
	[cont_id] [int] NULL,
	[cont_type] [varchar](10) NULL,
	[cont_desc] [varchar](30) NULL,
	[date_applied] [smalldatetime] NULL,
	[cont_rate] [decimal](18, 2) NULL,
	[employee_id] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Payroll_Details]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Payroll_Details](
	[detail_no] [int] IDENTITY(1,1) NOT NULL,
	[pay_id] [int] NULL,
	[employee_id] [int] NULL,
	[total_hrs] [decimal](18, 2) NULL,
	[rate_hrs] [decimal](18, 2) NULL,
	[tardiness] [decimal](18, 2) NULL,
	[absent] [decimal](18, 2) NULL,
	[cash_advance] [decimal](18, 2) NULL,
	[sss] [decimal](18, 2) NULL,
	[philhealth] [decimal](18, 2) NULL,
	[pagibig] [decimal](18, 2) NULL,
	[tax] [decimal](18, 2) NULL,
	[cashbond] [decimal](18, 2) NULL,
	[other_deduc] [decimal](18, 2) NULL,
	[gross_detail] [decimal](18, 2) NULL,
	[total_deduction] [decimal](18, 2) NULL,
	[net_income] [decimal](18, 2) NULL,
	[note] [text] NULL,
	[created_by] [varchar](30) NULL,
	[date_created] [smalldatetime] NULL,
	[modified_by] [varchar](30) NULL,
	[date_modified] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[detail_no] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Position]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Position](
	[position_no] [int] IDENTITY(1,1) NOT NULL,
	[position_name] [varchar](30) NULL,
	[dept_code] [int] NOT NULL,
 CONSTRAINT [PK__Position__0DAF0CB0] PRIMARY KEY CLUSTERED 
(
	[position_no] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Employee](
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[lastname] [varchar](30) NULL,
	[firstname] [varchar](30) NULL,
	[middlename] [varchar](30) NULL,
	[referred_by] [varchar](30) NULL,
	[gender] [char](1) NULL,
	[address] [varchar](50) NULL,
	[contact_no] [int] NULL,
	[birthdate] [smalldatetime] NULL,
	[dateHired] [smalldatetime] NULL,
	[position_no] [int] NULL,
	[is_deleted] [bit] NULL,
	[dailyrate] [decimal](9, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SearchdEmployee]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[SearchdEmployee]
	
	@lastname varchar(30),
	@firstname varchar(30),
	@middlename varchar(30),
	@referred_by varchar(30),
	@gender char(1),
	@address varchar(30),
	@contact_no varchar(30),
	@birthdate smalldatetime,
	@dateHired smalldatetime,
	@is_deleted bit,
	@dailyrate decimal(9,2)	

AS SELECT *

	FROM Employee

WHERE lastname LIKE @lastname + ''%''
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SearchEmpDept]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[SearchEmpDept]
	@str VARCHAR(100)
	
AS 

SELECT e.employee_id AS EmpNo, e.lastname AS LastName, e.FirstName AS FirstName, CONVERT(CHAR(10), e.dateHired, 23) AS DateHired
FROM Employee e
WHERE (e.lastname LIKE ''%''+@str + ''%'' ) 
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ListPosition]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ListPosition]
AS
SELECT p.position_no AS ID, p.position_name AS Name, d.dept_name AS Department
FROM Position p, Department d
WHERE p.dept_code = d.dept_code

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdatePosition]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[UpdatePosition]

	@position_no int,
	@position_name varchar(100),
	@dept_code varchar(10)


AS UPDATE Position

SET
		position_name = @position_name,
		dept_code = @dept_code

WHERE position_no = @position_no

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SavePosition]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[SavePosition]
	@position_no int,
	@position_name varchar(100),
	@dept_code int
AS 
  SET NOCOUNT ON
  BEGIN TRAN
     	INSERT INTO Position (position_name, dept_code)
		 VALUES(@position_name,@dept_code)

 COMMIT TRANSACTION


' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MergeAGLs]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[MergeAGLs]
AS

--sql 2008
--MERGE agl AS TT USING agl_temp AS SS ON TT.EnNo = SS.EnNo AND TT.DateTime = SS.DateTime 
--WHEN NOT MATCHED BY TT THEN
--INSERT (no,TMNo,EnNo,Name,GMNo,Mode,inout,Antipass,Daigong,DateTime)
--VALUES (SS.No,SS.TMNo,SS.EnNo,SS.Name,SS.GMNo,SS.Mode,SS.inout,SS.Antipass,SS.Daigong,SS.DateTime);

INSERT INTO agl (No, EnNo,DateTime)
SELECT No, EnNo,DateTime
      FROM agl_temp 
WHERE No NOT IN (SELECT No FROM agl);



' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertToAGL]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[InsertToAGL]
--	@no varchar(10),
--	@tmno varchar(100),
--	@enno varchar(10),
--	@name varchar(10),
--	@gmno varchar(10),
--	@mode varchar(10),
--	@inout varchar(10),
--	@antipass varchar(10),
--	@daigong varchar(10),
--	@datetime varchar(22)

AS 

--INSERT INTO AGL(no,tmno,enno,name,gmno,mode,inout,antipass,daigong,datetime) 
  --  VALUES (@no,@tmno,@enno,@name,@gmno,@mode,@inout,@antipass,@daigong,@datetime) 
	
--SELECT @@IDENTITY
BEGIN TRANSACTION
BULK INSERT  dbo.agl_temp FROM ''c:\bonings\AGL_0001.txt'' WITH(FIRSTROW=2,FIELDTERMINATOR = ''\t'',ROWTERMINATOR = ''\n'')
COMMIT TRANSACTION

EXEC MergeAGLs



' 
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Logs__employee_i__1FCDBCEB]') AND parent_object_id = OBJECT_ID(N'[dbo].[Logs]'))
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([employee_id])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Contribut__emplo__1DE57479]') AND parent_object_id = OBJECT_ID(N'[dbo].[Contribution]'))
ALTER TABLE [dbo].[Contribution]  WITH CHECK ADD FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([employee_id])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Payroll_D__emplo__20C1E124]') AND parent_object_id = OBJECT_ID(N'[dbo].[Payroll_Details]'))
ALTER TABLE [dbo].[Payroll_Details]  WITH CHECK ADD FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([employee_id])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Payroll_D__pay_i__21B6055D]') AND parent_object_id = OBJECT_ID(N'[dbo].[Payroll_Details]'))
ALTER TABLE [dbo].[Payroll_Details]  WITH CHECK ADD FOREIGN KEY([pay_id])
REFERENCES [dbo].[Payroll] ([pay_id])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Position__dept_c__22AA2996]') AND parent_object_id = OBJECT_ID(N'[dbo].[Position]'))
ALTER TABLE [dbo].[Position]  WITH CHECK ADD  CONSTRAINT [FK__Position__dept_c__22AA2996] FOREIGN KEY([dept_code])
REFERENCES [dbo].[Department] ([dept_code])
GO
ALTER TABLE [dbo].[Position] CHECK CONSTRAINT [FK__Position__dept_c__22AA2996]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Employee__positi__1ED998B2]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK__Employee__positi__1ED998B2] FOREIGN KEY([position_no])
REFERENCES [dbo].[Position] ([position_no])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK__Employee__positi__1ED998B2]
