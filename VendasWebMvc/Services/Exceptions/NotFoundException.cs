using System;

namespace VendasWebMvc.Services.Exceptions
{
    public class AplicationException : ApplicationException
    {
        public AplicationException(string message) : base(message)
        {

        }
    }
}
