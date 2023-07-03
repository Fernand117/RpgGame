using System;
using System.Collections.Generic;
using Assets.Src.Personaje.ListaPersonajes;
using Assets.Src.Personaje.PersonajeBase;

namespace Src.Personaje
{
    public class PersonajeFactory
    {
        private static Dictionary<string, PersonajeBaseModel> personajes = new Dictionary<string, PersonajeBaseModel>();

        public static PersonajeBaseModel ObtenerPersonaje(string tipo)
        {
            if (!personajes.ContainsKey(tipo))
            {
                switch (tipo)
                {
                    case "DamaNegra":
                        personajes[tipo] = new DamaNegra();
                        break;
                    default:
                        throw new ArgumentException("Tipo de personaje no válido");
                }
            }

            return personajes[tipo];
        }
    }
}