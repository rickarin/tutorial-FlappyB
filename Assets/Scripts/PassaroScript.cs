using UnityEngine;

public class PassaroScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody2D;
    public float flaptStrenght;
    public LogicScript logic;
    public bool sePassaroVivo = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logica").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && sePassaroVivo == true)
        {
            myrigidbody2D.linearVelocity = Vector2.up * flaptStrenght;
        }

    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        logic.gameOver();
        sePassaroVivo = false;
    }
}
