using Ves.Domain.Entities;

namespace Ves.DAL.Interfaces;

public interface IPedidoRepository
{
    int Add(Pedido p);
    Pedido? Get(int id);
    void Update(Pedido p);
}
