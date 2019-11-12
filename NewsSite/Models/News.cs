using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsSite.Models
{
    public class News
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PublishDate { get; set; } = DateTime.Now;

    }
}