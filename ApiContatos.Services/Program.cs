using ApiContatos.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDependencyInjection();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddCors(
          config => config.AddPolicy("DefaultPolicy", builder =>
          {
              builder.AllowAnyOrigin() //qualquer dominio poderá acessar a API
                     .AllowAnyMethod() //permitir POST, PUT, DELETE, GET
                     .AllowAnyHeader(); //aceitar parametros de cabeçalho de requisição
          })
          );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseCors("DefaultPolicy");

app.MapControllers();

app.Run();
