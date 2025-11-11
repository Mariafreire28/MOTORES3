using UnityEngine;

public class Chave : MonoBehaviour
{
    
    public GameObject textoDeVitoria;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (textoDeVitoria != null)
            {
                textoDeVitoria.SetActive(true);
            }

            gameObject.SetActive(false);
        }
    }
}