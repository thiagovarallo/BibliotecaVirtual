using bibliotecaVirtual.Data;
using Microsoft.EntityFrameworkCore;

namespace bibliotecaVirtual
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            string mysqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //conection mysql
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseMySql(mysqlConnection, ServerVersion.AutoDetect(mysqlConnection)));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}