using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Entities
{
    class Award
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public override string ToString()
        {
            return ID + " "+ Title;
        }
    }
}
