using System;
using System.Runtime.Serialization;

namespace Darkenstone
{
    public class DeadException: Exception, ISerializable
    {
        public DeadException(): base() { }

        public DeadException(string message): base(message) { }

        public DeadException(string message, Exception innerException):
            base(message, innerException) { }

        protected DeadException(SerializationInfo info, StreamingContext context):
            base(info, context) { }
    }
}
