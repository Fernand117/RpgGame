using Assets.Src.Personaje.PersonajeBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Src.Personaje.ListaPersonajes
{
    public class DamaNegra : PersonajeBaseModel
    {
        public DamaNegra()
        {
            nombre = "La Dama Negra";
        }

        public override void Correr(NavMeshAgent navMeshAgent, Animator animator, AudioSource audioRun, Input input, float velocidadPj, bool isRun)
        {
        }
    }
}
