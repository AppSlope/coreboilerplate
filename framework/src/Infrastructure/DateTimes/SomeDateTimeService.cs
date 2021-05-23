using CoreBoilerplate.Application.Abstractions.DateTimes;
using System;

namespace CoreBoilerplate.Infrastructure.DateTimes
{
    public class SomeDateTimeService : IDateTimeService
    {
        public DateTime UtcNow => throw new NotImplementedException();
    }
}