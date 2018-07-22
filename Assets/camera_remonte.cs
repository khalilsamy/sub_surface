using UnityEngine;
using System.Collections;

public class camera_remonte : MonoBehaviour {
    public GameObject coeur;
    
    //AnimationState animationState;
    float distance;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(coeur.transform.position, transform.position);
        if (distance < 50)
        {
            if (transform.position.y < 90) transform.position += Vector3.up * 10 * Time.deltaTime;
           
        }
    }
}
