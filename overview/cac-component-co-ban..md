---
description: Các component cơ bản trong Serenity Platform
---

# ✨ Các component cơ bản.

{% hint style="info" %}
**Component (thành phần)** trong ngữ cảnh phát triển phần mềm, đặc biệt là trong các nền tảng phát triển như Serenity Application Platform, là một phần tử tự chứa của một hệ thống phần mềm lớn hơn. Nó thực hiện một chức năng cụ thể và có thể được sử dụng lại trong nhiều phần khác nhau của ứng dụng. Các thành phần này có thể là các khối xây dựng của một ứng dụng, giúp phát triển và bảo trì hệ thống dễ dàng hơn.
{% endhint %}

### Serenity.Core: Component logic.

* Dependency Injection (DI): Cơ chế quản lý các đối tượng và phụ thuộc giữa chúng, giúp code dễ đọc, dễ bảo trì và dễ test.
* Logging: Cung cấp các công cụ để ghi lại các sự kiện xảy ra trong ứng dụng, giúp tìm và sửa lỗi.
* Configuration: Quản lý các cấu hình của ứng dụng, cho phép thay đổi cấu hình mà không cần chỉnh sửa code.
* CoreServiceCollectionExtensions class:static AddAnnotationTypes, static AddCaching, static AddServiceResolver, static AddTextRegistry, static AddTypeSource.

public static class CoreServiceCollectionExtensions

public class MyEventHandler : INotificationHandler\<SaveSuccessEvent>

{

&#x20;   public Task Handle(SaveSuccessEvent notification)

&#x20;   {

&#x20;       // Xử lý sự kiện khi một bản ghi được lưu thành công

&#x20;       Logger.Info("Record saved successfully: " + notification.EntityId);

&#x20;       return Task.CompletedTask;

&#x20;   }

}

### Serenity.Web: Component logic.

* Chức năng: Cung cấp các tính năng liên quan đến phát triển ứng dụng web, bao gồm định tuyến (Routing), xử lý yêu cầu trung gian (Middleware) và các thành phần giao diện có thể tái sử dụng (View Components).
* Vai trò: Là cầu nối giữa ứng dụng và trình duyệt, xử lý các yêu cầu HTTP và tạo ra các phản hồi.
* DynamicScriptServiceCollectionExtensions class: static AddContentHashCache, static AddDynamicScriptManager.

public static class DynamicScriptServiceCollectionExtensions

\[PageAuthorize(typeof(RoleRow))]

public class RolePage : Controller

{

&#x20;   \[Route("Administration/Role")]

&#x20;   public ActionResult Index()

&#x20;   {

&#x20;       return this.GridPage("@/Administration/Role/RolePage",

&#x20;           RoleRow.Fields.PageTitle());

&#x20;   }

}

### Serenity.Data: Component logic

* Chức năng: Cung cấp các công cụ để truy cập và thao tác với dữ liệu, bao gồm tích hợp với Entity Framework Core và các mẫu truy cập dữ liệu.
* Vai trò: Là lớp trung gian giữa ứng dụng và cơ sở dữ liệu.
* DataServiceCollectionExtensions class:static AddSqlConnections  (Thêm giao diện IConnectionStrings và ISqlConnections mặc định) (2 phương pháp).

public static class DataServiceCollectionExtensions

public class OrderRepository : BaseRepository

{

&#x20;   public OrderRepository(IRequestContext context) : base(context) { }

\


&#x20;   public ListResponse\<MyRow> List(IDbConnection connection, ListRequest request)

&#x20;   {

&#x20;       return new MyListHandler().Process(connection, request);

&#x20;   }

}

### Serenity.Services: Component logic

* Chức năng: Cung cấp các cơ chế để tạo và quản lý các dịch vụ, bao gồm đăng ký dịch vụ, tiêm phụ thuộc và gọi dịch vụ.
* Đăng ký tất cả trình xử lý yêu cầu tùy chỉnh triển khai giao diện IRequestHandler, từ nguồn loại trong bộ sưu tập dịch vụ nếu có hoặc sử dụng typeSource được cung cấp, tùy chọn lọc các loại trình xử lý thông qua một thuật ngữ được cung cấp.
* ServiceCollectionExtensions class: static AddBaseTexts, static AddCustomRequestHandlers, static AddServiceHandlers.

public static class ServiceCollectionExtensions

public interface IPfk7171ListHandler : IListHandler\<MyRow, MyRequest, MyResponse> { }

public class Pfk7171ListHandler : ListRequestHandler\<MyRow, MyRequest, MyResponse>, IPfk7171ListHandler

{

&#x20;   public Pfk7171ListHandler(IRequestContext context)

&#x20;           : base(context)

&#x20;   {

&#x20;   }

}

### Serenity.Entity: Component logic

* Chức năng: Đối tượng này thường được sử dụng để đại diện cho các thực thể trong cơ sở dữ liệu, và thường được kết hợp với Serenity.Data để thực hiện các thao tác CRUD (Create, Read, Update, Delete).
* Vai trò: Là mô hình dữ liệu của ứng dụng.
* Thêm các loại chú thích, kết nối sql, sổ đăng ký loại hàng mặc định và nhà cung cấp trường hàng. Cảnh báo: Phương pháp này đặt nhà cung cấp trường hàng đơn lẻ làm mặc định bằng cách gọi RowFieldsProvider.SetDefault khi tạo.
* EntityServiceCollectionExtensions class: static AddEntities.

public static class EntityServiceCollectionExtensions

public static void AddEntities(this IServiceCollection services)

&#x20;   {

&#x20;       services.AddSqlConnections();

&#x20;       services.AddAnnotationTypes();

&#x20;       services.TryAddSingleton\<IRowTypeRegistry, DefaultRowTypeRegistry>();

&#x20;       services.TryAddSingleton\<IRowFieldsProvider, DefaultRowFieldsProvider>();

&#x20;   }

### Serenity.UI: Component UI

* Chức năng: Cung cấp các thành phần giao diện người dùng, bao gồm các form, bảng, biểu đồ và thông báo.
* Vai trò: Tạo ra giao diện người dùng trực quan cho ứng dụng.
* Các loại component chính trong Serenity.UI:
* Form:

Form Editor: Cho phép tạo các form để thu thập dữ liệu người dùng, với các field như text box, dropdown, datepicker, checkbox, v.v.

Lookup Editor: Cho phép tìm kiếm và chọn giá trị từ một danh sách các record.

Grid Editor: Cho phép chỉnh sửa dữ liệu trực tiếp trong một grid.

* Grid:

DataGrid: Hiển thị dữ liệu dưới dạng bảng, có thể tùy chỉnh được các cột, sắp xếp, lọc, phân trang.

FlexGrid: Một grid linh hoạt hơn, hỗ trợ nhiều tính năng nâng cao như grouping, pivot, editing.

* Dialog:

Dialog: Cho phép tạo các hộp thoại để hiển thị thông tin, xác nhận hành động, hoặc nhập liệu.

* Panel:

Panel: Một container để nhóm các component khác lại với nhau.

* Toolbar:

Toolbar: Cung cấp các nút lệnh và các control khác để người dùng tương tác với ứng dụng.

* Widget:

Widget: Một component tùy biến cao, cho phép bạn tạo các component UI tùy chỉnh theo yêu cầu.

* Các component khác:

Tabs: Hiển thị nội dung dưới dạng các tab.

Tree: Hiển thị dữ liệu dạng cây.

Chart: Hiển thị dữ liệu dưới dạng biểu đồ.

Notification: Hiển thị các thông báo cho người dùng.

let buttons = super.getToolbarButtons();

\
\[LookupScript]

public class CustomerLookup : RowLookupScript\<MyRow>

{

&#x20;  \[LookupEditor(typeof(Pfk7171FilteredLookup), InplaceAdd = true, DialogType = "Default.Pfk7171")]

}

### Tham khảo thêm: [https://serenity.is/docs/framework/dependency-injection](https://serenity.is/docs/framework/dependency-injection)
