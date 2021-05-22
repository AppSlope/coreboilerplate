using CoreBoilerplate.Application.Abstractions.DateTimes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBoilerplate.Infrastructure.DateTimes
{
    public class SomeDateTimeService : IDateTimeService
    {
        public DateTime UtcNow => throw new NotImplementedException();
    }
}
