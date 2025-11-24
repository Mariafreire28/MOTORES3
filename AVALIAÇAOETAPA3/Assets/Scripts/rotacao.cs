using UnityEngine;

public class rotacao : MonoBehaviour
{
    private float angulo;
    public float velocidade = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angulo += velocidade * Time.deltaTime;
        
        if (angulo > 1)
        {
            angulo = 0;
        }

        
        gameObject.transform.Rotate(new Vector3(0, 0, angulo));
    }
}
