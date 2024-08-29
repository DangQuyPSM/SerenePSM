---
icon: pencil
description: Chức năng sửa
---

# Chức năng sửa

{% hint style="info" %}
Phương thức này thường được sử dụng khi bạn muốn xử lý việc cập nhật một đối tượng trong ứng dụng
{% endhint %}

### Phương thức này thường được sử dụng khi bạn muốn xử lý việc cập nhật một đối tượng trong ứng dụng, chẳng hạn như cập nhật thông tin của một sản phẩm, thay đổi chi tiết của một tài khoản người dùng, hoặc bất kỳ hành động nào yêu cầu cập nhật một bản ghi từ cơ sở dữ liệu.

```
[HttpPost, AuthorizeUpdate(typeof(MyRow))]
public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
    [FromServices] IPfk7171SaveHandler handler)
{
    return handler.Update(uow, request);
}
```
