---
description: Migration
icon: table-cells
---

# Tạo bảng từ Migration.

{% hint style="info" %}
**Good to know:** Trong khi sử dụng FluentMigrator trong các ví dụ của mình, điều quan trọng là phải làm rõ rằng Serenity không phụ thuộc trực tiếp vào migrations. không bắt buộc phải sử dụng migrations. Serenity hoạt động mà không cần chúng. Nếu muốn, bạn có thể tạo thủ công các bảng trong SQL Management Studio hoặc làm việc với cơ sở dữ liệu hiện có.
{% endhint %}

### Mở Open Terminal trong dự án và nhập “dotnet sergen g”, sau đó chọn tên bảng từ CSDL muốn tạo và chọn All.

<figure><img src="https://lh7-rt.googleusercontent.com/docsz/AD_4nXecYykBEU7sPiYOWJg0ByhmuLmrxQgsuIngRXPG7VnLNS6Yqbw8JE66QFCxvH56k6TuT1Jm1tBWdCs9bOtJknvKTTPHaxBIUt1jyUv7m3qqgy1qRlJfypeMWSKgkkl4R4E0M8JquGhVlRXkMlvSUpjXjmJ9iT2hXKZ0lJ0D2A?key=YCZZc6cavvO63WAAdUXzEA" alt=""><figcaption></figcaption></figure>

<figure><img src="https://lh7-rt.googleusercontent.com/docsz/AD_4nXcA7K8uXWgZY47pE_xUhhYe5zXZjVGpxzQcnMXTaKelu4o0RjeYuYwI_8H1K9Z1HLnfyc3OXftSCSod9USSOM23z28uR_nfifixDQIj7oOupv-kWFus4lrtVxx0mFqyNAZ19rqShbbK0UyYZoAdvM2pBMX-AEJY_iY0UwNT_A?key=YCZZc6cavvO63WAAdUXzEA" alt=""><figcaption></figcaption></figure>

### Sau khi thành công thì hệ thống sẽ tạo cho bạn một folder, trong đó bao gồm các Service, Endpoints, Row, Column, Page, Grid…

<figure><img src="https://lh7-rt.googleusercontent.com/docsz/AD_4nXdJiIZHXLx6Rcc3TWkUf03P6L9Sga_Sp03zqzM1PaxHX9_h3CkwCE6bridwEoqdo0zJkk9AYqisBe5T5iiMrQCnuu4gu5d9yUM3JPMRCG4nnbTHEI_TflTnyutyIAIRESFs3hYnQC0ZRHDPIT5YhafCNFV0udLY3p8jtSX74g?key=YCZZc6cavvO63WAAdUXzEA" alt=""><figcaption></figcaption></figure>
