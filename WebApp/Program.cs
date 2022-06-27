using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Plugins.Datastor.SQL;
using Plugins.DataStore.InMemory;
using UseCases;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;
using WebApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

// configuration for the SQL db
builder.Services.AddDbContext<MarketContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// dependency injection for in memory 
builder.Services.AddScoped<ICategoryRepository , CategoryInMemoryRepository>();
builder.Services.AddScoped<IProductRepository , ProductInMemoryRepository>();
builder.Services.AddScoped<ITransactionRepository , TransactionInMemoryRepository>();

// dependency injection for the use case and Repository
builder.Services.AddTransient<IViewCategoriesUseCases, ViewCategoriesUseCases>();
builder.Services.AddTransient<IAddCategoryUseCase, AddCategoryUseCase>();
builder.Services.AddTransient<IEditCategoryUseCse, EditCategoryUseCase>();
builder.Services.AddTransient<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();
builder.Services.AddTransient<IDeleteCategoryByIdUseCase, DeleteCategoryByIdUseCase>();
builder.Services.AddTransient<IViewProductUseCase, ViewProductUseCases>();
builder.Services.AddTransient<IAddProductUseCase, AddProductUseCase>();
builder.Services.AddTransient<IUpdateProductUseCase, UpdateProductUseCase>();
builder.Services.AddTransient<IGetProductByIdUseCase, GetProductByIdUseCase>();
builder.Services.AddTransient<IDeleteProductUseCase, DeleteProductUseCase>();
builder.Services.AddTransient<IViewProductsByCategoryId, ViewProductsByCategoryId>();
builder.Services.AddTransient<ISellProductUseCase, SellProductUseCase>();
builder.Services.AddTransient<IRecordTransactionUseCase, RecordTransactionUseCase>();
builder.Services.AddTransient<IGetTodayTransactionsUseCase, GetTodayTransactionsUseCase>();
builder.Services.AddTransient<IGetTransactionReportUseCase, GetTransactionReportUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();