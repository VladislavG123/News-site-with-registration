using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NewsSite.ViewModel
{
    public class UserViewModel
    {
        [DisplayName("Имя пользователя")]
        public string Name { get; set; }
    }
}