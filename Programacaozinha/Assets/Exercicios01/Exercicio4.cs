using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    [SerializeField] private int moedas;
   
    void Start()
    {
        print("O jogador tem " + moedas + " moedas, mas ao dividir entre 5 personagens, ficou com " + (moedas / 5) + " moedas.");
    }

    
    void Update()
    {
        
    }
}
