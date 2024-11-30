using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");

        Vector3 movement = new(moveX, 0, 0);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
