using System.Runtime.CompilerServices;
using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    [SerializeField] private int a, b;

    void Start()
    {
        print("A + B: " + (a + b));
    }

   
    void Update()
    {
        
    }
}
