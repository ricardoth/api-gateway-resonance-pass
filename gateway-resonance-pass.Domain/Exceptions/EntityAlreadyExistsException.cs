namespace gateway_resonance_pass.Domain.Exceptions
{
    [ExcludeFromCodeCoverage]
    public class EntityAlreadyExistsException : Exception
    {
        public EntityAlreadyExistsException()
        {
        }

        public EntityAlreadyExistsException(string message) : base(message)
        {
        }

        public EntityAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public EntityAlreadyExistsException(string name, object[] keys) : base($"Entity \"{name}\" ({string.Join(",", keys)} already exists")
        {
            
        }
    }
}
