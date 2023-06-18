using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Src.Personaje.PersonajeBase
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(NavMeshAgent))]
    public abstract class PersonajeBaseModel
    {
        protected string nombre;

        public abstract void Correr(
            NavMeshAgent navMeshAgent,
            Animator animator,
            AudioSource audioRun,
            Input input,
            float velocidadPj,
            bool isRun
        );
    }
}
