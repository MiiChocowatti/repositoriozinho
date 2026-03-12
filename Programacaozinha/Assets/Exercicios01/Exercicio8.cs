using UnityEngine;

public class Exercicio8 : MonoBehaviour
{
    [SerializeField] public int vida = 100;
    [SerializeField] public int dano;

    void Start()
    {
        print("A vida após o dano será de " + (vida - dano));
    }

    
    void Update()
    {
        
    }
}
