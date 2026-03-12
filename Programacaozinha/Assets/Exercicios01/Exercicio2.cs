using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    [SerializeField] private int vida;
    [SerializeField] private int dano;

    void Start()
    {
        print(dano + " de dano foi causado ao personagem, que tinha " + vida + " de vida.");
        print("O personagem agora tem " + (vida - dano) + " de vida.");    
    }

   
    void Update()
    {
        
    }
}
