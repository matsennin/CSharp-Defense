using System;
using System.Runtime.Serialization;

namespace APM.Utilities
{
    // Usar SERIALIZABLE para propagar exceções do SERVER para o CLIENT
    [Serializable()]
    public class DiscountNotFoundException : Exception
    {
        public DiscountNotFoundException() : base()
        {

        }

        public DiscountNotFoundException(string message) : base(message)
        {

        }

        public DiscountNotFoundException(string message, Exception inner) : base(message, inner)
        {

        }

        // Para propagar exceções do SERVER para o CLIENT
        protected DiscountNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
