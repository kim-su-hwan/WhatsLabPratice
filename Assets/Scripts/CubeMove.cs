using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward *(-2);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Deletezone")
        {
            Destroy(this.gameObject);
        }
    }

}
