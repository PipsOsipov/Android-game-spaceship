using System.Collections;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coin;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(coin, new Vector2(Random.Range(-2.6f, 2.6f), 6.3f), Quaternion.identity);
            yield return new WaitForSeconds(1.1f);
        }
    }
}
