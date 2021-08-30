using FluentValidation;
using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.DependencyInjection;
using PropertyRental.Application.Common.Behaviours;
using System.Reflection;

namespace PropertyRental.Application
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddApplication(this IServiceCollection services)
		{
			services.AddMediatR(Assembly.GetExecutingAssembly());
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
			services.AddTransient(typeof(IRequestPreProcessor<>), typeof(LoggingBehaviour<>));
			services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
			return services;
		}

	}
}
