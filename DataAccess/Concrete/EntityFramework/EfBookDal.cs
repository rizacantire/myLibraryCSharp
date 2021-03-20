using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, BookContext>, IBookDal
    {

        public List<BookDetailsDto> GetBookDetails(Expression<Func<BookDetailsDto, bool>> filter = null)
        {
            using(var context = new BookContext())
            {
                var result = from book in context.Books
                             join author in context.Authors on book.AuthorId equals author.Id
                             join category in context.Categories on book.CategoryId equals category.Id
                             select new BookDetailsDto
                             {
                                 BookName = book.Name,
                                 AuthorName = author.Name,
                                 CategoryName = category.Name,
                                 CategoryId = book.CategoryId,
                                 Description = book.Description,
                                 IsExist = book.IsExist,
                                 IsRead = book.IsRead,
                                 Page = book.Page

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
