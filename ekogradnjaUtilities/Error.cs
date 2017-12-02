using System;
using System.Collections.Generic;
using System.Text;

namespace ekogradnjaUtilities
{
    public enum ErrorType : byte
    {
        Info, Warning, Stop
    }

    public class Error:ApplicationException
    {
        public ErrorType Type;
        public string Message;

        public Error(ErrorType type, string m)
            : base(m)
        {
            Type = type;
            Message = m;
        }
    }
}
