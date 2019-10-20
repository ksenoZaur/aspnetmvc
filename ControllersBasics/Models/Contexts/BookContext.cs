using System.Data.Entity;

namespace ControllersBasics.Models.Contexts
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }

    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            context.Books.Add(new Book() { Title = "Война и Мир", Author = "Лев Толстой", Price = 220.0});
            base.Seed(context);
        }
    }
}