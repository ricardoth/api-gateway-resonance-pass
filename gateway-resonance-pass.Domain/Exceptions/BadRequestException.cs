namespace gateway_resonance_pass.Domain.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException()
        {

        }

        public BadRequestException(string mensaje) : base(mensaje)
        {

        }
    }
}
