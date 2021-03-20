using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookService
    {
        IDataResult<List<Book>> GetAll();
        IDataResult<List<Book>> GetAllByCategoryId(int categoryId);
        IDataResult<List<BookDetailsDto>> GetBookDetails();
        IDataResult<Book> GetById(int bookId);
        IResult Add(Book book);
        IResult Delete(Book book);
        IResult Update(Book book);

    }
}
