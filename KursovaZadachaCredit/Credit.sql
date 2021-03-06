USE [master]
GO
/****** Object:  Database [iani]    Script Date: 03-Apr-16 5:20:09 PM ******/
CREATE DATABASE [iani]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'iani', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\iani.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'iani_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\iani_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [iani] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [iani].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [iani] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [iani] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [iani] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [iani] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [iani] SET ARITHABORT OFF 
GO
ALTER DATABASE [iani] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [iani] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [iani] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [iani] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [iani] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [iani] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [iani] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [iani] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [iani] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [iani] SET  DISABLE_BROKER 
GO
ALTER DATABASE [iani] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [iani] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [iani] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [iani] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [iani] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [iani] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [iani] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [iani] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [iani] SET  MULTI_USER 
GO
ALTER DATABASE [iani] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [iani] SET DB_CHAINING OFF 
GO
ALTER DATABASE [iani] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [iani] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [iani] SET DELAYED_DURABILITY = DISABLED 
GO
USE [iani]
GO
/****** Object:  Table [dbo].[CLIENT]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLIENT](
	[CLIENT_ID] [int] IDENTITY(1,1) NOT NULL,
	[CLIENT_TYPE] [char](1) NOT NULL,
	[CLIENT_EGN_BULSTAT] [nvarchar](13) NOT NULL,
	[CLIENT_FULLNAME] [nvarchar](400) NOT NULL,
	[EMAIL] [nvarchar](400) NULL,
	[TELEPHONE] [nvarchar](400) NULL,
	[ADRESS_TEXT] [nvarchar](400) NOT NULL,
	[CLIENT_NOTE] [nvarchar](400) NULL,
	[MODIF_DATE] [datetime] NULL,
 CONSTRAINT [PK_CLIENT] PRIMARY KEY CLUSTERED 
(
	[CLIENT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CREDIT]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CREDIT](
	[CREDIT_ID] [int] IDENTITY(1,1) NOT NULL,
	[CREDIT_NO] [nvarchar](50) NOT NULL,
	[CREDIT_DATE] [datetime] NULL,
	[CREDIT_PERIOD] [int] NOT NULL,
	[CREDIT_END_DATE] [datetime] NULL,
	[CREDIT_BEGIN_DATE] [datetime] NULL,
	[CLIENT_ID] [int] NOT NULL,
	[PROD_CODE] [int] NULL,
	[CREDIT_SUM] [numeric](10, 2) NOT NULL,
	[CREDIT_NOTE] [nvarchar](400) NULL,
	[MODIF_DATE] [datetime] NULL,
 CONSTRAINT [PK_CREDIT] PRIMARY KEY CLUSTERED 
(
	[CREDIT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CREDIT_PLAN]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CREDIT_PLAN](
	[MATURITY_ID] [int] IDENTITY(1,1) NOT NULL,
	[CREDIT_ID] [int] NULL,
	[MATURITY_DATE] [datetime] NOT NULL,
	[MATURITY_SUM] [numeric](15, 2) NOT NULL,
	[MATURITY_NOTE] [nvarchar](400) NULL,
	[MODIF_DATE] [datetime] NULL,
 CONSTRAINT [PK_CREDIT_PLAN] PRIMARY KEY CLUSTERED 
(
	[MATURITY_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CREDIT_PRODUCT]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CREDIT_PRODUCT](
	[PROD_CODE] [int] IDENTITY(1,1) NOT NULL,
	[PROD_NAME] [nvarchar](100) NOT NULL,
	[PROD_ACTIVE] [char](1) NOT NULL CONSTRAINT [DF__CREDIT_PR__PROD___164452B1]  DEFAULT ('N'),
	[PROD_SUM_FROM] [numeric](10, 2) NOT NULL,
	[PROD_SUM_TO] [numeric](10, 2) NOT NULL,
	[MODIF_DATE] [datetime] NULL,
	[INTEREST] [numeric](10, 5) NOT NULL,
 CONSTRAINT [PK_CREDIT_PRODUCT] PRIMARY KEY CLUSTERED 
(
	[PROD_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INTEREST]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INTEREST](
	[PROD_CODE] [int] NOT NULL,
	[PROD_PERIOD] [int] NOT NULL,
	[SUM_FROM] [numeric](10, 2) NOT NULL,
	[SUM_TO] [numeric](10, 2) NOT NULL,
 CONSTRAINT [PK_INTEREST] PRIMARY KEY CLUSTERED 
(
	[PROD_CODE] ASC,
	[PROD_PERIOD] ASC,
	[SUM_FROM] ASC,
	[SUM_TO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[User_id] [int] NOT NULL,
	[User_pass] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[User_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PROD_PERIODS]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROD_PERIODS](
	[PROD_CODE] [int] NOT NULL,
	[PROD_PERIOD] [int] NOT NULL,
 CONSTRAINT [PK_PROD_PERIODS] PRIMARY KEY CLUSTERED 
(
	[PROD_CODE] ASC,
	[PROD_PERIOD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[V_Contract1]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create VIEW [dbo].[V_Contract1]
	AS SELECT c.CLIENT_ID,cr.CREDIT_NO, cr.CREDIT_PERIOD, c.CLIENT_FULLNAME,c.CLIENT_EGN_BULSTAT,p.PROD_NAME 

	 FROM CLIENT c inner join CREDIT cr on c.CLIENT_ID=cr.CLIENT_ID
	               inner join CREDIT_PRODUCT p on p.PROD_CODE=cr.PROD_CODE

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IDX_CLIENT_EGN_BULSTAT_UQ]    Script Date: 03-Apr-16 5:20:09 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IDX_CLIENT_EGN_BULSTAT_UQ] ON [dbo].[CLIENT]
(
	[CLIENT_TYPE] ASC,
	[CLIENT_EGN_BULSTAT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IDX_CREDIT_NO_UQ]    Script Date: 03-Apr-16 5:20:09 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IDX_CREDIT_NO_UQ] ON [dbo].[CREDIT]
(
	[CREDIT_NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IDX_MATURITY_UQ]    Script Date: 03-Apr-16 5:20:09 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IDX_MATURITY_UQ] ON [dbo].[CREDIT_PLAN]
(
	[MATURITY_DATE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IDX_PROD_NAME_UQ]    Script Date: 03-Apr-16 5:20:09 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IDX_PROD_NAME_UQ] ON [dbo].[CREDIT_PRODUCT]
(
	[PROD_NAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CREDIT]  WITH CHECK ADD  CONSTRAINT [FK_CREDIT_REFERENCE_CLIENT] FOREIGN KEY([CLIENT_ID])
REFERENCES [dbo].[CLIENT] ([CLIENT_ID])
GO
ALTER TABLE [dbo].[CREDIT] CHECK CONSTRAINT [FK_CREDIT_REFERENCE_CLIENT]
GO
ALTER TABLE [dbo].[CREDIT]  WITH CHECK ADD  CONSTRAINT [FK_CREDIT_REFERENCE_CREDIT_P] FOREIGN KEY([PROD_CODE])
REFERENCES [dbo].[CREDIT_PRODUCT] ([PROD_CODE])
GO
ALTER TABLE [dbo].[CREDIT] CHECK CONSTRAINT [FK_CREDIT_REFERENCE_CREDIT_P]
GO
ALTER TABLE [dbo].[CREDIT_PLAN]  WITH CHECK ADD  CONSTRAINT [FK_CREDIT_P_REFERENCE_CREDIT] FOREIGN KEY([CREDIT_ID])
REFERENCES [dbo].[CREDIT] ([CREDIT_ID])
GO
ALTER TABLE [dbo].[CREDIT_PLAN] CHECK CONSTRAINT [FK_CREDIT_P_REFERENCE_CREDIT]
GO
ALTER TABLE [dbo].[INTEREST]  WITH CHECK ADD  CONSTRAINT [FK_INTEREST_REFERENCE_PROD_PER] FOREIGN KEY([PROD_CODE], [PROD_PERIOD])
REFERENCES [dbo].[PROD_PERIODS] ([PROD_CODE], [PROD_PERIOD])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[INTEREST] CHECK CONSTRAINT [FK_INTEREST_REFERENCE_PROD_PER]
GO
ALTER TABLE [dbo].[PROD_PERIODS]  WITH CHECK ADD  CONSTRAINT [FK_PROD_PER_REFERENCE_CREDIT_P] FOREIGN KEY([PROD_CODE])
REFERENCES [dbo].[CREDIT_PRODUCT] ([PROD_CODE])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PROD_PERIODS] CHECK CONSTRAINT [FK_PROD_PER_REFERENCE_CREDIT_P]
GO
ALTER TABLE [dbo].[CREDIT_PRODUCT]  WITH CHECK ADD  CONSTRAINT [CKC_PROD_ACTIVE_CREDIT_P] CHECK  (([PROD_ACTIVE]='N' OR [PROD_ACTIVE]='Y'))
GO
ALTER TABLE [dbo].[CREDIT_PRODUCT] CHECK CONSTRAINT [CKC_PROD_ACTIVE_CREDIT_P]
GO
ALTER TABLE [dbo].[CREDIT_PRODUCT]  WITH CHECK ADD  CONSTRAINT [CKC_PROD_SUM_FROM_CREDIT_P] CHECK  (([PROD_SUM_FROM]>=(0)))
GO
ALTER TABLE [dbo].[CREDIT_PRODUCT] CHECK CONSTRAINT [CKC_PROD_SUM_FROM_CREDIT_P]
GO
/****** Object:  StoredProcedure [dbo].[sp_insertCrProduct]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertCrProduct]

@P_name nvarchar(100)=null,
@P_active char (1)=null,
@P_sumFrom numeric(10,2)=null,
@P_sumTo numeric(10,2)=null,
@interest numeric(10,5)=null

as begin
 declare @msg nvarchar (40)
 --select @C_id=max(c_id) from Customers
 select @interest=max(INTEREST) from CREDIT_PRODUCT
   begin try
     insert into CREDIT_PRODUCT(PROD_NAME,PROD_ACTIVE, PROD_SUM_FROM, PROD_SUM_TO, INTEREST)
	 values(@P_name ,@P_active ,@P_sumFrom ,@P_sumTo ,@interest )

	 end try
   begin catch
   set @msg=N'Producta ne moje da bade dobaven!'
   raiserror(@msg, 16,1)
   return
   end catch
end

GO
/****** Object:  StoredProcedure [dbo].[sp_insertInterest]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertInterest]
@P_cod int=null,
@P_period int=null

as begin
 declare @msg nvarchar (40)
 ----select @C_id=max(c_id) from Customers
 select @P_cod=max(PROD_CODE) from CREDIT_PRODUCT
 --select @P_period=max(PROD_PERIOD) from PROD_PERIODS
   begin try
     insert into PROD_PERIODS (PROD_CODE,PROD_PERIOD)
	 values(@P_cod , @P_period)
	 end try
   begin catch
   set @msg=N'Lihvata ne moje da bade dobavena!'
   raiserror(@msg, 16,1)
   return
   end catch
end

GO
/****** Object:  StoredProcedure [dbo].[sp_isertCredit]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_isertCredit]
	
	@Credit_NO nvarchar(50),
	@Cr_date datetime,
	@Cr_period int,
	@Cr_end_date datetime,
	@Cr_begin_date datetime,
	@Cr_client_id int,
	@prod_code int,
	@Cr_sum numeric(10,2),
	@Cr_note nvarchar(400)
	
AS
INSERT INTO CREDIT(CREDIT_NO,CREDIT_DATE,
CREDIT_PERIOD,CREDIT_END_DATE,
CREDIT_BEGIN_DATE,
CREDIT_SUM,CLIENT_ID,PROD_CODE,CREDIT_NOTE)
values(@Credit_NO,@Cr_date,
@Cr_period,@Cr_end_date,
@Cr_begin_date,@Cr_sum,
@Cr_client_id,@prod_code,@Cr_note)	
RETURN
GO
/****** Object:  StoredProcedure [dbo].[sp_isertCustomer1]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_isertCustomer1]
	
	@Customer_type char(1),
	@Customer_EGN_BULSTAT nvarchar(13),
	@Customer_fullname nvarchar(400),
	@Customer_EMAIL nvarchar(400),
	@Customer_Phone nvarchar(400),
	@Customer_address nvarchar(400)
	
	
AS
	insert into CLIENT(CLIENT_TYPE,CLIENT_EGN_BULSTAT,CLIENT_FULLNAME,EMAIL,TELEPHONE,ADRESS_TEXT)
	values(@Customer_type,@Customer_EGN_BULSTAT,@Customer_fullname,@Customer_EMAIL,@Customer_Phone,@Customer_address);
RETURN
GO
/****** Object:  StoredProcedure [dbo].[sp_searchCreditenP]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_searchCreditenP]
	
	@Cod_p int=null,
	@Name_p nvarchar(100)=null,
	@Sum_from numeric(10,2)=null,
	@Sum_to numeric(10,2)=null,
	@status char(1)=null

AS
 BEGIN
	DECLARE @SQL_STRING varchar(max)
	SET @SQL_STRING=
	  'SELECT * from CREDIT_PRODUCT
	  where 1=1 '

	  IF @Cod_p is not null
	   set @SQL_STRING=@SQL_STRING +'AND PROD_CODE like ''%'+cast(@Cod_p as varchar(10))+'%'' '
      IF @status is not null
	   set @SQL_STRING=@SQL_STRING +'AND PROD_ACTIVE ='''+cast(@status  as nvarchar(1))+''' '
	   IF @Name_p is not null
	   set @SQL_STRING=@SQL_STRING +'AND PROD_NAME like ''%'+@Name_p+'%'' '
	   
	   IF @Sum_from is not null
	   set @SQL_STRING=@SQL_STRING +'AND PROD_SUM_FROM >= '+cast(@Sum_from as nvarchar(10))
	   IF @Sum_to is not null
	   set @SQL_STRING=@SQL_STRING +'AND PROD_SUM_TO <= '+cast(@Sum_to as nvarchar(10))
	   print @SQL_STRING
	exec (@SQL_STRING) 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchCustomer]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SearchCustomer]
	@client_id int = null,
	@Client_type char(1)=null,
	@Customer_EGN_BULSTAT nvarchar(13)=NULL,
	@Customer_fullname nvarchar(400)=NULL,
	@Customer_EMAIL nvarchar(400)=NULL,
	@Customer_Phone nvarchar(400)=NULL,
	@Customer_address nvarchar(400)=NULL,
	@Customer_clientNote nvarchar(400)=NULL
AS
 BEGIN
	DECLARE @SQL_STRING varchar(max)
	SET @SQL_STRING=
	  'SELECT * from CLIENT
	  where 1=1 '
	  IF @client_id is not null
	   set @SQL_STRING=@SQL_STRING +'AND CLIENT_ID = '+cast(@client_id as varchar(10))+' '
      IF @Client_type is not null
	   set @SQL_STRING=@SQL_STRING +'AND CLIENT_TYPE ='+@Client_type+' '
      IF @Customer_EGN_BULSTAT is not null
	   set @SQL_STRING=@SQL_STRING +'AND CLIENT_EGN_BULSTAT like''%'+@Customer_EGN_BULSTAT+'%'' '
	 IF @Customer_fullname is not null
	   set @SQL_STRING=@SQL_STRING +'AND CLIENT_FULLNAME like''%'+@Customer_fullname+'%'' '
	 IF @Customer_EMAIL is not null
	   set @SQL_STRING=@SQL_STRING +'AND EMAIL like''%'+@Customer_EMAIL+'%'' '
     IF @Customer_Phone is not null
	   set @SQL_STRING=@SQL_STRING +'AND TELEPHONE like''%'+@Customer_Phone+'%'' '
	 IF @Customer_address is not null
	   set @SQL_STRING=@SQL_STRING +'AND ADRESS_TEXT like''%'+@Customer_address+'%'' '
	 IF @Customer_clientNote is not null
	   set @SQL_STRING=@SQL_STRING +'AND CLIENT_NOTE like''%'+@Customer_clientNote+'%'' '

	   exec (@SQL_STRING) 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_shearchContract]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_shearchContract]
@fullname_d nvarchar(400)=null,
@egn_bulstat_d nvarchar(13)=null,
@contractNo_d nvarchar(50)=null,
@Srok_d int=null,
@CreditType_d nvarchar(100)=null
	
AS
BEGIN
	DECLARE @SQL_STRING varchar(max)
	SET @SQL_STRING=
	  'SELECT * from V_Contract1
	  where 1=1 '
	  if @fullname_d is not null
	   set @SQL_STRING=@SQL_STRING +'AND CLIENT_FULLNAME like ''%'+@fullname_d+'%'' '
      if @egn_bulstat_d is not null
	  set @SQL_STRING=@SQL_STRING +'AND CLIENT_EGN_BULSTAT like''%'+@egn_bulstat_d+'%'' '
	  if @contractNo_d is not null
	  set @SQL_STRING=@SQL_STRING +'AND CREDIT_NO like''%'+@contractNo_d+'%'' '
	  if @Srok_d is not null
	  set  @SQL_STRING=@SQL_STRING +'AND CREDIT_PERIOD = '+cast(@Srok_d as varchar(10))+' '
	  if @CreditType_d is not null
	  set @SQL_STRING=@SQL_STRING +'AND PROD_NAME like''%'+@CreditType_d+'%'' '
	  print @SQL_STRING
exec(@SQL_STRING)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateClient]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateClient]
	@Customer_id int,
	@Customer_type char(1),
	@Customer_EGN_BULSTAT nvarchar(13),
	@Customer_fullname nvarchar(400),
	@Customer_EMAIL nvarchar(400),
	@Customer_Phone nvarchar(400),
	@Customer_address nvarchar(400)
	
AS
	BEGIN
	UPDATE CLIENT
	 set
	 CLIENT_TYPE=@Customer_type,CLIENT_EGN_BULSTAT=@Customer_EGN_BULSTAT,CLIENT_FULLNAME=@Customer_fullname,EMAIL=@Customer_EMAIL,TELEPHONE=@Customer_Phone ,ADRESS_TEXT=@Customer_address
	 where CLIENT_ID=@Customer_id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_updateCrProduct]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateCrProduct]
@P_cod int,
@P_name nvarchar(100),
@P_active char (1),
@P_sumFrom numeric(10,2),
@P_sumTo numeric(10,2),
@interest numeric(10,5)

AS
  BEGIN
  UPDATE CREDIT_PRODUCT
  SET
  PROD_NAME=@P_name, PROD_ACTIVE=@P_active,PROD_SUM_FROM=@P_sumFrom,PROD_SUM_TO=@P_sumTo,INTEREST=@interest
  WHERE PROD_CODE=@P_cod
  END

GO
/****** Object:  StoredProcedure [dbo].[sp_updateInterest]    Script Date: 03-Apr-16 5:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateInterest]
@P_cod int,
@P_period int

as
 begin
 update PROD_PERIODS
   set 
   PROD_CODE=@P_cod,PROD_PERIOD=@P_period
   where PROD_CODE=@P_cod
end

GO
USE [master]
GO
ALTER DATABASE [iani] SET  READ_WRITE 
GO
