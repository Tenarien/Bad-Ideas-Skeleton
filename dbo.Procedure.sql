CREATE PROCEDURE sproc_tblUsers_FindUserNameFA
-- this stored procedure accepts two parameters @Username and @Password and no value

--declare the parameters
    @UserName VARCHAR(20),
	@PassWord VARCHAR(30)

AS -- select all fields when the user use name and password matches both values in the parameters
   SELECT * FROM tblUsers WHERE UserName = @UserName AND Password = @Password
RETURN 0

