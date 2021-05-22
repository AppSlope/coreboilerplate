using CoreBoilerplate.Application.Abstractions.DateTimes;
using System;

namespace CoreBoilerplate.Infrastructure.DateTimes
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
