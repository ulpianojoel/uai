using Ves.Domain.Entities;

namespace Ves.DAL.Interfaces;

public interface IProductoRepository
{
    Producto? Get(int id);
    void Save(Producto p);
    void UpdateStock(int productoId, int delta);
}
