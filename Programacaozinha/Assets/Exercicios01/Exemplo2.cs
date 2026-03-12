using UnityEngine;

public class Exemplo2 : MonoBehaviour
{
    [SerializeField] private string nomeFuncionario;
    [SerializeField] private float tempoTrabalho;
    [SerializeField] private float valorHora;

    void Start()
    {
        print(nomeFuncionario + " trabalhou por " + tempoTrabalho + " horas.");

        print("Valor por hora: " + valorHora);

        float salario = tempoTrabalho * valorHora;

        print("O salário que " + nomeFuncionario + " recebeu foram: " + salario + " reais.");
    }

    void Update()
    {
        
    }
}
