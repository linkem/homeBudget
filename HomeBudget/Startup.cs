using HomeBudget.BussinesLogic;
using HomeBudget.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using FluentValidation;
using HomeBudget.Models.Bills;
using HomeBudget.Validations;
using System;
using System.Collections.Generic;
using HomeBudget.Configuration;

namespace HomeBudget
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseInMemoryDatabase("myDB"));

            services.AddTransient<IBillsService, BillsService>();
            services.AddTransient<IPeopleService, PeopleService>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new PathString("/Account/Login");
                    options.AccessDeniedPath = new PathString("/account/forbidden");
                });
            services.AddIdentity<UserEntity, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation();

            services.AddTransient<IValidator<AddBillViewModel>, AddBillViewModelValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            InitAccountsData(serviceProvider);
            InitTestData(serviceProvider);
        }

        private void InitAccountsData(IServiceProvider serviceProvider)
        {
            var _userManager = serviceProvider.GetRequiredService<UserManager<UserEntity>>();
            List<DefaultUserConfiguration> defaultUsers = new List<DefaultUserConfiguration>();


            Configuration.Bind("DefaultUsers", defaultUsers);
            foreach (var user in defaultUsers)
            {
                var admnAlreadyExists = _userManager.FindByNameAsync(user.UserName).GetAwaiter().GetResult();
                if (admnAlreadyExists != null)
                    continue;

                var entityUser = new UserEntity { UserName = user.UserName };
                var createUserResponse = _userManager.CreateAsync(entityUser, user.Password).GetAwaiter().GetResult();
                if (!createUserResponse.Succeeded)
                    throw new Exception($"Creating user: {user.UserName} finished unssuccesfully");
            }
        }

        private void InitTestData(IServiceProvider serviceProvider)
        {
            var dbContext = serviceProvider.GetRequiredService<ApplicationDbContext>();
            var relations = new[]
            {
                new RelationEntity{RelationId = 1 , Description = "Father" },
                new RelationEntity{RelationId = 2, Description = "Mother" },
                new RelationEntity{RelationId = 3, Description = "Son" },
                new RelationEntity{RelationId = 4, Description = "Daughter"}
            };
            dbContext.Relations.AddRange(relations);

            var people = new[]
{
                new PersonEntity{PersonId = 1, Description = "Girl",Name = "Emily", RelationId = 4 },
                new PersonEntity{PersonId = 2, Description = "head of family", Name = "Bob", RelationId = 1}
            };
            dbContext.People.AddRange(people);

            var bills = new[]
            {
                new BillEntity {BillId = 1, Description = "TV", Amount = 3999.99f, CreatedBy = "Emily", CreatedDate = DateTime.Now, PersonId = 1, BillDate = new DateTime(2019,3,4)},
                new BillEntity {BillId = 2, Description = "Washer", Amount = 1000f, CreatedBy = "Emily", CreatedDate = DateTime.Now, PersonId = 1, BillDate = new DateTime(2019,1,25)},
                new BillEntity {BillId = 3, Description = "Audio SYstem", Amount = 5999.00f, CreatedBy = "Emily", CreatedDate = DateTime.Now, PersonId = 1, BillDate = new DateTime(2019,2,10)},
                new BillEntity {BillId = 4, Description = "Groseriec", Amount = 30f, CreatedBy = "Bob", CreatedDate = DateTime.Now, PersonId = 2, BillDate = new DateTime(2019,5,15)},
                new BillEntity {BillId = 5, Description = "Food", Amount = 100f, CreatedBy = "Bob", CreatedDate = DateTime.Now, PersonId = 2, BillDate = new DateTime(2019,5,6)},
                new BillEntity {BillId = 6, Description = "Beer", Amount = 15f, CreatedBy = "Bob", CreatedDate = DateTime.Now, PersonId = 2, BillDate = new DateTime(2019,5,9)}
            };
            dbContext.Bills.AddRange(bills);
            dbContext.SaveChanges();
        }
    }
}
