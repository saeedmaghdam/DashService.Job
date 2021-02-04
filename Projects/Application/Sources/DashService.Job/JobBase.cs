using DashService.Logger;
using System;

namespace DashService.Job
{
    public abstract class JobBase
    {
        private readonly ILogger _logger;
        private readonly Guid _uniqueId;

        public ILogger Logger => _logger;

        public Guid UniqueId => _uniqueId;

        public virtual string Name => throw new NotImplementedException();

        public virtual string Description => throw new NotImplementedException();

        public virtual string Version => throw new NotImplementedException();

        public JobBase(ILogger logger)
        {
            _logger = logger;
            _uniqueId = new Guid();
        }
    }
}
