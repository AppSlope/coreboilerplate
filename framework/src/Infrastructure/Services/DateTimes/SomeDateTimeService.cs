using CoreBoilerplate.Application.Abstractions.DateTimes;
using System;

namespace CoreBoilerplate.Infrastructure.Services.DateTimes
{
    public class SomeDateTimeService : IDateTimeService
    {
        public DateTime UtcNow => throw new NotImplementedException();
    }
}