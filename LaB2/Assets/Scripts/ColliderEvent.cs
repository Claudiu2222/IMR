using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColliderEvent : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    public TMP_Text score;
    public ParticleSystem myParticleSystem;
    void Start()
    {
     myParticleSystem.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ball)
        {
            score.text = (int.Parse(score.text) + 1).ToString();
            myParticleSystem.Play();

        }
    }
}
