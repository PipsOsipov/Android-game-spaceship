using UnityEngine;

public class coinfalling : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 5f;
    void Update()
    {
        if (transform.position.y < -5.8f)
        {
            Destroy(gameObject);
        }
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }
}
