using Ves.Domain.Entities;

namespace Ves.BLL.Interfaces;

public interface IProductoService
{
    int Crear(Producto p);
    void Editar(Producto p);
    void Baja(Producto p);
}
