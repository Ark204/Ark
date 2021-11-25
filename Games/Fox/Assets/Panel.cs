using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Psnrl : MonoBehaviour
{
    private Fox Fox;
    public Transform point;

    // Start is called before the first frame update

    void Start()
    {
        Fox=GameObject.FindGameObjectWithTag("Fox").GetComponentInParent<Fox>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Fox.transform.position;
    }
}
