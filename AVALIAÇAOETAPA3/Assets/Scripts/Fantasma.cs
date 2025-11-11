using UnityEngine;

public class Fantasma : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public bool estaVisivel = true; // variável que controla se o fantasma está visível

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Aqui, por exemplo, o fantasma muda de visível pra invisível ao apertar a tecla "F"
        if (Input.GetKeyDown(KeyCode.F))
        {
            AlternarVisibilidade();
        }
    }

    void AlternarVisibilidade()
    {
        estaVisivel = !estaVisivel; // inverte o estado
        spriteRenderer.enabled = estaVisivel; // ativa ou desativa a aparência do fantasma
    }
}