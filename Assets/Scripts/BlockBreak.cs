using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBreak : MonoBehaviour
{
   
    private void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
}
