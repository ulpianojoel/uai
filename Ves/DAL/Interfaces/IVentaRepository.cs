using System;
using System.Collections.Generic;
using Ves.Domain.Entities;

namespace Ves.DAL.Interfaces;

public interface IVentaRepository
{
    IList<Venta> GetVentasByDate(DateTime desde, DateTime hasta);
}
