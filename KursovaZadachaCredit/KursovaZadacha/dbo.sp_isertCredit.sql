CREATE PROCEDURE [dbo].[sp_isertCredit]
	@Credit_id int ,
	@Credit_NO nvarchar(50),
	@Cr_date datetime,
	@Cr_period int,
	@Cr_end_date datetime,
	@Cr_begin_date datetime,
	@Cr_client_id int,
	@prod_code int,
	@Cr_sum numeric(10,2),
	@Cr_note nvarchar(400),
	@Cr_modif datetime
AS
INSERT INTO CREDIT(CREDIT_ID,CREDIT_NO,CREDIT_DATE,CREDIT_PERIOD,CREDIT_END_DATE,CREDIT_BEGIN_DATE,CREDIT_SUM,CLIENT_ID,PROD_CODE,CREDIT_NOTE,MODIF_DATE)
values(@Credit_id,@Credit_NO,@Cr_date,@Cr_period,@Cr_end_date,@Cr_begin_date,@Cr_client_id,@prod_code,@Cr_sum,@Cr_note,@Cr_modif)	
RETURN