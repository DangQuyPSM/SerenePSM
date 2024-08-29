---
icon: database
description: Kết nối CSDL Sql Server
---

# Xử lý kết nối CSDL

### Kết nối CSDL SQL Server.

<figure><img src="https://lh7-rt.googleusercontent.com/docsz/AD_4nXfDm4i-W3KipXb7x1-rh1wCuKZrm4AkZdd81rZoMycNHz2eU20We-T8uSBuiRlbiF3mQEKV_Yc463x-Jg93kh1L92q_d1KGNM5D1S21rjbGUkswJR5dJxRVGEqMW22PapYv2iid0zR6bevLMAQCpJQc34W-ED0DULtO4JrU?key=YCZZc6cavvO63WAAdUXzEA" alt=""><figcaption></figcaption></figure>

### Chuỗi kết nối "ConnectionString" trong file appsettings.json.

<figure><img src="https://lh7-rt.googleusercontent.com/docsz/AD_4nXc9_XZoshkYY5Hup_ffmMa0c6DOPlsYXVN08JSklBel_FIa1X5YbFq2Yzt74oDwj2NJQg05E16FuKvzy6ZDyucnInlaOlEZ90cgSskCQaUQ-CKEPY0gAJM3i9R7iwT5024Wtwm6WXlDNDVQLzuRprkrDkF7YKPgFqYD6OBC?key=YCZZc6cavvO63WAAdUXzEA" alt=""><figcaption></figcaption></figure>

```
"Default": {
  "ConnectionString": "Server=xx.xx.xxx.43,14330;Database=Your_Database;User Id=UserID;Password=Password;Encrypt=false;TrustServerCertificate=true",
  "ProviderName": "System.Data.SqlClient"
},
```
