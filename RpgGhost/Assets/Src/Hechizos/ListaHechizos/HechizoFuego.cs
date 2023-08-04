using Assets.Src.Hechizos.HechizoBase;
using UnityEngine;

namespace Assets.Src.Hechizos.ListaHechizos
{
    public class HechizoFuego : SpellBase
    {
        public HechizoFuego()
        {
            nombre = "Fuego";
            costoMana = 10;
        }

        public override void LanzarEchizo(GameObject objetoLanzable, GameObject personaje, ParticleSystem hechizoParticle, AudioSource soundSpell, Vector3 direccion, float fuerzaDisparo)
        {
            hechizoParticle.transform.parent = objetoLanzable.transform;
            hechizoParticle.Play();

            soundSpell.Play();

            Rigidbody rigidbody = objetoLanzable.GetComponent<Rigidbody>();
            Quaternion rotacionDefault = Quaternion.Euler(0f, 90f, 0f);
            objetoLanzable.transform.rotation = rotacionDefault;
            rigidbody.AddForce(direccion * fuerzaDisparo, ForceMode.Impulse);
            //rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        }
    }
}
