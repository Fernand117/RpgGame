using Assets.Src.Hechizos;
using Assets.Src.Hechizos.HechizoBase;
using System.Collections;
using Assets.Src.Personaje.PersonajeBase;
using Src.Personaje;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(NavMeshAgent))]
public class PersonajeMovimiento : MonoBehaviour
{
    NavMeshAgent nv;
    Animator anim;
    
    Vector3 objetivo;
    public float velocidadPJ = 5f;

    public AudioSource corriendo;
    private bool estaCorriendo = false;
    
    public AudioSource lanzarHechizo;
    public ParticleSystem particle;
    public GameObject objetoLanzable;
    public GameObject hechizoIni;
    public float fuerzaDisparo;

    Vector3 posicionInicial;
    Quaternion rotacionInicial;

    public Animator animMago;
    public float duracionAnim = 0f;


    // Start is called before the first frame update
    void Start()
    {
        nv = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        nv.speed *= velocidadPJ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            /*Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit h;
            if (Physics.Raycast(r, out h))
            {
                objetivo = h.point;
                SetPosition();
            }*/
            string tipoPersonaje = "DamaNegra";
            PersonajeBaseModel personajeBaseModel = PersonajeFactory.ObtenerPersonaje(tipoPersonaje);
            personajeBaseModel.Correr(nv, objetivo);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameObject hechizoTemp = Instantiate(objetoLanzable, hechizoIni.transform.position, hechizoIni.transform.rotation) as GameObject;

            ParticleSystem partiTemp = Instantiate(particle, hechizoIni.transform.position, hechizoIni.transform.rotation) as ParticleSystem;

            string tipoHechizo = "Fuego";
            SpellBase spell = HechizoFactory.ObtenerHechizo(tipoHechizo);

            spell.LanzarEchizo(hechizoTemp, gameObject, partiTemp, lanzarHechizo, transform.forward, fuerzaDisparo);

            Destroy(partiTemp, 5.0f);
            Destroy(hechizoTemp, 5.0f);
            StartCoroutine(DetenerAnimacionDespuesDeTiempo(duracionAnim));
        }

        if (nv.velocity.magnitude > 0.1f && !estaCorriendo)
        {
            ReproducirAudio();
        }
        else if (nv.velocity.magnitude <= 0.1f && estaCorriendo)
        {
            DetenerAudio();
        }

        anim.SetFloat("Velocidad", nv.velocity.magnitude / nv.speed);
        animMago.SetBool("LanzarHechizo", false);
    }

    void SetPosition()
    {
        nv.SetDestination(objetivo);
    }

    void ReproducirAudio()
    {
        corriendo.Play();
        estaCorriendo = true;
    }

    void DetenerAudio()
    {
        corriendo.Stop();
        estaCorriendo = false;
    }

    IEnumerator DetenerAnimacionDespuesDeTiempo(float duracion)
    {
        yield return new WaitForSeconds(duracion);
        animMago.SetBool("LanzarHechizo", false);
    }

    public Vector3 getPosicionInicial()
    {
        return posicionInicial;
    }

    public Quaternion getRotacion()
    {
        return rotacionInicial;
    }
}