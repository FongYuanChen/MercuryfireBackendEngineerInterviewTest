# 📝 水星工程科技有限公司 - 中階後端工程師面試測驗

**此 GitHub 專案用於存放 [水星工程科技有限公司 - 中階後端工程師](https://github.com/mercuryfire/Backend_Engineer_II) 面試測驗的實作內容。**


## 📦 專案內容

- C# .NET 8 Web API MVC 的實作
- SQL server / Stored Procedure / JSON 與 CURD 的實作
- 面試考題功能完整實作


## 🚀 使用方式

1. Clone 專案到本地端
2. 開啟 SQL Server Management Studio (SSMS)
3. 還原資料庫：
   - 右鍵「資料庫」→「還原資料庫」
   - 選擇專案中的備份檔：
     - `BackendExamHub_2022.bak`（2022 版本）
     - `BackendExamHub_2025.bak`（2025 版本）
   - 還原到 SQL Server
4. 開啟 Visual Studio，載入專案  
5. 設定 `appsettings.json` 的資料庫連線字串，指向剛還原的資料庫  
6. 執行專案，即可測試 API 與 SP 功能


## 📄 API 文件

本專案提供 Swagger UI 作為 API 文件與測試工具。專案執行後，可透過 `/swagger` 存取 Swagger UI。

![Swagger UI Screenshot](https://github.com/user-attachments/assets/4b6da4ee-ed1f-4305-8184-2b0edeb7e86b)

