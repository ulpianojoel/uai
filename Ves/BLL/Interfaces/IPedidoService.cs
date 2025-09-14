using Ves.Domain.Entities;

namespace Ves.BLL.Interfaces;

public interface IPedidoService
{
    int Crear(Pedido p);
    void AgregarItem(Pedido p, PedidoDetalle item);
    void Confirmar(Pedido p);
}
