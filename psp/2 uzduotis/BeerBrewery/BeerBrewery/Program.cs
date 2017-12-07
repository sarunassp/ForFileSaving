using System;
using Autofac;
using BeerBrewery.Entities;
using BeerBrewery.Repositories;

namespace BeerBrewery
{
    internal class Program
    {
        public static void Main (string[] args)
        {
            var builder = new ContainerBuilder ();

            builder.RegisterEntities ();
            builder.RegisterRepositories ();
            builder.RegisterServices ();
            builder.RegisterControllers ();

            builder.Build ();
            
            Console.WriteLine ("success");
        }
    }

    internal static class BuilderThings
    {
        public static void RegisterEntities (this ContainerBuilder builder)
        {
            builder.RegisterType<BeerImplementationA> ().Named<IBeer> ("beerA");
            builder.RegisterType<BeerImplementationB> ().Named<IBeer> ("beerB");
            
            builder.RegisterType<BrewingMaterialImplementationA> ().Named<IBrewingMaterial> ("materialA");
            builder.RegisterType<BrewingMaterialImplementationB> ().Named<IBrewingMaterial> ("materialB");
            
            builder.RegisterType<StorageImplementationA> ().Named<IStorage> ("storageA");
            builder.RegisterType<StorageImplementationB> ().Named<IStorage> ("storageB");
            
            builder.RegisterType<TreasuryImplementationA> ().Named<ITreasury> ("treasuryA");
            builder.RegisterType<TreasuryImplementationB> ().Named<ITreasury> ("treasuryB");
        }
        
        public static void RegisterRepositories (this ContainerBuilder builder)
        {
            
        }

        public static void RegisterServices (this ContainerBuilder builder)
        {
            
        }
        
        public static void RegisterControllers (this ContainerBuilder builder)
        {
            
        }
    }
}