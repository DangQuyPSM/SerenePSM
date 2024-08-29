---
icon: arrow-down-z-a
description: Chức năng lọc và mở rộng
---

# Chức năng lọc và mở rộng

{% hint style="info" %}
Lọc và tìm kiếm một hoặc nhiều đối tượng trong bảng
{% endhint %}

### Sử dụng LookupEditor để thể hiện danh sách thả xuống. Bằng cách thêm LookupEditor vào Row ở trên các thuộc tính được định nghĩa, lưu ý là thuộc tính cần có IdProperty để có thể hiển thị được dữ liệu.

```
[LookupEditor(typeof(Pfk7171FilteredLookup), InplaceAdd = true, DialogType = "Default.Pfk7171")]
[DisplayName("Basic Code"), Column("K7171_BasicCode"), Size(3), NotNull, PrimaryKey, IdProperty]
public string BasicCode { get => fields.BasicCode[this]; set => fields.BasicCode[this] = value; }
```

### Thêm đoạn code để thực hiện truy vấn cho LookupEditor, hiển thị Id, văn bản theo điều kiện đưa ra

```
[LookupScript("Default.Pfk7171FilteredLookup")]
public sealed class Pfk7171FilteredLookup : RowLookupScript<Pfk7171Row>
{
    public Pfk7171FilteredLookup(ISqlConnections sqlConnections)
        : base(sqlConnections)
    {
        IdField = Pfk7171Row.Fields.BasicCode.PropertyName;
        TextField = Pfk7171Row.Fields.BasicName.PropertyName;
    }

    protected override void PrepareQuery(SqlQuery query)
    {
        base.PrepareQuery(query);
        var fld = Pfk7171Row.Fields;

        query.Distinct(true)
             .Select(fld.BasicCode)  // Select phải khớp với tên trường
             .Select(fld.BasicName)
             .Where(fld.BasicSel == "000"); // Sử dụng tên trường chính xác
    }



    protected override void ApplyOrder(SqlQuery query)
    {
        base.ApplyOrder(query);
        var fld = Pfk7171Row.Fields;

        // Áp dụng order
        query.OrderBy(fld.BasicCode);
    }
}

```

### Ngoài ra còn một số tính năng lọc mở rộng hơn như lọc với nhiều điều kiện, bằng cách

####

```
//Thêm đoạn code này vào Columns ngay trên thuộc tính.
[Width(200), GenreListFormatter, QuickFilter]
public List<int> GenreList { get; set; }
```

```
//Thêm đoạn code này vào file Grid.ts.
protected getQuickFilters() {
        let items = super.getQuickFilters();

        const genreListFilter = first(items, x =>
            x.field == MovieRow.Fields.GenreList);

        genreListFilter.handler = h => {
            const request = (h.request as MovieListRequest);
            const values = (h.widget as LookupEditor).values;
            request.Genres = values.map(x => parseInt(x, 10));
            h.handled = true;
        };

        return items;
    }
```

### Tài liệu tham khảo thêm về các tính năng lọc nâng cao cho dự án:

[https://serenity.is/docs/tutorials/movies/05-customizing-quick-search](https://serenity.is/docs/tutorials/movies/05-customizing-quick-search)
