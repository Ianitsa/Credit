USE [iani]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_shearchContract]
		@fullname_d = N'ani',
		@egn_bulstat_d = NULL,
		@contractNo_d = NULL,
		@Srok_d = NULL,
		@CreditType_d = NULL

SELECT	@return_value as 'Return Value'

GO
