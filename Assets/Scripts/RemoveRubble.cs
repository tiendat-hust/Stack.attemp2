using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRubble : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
    }
}
