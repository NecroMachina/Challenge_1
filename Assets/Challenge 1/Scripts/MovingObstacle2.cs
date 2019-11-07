using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle2 : MonoBehaviour
{

    public Vector3 startPositie;

    public float begin;

    public float eind;

    public bool omlaag = true;

    // Start is called before the first frame update
    void Start()
    {
        startPositie = transform.position;
        begin = startPositie.y;
        eind = startPositie.y + -4f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < eind)
        {
            omlaag = true;
        }
        else if (transform.position.y > begin)
        {
            omlaag = false;
        }
        if (omlaag)
        {
            transform.Translate(x: 0, y: Time.deltaTime * 2f, z: 0);
        }
        else
        {
            transform.Translate(x: 0, y: Time.deltaTime * -2f, z: 0);
        }
    }
}
