# QL_DiemSV_Winform
Chương trình quản lý điểm sv. Bài tập lớn môn lập trình trực quan
_________________________________________________________________________________________________________________________________________________________________________
*Muốn chạy phần mềm phải Restore lại database vào SQL trong máy:
Phục hồi lại database từ file dataQL_Diem_HVQLGD.bak, thì tạo new querry trong SQL và gõ lệnh sau vào querry vừa tạo:

  RESTORE DATABASE QL_Diem_HVQLGD FROM DISK = 'Đường dẫn vào file .bak'

VD:
  RESTORE DATABASE QL_Diem_HVQLGD FROM DISK = 'D:/BTL Lập trình trực quan/Database/dataQL_Diem_HVQLGD.bak'
Lệnh trên tạo database mới có tên QL_Diem_HVQLGD từ dataQL_Diem_HVQLGD.bak
_________________________________________________________________________________________________________________________________________________________________________
*Hoặc chuyển database sang máy khác bằng file .mdf và .ldf:
https://truonggiangit.com/huong-dan-chuyen-database-tu-may-nay-sang-may-khac-sql-server/
