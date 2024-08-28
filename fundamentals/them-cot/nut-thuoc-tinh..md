---
description: Thêm một thuộc tính nút
icon: toggle-large-on
---

# Nút, thuộc tính.

{% hint style="info" %}
**Hướng dẫn:** Nếu bạn muốn thêm một button tùy chỉnh vào form trong Serenity, bạn có thể làm như sau:
{% endhint %}

* Mở File TypeScript của Form:
* Tìm đến file .ts của form mà bạn muốn thêm button. Thông thường file này sẽ nằm trong thư mục ServerTypes của dự án.
* Thêm Button Trong onClick Event:
* Trong class của form, bạn có thể thêm button bằng cách sử dụng Toolbar trong phương thức getToolbarButtons.

protected getToolbarButtons() {

&#x20;   let buttons = super.getToolbarButtons();

&#x20;   buttons.push({

&#x20;       title: 'My Custom Button',

&#x20;       cssClass: 'add-button',

&#x20;       onClick: () => {

&#x20;           // Hành động khi bấm vào button

&#x20;           Q.notifySuccess("Button clicked!");

&#x20;       }

&#x20;   });

&#x20;   return buttons;

}

### Thêm Button Trong Grid (Grid Customization):

* Mở File TypeScript của Grid:
* Tìm đến file .ts của grid mà bạn muốn thêm button.
* Thêm Button Trong getButtons Method:
* Thêm button vào grid bằng cách sử dụng phương thức getButtons.

protected getButtons() {

&#x20;   let buttons = super.getButtons();

\
&#x20;   buttons.push({

&#x20;       title: 'My Custom Button',

&#x20;       cssClass: 'add-button',

&#x20;       onClick: () => {

&#x20;           // Hành động khi bấm vào button

&#x20;           Q.notifyInfo("Grid button clicked!");

&#x20;       }

&#x20;   });



&#x20;   return buttons;

}
