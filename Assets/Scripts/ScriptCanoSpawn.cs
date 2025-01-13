using UnityEngine;

public class ScriptCanoSpawn : MonoBehaviour
{
    public GameObject cano;
    public float spawnRate = 2;
    private float timer = 0;
    public float alturaOffSet = 10;
    void Start()
    {
        SpawnCano();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnCano();
            timer = 0;
        }

    }

    void SpawnCano()
    {
        float pontoBaixoCano = transform.position.y - alturaOffSet;
        float pontoAltoCano = transform.position.y + alturaOffSet;


        Instantiate(cano, new Vector3(transform.position.x, Random.Range(pontoBaixoCano, pontoAltoCano), 0), transform.rotation);
    }
}
