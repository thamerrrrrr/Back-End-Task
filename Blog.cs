using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThamerDraidi_Task1.Model
{
     public class Blog
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public int UserId { set; get; }
        public User user { set; get; }
    }
}
