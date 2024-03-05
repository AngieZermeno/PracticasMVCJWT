using System;
using System.Collections.Generic;

namespace ApiJWT.Entities;

public partial class Maestro
{
    public int? Id{ get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Cedula { get; set; }

    public int? Edad { get; set; }

    public int Estatus { get; set; }
}
