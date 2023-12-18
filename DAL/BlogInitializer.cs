using System.Collections.Generic;
using System;
using System.Data.Entity;

namespace DAL
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<AdminInfo> adminInfos = new List<AdminInfo>();

            adminInfos.Add(new AdminInfo() { Email = "sai@gmail.com", Password = "123" });
           

            context.AdminInfos.AddRange(adminInfos);
            context.SaveChanges();

            List<EmpInfo> empInfos = new List<EmpInfo>();
            empInfos.Add(new EmpInfo() { Email = "ramu@gmail.com", PassCode = 123, DateOfJoining = new DateTime(2023, 12, 17), Name = "ramu" });
            empInfos.Add(new EmpInfo() { Email = "giri@gmail.com", PassCode = 456, DateOfJoining = new DateTime(2023, 12, 16), Name = "giri" });
            
            context.EmpInfos.AddRange(empInfos);
            context.SaveChanges();

            List<BlogInfo> blogInfos = new List<BlogInfo>();
            blogInfos.Add(new BlogInfo() { Email = "ramu@gmail.com", BlogUrl = "www.playstation.com", DateOfCreation = new DateTime(2023, 12, 17), Subject = "gaming", Title = "sony playstation" });

            blogInfos.Add(new BlogInfo() { Email = "giri@gmail.com", BlogUrl = "www.google.com", DateOfCreation = new DateTime(2023, 12, 16), Subject = "website", Title = "google blog" });
            
            context.BlogInfos.AddRange(blogInfos);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}