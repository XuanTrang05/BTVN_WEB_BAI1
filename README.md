# BTVN_WEB_BAI1
# BÀI TẬP VỀ NHÀ 01:
# TẠO SOLUTION GỒM CÁC PROJECT SAU:
1. DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
2. Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
3. Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
4. Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.
##                                      BÀI LÀM
1. DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis)

* Cấu hình project (Configure your new project)

  <img width="1917" height="1068" alt="image" src="https://github.com/user-attachments/assets/6bab0350-1a99-46e0-94b6-b45f9ae40f8a" />

* viết code trong project (triển khai logic của DLL).
  <img width="1340" height="1079" alt="image" src="https://github.com/user-attachments/assets/8faeea34-b6ec-4c9f-9a5e-773eef6d9846" />

  <img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/29f141f6-6433-4813-a232-70d782ab80f3" />

  <img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/0741eb62-b2ea-41ac-ae6b-5a21521f5dff" />

  <img width="1215" height="1017" alt="image" src="https://github.com/user-attachments/assets/5d67b3e1-24ca-4c8d-8009-6904d5103d11" />
2. Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
* Cấu hình project (Configure Project).

<img width="1919" height="1078" alt="image" src="https://github.com/user-attachments/assets/b340a9ff-fcd3-4e9d-a723-d2f283d6e340" />

* viết code (Code Implementation)-cài đặt logic ứng dụng.
  
* <img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/158b4bf1-f8fd-4197-92b7-5e1fa72005d2" />

3. Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
* Cấu hình project (Configure New Project).

<img width="842" height="697" alt="image" src="https://github.com/user-attachments/assets/967b0e9c-0726-4bd4-98b4-3a6c2e80bae3" />

*Sau khi nhấn Create và Visual Studio sinh ra project: Form1.cs, From1.designer.cs,  From1.designer
* From1.cs
  
<img width="934" height="999" alt="image" src="https://github.com/user-attachments/assets/ddd9bb36-c094-4792-8df2-1ea8f9a719f9" />

*  From1.designer.cs
  
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/26276f7b-e980-466d-bce6-014556c6182f" />

* From1.cs[design]

<img width="692" height="470" alt="image" src="https://github.com/user-attachments/assets/1bbf43ba-d42d-45a3-b88a-cb9219581b60" />

4. Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

* tạo project (Create New Project / Project Setup).
<img width="806" height="658" alt="image" src="https://github.com/user-attachments/assets/c8c707a9-6067-43e6-ac9b-f1464e48b09c" />

* Cấu hình IIS
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/799f487e-ad2c-4ce6-b6d1-ed8826ac063d" />

* phát triển và lập trình.

* Giao diện (UI).
<img width="1919" height="1077" alt="image" src="https://github.com/user-attachments/assets/38636542-b012-404f-ae0b-036feac9dddf" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/f7c3be18-25b4-436c-a394-7533f5e9d167" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/f5bb3200-fd58-4b68-bb89-e3613c8ad1fd" />

*














