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
