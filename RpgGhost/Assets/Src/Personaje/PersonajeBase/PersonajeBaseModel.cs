using UnityEngine;
using UnityEngine.AI;

namespace Assets.Src.Personaje.PersonajeBase
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(NavMeshAgent))]
    public abstract class PersonajeBaseModel : MonoBehaviour
    {
        protected string nombre;

        public abstract void Correr(
            NavMeshAgent navMeshAgent,
            Vector3 objetivo
        );
    }
}
