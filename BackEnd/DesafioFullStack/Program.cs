using Infra.Context;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Domain.Services.Interface;
using Domain.Services;
using Domain.AutoMapper;
using Infra.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DBContext>(op =>
{
    op.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
    op.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddScoped<IEmpresaRepository, EmpresaRepository>();
builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();

builder.Services.AddScoped<IEmpresaService, EmpresaService>();
builder.Services.AddScoped<IFornecedorService, FornecedorService>();

builder.Services.AddAutoMapper(typeof(DomainToViewModelMappingProfile));
builder.Services.AddAutoMapper(typeof(ViewModelToDomainMappingProfile));

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

app.UseAuthorization();

app.MapControllers();

app.Run();
