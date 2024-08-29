---
icon: toggle-large-on
description: Thêm một thuộc tính nút
---

# Nút, thuộc tính.

{% hint style="info" %}
**Hướng dẫn:** Nếu bạn muốn thêm một button tùy chỉnh vào form trong Serenity, bạn có thể làm như sau:
{% endhint %}

* Mở File TypeScript của Form:
* Tìm đến file .ts của form mà bạn muốn thêm button. Thông thường file này sẽ nằm trong thư mục ServerTypes của dự án.
* Thêm Button Trong onClick Event:
* Trong class của form, bạn có thể thêm button bằng cách sử dụng Toolbar trong phương thức getToolbarButtons.

```
protected getToolbarButtons() {
    let buttons = super.getToolbarButtons();
    buttons.push({
        title: 'My Custom Button',
        cssClass: 'add-button',
        onClick: () => {
            // Hành động khi bấm vào button
            Q.notifySuccess("Button clicked!");
        }
    });
    return buttons;
}
```

### Thêm Button Trong Grid (Grid Customization):

* Mở File TypeScript của Grid:
* Tìm đến file .ts của grid mà bạn muốn thêm button.
* Thêm Button Trong getButtons Method:
* Thêm button vào grid bằng cách sử dụng phương thức getButtons.

```
protected getButtons() {
    let buttons = super.getButtons();

    buttons.push({
        title: 'My Custom Button',
        cssClass: 'add-button',
        onClick: () => {
            // Hành động khi bấm vào button
            Q.notifyInfo("Grid button clicked!");
        }
    });

    return buttons;
}
```
