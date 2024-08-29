---
icon: eye
description: Hiển thị
---

# Chức năng hiển thị.

{% hint style="info" %}
## Chức năng get dữ liệu và hiển thị dữ liệu lên grid
{% endhint %}

## Trong file Endpoint.cs ta sẽ xử lý hiển thị data lên grid bằng hàm public ListResponse List.

●      Public ListResponse\<MyRow> List(...): Đây là một phương thức công khai (public) trả về một đối tượng kiểu ListResponse\<MyRow>. ListResponse\<MyRow> là một kiểu dữ liệu chứa danh sách các đối tượng MyRow (các dòng dữ liệu).

●      Tham số đầu vào: IDbConnection connection: Đây là kết nối tới cơ sở dữ liệu, thường được dùng để thực hiện các truy vấn dữ liệu.

●      ListRequest request: Đây là đối tượng chứa thông tin về yêu cầu từ client, chẳng hạn như điều kiện lọc, phân trang, và sắp xếp.

●      \[FromServices] IPfk7171ListHandler handler: Đây là một dependency injection của kiểu IPfk7171ListHandler. handler được sử dụng để xử lý các yêu cầu danh sách (list request) cho loại dữ liệu Pfk7171.

* Return handler.List(connection, request);: Dòng này gọi phương thức List của đối tượng handler, truyền vào kết nối cơ sở dữ liệu (connection) và yêu cầu (request). Phương thức này sẽ thực hiện việc truy vấn dữ liệu từ cơ sở dữ liệu dựa trên các điều kiện trong request, sau đó trả về một đối tượng ListResponse\<MyRow> chứa danh sách các dòng dữ liệu MyRow.
* \[HttpPost, AuthorizeList(typeof(MyRow))] public ListResponse List(IDbConnection connection, ListRequest request, \[FromServices] IPfk7171ListHandler handler) { // Check if EqualityFilter contains the key "BasicCode" if (request.EqualityFilter != null && request.EqualityFilter.ContainsKey("BasicCode")) { var basicCode = (string)request.EqualityFilter\["BasicCode"];

<pre><code><strong>    // Check if basicCode is not null or empty
</strong>    if (!string.IsNullOrEmpty(basicCode))
    {
        // Apply filter criteria based on K7171_BasicSel equal to the BasicCode value
        request.Criteria = new Criteria("BasicSel") == new ValueCriteria(basicCode);

        // Retrieve the filtered list from the handler
        var response = handler.List(connection, request);

        // Debug: Log the number of results returned
        Console.WriteLine("Number of results: " + response.Entities.Count);

        // Return the filtered response
        return response;
    }
}

// If no BasicCode filter is provided, return the full list
return handler.List(connection, request);
}
</code></pre>
