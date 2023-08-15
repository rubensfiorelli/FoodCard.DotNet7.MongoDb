//using FoodCard.Application.Services;
//using FoodCard.Application.Services.Interfaces;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//namespace FoodCard.CrossCutting.ApplicationModule
//{
//    public static class ApplicationModule
//    {
//        public static IServiceCollection AddApllication(this IServiceCollection services, IConfiguration configuration)
//        {

//            services
//                .AddApplicationServices();

//            return services;
//        }

//        private static IServiceCollection AddApplicationServices(this IServiceCollection services)
//        {
//            services
//                .AddScoped(typeof(IFoodCardOrderService), typeof(FoodCardOrderService))
//                .AddScoped(typeof(IFoodCardServiceService), typeof(FoodCardServiceService));

//            return services;
//        }

//        //private static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
//        //{
//        //    services
//        //        .AddRepositories();

//        //    services.AddDbContext<ApplicationDbContext>(opts => opts
//        //            .UseMySql(configuration.GetConnectionString("DbConnection"),
//        //             ServerVersion.AutoDetect(configuration.GetConnectionString("DbConnection")),
//        //             b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

//        //    return services;

//        //}

//    }
//}
