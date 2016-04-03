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
	   set @SQL_STRING=@SQL_STRING +'AND PROD_CODE = '+cast(@Cod_p as varchar(10))+' '
      IF @status is not null
	   set @SQL_STRING=@SQL_STRING +'AND PROD_ACTIVE ='+@status+' '
	   IF @Name_p is not null
	   set @SQL_STRING=@SQL_STRING +'AND PROD_NAME like''%'+@Name_p+'%'' '
	   
	   IF @Sum_from is not null
	   set @SQL_STRING=@SQL_STRING +'AND PROD_SUM_FROM like''%'+cast(@Sum_from as numeric(10,2))+'%'' '
	   IF @Sum_to is not null
	   set @SQL_STRING=@SQL_STRING +'AND PROD_SUM_TO like''%'+cast(@Sum_to as numeric(10,2))+'%'' '



	exec (@SQL_STRING) 
END
