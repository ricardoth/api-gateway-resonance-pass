﻿namespace gateway_resonance_pass.Application.Decimatio.Queries.Comunas.Get
{
    public class GetComunaGroupQueryResult
    {
        public int IdComuna { get; set; }
        public int IdRegion { get; set; }
        public string? NombreComuna { get; set; }
        public bool Activo { get; set; }
    }
}
