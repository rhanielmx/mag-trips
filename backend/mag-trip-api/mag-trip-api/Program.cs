using mag_trip_api.DTOs;
using mag_trip_api.Interfaces;
using mag_trip_api.Mapping;
using mag_trip_api.REST;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ILocalService, LocalService>();
builder.Services.AddSingleton<IOpenTripApi, OpenTripAPI>();

builder.Services.AddAutoMapper(typeof(LocalMapping));

builder.Services.AddCors(options =>
{
      options.AddPolicy("DevPolicy",
        policy =>
        {
            policy.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
        });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
