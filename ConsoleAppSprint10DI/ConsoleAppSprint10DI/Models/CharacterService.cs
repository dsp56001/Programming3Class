using Microsoft.Extensions.DependencyInjection;

namespace ConsoleAppSprint10DI.Models
{
    public class CharacterService
    {
        IServiceCollection serviceCollection;
        public ServiceProvider ServiceProvider;

        public CharacterService()
        {
            serviceCollection = new ServiceCollection();

            //No property injection
            //serviceCollection.AddScoped<Samurai>().AddScoped<IWeapon, Katana>();
            //serviceCollection.AddScoped<Ninja>().AddScoped<IWeapon, Sword>();
            serviceCollection.AddScoped<IWeapon, Katana>();
            serviceCollection.AddScoped<Character, Samuri>();
            serviceCollection.AddScoped<ICharacter, Samuri>();

            ServiceProvider = serviceCollection.BuildServiceProvider();

        }
    }
}
