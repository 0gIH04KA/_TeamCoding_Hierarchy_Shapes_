using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _02_03_2020_TeamCoding_Hierarchy_Shapes_
{
    class PositionY_InvalidException : Exception
    {
        public PositionY_InvalidException()
        {
        }

        public PositionY_InvalidException(string message) : base(message)
        {
        }

        public PositionY_InvalidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PositionY_InvalidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
