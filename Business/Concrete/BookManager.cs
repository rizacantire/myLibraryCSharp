using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public IResult Add(Book book)
        {
            _bookDal.Add(book);
            return new SuccessResult(Messages.BookAdded);
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);
            return new SuccessResult(Messages.BookDeleted);
        }

        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(),Messages.BooksListed);
        }

        public IDataResult<List<Book>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(b=>b.Id == categoryId), Messages.BooksListed);
        }

        public IDataResult<List<BookDetailsDto>> GetBookDetails()
        {
            return new SuccessDataResult<List<BookDetailsDto>>(_bookDal.GetBookDetails(), Messages.BooksListed);
        }

        public IDataResult<Book> GetById(int bookId)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(b => b.Id == bookId), Messages.Listed);
        }

        public IResult Update(Book book)
        {
            _bookDal.Update(book);
            return new SuccessResult(Messages.BookUpdated);
        }
         public IDataResult<List<BookDetailsDto>> GetBookDetailsByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<BookDetailsDto>>(_bookDal.GetBookDetails(b=>b.CategoryId == categoryId), Messages.BooksListed);
        }
    }
}
