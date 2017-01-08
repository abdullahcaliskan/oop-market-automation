using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Okul
{
    public interface IEklenebilen
    {
        string ListeEkle<T>(List<T> Param_List, T Param_Val);
    }
}
