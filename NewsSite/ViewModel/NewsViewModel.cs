using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NewsSite.ViewModel
{
    public class NewsViewModel
    {
        [DisplayName("Заголовок")]
        public string Title { get; set; }
        
        [DisplayName("Тело")]
        public string Body { get; set; }

        [DisplayName("Дата публикации")]
        public DateTime PublishDate { get; set; } = DateTime.Now;
    }
}