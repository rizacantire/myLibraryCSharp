using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BookDetailsDto : IDto
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Page { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public bool IsExist { get; set; }
    }
}