# ForumTesting

## 專案簡介

本專案為 .NET 8 Razor Pages 討論區範例，支援訊息新增、編輯、刪除、檢視。

## 環境需求
- .NET 8 SDK
- SQL Server（或其他支援的資料庫）

## 建置專案
```bash
dotnet build
```

## 資料庫連線設定
請編輯 `appsettings.json`，設定連線字串：
```json
"ConnectionStrings": {
  "MessageContext": "Server=YOUR_SERVER;Database=ForumTestingDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
請將 `YOUR_SERVER` 替換為你的 SQL Server 名稱。

## 開發環境設定
開發時請將 `appsettings.json` 的內容複製到 `appsettings.Development.json`，並根據開發需求修改資料庫連線等設定。
`appsettings.Development.json` 已加入 `.gitignore`，不會被推送到 Git。

## 套件安裝
如需安裝 Entity Framework Core 及 SQL Server provider：
```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

## 資料表遷移與更新
1. 建立初始遷移：
```bash
dotnet ef migrations add InitialCreate
```
2. 套用遷移至資料庫：
```bash
dotnet ef database update
```

## 執行專案
```bash
dotnet run
```

## 其他
- 頁面功能：訊息新增、編輯、刪除、檢視。
- Controller 與 Razor Pages 皆可用。

如需更詳細設定或遇到問題，請參考官方文件或專案原始碼。

