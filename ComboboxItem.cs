using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Okul
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public Tedarikci Value { get; set; }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
