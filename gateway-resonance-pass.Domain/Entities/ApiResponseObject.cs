namespace gateway_resonance_pass.Domain.Entities
{
    public class ApiResponseObject<T>
    {
        public T Data { get; set; }
        public MetaData Meta { get; set; }
    }
}
