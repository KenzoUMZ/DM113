
using DM_113_SOAP_Consumer.Controller;
using GameServiceSoap;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var soapController = new GameServiceSoapController();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/orders", async (Order orders) =>
{
    var msg = await soapController.CreateOrderAsync(orders);
    return Results.Ok(msg);
});

app.MapGet("/orders/{id:int}", async (int id) =>
{
    var order = await soapController.GetOrderAsync(id);
    return order is not null ? Results.Ok(order) : Results.NotFound();
});

app.MapGet("/orders", async () =>
{
    var orders = await soapController.GetAllOrdersAsync();
    return Results.Ok(orders);
});

app.MapPut("/orders/{id:int}/status", async (int id, string newStatus) =>
{
    var msg = await soapController.UpdateOrderStatusAsync(id, newStatus);
    return Results.Ok(msg);
});

app.MapDelete("/orders/{id:int}", async (int id) =>
{
    var msg = await soapController.DeleteOrderAsync(id);
    return Results.Ok(msg);
});

app.Run();

