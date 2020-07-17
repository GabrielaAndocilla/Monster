using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderCoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other is BoxCollider)
        {
            other.GetComponent<Player>().points = other.GetComponent<Player>().points+1;
            Destroy(gameObject);
            print("Se destruye");
        }
    }
}
