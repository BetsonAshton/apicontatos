using ApiContatos.Application.Interfaces;
using ApiContatos.Application.Services;
using ApiContatos.Data.Repositories;
using ApiContatos.Domain.Interfaces.Repositories;
using ApiContatos.Domain.Interfaces.Services;
using ApiContatos.Domain.Services;

namespace ApiContatos.Services.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IContatoAppService, ContatoAppService>();
            services.AddTransient<IContatoDomainService, ContatoDomainService>();
            services.AddTransient<IContatoRepository, ContatoRepository>();



            return services;
        }
    }
}
