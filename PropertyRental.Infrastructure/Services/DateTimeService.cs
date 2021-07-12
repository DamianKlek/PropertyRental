using PropertyRental.Application.Common.Interfaces;
using System;

namespace PropertyRental.Infrastructure.Services
{
	public class DateTimeService : IDateTime
	{
		public DateTime Now => DateTime.Now;
	}
}
