using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //context: Db tabloları ile proje classlarını bağlamak

    public class DatabaseContext:DbContext
    {
        //first locate the db 

        // video : 01:30:00 ,,, 02:10:00
        //https://www.youtube.com/watch?v=ow-EHetuNAU&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=8
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=94.73.151.69;Initial Catalog=u6150386_Mbarrel; User Id=u6150386_Mbarrel;Password=ZMar83G8GFto32M;"); // ;Database=u6150386_Mbarrel;Trusted_Connection=true
            //ask this part 

        }

        public DbSet<M100AddressBook> M100AddressBook { get; set; } //dbo.M100AddressBook 
        public DbSet<M100Admin> M100Admin { get; set; }
        public DbSet<M100AllEmailAddress> M100AllEmailAddress { get; set; }
        public DbSet<M100AllPhone> M100AllPhone { get; set; }
        public DbSet<M100Article> M100Article { get; set; }
        public DbSet<M100Categories> M100Categories { get; set; }
        public DbSet<M100Certificates> M100Certificates { get; set; }
        public DbSet<M100Cities> M100Cities { get; set; }
        public DbSet<M100Client> M100Client { get; set; }
        public DbSet<M100ClientOperationClaims> M100ClientOperationClaims { get; set; }
        public DbSet<M100CompanyAddresses> M100CompanyAddresses { get; set; }
        public DbSet<M100CompanyInfo> M100CompanyInfo { get; set; }
        public DbSet<M100Countries> M100Countries { get; set; }
        public DbSet<M100Department> M100Department { get; set; }
        public DbSet<M100DepartmentDetails> M100DepartmentDetails { get; set; }
        public DbSet<M100DocumentContainer> M100DocumentContainer { get; set; }
        public DbSet<M100EmailContent> M100EmailContent { get; set; }
        public DbSet<M100EmailContentSpecifications> M100EmailContentSpecifications { get; set; }
        public DbSet<M100EmailControl> M100EmailControl { get; set; }
        public DbSet<M100Employee> M100Employee { get; set; }
        public DbSet<M100EmployeeOperationClaims> M100EmployeeOperationClaims { get; set; }
        public DbSet<M100EmployeePersonalInformation> M100EmployeePersonalInformation { get; set; }
        public DbSet<M100ExceptionLogs> M100ExceptionLogs { get; set; } 
        public DbSet<M100FAQ> M100FAQ { get; set; }
        public DbSet<M100ImageContainer> M100ImageContainer { get; set; }
        public DbSet<M100IpList> M100IpList { get; set; }
        public DbSet<M100MacList> M100MacList { get; set; }
        public DbSet<M100MessageBox> M100MessageBox { get; set; }
        public DbSet<M100NewsletterControls> M100NewsletterControls { get; set; }
        public DbSet<M100OperationClaims> M100OperationClaims { get; set; }
        public DbSet<M100Persons> M100Persons { get; set; }
        public DbSet<M100PersonsAddresses> M100PersonsAddresses { get; set; }
        public DbSet<M100Policy> M100Policy { get; set; }
        public DbSet<M100SiteInfo> M100SiteInfo { get; set; }
        public DbSet<M100SocialMediaAccounts> M100SocialMediaAccounts { get; set; }
        public DbSet<M100SocialMediaTypes> M100SocialMediaTypes { get; set; }
        public DbSet<M100States> M100States { get; set; }
        public DbSet<M100TimeZone> M100TimeZone { get; set; }
        public DbSet<M100Universities> M100Universities { get; set; }
        public DbSet<M100Verifications> M100Verifications { get; set; }
        public DbSet<M100VideoContainer> M100VideoContainer { get; set; }
        public DbSet<M102Assigns> M102Assigns { get; set; }
        public DbSet<M102ClientDocuments> M102ClientDocuments { get; set; }
        public DbSet<M102DietList> M102DietList { get; set; }
        public DbSet<M102Employees> M102Employees { get; set; }
        public DbSet<M102KcalList> M102KcalList { get; set; }
        public DbSet<M102Repeats> M102Repeats { get; set; }
        public DbSet<M102RepeatsType> M102RepeatsType { get; set; }
        public DbSet<M102WhoList> M102WhoList { get; set; }


    }
}
