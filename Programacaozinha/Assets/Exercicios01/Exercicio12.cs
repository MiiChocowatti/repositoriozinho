using UnityEngine;

public class Exercicio12 : MonoBehaviour
{
    public int pontosBase;
    public int inimigosDerrotados;
    public int bonus;

    void Start()
    {
        int pontuacaoFinal = (pontosBase * inimigosDerrotados) + bonus;
        print("A pontuação final do jogador é: " + pontuacaoFinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
