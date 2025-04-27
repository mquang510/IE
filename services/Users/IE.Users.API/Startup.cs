using FluentValidation;
using FluentValidation.AspNetCore;
using IE.Shared.Interfaces;
using IE.Users.Application.Commands;
using IE.Users.Application.Data;
using IE.Users.Application.Interfaces;
using IE.Users.Application.Mapping;
using IE.Users.Application.Queries;
using IE.Users.Application.Validators;
using IE.Users.Domain.Interfaces;
using IE.Users.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using IE.Shared.Constants;

namespace IE.Users.API
{
    public class Startup(IConfiguration configuration)
    {
        public string ConnectionString = configuration.GetConnectionString("Default");
        public IConfiguration Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddControllers().AddNewtonsoftJson();
            services.AddAutoMapper(cfg => cfg.AddProfile<ConfigMapper>());
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<AppDbContext>();

            this.ConfigureCors(services);
            this.ConfigureMediatR(services);
            this.ConfigureJwt(services);
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
            services.AddValidatorsFromAssemblyContaining<CreateUserCommandValidator>();
            services.AddFluentValidationAutoValidation();
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CreateUserCommand>());
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<GetAllUserQuery>());
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<GetUserLoginQuery>());
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<GetUserByIdQuery>());
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<GetUserByEmailQuery>());

            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(CreateUserCommand).Assembly);
            });
        }

        public void ConfigureJwt(IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
              .AddJwtBearer(options =>
              {
                  options.TokenValidationParameters = new TokenValidationParameters
                  {
                      ValidateIssuer = true,
                      ValidateAudience = true,
                      ValidateLifetime = true,
                      ValidateIssuerSigningKey = true,
                      ValidIssuer = JwtAppConstants.Issuer,
                      ValidAudience = JwtAppConstants.Audience,
                      IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtAppConstants.PrivateKey))
                  };
              })
              .AddCookie(options => {
                  options.ExpireTimeSpan = TimeSpan.FromHours(JwtAppConstants.ExpiredHour);
              });
        }
    }
}
