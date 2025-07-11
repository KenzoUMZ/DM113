using System.ServiceModel.Channels;
using DM_113_SOAP_Producer.Services;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.  
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi  
builder.Services.AddOpenApi();
builder.Services.AddSingleton<IOrderService, OrderService>();

var app = builder.Build();

app.UseSoapEndpoint<IOrderService>("/Service.asmx", new SoapEncoderOptions());

// Configure the HTTP request pipeline.  
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseSoapEndpoint<IOrderService>(
    "/GameService.asmx",
    new SoapEncoderOptions()
    {
        MessageVersion = MessageVersion.Soap11 // or Soap12, depending on your needs
    }
);
app.Run();
