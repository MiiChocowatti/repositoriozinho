using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    [SerializeField] private int a;
    [SerializeField] private int b;

    void Start()
    {
        print("O resto da divisão entre " + a + " e " + b + " é: " + (a % b));
    }

    
    void Update()
    {
        
    }
}
