using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Accounting.DataLayer.Services
{
    public class GenericRepository<T> where T : class
        //یک ریپوزیتوری جنریک ایجاد میکنیم تا برای تمام موجودیت های دیتابیس بتوانیم از متد های استفاده کنیم
        //در بین علامت <> نوع جنریک مشخص میشود
        //که میتوان نوع آنرا یکی از موجودیت های دیتابیس مانند جدول ها و غیره قرار داد 
    {
        private AccountingEntity _DB;
        //یک کانتکست برای ارتباط با دیتابیس ایجاد میکنیم 
        private DbSet<T> _DBSet;
        //موجودیت های دیتابیس در انتیتی به عنوان یک دی بی ست تعریف شده اند
        //یک نماینده برای موجودیت ها تعریف میکنیم

        public GenericRepository(AccountingEntity DB)
        //کانستراکتور را ایجاد میکنیم
        {
            _DB = DB;
            //تزریق وابستگی

            _DBSet = _DB.Set<T>();
            //گرفتن موجودیت از نماینده دیتابیس و ست کردن با نماینده موجودیت های دیتابیس که بالاتر تعریف کردیم
        }

        //عملیات های موردنظر را به صورت متد مینویسیم
        public virtual void Insert(T entity)
            //کلاسی که از این کلاس ارث بری کند میتوان در آن متد های این کلاس را فراخوانی کرد 
            //حالا اگر متدی از این کلاس دارای کلمه ویرچوال باشد 
            //علاوه بر فراخوانی متد میتوان رفتار متد را نیز عوض کرد
        {
            _DBSet.Add(entity);
            //موجودیت دیتابیس را به دیبی ست اضافه کن 
        }

        public virtual T GetByID (Object ID)
        //دیتا تایپ ابجکت تمام دیتا ایپ ها را شامل مبشود
        {
            return _DBSet.Find(ID);
        }

        public virtual void Update(T entity) 
        {
            _DBSet.Attach(entity);
            //مجودیت را به کانتکست متصل کن 
            _DB.Entry(entity).State = EntityState.Modified;
            //سپس آنرا روی حالت تغییریافته قرار بده
        }

        public virtual void Delete(T entity)
        {
            if  (_DB.Entry(entity).State == EntityState.Detached) 
            //اگر موجودیت ما به کانتکست متصل نبود
            {
                _DBSet.Attach(entity);    
                //آنرا به کانتکست متصل کن
            }
            _DBSet.Remove(entity);
            //سپس حذفش کن
        }

        public virtual void Delete(object ID) 
        {
            var entity = GetByID(ID);
            //با متد گت بای ایدی موجودیت مورد نظر را بگیر
            Delete(entity);
            //و با متد دیلیت آنرا حذف کن
        }

        public virtual IEnumerable<T> Get(Expression<Func<T,bool>> where = null )
            //ورودی این متد یک اکسپرشن مانند متد های لامدا است که دیفالت آن نال است
            //یعنی نیازی به گرفت ورودی ندارد اما میتوان 
            //با متد های موردنظر لامدا به آن یک شرط اضافه کرد
        {
            IQueryable<T> query = _DBSet;
            //نوع کویری های جست و جوی لینک از نوع کویریبل است
            //با این کد امکان انجام عملیات های لینک و لامدا روی عضو دیتا بیس ما فراهم میشود
            
            if (where != null)
            //اگر شرط روی متد اعمال شد
            {
                 query = query.Where(where);
                 //شرط روی اعمال شده در متد به کویری داده شده به عوض دیتا بیس داده شود
            }
            return query.ToList();
            //ما تا زمانی که از متد دات تو لیست استفاده نکنیم متغیر ما داده ای در خودش ذخیره نکرده به این کار لیزی لود گفته میشه
            //که پس از انجام تمام تغییرات تازه داده ای در متغیر ما ذخیره میشود
        }
    
    }
}
