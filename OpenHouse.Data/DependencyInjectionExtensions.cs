using Microsoft.Practices.Unity;
using OpenHouse.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse.Data
{
    public static class DependencyInjectionExtensions
    {
        public static void RegisterData(this IUnityContainer container)
        {
            container.RegisterType<DbContext, FifaLeagueContext>();
            container.RegisterType<IMatchesRepository, MatchesRepository>();
        }
    }
}
