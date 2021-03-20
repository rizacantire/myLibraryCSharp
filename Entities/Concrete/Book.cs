using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Book:IEntity
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Page { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public bool IsExist { get; set; }
    }
}
