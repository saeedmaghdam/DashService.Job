using DashService.Job.Framework;
using DashService.Logger;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DashService.Job
{
    public abstract class JobBase : IJob
    {
        private readonly ILogger _logger;

        public ILogger Logger => _logger;

        public virtual string Name => throw new NotImplementedException();

        public virtual string Description => throw new NotImplementedException();

        public virtual string Version => throw new NotImplementedException();

        public JobBase(ILogger logger)
        {
            _logger = logger;
        }

        public virtual Task StartAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public virtual Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
