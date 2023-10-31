namespace AmazonBooks.Data;
using AmazonBooks.Models;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

public class ApplicationDbContext:DbCotext
{

public ApplicationDbContext(DbContextOptions<Application>options):base(options){

}

public DbSet<BooksEntity> Books {get;}
}