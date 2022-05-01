using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;


namespace TestWeelo.WebExceptions
{
    public interface IExceptionHandler
    {
        Task Handle(ExceptionContext context);
    }
}
