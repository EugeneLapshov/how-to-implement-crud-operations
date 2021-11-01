<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/265491908/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T899930)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!--WARNING: This file has been automatically generated. Do not change it manually.-->
# Implement CRUD Operations in the WPF Data Grid

This example shows how to implement CRUD operations (create, read, update, and delete) in the Data Grid bound to different data sources. Refer to the following topic for information on these operations: [Implement CRUD Operations in a Data-Bound Grid](https://docs.devexpress.com/WPF/401907/controls-and-libraries/data-grid/crud-operations).

![CRUD operations](https://docs.devexpress.com/WPF/images/GridControl_CRUDMVVMInfiniteAsyncSource.png)

The example includes multiple solutions that demonstrate:

* How to bind the Data Grid to [Entity Framework](https://docs.microsoft.com/en-us/ef/ef6/), [EF Core](https://docs.microsoft.com/en-us/ef/), and [XPO](https://docs.devexpress.com/XPO/1998/express-persistent-objects).
* Different binding mechanisms: [virtual sources](https://docs.devexpress.com/WPF/10803/controls-and-libraries/data-grid/bind-to-data/bind-to-any-data-source-with-virtual-sources), [server mode sources](https://docs.devexpress.com/WPF/6279/controls-and-libraries/data-grid/bind-to-data/server-mode-and-instant-feedback), and [local data](https://docs.devexpress.com/WPF/6090/controls-and-libraries/data-grid/bind-to-data/bind-to-local-data).
* MVVM and code-behind patterns.

## Files to Look At

### Local Data

* [MVVVM - EFCore](CS/ViewModel/EFCore/LocalData)
* [MVVVM - EntityFramework](CS/ViewModel/EntityFramework/LocalData)
* [MVVVM - XPO](CS/ViewModel/XPO/LocalData)
* [Code-behind - EFCore](CS/CodeBehind/EFCore/LocalData)
* [Code-behind - EntityFramework](CS/CodeBehind/EntityFramework/LocalData)
* [Code-behind - XPO](CS/CodeBehind/XPO/LocalData)

### InfiniteAsyncSource

* [MVVVM - EFCore](CS/ViewModel/EFCore/InfiniteAsyncSource)
* [MVVVM - EntityFramework](CS/ViewModel/EntityFramework/InfiniteAsyncSource)
* [MVVVM - XPO](CS/ViewModel/XPO/InfiniteAsyncSource)
* [Code-behind - EFCore](CS/CodeBehind/EFCore/InfiniteAsyncSource)
* [Code-behind - EntityFramework](CS/CodeBehind/EntityFramework/InfiniteAsyncSource)
* [Code-behind - XPO](CS/CodeBehind/XPO/InfiniteAsyncSource)

### PagedAsyncSource

* [MVVVM - EFCore](CS/ViewModel/EFCore/PagedAsyncSource)
* [MVVVM - EntityFramework](CS/ViewModel/EntityFramework/PagedAsyncSource)
* [MVVVM - XPO](CS/ViewModel/XPO/PagedAsyncSource)
* [Code-behind - EFCore](CS/CodeBehind/EFCore/PagedAsyncSource)
* [Code-behind - EntityFramework](CS/CodeBehind/EntityFramework/PagedAsyncSource)
* [Code-behind - XPO](CS/CodeBehind/XPO/PagedAsyncSource)

### Instant Feedback

* [MVVVM - EFCore](CS/ViewModel/EFCore/InstantFeedbackMode)
* [MVVVM - EntityFramework](CS/ViewModel/EntityFramework/InstantFeedbackMode)
* [MVVVM - XPO](CS/ViewModel/XPO/InstantFeedbackMode)
* [Code-behind - EFCore](CS/CodeBehind/EFCore/InstantFeedbackMode)
* [Code-behind - EntityFramework](CS/CodeBehind/EntityFramework/InstantFeedbackMode)
* [Code-behind - XPO](CS/CodeBehind/XPO/InstantFeedbackMode)

### Server Mode

* [MVVVM - EFCore](CS/ViewModel/EFCore/ServerMode)
* [MVVVM - EntityFramework](CS/ViewModel/EntityFramework/ServerMode)
* [MVVVM - XPO](CS/ViewModel/XPO/ServerMode)
* [Code-behind - EFCore](CS/CodeBehind/EFCore/ServerMode)
* [Code-behind - EntityFramework](CS/CodeBehind/EntityFramework/ServerMode)
* [Code-behind - XPO](CS/CodeBehind/XPO/ServerMode)
