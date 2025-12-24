using CarBook.WebApi.Repositories;
using CarBook.WebApiPersistance.Repositories.CarRepository;
using CarBookPersistence.Context;
using CarBoorApplication.Features.CQRS.Handles.AboutHandlers;
using CarBoorApplication.Features.CQRS.Handles.BannerHandlers;
using CarBoorApplication.Features.CQRS.Handles.BrandHandlers;
using CarBoorApplication.Features.CQRS.Handles.CarHandler;
using CarBoorApplication.Features.CQRS.Handles.CategoryHandlers;
using CarBoorApplication.Features.CQRS.Handles.ContacHandlers;
using CarBoorApplication.Interfaces;
using CarBoorApplication.Interfaces.CarInterfaces;
using CarBoorApplication.Services;

var builder = WebApplication.CreateBuilder(args);

// DbContext
builder.Services.AddScoped<CarbookContext>();

// Generic Repository
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// Car Repository
builder.Services.AddScoped<ICarRepository, CarRepository>();

// About
builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetAboutByIdQuaryHandler>();
builder.Services.AddScoped<CreatAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();

// Banner
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<GetBannerQuaryHandlers>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<UpdataBannerCommandHandler>();
builder.Services.AddScoped<RemoverBannerCommandHandler>();

// Brand
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();

// Car
builder.Services.AddScoped<GetCarByIdQuaryHandlers>();
builder.Services.AddScoped<GetCarQuaryHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<UpdateCarCommandHandle>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
builder.Services.AddScoped<GetCarWithQuaryHandler>(); //
                                                      //
 //Categories                                                     //✔ Doğru şekilde ekli

builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();

//contact
builder.Services.AddScoped<CreateContacCommandHandler>();
builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();


builder.Services.AddApplicationService(builder.Configuration);



builder.Services.AddControllers();

// Swagger
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
