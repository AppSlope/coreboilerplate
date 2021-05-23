using CoreBoilerplate.Application.Abstractions.DateTimes;
using System;

namespace CoreBoilerplate.Infrastructure.Services.DateTimes
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}