using ThamerDraidi_Task1.Data;
using ThamerDraidi_Task1.Model;

namespace ThamerDraidi_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();



            User u1 = new User() { Name = "thamer", Email = "th@hmq", Password = "123" };
            User u2 = new User() { Name = "qaise", Email = "qa@hmq", Password = "1234" };
            User u3 = new User() { Name = "reziq", Email = "re@hmq", Password = "12345" };
            context.users.Add(u1);
            context.users.Add(u2);
            context.users.Add(u3);

            context.SaveChanges();

            Blog b1 = new Blog() { Title = "blog1", Description = "this is blog1", UserId = 1 };
            Blog b2 = new Blog() { Title = "blog2", Description = "this is blog2", UserId = 1 };
            Blog b3 = new Blog() { Title = "blog3", Description = "this is blog3", UserId = 2 };
            Blog b4 = new Blog() { Title = "blog4", Description = "this is blog4", UserId = 2 };
            Blog b5 = new Blog() { Title = "blog5", Description = "this is blog5", UserId = 3 };

            context.blogs.Add(b1);
            context.blogs.Add(b2);
            context.blogs.Add(b3);
            context.blogs.Add(b4);
            context.blogs.Add(b5);


            context.SaveChanges();

          





        }
    }
}
