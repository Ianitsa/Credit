﻿CREATE VIEW [dbo].[V_Contract]
	AS SELECT c.CLIENT_ID, cr.CREDIT_PERIOD, c.CLIENT_FULLNAME,c.CLIENT_EGN_BULSTAT,p.PROD_NAME 

	 FROM CLIENT c inner join CREDIT cr on c.CLIENT_ID=cr.CLIENT_ID
	               inner join CREDIT_PRODUCT p on p.PROD_CODE=cr.PROD_CODE