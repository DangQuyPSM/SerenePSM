---
icon: plus-large
---

# Chức năng thêm

{% hint style="info" %}
Chức năng thêm dữ liệu vào database
{% endhint %}

### Phương thức này thường được sử dụng khi bạn muốn xử lý việc tạo mới một đối tượng trong ứng dụng, ví dụ như thêm mới một sản phẩm vào cơ sở dữ liệu, tạo một tài khoản người dùng mới, hoặc bất kỳ hành động nào yêu cầu thêm một bản ghi mới vào cơ sở dữ liệu.

```
[HttpPost, AuthorizeCreate(typeof(MyRow))]
public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
    [FromServices] IPfk7171SaveHandler handler)
{
    return handler.Create(uow, request);
}
```
