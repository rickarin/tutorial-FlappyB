using UnityEngine;

public class MovimentoCano : MonoBehaviour
{
    public float movespeed = 5;
    public float zonaMorta = -45;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;

        if (transform.position.x < zonaMorta)
        {
            Debug.Log("Cano Destruido");
            Destroy(gameObject);
        }
    }
}
