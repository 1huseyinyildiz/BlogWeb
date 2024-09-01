using Data.Concrete.Mongodb.Context;
using Data.Concrete.Mongodb.Entity;
using Entities.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var serviceProvider = new ServiceCollection()
            .AddSingleton<BlogMongoDbContext>()
            .Configure<MongoDBSettings>(builder.Configuration.GetSection("MongoDBSettings"))
            .BuildServiceProvider();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
