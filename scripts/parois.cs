using UnityEngine;
using System.Collections;

public class parois : MonoBehaviour
{
    public GameObject player;
    public virus My_virus;
    private Transform playerTransform;
    private float blending, distance;
    private bool reduce, stop;
    // Use this for initialization

    void Start()
    {
        playerTransform = player.transform;
        renderer.material.shader = Shader.Find("Custom/blend");
        blending = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(playerTransform.position, transform.position);
        if (distance < 3)
        {
            //stop = false;
            blending += 0.05f;
            renderer.material.SetFloat("_Blend", blending);

            reduce = true;
            if (distance < 2)
            {
                My_virus.reduceSpeed();
                if (distance < 1.5 && !stop)
                {

                    My_virus.stop(Time.time + 0.1f);
                    My_virus.score += 2;
                    stop = true;
                }
            }
        }
        else reduce = false;
    }
}