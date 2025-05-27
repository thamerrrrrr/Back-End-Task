using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThamerDraidi_Task1.Model
{
   public class User
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public ICollection<Blog> blogs { set; get; } = new List<Blog>();
    }
}
