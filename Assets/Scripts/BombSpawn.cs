using System.Collections;
using UnityEngine;

public class BombSpawn : MonoBehaviour
{
    public GameObject bomb;

    void Start()
    {
        StartCoroutine(Spawn ());
    }

    IEnumerator Spawn ()
    {
        while (!Player.lose)
        {
            Instantiate(bomb, new Vector2 (Random.Range (-2.6f, 2.6f), 6.3f), Quaternion.identity);
            yield return new WaitForSeconds (1f);
        }
    }

    
}
