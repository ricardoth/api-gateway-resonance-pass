namespace gateway_resonance_pass.Application.Decimatio.Queries.Regiones.Get
{
    public class GetRegionGroupQueryResult
    {
        public int IdRegion { get; set; }
        public int NumeroRegion { get; set; }
        public string? Abreviatura { get; set; }
        public string? NombreRegion { get; set; }
        public bool Activo { get; set; }
    }
}
