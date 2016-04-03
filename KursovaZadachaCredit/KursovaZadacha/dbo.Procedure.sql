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