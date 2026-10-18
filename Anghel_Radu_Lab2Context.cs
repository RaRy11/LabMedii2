using Microsoft.EntityFrameworkCore;

public class Anghel_Radu_Lab2Context(DbContextOptions<Anghel_Radu_Lab2Context> options) : DbContext(options)
{
    public DbSet<Anghel_Radu_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Anghel_Radu_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Anghel_Radu_Lab2.Models.Author> Author { get; set; } = default!;
}
