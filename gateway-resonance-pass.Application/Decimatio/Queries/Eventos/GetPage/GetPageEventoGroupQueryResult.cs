﻿namespace gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetPage
{
    public class GetPageEventoGroupQueryResult : IRequest<ApiResponse<GetPageEventoGroupQueryResult>>
    {
        public long IdEvento { get; set; }
        public int IdLugar { get; set; }
        public string NombreEvento { get; set; }
        public string? Descripcion { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha { get; set; }
        public string? Flyer { get; set; }
        public string? ContenidoFlyer { get; set; }
        public string? Observacion { get; set; }
        public string? ProductoraResponsable { get; set; }
        public bool? Banner { get; set; }
        public string? ContenidoBanner { get; set; }
        public bool? Activo { get; set; }
        //public LugarDto? Lugar { get; set; }
    }
}