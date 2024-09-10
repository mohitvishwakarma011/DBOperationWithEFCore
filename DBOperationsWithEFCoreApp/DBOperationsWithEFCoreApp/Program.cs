
using DBOperationsWithEFCoreApp.Data;
using Microsoft.EntityFrameworkCore;

namespace DBOperationsWithEFCoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDBContext>(options=> 
            options.UseSqlServer(builder.Configuration.GetConnectionString("AppDb"))
            );
        }
    }
}
