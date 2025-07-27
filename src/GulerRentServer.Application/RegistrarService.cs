using FluentValidation;
using GulerRentServer.Application.Behaviors;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GulerRentServer.Application
{
    public static class RegistrarService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfr =>
            {
                cfr.RegisterServicesFromAssembly(typeof(RegistrarService).Assembly);
                cfr.AddOpenBehavior(typeof(ValidationBehavior<,>));
                cfr.AddOpenBehavior(typeof(PermissionBehavior<,>));
            });
            services.AddValidatorsFromAssembly(typeof(RegistrarService).Assembly);
           
            return services;
        }
    }
}
