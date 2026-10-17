# نرم‌افزار حسابداری ویندوزی | Accounting Software

یک نرم‌افزار حسابداری ویندوزی چندلایه با سی‌شارپ برای مدیریت مشتریان، اسناد حسابداری و گزارش پرداخت‌ها.

A multi-layer Windows Forms accounting application in C# for managing customers, accounting documents and payment reports.

## ویژگی‌ها

* مدیریت مشتریان (ثبت، ویرایش، جست‌وجو، مانده حساب)
* ثبت اسناد حسابداری (دریافت / پرداخت)
* گزارش پرداخت با استیمول‌سافت
* فرم ورود کاربران
* معماری چندلایه

## تکنولوژی‌ها

* سی‌شارپ , .NET Framework 4.7.2 , ویندوزفرم
* انتیتی فریم‌ورک (Database First با edmx.)
* اس‌کیوال سرور همراه با T-SQL
* استیمول‌سافت نسخه 2014.3
* گیت

## ساختار پروژه

```
Accounting.sln
├── Accounting.App         # لایه رابط کاربری - فرم‌ها (Form1, Form\\\\\\\_Login, Form\\\\\\\_Customers, Form\\\\\\\_Accounting, Form\\\\\\\_PayReport)
├── Accounting.Business    # لایه منطق تجاری (Account.cs)
├── Accounting.DataLayer   # لایه دسترسی به داده (edmx. و ریپازیتوری‌ها)
├── Accounting.Utility     # ابزارها و توابع کمکی
└── Accounting.ViewModels  # ویومدل‌ها و دی‌تی‌اوها
```

## پیش‌نیازها

* ویژوال استودیو 2019 یا جدیدتر
* دات‌نت فریم‌ورک 4.7.2
* اس‌کیوال سرور 2016 به بالا
* استیمول‌ریپورت

## نصب و اجرا

۱. ریپو را کلون کنید:

```bash
git clone https://github.com/SeyyedAliEmam/Accounting.git
```

۲. فایل `Accounting.sln` را با ویژوال استودیو باز کنید.

۳. کانکشن استرینگ را در `Accounting.DataLayer` و `App.config` متناسب با اس‌کیوال سرور خودتان تنظیم کنید.

۴. پکیج‌های NuGet را ریستور کنید و Rebuild Solution بگیرید.

۵. پروژه را اجرا کنید (F5). فرم‌های اصلی:

* `Form\\\\\\\_Login` : ورود کاربران
* `Form\\\\\\\_Customers` : لیست مشتریان
* `Form\\\\\\\_Accounting` : ثبت سند جدید
* `Form\\\\\\\_PayReport` : گزارش پرداخت با استیمول‌سافت

## دیتابیس

* جدول‌های اصلی: Customers ،Accounting (اسناد) ،Login
* دسترسی به داده با انتیتی فریم‌ورک انجام می‌شود.

## سازنده

سید علی امام 
GitHub: https://github.com/SeyyedAliEmam/Accounting

