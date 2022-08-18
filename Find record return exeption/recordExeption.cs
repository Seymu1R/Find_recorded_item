using System;
using System.Runtime.Serialization;

namespace Find_record_return_exeption
{
    [Serializable]
    internal class recordExeption : Exception
    {
        public recordExeption()
        {
        }

        public recordExeption(string message) : base(message)
        {
        }

        public recordExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected recordExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}