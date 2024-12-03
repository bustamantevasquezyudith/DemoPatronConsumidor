using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronConsumidor
{
    public class Productor
    {
        private Cola<Usuario> _cola;

        public Productor(Cola<Usuario>cola)
        {
            _cola = cola;   
        }
        public void producir(Usuario item)
        {
            _cola .Agregar(item);
        }
    }
}
