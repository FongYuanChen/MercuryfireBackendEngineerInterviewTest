# 水星工程科技有限公司 - 中階後端工程師面試測驗
**此 GitHub 專案用於存放 [水星工程科技有限公司 - 中階後端工程師](https://github.com/mercuryfire/Backend_Engineer_II) 面試測驗的實作內容。**

## 專案內容
- C# .NET 8 Web API MVC 的實作
- SQL SERVER / Stored Procedure / JSON 與 CURD 的實作
- 面試考題功能完整實作

## 使用方式
1. Clone 專案到本地端
2. 開啟 SQL Server Management Studio (SSMS)
3. 還原資料庫：
   - 右鍵「資料庫」→「還原資料庫」
   - 選擇專案中的 `BackendExamHub.bak`
   - 還原到 SQL Server
4. 開啟 Visual Studio，載入專案  
5. 設定 appsettings.json 的資料庫連線字串，指向剛還原的資料庫  
6. 執行專案，即可測試 API 與 SP 功能