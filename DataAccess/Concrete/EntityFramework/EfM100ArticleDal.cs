using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfM100ArticleDal : EfEntityRepositoryBase<M100Article, DatabaseContext>, IM100ArticleDal
    {
        public List<M100ArticleDto> GetM100ArticleDto()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from a in context.M100Article
                             join c in context.M100Categories
                             on a.CategoryId equals c.CategoryId
                             select new M100ArticleDto { ArticleId = a.ArticleId, CategoryId = c.CategoryId, AuthorId = a.AuthorId, EditorId = a.EditorId};

                return result.ToList();
            }
        }
    }
}
