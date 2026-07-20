using UnityEngine;

public class loadNextPartTA : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public Transform spawnPoint;
    public GameObject ta0;

    private bool isComplete = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")&&!isComplete)
        {
            Instantiate(ta0, new Vector3(spawnPoint.position.x, spawnPoint.position.y+44, spawnPoint.position.z), spawnPoint.rotation);
            isComplete = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(ta0, new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z), spawnPoint.rotation);
            /*        
            switch (Random.Range(0, 1))
            {
                case 0:
                    Instantiate(ta0, new Vector3(13, spawnPoint.position.y - 20, 0), spawnPoint.rotation);
                    break;
                
            }*/
        }
    }
}
