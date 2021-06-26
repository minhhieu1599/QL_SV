
CREATE PROCEDURE del_thongtincanhan
@ID int,
@SoTB int,
@Hoten nvarchar(30),
@Tinh nvarchar(50),
@Huyen nvarchar(50),
@Xa nvarchar(50),
@Gioitinh bit
AS
BEGIN
		delete
		from thongtincanhan
		where SoTB = @SoTB
END
GO
