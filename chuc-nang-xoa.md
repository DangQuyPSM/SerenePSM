---
description: Chức năng xóa
icon: trash-can-clock
---

# Chức năng xóa

{% hint style="info" %}
Xử lý việc xóa một đối tượng trong ứng dụng
{% endhint %}

Phương thức này thường được sử dụng khi bạn muốn xử lý việc xóa một đối tượng trong ứng dụng, ví dụ như xóa một sản phẩm khỏi cơ sở dữ liệu, xóa một tài khoản người dùng, hoặc bất kỳ hành động nào yêu cầu xóa một bản ghi từ cơ sở dữ liệu.

```
[HttpPost, AuthorizeDelete(typeof(MyRow))]
public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
    [FromServices] IPfk7171DeleteHandler handler)
{
    return handler.Delete(uow, request);
}
```
