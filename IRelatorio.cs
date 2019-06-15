using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace study_aspnet
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}
