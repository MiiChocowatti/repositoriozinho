using UnityEngine;

public class Exercicio11 : MonoBehaviour
{
    [SerializeField] public float velocidadeInicial;
    [SerializeField] public float aceleracao;
    [SerializeField] public float tempo;

    void Start()
    {
        float velocidadeFinal = velocidadeInicial + aceleracao * tempo;
        print(velocidadeFinal);
    }

    
    void Update()
    {
        
    }
}
