using UnityEngine;

public class Exercicio9 : MonoBehaviour
{
    [SerializeField] private int numero;

    void Start()
    {
        print("O dobro do número "+ numero + " é: " + (numero * 2));
        print("A metade do número "+ numero + " é: " + (numero / 2));
    }

    
    void Update()
    {
        
    }
}
