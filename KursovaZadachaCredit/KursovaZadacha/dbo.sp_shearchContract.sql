alter PROCEDURE [dbo].[sp_shearchContract]
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