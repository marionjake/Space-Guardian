using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject laserPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laserPrefab, transform.position, Quaternion.identity);
        }
    }
}
