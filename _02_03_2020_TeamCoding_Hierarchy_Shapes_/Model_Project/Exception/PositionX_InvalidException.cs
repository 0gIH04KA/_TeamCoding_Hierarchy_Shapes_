using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _02_03_2020_TeamCoding_Hierarchy_Shapes_
{
    class PositionX_InvalidException : Exception
    {
        public PositionX_InvalidException()
        {
        }

        public PositionX_InvalidException(string message) : base(message)
        {
        }

        public PositionX_InvalidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PositionX_InvalidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
