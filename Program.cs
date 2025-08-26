/*Kasey Sanderson 
 COP 2839 - Assignment Week 2
Collaborators: learn.microsoft.com and
"Arcitecting Modern Web Applications.." by
Steve "ardalis" Smith*/

using ksanderson_week2.Services;

var builder = WebApplication.CreateBuilder(args);

//register srvices 

builder.Services.AddSingleton<ICalculator, Calculator>();

//controllers
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
