using UnityEngine;

public class loadNextPart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public Transform spawnPoint;
    public GameObject d0;
    public GameObject d1;
    public GameObject d2;
    public GameObject d3;
    public GameObject d4;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            switch (Random.Range(0, 5))
            {
                case 0:
                    Instantiate(d0, new Vector3(13, spawnPoint.position.y - 20, 0), spawnPoint.rotation);
                    break;
                case 1:
                    Instantiate(d1, new Vector3(13, spawnPoint.position.y - 20, 0), spawnPoint.rotation);
                    break;
                case 2:
                    Instantiate(d2, new Vector3(13, spawnPoint.position.y - 20, 0), spawnPoint.rotation);
                    break;
                case 3:
                    Instantiate(d3, new Vector3(13, spawnPoint.position.y - 20, 0), spawnPoint.rotation);
                    break;
                case 4:
                Instantiate(d4, new Vector3(13, spawnPoint.position.y - 20, 0), spawnPoint.rotation);
                break;
            }
        }
    }
}
