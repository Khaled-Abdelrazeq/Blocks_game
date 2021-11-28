using UnityEngine;

public class Block : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
    }

}
