create table thongtinnhanvien (
manhanvien int,
tennhanvien nvarchar(30),
diachi nvarchar(30),
sdt int,
gioitinh bit,
email nvarchar(20),
constraint pk_thongtinnhanvien primary key(sdt))

create table khachhang (
tenkhachhang nvarchar(30),
tencongty nvarchar(30),
tenlienlac nvarchar(30),
thongtinlienlac nvarchar(30),
diachinha nvarchar(60),
thanhpho nvarchar(20),
quocgia nvarchar(15),
sdt int,
constraint pk_khachhang primary key(tenkhachhang))