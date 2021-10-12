# Ứng dụng tạo và tìm kiếm danh sách nhu yếu phẩm
# Thông tin về ứng dụng
  - Giao diện: Windows form
  - Ngôn ngữ: C#
  - File lưu trữ: data_source.xml
# Mô hình tương tác:
  - Thêm: formMain (Menu) -> formDetail -> Save
  - Sửa: formMain (click dataGridView) -> formDetail -> Save
  - Xóa: formMain (click dataGridView) -> Menu (Xóa) -> xác nhận
  - Tìm kiếm: Tìm riêng lẻ hoặc kết hợp các giá trị sau
    + Tên sản phẩm (contain)
    + Nhà sản xuất (contain)
    + Giá (from -> to)
    + Loại (lựa chọn từ comboBox)
# Mô hình lưu trữ và tìm kiếm:
  - Lưu trữ: Node to XML
  - Tìm kiếm: linQ to XML -> table
