using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data_Access;
using AutoMapper;
using RecipeApp.Business_Logic.DTO;
using RecipeApp.Data_Access.EFcore.Repositories;
using RecipeApp.Data_Access.Interfaces;
using RecipeApp.Data_Access.Models;
using RecipeApp.Business_Logic.Interfaces;
using RecipeApp.Business_Logic.Services;
using RecipeApp.Pages;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace RecipeApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddRazorPagesOptions(options =>
            {
                options.Conventions.AllowAnonymousToPage("/Index");
            });
            services.AddControllers();

            
            //services.AddSwaggerGen(c => c.SwaggerDoc(name: "v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "RecipeApp API", Version = "v1"}));

            
            services.AddEntityFrameworkNpgsql().AddDbContext<RecipeApp.Data_Access.EFcore.RecipeAppWebApiContext>(optionsAction: opt =>
            opt.UseNpgsql(Configuration.GetConnectionString(name: "RecipeAppWebApiContext")));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => //CookieAuthenticationOptions
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Login");
                });

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IRepository<Recipe>, RecipeRep>();
            services.AddScoped<IRepository<Recipe_Ingredient>, Recipe_IngredientRepo>();
            services.AddScoped<IRepository<Recipe_Type>, Recipe_TypesRepo>();
            services.AddScoped<IRepository<Ingredient>, IngredientRepo>();
            services.AddScoped<IRepository<RecipeApp.Data_Access.Models.Type>, TypesRepo>();
            services.AddScoped<IUserRepository, UsersRepo>();

            services.AddScoped<IUnitOfWork, EFUnitOfwork>();

            services.AddScoped<IRecipeService, RecipeServices>();
            services.AddScoped<ITypesService, TypesService>();
            services.AddScoped<IIngredientService, IngredientService>();
            services.AddScoped<IRecipe_TypeService, Recipe_TypeService>();
            services.AddScoped<IRecipe_IngredientService, Recipe_IngredientService>();
            services.AddScoped<IUserService, UserService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseSwagger();

            //app.UseSwaggerUI(c => c.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "RecipeApp API v1")) ;

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();//MapSwagger();
            });
        }
    }
}
