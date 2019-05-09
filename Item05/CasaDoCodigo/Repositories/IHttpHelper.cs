using System.Threading.Tasks;
using CasaDoCodigo.Models;
using Microsoft.Extensions.Configuration;

namespace CasaDoCodigo
{
    public interface IHttpHelper
    {
        IConfiguration Configuration { get; }
        int? GetPedidoId(string clienteId);
        void SetPedidoId(string clienteId, int pedidoId);
        void ResetPedidoId(string clienteId);
        void SetCadastro(string clienteId, Cadastro cadastro);
        Cadastro GetCadastro(string clienteId);
    }
}