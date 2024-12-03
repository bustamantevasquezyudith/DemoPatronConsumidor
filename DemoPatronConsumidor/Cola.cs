using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronConsumidor
{
    public class Cola<T>
    {
        private int capacidadMaxima;
        private Queue<T> cola = new Queue<T>();
        private object lockObjeto = new object();

        public Cola(int capacidad)
        {
            capacidadMaxima = capacidad;
        }
        public void Agregar(T iten)
        {
            lock (lockObjeto)
            {
                while (cola.Count > capacidadMaxima)
                {
                    Monitor.Wait(lockObjeto);
                }
                cola.Enqueue(iten);
                Monitor.Wait(lockObjeto);
            }

        }
        public T Extraer()
        {
            lock (lockObjeto)
            {
                while (cola.Count == 0)
                {
                    Monitor.Wait(lockObjeto);
                }
                T iten = cola.Dequeue();
                Monitor.Pulse(lockObjeto);
                return iten;

            }
        }
    }
}