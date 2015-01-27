using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(AudioSource))]
public class SoundTrap : MonoBehaviour {

    [SerializeField]
    AudioClip sound;
    bool canPlay;

    void Start()
    {
        canPlay = true;
        audio.minDistance = audio.maxDistance - 100f;
        rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        GetComponent<BoxCollider>().isTrigger = true;
    }
	void OnTriggerEnter(Collider other){

        if (canPlay &&other.tag == "Player")
        {
            canPlay = false;
            audio.PlayOneShot(sound);
            StartCoroutine(coolDown(3f));
            print("trigger sound");
        }
    }

    IEnumerator coolDown(float t)
    {
        yield return new WaitForSeconds(t);
        canPlay = true;
    }
}
