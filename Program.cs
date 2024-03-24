global using Ath_Thoyyibah_BE.Models;
global using Ath_Thoyyibah_BE.Models.DTO;
using Ath_Thoyyibah_BE.Data;
using Ath_Thoyyibah_BE.Services.AuthService;

//using KelasDigital.Services.AuthService;
//using KelasDigital.Services.ProspStudentService;
//using KelasDigital.Services.YearPeriodService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddDbContext<DataContext>();


var app = builder.Build();

ValueStorage.connectionStringDev = builder.Configuration["ConnectionStrings:Ath_Thoyyibah_BE"].ToString();
ValueStorage.messageAddSuccess = builder.Configuration["Message:AddSucces"];
ValueStorage.messageAddError = builder.Configuration["Message:AddError"];
ValueStorage.messageDataNotFound = builder.Configuration["Message:DataNotFound"];
ValueStorage.messageGetDateSucces = builder.Configuration["Message:GetDataSuccess"];
ValueStorage.tokenKey = builder.Configuration["AppSetting:TokenKey"];
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.UseAuthorization();

app.MapControllers();

app.Run();
