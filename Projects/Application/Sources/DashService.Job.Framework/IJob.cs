using System.Threading.Tasks;

namespace DashService.Job.Framework
{
    public interface IJob
    {
        Task ExecuteAsync();
    }
}
