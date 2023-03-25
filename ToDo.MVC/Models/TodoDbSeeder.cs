using Microsoft.EntityFrameworkCore;

namespace ToDo.MVC.Models
{
    public class TodoDbSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new TodoDbContext(serviceProvider.GetRequiredService<DbContextOptions<TodoDbContext>>());

            //Look for any Todos.
            if (context.Todos.Any())
            {
                //If there is any seeded data already, then return
                return;
            }

            context.Todos.AddRange(
                new Todo
                {
                    Id = 1,
                    TaskName = "Work on book Chapter",
                    IsComplete = false,
                },

                new Todo
                {
                    Id = 2,
                    TaskName = "Create video content",
                    IsComplete = false,
                }
            );

            context.SaveChanges();
        }
    }
}
