USE [p2755807]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblOrderFilterByAddressId]
		@OrderId = 1

SELECT	@return_value as 'Return Value'

GO
