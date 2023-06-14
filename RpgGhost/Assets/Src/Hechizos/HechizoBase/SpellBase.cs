using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Hechizos.HechizoBase
{
    public abstract class SpellBase
    {
        protected string nombre;
        protected int costoMana;

        public abstract void LanzarEchizo(GameObject objetoLanzable, GameObject personaje, ParticleSystem hechizoParticle, AudioSource soundSpell, Vector3 direccion, float fuerzaDisparo);
    }
}
