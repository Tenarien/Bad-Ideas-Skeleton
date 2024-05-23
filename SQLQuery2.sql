USE [p2755807]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblUsers_FindUserNameFA]
		@UserName = N'Butterfly',
		@PassWord = N'FlyawayFA'

SELECT	@return_value as 'Return Value'

GO
