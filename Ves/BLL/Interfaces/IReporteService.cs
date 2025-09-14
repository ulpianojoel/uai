using System;
using System.Collections.Generic;
using Ves.Domain.Entities;

namespace Ves.BLL.Interfaces;

public interface IReporteService
{
    IList<Venta> ObtenerVentas(DateTime desde, DateTime hasta);
}
