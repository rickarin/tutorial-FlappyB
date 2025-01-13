using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int pontuacaoJogador;
    public Text pontuacao;
    public GameObject gameoverScreen;
    [ContextMenu("Increase Score")]
    public void adicionarPontuacao(int pontuacaoaAdicionar)
    {
        pontuacaoJogador += pontuacaoaAdicionar;
        pontuacao.text = Convert.ToString(pontuacaoJogador);
    }

    public void recomeçarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameoverScreen.SetActive(true);
    }
}
