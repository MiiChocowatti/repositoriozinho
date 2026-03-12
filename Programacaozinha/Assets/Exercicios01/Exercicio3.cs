using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    [SerializeField] private int pontos;
    [SerializeField] private int multiplicador;

    void Start()
    {
        print("A pontuação final é " + (multiplicador * pontos));
    }

    
    void Update()
    {
        
    }
}
