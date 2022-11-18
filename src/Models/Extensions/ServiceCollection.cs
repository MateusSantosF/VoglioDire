using Microsoft.Extensions.DependencyInjection;
using VoglioDire.Api.src.Facades;
using VoglioDire.Api.src.Facades.Interfaces;
using VoglioDire.Api.src.Factory;
using VoglioDire.Api.src.Factory.Interfaces;
using VoglioDire.Api.src.Services;
using VoglioDire.Api.src.Services.Interfaces;

namespace VoglioDire.Api.src.Models.Extensions
{
    public static class ServiceCollection
    {
        public static void ResolveDependencies(this IServiceCollection serviceProvider)
        {
            serviceProvider.AddScoped<IEmailFacade, EmailFacade>();
            serviceProvider.AddScoped<IEmailService, EmailService>();
            serviceProvider.AddScoped<IMailFactory, MailFactory>();
        }
    }
}
