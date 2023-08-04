﻿using Assets.Src.Personaje.PersonajeBase;
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

        public override void Correr(NavMeshAgent navMeshAgent, Vector3 objetivo)
        {
            Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit h;
            if (Physics.Raycast(r, out h))
            {
                objetivo = h.point;
                navMeshAgent.SetDestination(objetivo);
            }
        }
    }
}
