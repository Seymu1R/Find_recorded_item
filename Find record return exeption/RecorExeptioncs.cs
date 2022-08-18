using System;
using System.Collections.Generic;
using System.Text;

namespace Find_record_return_exeption
{
    internal class RecorExeption:Exception
    {
        public RecorExeption(string message):base(message)
        {
                
        }
    }
}
