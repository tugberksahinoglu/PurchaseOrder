using Microsoft.EntityFrameworkCore;
using PurchaseOrder.Business.Interfaces;
using PurchaseOrder.Business.Services;
using PurchaseOrder.Data;
using PurchaseOrder.Data.Interfaces;
using PurchaseOrder.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options => {
    options.UseInMemoryDatabase("InMemoryDb");
});

//Repositories
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<INotificationRepository, NotificationRepository>();

//Services
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<INotificationStrategyService, EmailNotificationService>();
builder.Services.AddScoped<INotificationStrategyService, SmsNotificationService>();
builder.Services.AddScoped<INotificationStrategyService, PushNotificationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
