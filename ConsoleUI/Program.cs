using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //M100CategoriesManager m100CategoryManager = new M100CategoriesManager(new EfM100CategoriesDal());
            //if you create this Project as a ConsoleApplication it will not work
            //its not adding the Business.Concrete
            //but when we write like that it will not start bcs its a "class library"
            
            /*foreach (var category in m100CategoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
            */
            

        }
    }
}