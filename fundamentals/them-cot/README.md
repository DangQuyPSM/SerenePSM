---
icon: chart-simple
description: Thêm cột vào grid
---

# Thêm cột

<details>

<summary>Bước 1: Ở Row thì ta sẽ thêm một số cột vào trong theo format này, DisplayName để thể hiện tên cột, Column định nghĩa tên cột theo bảng, public lưu trữ giá trị của cột đó.</summary>

```
[DisplayName("Basic Code"), Column("K7171_BasicCode"), Size(3), NotNull, PrimaryKey, IdProperty]
public string BasicCode { get => fields.BasicCode[this]; set => fields.BasicCode[this] = value; }
```

</details>

```
[DisplayName("Basic Code"), Column("K7171_BasicCode"), Size(3), NotNull, PrimaryKey, IdProperty]
public string BasicCode { get => fields.BasicCode[this]; set => fields.BasicCode[this] = value; }
```

<details>

<summary>Bước 2: Đồng thời sẽ phải thêm ở Columns để hiển thị lên view.</summary>

```
public string BasicCode { get; set; }
```

</details>

```
public string BasicCode { get; set; }
```
