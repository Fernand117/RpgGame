using Assets.Src.Hechizos.HechizoBase;
using Assets.Src.Hechizos.ListaHechizos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Hechizos
{
    public static class HechizoFactory
    {
        private static Dictionary<string, SpellBase> hechizos = new Dictionary<string, SpellBase>();

        public static SpellBase ObtenerHechizo(string tipo)
        {
            if(!hechizos.ContainsKey(tipo))
            {
                switch(tipo)
                {
                    case "Fuego":
                        hechizos[tipo] = new HechizoFuego();
                        break;
                    default:
                        throw new ArgumentException("Tipo de hechizo no válido");
                }
            }

            return hechizos[tipo];
        }
    }
}
