using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConlisionDeEchizo : MonoBehaviour
{
    public AudioSource collSpell;
    public AudioClip audioClip;
    private Collider collider;
    // Start is called before the first frame update
    void Start()
    {
        collSpell = GetComponent<AudioSource>();
        collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(PlayCollisionAudio());
    }

    private IEnumerator PlayCollisionAudio()
    {
        collSpell.clip = audioClip;
        collSpell.Play();
        yield return new WaitForSeconds(collSpell.clip.length);
    }
}
