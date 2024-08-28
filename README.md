---
description: >-
  Serenity là nền tảng ứng dụng ASP.NET Core / TypeScript được xây dựng trên
  công nghệ mã nguồn mở.
cover: .gitbook/assets/PSMLogo1.jpg
coverY: 0
---

# ✍️ SERENITY

## 1. Khái niệm

* Có hai phiên bản dựa trên nền tảng Serenity đó là:

&#x20;      \+  Serene là mẫu ứng dụng khởi động mã nguồn mở miễn phí.

&#x20;      \+  StartSharp là mẫu ứng dụng cao cấp mà chúng tôi cung cấp cho khách hàng trả phí. Có thể xây dựng đa nền tảng trên các ứng dụng mobile.

## 2. Các thành phần chính trong Serenity.

* Lớp truy cập dữ liệu (DAL):
  * Xử lý các tương tác với cơ sở dữ liệu, truy xuất và cập nhật dữ liệu.
  * Sử dụng Dapper để truy cập dữ liệu hiệu quả, cải thiện hiệu suất và giảm độ phức tạp của mã.
  * Phân lập logic truy cập dữ liệu khỏi lớp nghiệp vụ, thúc đẩy khả năng tái sử dụng và bảo trì mã.
  * Lớp dịch vụ:
  * Gói gọn logic nghiệp vụ, xử lý các chức năng ứng dụng cốt lõi.
  * Hoạt động như một trung gian giữa giao diện người dùng và truy cập dữ liệu, cải thiện tính mô-đun của ứng dụng.
  * Cho phép phân tách rõ ràng các mối quan tâm, giúp mã được tổ chức tốt hơn và dễ kiểm tra hơn.
* Lớp giao diện người dùng:
  * Chịu trách nhiệm về giao diện người dùng và các tương tác.
  * Được xây dựng trên ASP.NET Core MVC và TypeScript, cung cấp nền tảng vững chắc.
  * Tận dụng Bootstrap và SlickGrid cho các thành phần giao diện người dùng phong phú, đẩy nhanh quá trình phát triển.
  * Tập trung vào trải nghiệm và tương tác của người dùng, trong khi lớp dịch vụ xử lý logic kinh doanh.

## 3. Cài đặt ứng dụng, môi trường phát triển.

### &#x20;      3.1. Cài đặt phiên bản Visual Studio 2022, SDK 8 và TypeScript 4.8.&#x20;

* &#x20; Cài đặt Visual Studio 2022, .SDK 8 và TypeScript 4.8.

&#x20;        [https://visualstudio.microsoft.com/downloads/](https://visualstudio.microsoft.com/downloads/)

* &#x20; Cài đặt Typescript 4.8, NodeJS / NPM.

&#x20;  \> npm -v                                        &#x20;

&#x20;  8.19.2

\
&#x20;   \> node -v

&#x20;   18.12.1

{% embed url="https://www.typescriptlang.org/download/" %}

### &#x20;      3.2. Cài đặt môi trường SDK 8.

* &#x20; Cài đặt phiên bản SDK 8 cho Visual studio.

&#x20;        [https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)

### &#x20;       3.3. Cài đặt các extension từ Visual Studio Marketplace.

* &#x20;  Mở URL bên dưới trong trình duyệt của bạn:

[https://marketplace.visualstudio.com/items?itemName=VolkanCeylan.SereneSerenityApplicationTemplate](https://marketplace.visualstudio.com/items?itemName=VolkanCeylan.SereneSerenityApplicationTemplate)

{% hint style="info" %}
**Lưu ý:** Yêu cầu cài đặt Serene để tích hợp với IDE.
{% endhint %}

<figure><img src="https://lh7-rt.googleusercontent.com/docsz/AD_4nXet63Xkpr2mCGjyKyIhDneh-y-SRHAz7A4SZB6G-4sBnLoGnFhQdQpIon7pEVkjMFzNTE9wJuFHO2fKRtzzXz4-sqeP_IC3Wz9Gft_lCpC6C0E4q-TuDDRXalRhM8j0UQ3B-e9LQg_qq8VQwescpsUh3Shxzct47JTgSNhj?key=YCZZc6cavvO63WAAdUXzEA" alt=""><figcaption></figcaption></figure>

* Cài đặt Template vào Visual Studio

<figure><img src="https://lh7-rt.googleusercontent.com/docsz/AD_4nXdVPQpVEk_exDOoDIJlMjaSqv6FZ9s3LjOaIGca-RNipYjJUG7uPhLxJR_X2zTyVmvoOYE4K07UdpDjncZ3DN2AtX07nsWk0nIH-nxkcXtCVRX5MhJ7pAbNE1LcJXG7fDZIPCeA6Hz0sQveEv0D8jLGIN7LjYrv7Lb9p8X7fw?key=YCZZc6cavvO63WAAdUXzEA" alt=""><figcaption></figcaption></figure>

## 4. Cách tạo dự án.

### &#x20;     4.1. Tổng quan về Serenity

Dưới đây là một số tổng quan về Serenity Platform:

> * Serenity Platform là một framework mã nguồn mở được thiết kế để giúp các nhà phát triển xây dựng các ứng dụng web doanh nghiệp một cách nhanh chóng và hiệu quả. Được xây dựng dựa trên ASP.NET Core, Serenity cung cấp một tập hợp các công cụ và thư viện mạnh mẽ, giúp giảm thiểu công sức cần thiết trong việc phát triển các ứng dụng phức tạp như hệ thống quản lý doanh nghiệp (ERP), quản lý quan hệ khách hàng (CRM), và nhiều loại ứng dụng quản lý khác.

>
>
> * Một trong những điểm mạnh của Serenity là khả năng tự động tạo giao diện từ các mô hình dữ liệu được định nghĩa. Các form, grid, và dialog được tự động tạo dựa trên cấu trúc của dữ liệu, giúp giảm bớt thời gian thiết kế UI.
> * Hệ thống quản lý doanh nghiệp (ERP).
> * Hệ thống quản lý quan hệ khách hàng (CRM).
> * Các ứng dụng quản lý dự án.
> * Các hệ thống quản lý nội dung (CMS).
> * Các ứng dụng quản lý tài sản.

### &#x20;     4.2. Tạo dự án ban đầu với Serene.

{% content-ref url="overview/tao-du-an-ban-dau-voi-serene..md" %}
[tao-du-an-ban-dau-voi-serene..md](overview/tao-du-an-ban-dau-voi-serene..md)
{% endcontent-ref %}

### &#x20;     4.3. Các component cơ bản.

{% content-ref url="overview/cac-component-co-ban..md" %}
[cac-component-co-ban..md](overview/cac-component-co-ban..md)
{% endcontent-ref %}

## 5. Cách kết nối CSDL và tạo bảng.

### &#x20;     5.1. Xử lý kết nối CSDL

{% content-ref url="product-guides/xu-ly-ket-noi-csdl.md" %}
[xu-ly-ket-noi-csdl.md](product-guides/xu-ly-ket-noi-csdl.md)
{% endcontent-ref %}

### &#x20;     5.2. Tạo bảng từ Migration.

{% content-ref url="use-cases/tao-bang-tu-migration..md" %}
[tao-bang-tu-migration..md](use-cases/tao-bang-tu-migration..md)
{% endcontent-ref %}

## 6. Custom giao diện.

### &#x20;     6.1. Thêm cột

{% content-ref url="fundamentals/them-cot/" %}
[them-cot](fundamentals/them-cot/)
{% endcontent-ref %}

### &#x20;     6.2. Nút, thuộc tính.

{% content-ref url="fundamentals/them-cot/nut-thuoc-tinh..md" %}
[nut-thuoc-tinh..md](fundamentals/them-cot/nut-thuoc-tinh..md)
{% endcontent-ref %}

### &#x20;     6.2. Thuộc tính CSS.

{% content-ref url="fundamentals/them-cot/thuoc-tinh-css..md" %}
[thuoc-tinh-css..md](fundamentals/them-cot/thuoc-tinh-css..md)
{% endcontent-ref %}

## 7. Xử lý các chức năng CRUD cho dự án.

### &#x20;    7.1. Chức năng hiển thị&#x20;

{% content-ref url="product-guides/chuc-nang-hien-thi..md" %}
[chuc-nang-hien-thi..md](product-guides/chuc-nang-hien-thi..md)
{% endcontent-ref %}

### &#x20;     7.2. Chức năng thêm

{% content-ref url="page-1.md" %}
[page-1.md](page-1.md)
{% endcontent-ref %}
