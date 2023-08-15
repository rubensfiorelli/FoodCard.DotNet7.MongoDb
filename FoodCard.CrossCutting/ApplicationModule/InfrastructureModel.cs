using FoodCard.Application.Services;
using FoodCard.Application.Services.Interfaces;
using FoodCard.CrossCutting.MongoDb;
using FoodCard.Data.DbSeed;
using FoodCard.Data.Repositories;
using FoodCard.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FoodCard.CrossCutting.ApplicationModule
{
    public static class InfrastructureModel
    {
        public static IServiceCollection AddInfrastrucuture(this IServiceCollection services)
        {
            services
                .AddMongo()
                .AddServicesAndRepositories();

            return services;
        }

        public static IServiceCollection AddMongo(this IServiceCollection services)
        {
            services.AddSingleton(options =>
            {

                var configuration = options.GetService<IConfiguration>();
                var opts = new MongoDbOptions();

                configuration.GetSection("Mongo").Bind(opts);

                return (MongoDbOptions)options;

            });

            services.AddSingleton<IMongoClient>(options =>
            {
                var configuration = options.GetService<IConfiguration>();
                var opts = new MongoDbOptions();



                return new MongoClient(opts.ConnectionString);
            });

            services.AddTransient(options =>
            {
                BsonDefaults.GuidRepresentation = GuidRepresentation.Standard;

                var opts = options.GetService<MongoDbOptions>();
                var mongoClient = options.GetService<IMongoClient>();


                var db = mongoClient.GetDatabase(opts.DatabaseName);

                var dbSeed = new DbSeed(db);
                dbSeed.Populate();


                return db;

            });

            return services;
        }

        private static IServiceCollection AddServicesAndRepositories(this IServiceCollection services)
        {
            services
                .AddScoped(typeof(IFoodCardOrderRepository), typeof(FoodCardOrderRepository))
                .AddScoped(typeof(IFoodCardServiceRepository), typeof(FoodCardServiceRepository))
                .AddScoped(typeof(IFoodCardOrderService), typeof(FoodCardOrderService))
                .AddScoped(typeof(IFoodCardServiceService), typeof(FoodCardServiceService));

            return services;
        }

    }
}
