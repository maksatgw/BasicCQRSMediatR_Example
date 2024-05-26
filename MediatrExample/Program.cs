using MediatR;
using MediatrExample.Service;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//MediatR'ý projemize servisler üzerinden eklemesini yapýyoruz.
//Assembly.GetExecutingAssembly() þu anki çalýþan derlemeyi kaydeder. 
//detalý bilgi için https://chatgpt.com/share/5d97f1a4-2b22-4d77-aed5-2aafd7c943bd
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

//Ramde tutacaðýmýz Product için singleton nesne oluþturduk.
builder.Services.AddSingleton<IProductService, ProductService>();

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
