namespace gateway_resonance_pass.Domain.Entities
{
    public class ApiResponse<T>
    {
        public List<T> Data { get; set; }
        public MetaData Meta { get; set; }
    }
}
