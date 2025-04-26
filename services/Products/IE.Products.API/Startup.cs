using IE.Products.Application.Queries;
using IE.Products.Application.Commands;
using IE.Products.Application.Interfaces;
using IE.Products.Application.Mapping;
using IE.Products.Application.Services;
using IE.Products.Infrastructure.Data;
using IE.Products.Interfaces;
using IE.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IE.Products.API
{
    public class Startup(IConfiguration configuration)
    {
        public string ConnectionString = configuration.GetConnectionString("Default");
        public IConfiguration Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson();
            services.AddControllers().AddNewtonsoftJson();
            services.AddAutoMapper(cfg => cfg.AddProfile<ConfigMapper>());
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IProductService, ProductService>();
            services.AddDbContext<AppDbContext>();

            this.ConfigureCors(services);
            this.ConfigureMediatR(services);
        }

        public void ConfigureCors(IServiceCollection services)
        {
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });
        }

        public void ConfigureMediatR(IServiceCollection services)
        {
            // services.AddValidatorsFromAssemblyContaining<CreateUserCommandValidator>();
            // services.AddFluentValidationAutoValidation();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CreateProductCommand>());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<GetAllProductQuery>());
        }
    }
}
