using Microsoft.EntityFrameworkCore;
using TodoList.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(options =>
    options.UseInMemoryDatabase("TodoList")); // Add DbContext for in-memory database

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Changed to Developer Exception Page for development environment

    // Enable Swagger in development
    app.UseSwagger();
    app.UseSwaggerUI(c =>
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoList API V1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();
app.Run();
