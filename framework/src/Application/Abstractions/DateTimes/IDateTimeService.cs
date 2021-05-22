using CoreBoilerplate.Application.Abstractions.DI;
using System;

namespace CoreBoilerplate.Application.Abstractions.DateTimes
{
    public interface IDateTimeService : IApplicationService
    {
        DateTime UtcNow { get; }
    }
}
