﻿using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

public class DialogoComSlipt : MonoBehaviour
{
    public GameObject[] Ayla;
    public GameObject[] Alice;
    public GameObject[] Cenarios;

    string[] linhasIniciais;
    string[] linhasIniciaisSplit;
    List<string> listaLinhasIniciaisPersonagem = new List<string>();
    List<string> listaLinhasIniciaisFala = new List<string>();
    List<string> listaLinhasIniciaisCenario = new List<string>();

    string[] linhasA;
    string[] linhasASplit;
    List<string> listaLinhasAPersonagem = new List<string>();
    List<string> listaLinhasAFala = new List<string>();
    List<string> listaLinhasACenario = new List<string>();

    string[] linhasB;
    string[] linhasBSplit;
    List<string> listaLinhasBPersonagem = new List<string>();
    List<string> listaLinhasBFala = new List<string>();
    List<string> listaLinhasBCenario = new List<string>();


    string[] linhasAa;
    string[] linhasAaSplit;
    List<string> listaLinhasAaPersonagem = new List<string>();
    List<string> listaLinhasAaFala = new List<string>();
    List<string> listaLinhasAaCenario = new List<string>();

    string[] linhasAb;
    string[] linhasAbSplit;
    List<string> listaLinhasAbPersonagem = new List<string>();
    List<string> listaLinhasAbFala = new List<string>();
    List<string> listaLinhasAbCenario = new List<string>();

    string[] linhasBa;
    string[] linhasBaSplit;
    List<string> listaLinhasBaPersonagem = new List<string>();
    List<string> listaLinhasBaFala = new List<string>();
    List<string> listaLinhasBaCenario = new List<string>();

    string[] linhasBb;
    string[] linhasBbSplit;
    List<string> listaLinhasBbPersonagem = new List<string>();
    List<string> listaLinhasBbFala = new List<string>();
    List<string> listaLinhasBbCenario = new List<string>();


    string[] linhasAAa;
    string[] linhasAAaSplit;
    List<string> listaLinhasAAaPersonagem = new List<string>();
    List<string> listaLinhasAAaFala = new List<string>();
    List<string> listaLinhasAAaCenario = new List<string>();

    string[] linhasAAb;
    string[] linhasAAbSplit;
    List<string> listaLinhasAAbPersonagem = new List<string>();
    List<string> listaLinhasAAbFala = new List<string>();
    List<string> listaLinhasAAbCenario = new List<string>();


    string[] linhasBAa;
    string[] linhasBAaSplit;
    List<string> listaLinhasBAaPersonagem = new List<string>();
    List<string> listaLinhasBAaFala = new List<string>();
    List<string> listaLinhasBAaCenario = new List<string>();

    string[] linhasBAb;
    string[] linhasBAbSplit;
    List<string> listaLinhasBAbPersonagem = new List<string>();
    List<string> listaLinhasBAbFala = new List<string>();
    List<string> listaLinhasBAbCenario = new List<string>();

    public TextMeshProUGUI personagem;
    public TextMeshProUGUI conteudo;
    public string cenarios;

    public int num = 1;
    private bool[] opcoes = new bool[7];

    float tempo;
    bool podeLer = true;

    public static DialogoComSlipt instancia;

    public void Awake()
    {
        if (PlayerPrefs.GetString("Idioma") == "Port")
        {
            TextAsset textoInicial = (TextAsset)Resources.Load("Dialogos/Port/Inicio");
            linhasIniciais = textoInicial.text.Split('\n');

            TextAsset textoA = (TextAsset)Resources.Load("Dialogos/Port/OpcaoA");
            linhasA = textoA.text.Split('\n');
            TextAsset textoB = (TextAsset)Resources.Load("Dialogos/Port/OpcaoB");
            linhasB = textoB.text.Split('\n');

            TextAsset textoAa = (TextAsset)Resources.Load("Dialogos/Port/OpcaoAa");
            linhasAa = textoAa.text.Split('\n');
            TextAsset textoAb = (TextAsset)Resources.Load("Dialogos/Port/OpcaoAb");
            linhasAb = textoAb.text.Split('\n');
            TextAsset textoBa = (TextAsset)Resources.Load("Dialogos/Port/OpcaoBa");
            linhasBa = textoBa.text.Split('\n');
            TextAsset textoBb = (TextAsset)Resources.Load("Dialogos/Port/OpcaoBb");
            linhasBb = textoBb.text.Split('\n');

            TextAsset textoAAa = (TextAsset)Resources.Load("Dialogos/Port/OpcaoAAa");
            linhasAAa = textoAAa.text.Split('\n');
            TextAsset textoAAb = (TextAsset)Resources.Load("Dialogos/Port/OpcaoAAb");
            linhasAAb = textoAAb.text.Split('\n');
            TextAsset textoBAa = (TextAsset)Resources.Load("Dialogos/Port/OpcaoBAa");
            linhasBAa = textoBAa.text.Split('\n');
            TextAsset textoBAb = (TextAsset)Resources.Load("Dialogos/Port/OpcaoBAb");
            linhasBAb = textoBAb.text.Split('\n');
        }

        else if (PlayerPrefs.GetString("Idioma") == "Esp")
        {
            TextAsset textoInicial = (TextAsset)Resources.Load("Dialogos/Esp/Inicio");
            linhasIniciais = textoInicial.text.Split('\n');
            Debug.Log(textoInicial);

            TextAsset textoA = (TextAsset)Resources.Load("Dialogos/Esp/OpcaoA");
            linhasA = textoA.text.Split('\n');
            TextAsset textoB = (TextAsset)Resources.Load("Dialogos/Esp/OpcaoB");
            linhasB = textoB.text.Split('\n');

            TextAsset textoAa = (TextAsset)Resources.Load("Dialogos/Esp/OpcaoAa");
            linhasAa = textoAa.text.Split('\n');
            TextAsset textoAb = (TextAsset)Resources.Load("Dialogos/Esp/OpcaoAb");
            linhasAb = textoAb.text.Split('\n');
            TextAsset textoBa = (TextAsset)Resources.Load("Dialogos/Esp/OpcaoBa");
            linhasBa = textoBa.text.Split('\n');
            TextAsset textoBb = (TextAsset)Resources.Load("Dialogos/Esp/OpcaoBb");
            linhasBb = textoBb.text.Split('\n');

            TextAsset textoAAa = (TextAsset)Resources.Load("Dialogos/Esp/OpcaoAAa");
            linhasAAa = textoAAa.text.Split('\n');
            TextAsset textoAAb = (TextAsset)Resources.Load("Dialogos/Esp/OpcaoAAb");
            linhasAAb = textoAAb.text.Split('\n');
            TextAsset textoBAa = (TextAsset)Resources.Load("Dialogos/Esp/OpcaoBAa");
            linhasBAa = textoBAa.text.Split('\n');
            TextAsset textoBAb = (TextAsset)Resources.Load("Dialogos/Esp/OpcaoBAb");
            linhasBAb = textoBAb.text.Split('\n');
        }

        for (int i = 0; i < linhasIniciais.Length; i++)
        {
            linhasIniciaisSplit = linhasIniciais[i].Split("_"[0]);
            listaLinhasIniciaisCenario.Add(linhasIniciaisSplit[0]);
            listaLinhasIniciaisPersonagem.Add(linhasIniciaisSplit[1]);
            listaLinhasIniciaisFala.Add(linhasIniciaisSplit[2]);
        }

        for (int i = 0; i < linhasA.Length; i++)
        {
            linhasASplit = linhasA[i].Split("_"[0]);
            listaLinhasACenario.Add(linhasASplit[0]);
            listaLinhasAPersonagem.Add(linhasASplit[1]);
            listaLinhasAFala.Add(linhasASplit[2]);
        }
        for (int i = 0; i < linhasB.Length; i++)
        {
            linhasBSplit = linhasB[i].Split("_"[0]);
            listaLinhasBCenario.Add(linhasBSplit[0]);
            listaLinhasBPersonagem.Add(linhasBSplit[1]);
            listaLinhasBFala.Add(linhasBSplit[2]);
        }

        for (int i = 0; i < linhasAa.Length; i++)
        {
            linhasAaSplit = linhasAa[i].Split("_"[0]);
            listaLinhasAaCenario.Add(linhasAaSplit[0]);
            listaLinhasAaPersonagem.Add(linhasAaSplit[1]);
            listaLinhasAaFala.Add(linhasAaSplit[2]);
        }
        for (int i = 0; i < linhasAb.Length; i++)
        {
            linhasAbSplit = linhasAb[i].Split("_"[0]);
            listaLinhasAbCenario.Add(linhasAbSplit[0]);
            listaLinhasAbPersonagem.Add(linhasAbSplit[1]);
            listaLinhasAbFala.Add(linhasAbSplit[2]);
        }
        for (int i = 0; i < linhasBa.Length; i++)
        {
            linhasBaSplit = linhasBa[i].Split("_"[0]);
            listaLinhasBaCenario.Add(linhasBaSplit[0]);
            listaLinhasBaPersonagem.Add(linhasBaSplit[1]);
            listaLinhasBaFala.Add(linhasBaSplit[2]);
        }
        for (int i = 0; i < linhasBb.Length; i++)
        {
            linhasBbSplit = linhasBb[i].Split("_"[0]);
            listaLinhasBbCenario.Add(linhasBbSplit[0]);
            listaLinhasBbPersonagem.Add(linhasBbSplit[1]);
            listaLinhasBbFala.Add(linhasBbSplit[2]);
        }

        for (int i = 0; i < linhasAAa.Length; i++)
        {
            linhasAAaSplit = linhasAAa[i].Split("_"[0]);
            listaLinhasAAaCenario.Add(linhasAAaSplit[0]);
            listaLinhasAAaPersonagem.Add(linhasAAaSplit[1]);
            listaLinhasAAaFala.Add(linhasAAaSplit[2]);
        }
        for (int i = 0; i < linhasAAb.Length; i++)
        {
            linhasAAbSplit = linhasAAb[i].Split("_"[0]);
            listaLinhasAAbCenario.Add(linhasAAbSplit[0]);
            listaLinhasAAbPersonagem.Add(linhasAAbSplit[1]);
            listaLinhasAAbFala.Add(linhasAAbSplit[2]);
        }
        for (int i = 0; i < linhasBAa.Length; i++)
        {
            linhasBAaSplit = linhasBAa[i].Split("_"[0]);
            listaLinhasBAaCenario.Add(linhasBAaSplit[0]);
            listaLinhasBAaPersonagem.Add(linhasBAaSplit[1]);
            listaLinhasBAaFala.Add(linhasBAaSplit[2]);
        }
        for (int i = 0; i < linhasBAb.Length; i++)
        {
            linhasBAbSplit = linhasBAb[i].Split("_"[0]);
            listaLinhasBAbCenario.Add(linhasBAbSplit[0]);
            listaLinhasBAbPersonagem.Add(linhasBAbSplit[1]);
            listaLinhasBAbFala.Add(linhasBAbSplit[2]);
        }
    }

    private void Start()
    {
        instancia = this;

        if (PlayerPrefs.HasKey("Escolha") == false)
        {
            opcoes[0] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            personagem.text = listaLinhasIniciaisPersonagem[0];
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha") == "BAb")
        {
            opcoes[10] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha") == "BAa")
        {
            opcoes[9] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha") == "AAb")
        {
            opcoes[8] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha") == "AAa")
        {
            opcoes[7] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha") == "Bb")
        {
            opcoes[6] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha") == "Ba")
        {
            opcoes[5] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha") == "Ab")
        {
            opcoes[4] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha") == "Aa")
        {
            opcoes[3] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha") == "B")
        {
            opcoes[2] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha") == "A")
        {
            opcoes[1] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else
        {
            conteudo.text = "Erro";
        }
    }

    private void Update()
    {
        if (BotoesEmJogo.instancia.automatico)
        {
            if (podeLer)
            {
                tempo += Time.deltaTime;
                if (tempo >= 20f)
                {
                    num++;
                    Ler();
                    tempo = 0f;
                }
            }
        }
    }

    public void PosicoesPersonagens()
    {
        //Narrador
        if (personagem.text == "Narrador" || personagem.text == "")
        {
            personagem.text = "Narrador";
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }

        //Ayla
        else if (personagem.text == "AylaPadrao")
        {
            personagem.text = "Ayla";
            Ayla[0].SetActive(true);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }
        else if (personagem.text == "AylaIrritada")
        {
            personagem.text = "Ayla";
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(true);
            Ayla[0].SetActive(false);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }
        else if (personagem.text == "AylaTriste")
        {
            personagem.text = "Ayla";
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(true);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }

        //Alice
        else if (personagem.text == "AlicePadrao")
        {
            personagem.text = "Alice";
            Alice[0].SetActive(true);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }
        else if (personagem.text == "AliceIrritada")
        {
            personagem.text = "Alice";
            Alice[0].SetActive(false);
            Alice[1].SetActive(true);
            Alice[0].SetActive(false);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }
        else if (personagem.text == "AliceTriste")
        {
            personagem.text = "Alice";
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(true);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }

        //Fernando
        else if (personagem.text == "FernandoNormal")
        {
            personagem.text = "Fernando";
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }
        else if (personagem.text == "FernandoIrritado")
        {
            personagem.text = "Fernando";
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[0].SetActive(false);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }
        else if (personagem.text == "FernandoTriste")
        {
            personagem.text = "Fernando";
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }
    }

    public void MudarCenarios()
    {
        if (cenarios == "")
        {
            Cenarios[0].SetActive(true);
            Cenarios[1].SetActive(false);
            Cenarios[2].SetActive(false);
        }
        else if (cenarios == "QuartoAyla")
        {
            Cenarios[0].SetActive(false);
            Cenarios[1].SetActive(true);
            Cenarios[2].SetActive(false);
        }
        else if (cenarios == "QuartoAlice")
        {
            Cenarios[0].SetActive(false);
            Cenarios[1].SetActive(false);
            Cenarios[2].SetActive(true);
        }
    }

    public void Ler()
    {
        //Inicial
        if(opcoes[0])
        {
            for (int i = num; i < linhasIniciais.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasIniciaisCenario[i];
                personagem.text = listaLinhasIniciaisPersonagem[i];
                conteudo.text = listaLinhasIniciaisFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasIniciais.Length - 1)
                {
                    BotoesEmJogo.instancia.escolhas[0].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[1].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[0] = false;
                    num = 0;
                }
                break;
            }
        }

        //Escolha A/B
        else if (opcoes[1])
        {
            for (int i = num; i < linhasA.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasACenario[i];
                personagem.text = listaLinhasAPersonagem[i];
                conteudo.text = listaLinhasAFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasA.Length - 1)
                {
                    BotoesEmJogo.instancia.escolhas[2].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[3].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[1] = false;
                }
                break;
            }
        }

        else if (opcoes[2])
        {
            for (int i = num; i < linhasB.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasBCenario[i];
                personagem.text = listaLinhasBPersonagem[i];
                conteudo.text = listaLinhasBFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasB.Length - 1)
                {
                    BotoesEmJogo.instancia.escolhas[4].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[5].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[2] = false;
                    num = 0;
                }
                break;
            }
        }

        //Escolha Aa/Ab/Ba/Bb
        else if (opcoes[3])
        {
            for (int i = num; i < linhasAa.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasAaCenario[i];
                personagem.text = listaLinhasAaPersonagem[i];
                conteudo.text = listaLinhasAaFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasAa.Length - 1)
                {
                    BotoesEmJogo.instancia.escolhas[6].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[7].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[3] = false;
                    num = 0;
                }
                break;
            }
        }

        else if (opcoes[4])
        {
            for (int i = num; i < linhasAb.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasAbCenario[i];
                personagem.text = listaLinhasAbPersonagem[i];
                conteudo.text = listaLinhasAbFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasAb.Length - 1)
                {
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[4] = false;
                    num = 0;
                }
                break;
            }
        }

        else if (opcoes[5])
        {
            for (int i = num; i < linhasBa.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasBaCenario[i];
                personagem.text = listaLinhasBaPersonagem[i];
                conteudo.text = listaLinhasBaFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasBa.Length - 1)
                {
                    BotoesEmJogo.instancia.escolhas[8].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[9].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[5] = false;
                    num = 0;
                }
                break;
            }
        }

        else if (opcoes[6])
        {
            for (int i = num; i < linhasBb.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasBbCenario[i];
                personagem.text = listaLinhasBbPersonagem[i];
                conteudo.text = listaLinhasBbFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasBb.Length - 1)
                {
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[6] = false;
                }
                break;
            }
        }

        //Escolha AAa/AAb/BAa/BAb
        else if (opcoes[7])
        {
            for (int i = num; i < linhasAAa.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasAAaCenario[i];
                personagem.text = listaLinhasAAaPersonagem[i];
                conteudo.text = listaLinhasAAaFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasAAa.Length - 1)
                {
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[7] = false;
                    num = 0;
                }
                break;
            }
        }

        else if (opcoes[8])
        {
            for (int i = num; i < linhasAAb.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasAAbCenario[i];
                personagem.text = listaLinhasAAbPersonagem[i];
                conteudo.text = listaLinhasAAbFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasAAb.Length - 1)
                {
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[8] = false;
                    num = 0;
                }
                break;
            }
        }

        else if (opcoes[9])
        {
            for (int i = num; i < linhasBAa.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasBAaCenario[i];
                personagem.text = listaLinhasBAaPersonagem[i];
                conteudo.text = listaLinhasBAaFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasBAa.Length - 1)
                {
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[9] = false;
                }
                break;
            }
        }

        else if (opcoes[10])
        {
            for (int i = num; i < linhasBAb.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasBAbCenario[i];
                personagem.text = listaLinhasBAbPersonagem[i];
                conteudo.text = listaLinhasBAbFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasBAb.Length - 1)
                {
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[10] = false;
                }
                break;
            }
        }
    }

    public void Anterior()
    {
        num--;
        Ler();
    }

    public void Proximo()
    {
        num++;
        Ler();
    }

    public void Escolhas(string escolha)
    {
        switch (escolha)
        {
            case "A":
                PlayerPrefs.SetString("Escolha", "A");
                podeLer = true;
                opcoes[1] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[0].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[1].gameObject.SetActive(false);
                Ler();
                break;
            case "B":
                PlayerPrefs.SetString("Escolha", "B");
                podeLer = true;
                opcoes[2] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[0].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[1].gameObject.SetActive(false);
                Ler();
                break;

            case "Aa":
                PlayerPrefs.SetString("Escolha", "Aa");
                podeLer = true;
                opcoes[3] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[2].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[3].gameObject.SetActive(false);
                Ler();
                break;
            case "Ab":
                PlayerPrefs.SetString("Escolha", "Ab");
                podeLer = true;
                opcoes[4] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[2].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[3].gameObject.SetActive(false);
                Ler();
                break;
            case "Ba":
                PlayerPrefs.SetString("Escolha", "Ba");
                podeLer = true;
                opcoes[5] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[4].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[5].gameObject.SetActive(false);
                Ler();
                break;
            case "Bb":
                PlayerPrefs.SetString("Escolha", "Bb");
                podeLer = true;
                opcoes[6] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[4].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[5].gameObject.SetActive(false);
                Ler();
                break;
            case "AAa":
                PlayerPrefs.SetString("Escolha", "Aaa");
                podeLer = true;
                opcoes[7] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[6].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[7].gameObject.SetActive(false);
                Ler();
                break;
            case "AAb":
                PlayerPrefs.SetString("Escolha", "AAb");
                podeLer = true;
                opcoes[8] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[6].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[7].gameObject.SetActive(false);
                Ler();
                break;
            case "BAa":
                PlayerPrefs.SetString("EscolhaBAa", "BAa");
                podeLer = true;
                opcoes[9] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[8].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[9].gameObject.SetActive(false);
                Ler();
                break;
            case "BAb":
                PlayerPrefs.SetString("Escolha", "BAb");
                podeLer = true;
                opcoes[10] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[8].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[9].gameObject.SetActive(false);
                Ler();
                break;
        }
    }
    
    public void EscolhasEsp(string escolha)
    {
        switch (escolha)
        {
            case "A":
                PlayerPrefs.SetString("Escolha", "A");
                podeLer = true;
                opcoes[1] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[0].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[1].gameObject.SetActive(false);
                Ler();
                break;
            case "B":
                PlayerPrefs.SetString("Escolha", "B");
                podeLer = true;
                opcoes[2] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[0].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[1].gameObject.SetActive(false);
                Ler();
                break;

            case "Aa":
                PlayerPrefs.SetString("Escolha", "Aa");
                podeLer = true;
                opcoes[3] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[2].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[3].gameObject.SetActive(false);
                Ler();
                break;
            case "Ab":
                PlayerPrefs.SetString("Escolha", "Ab");
                podeLer = true;
                opcoes[4] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[2].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[3].gameObject.SetActive(false);
                Ler();
                break;
            case "Ba":
                PlayerPrefs.SetString("Escolha", "Ba");
                podeLer = true;
                opcoes[5] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[4].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[5].gameObject.SetActive(false);
                Ler();
                break;
            case "Bb":
                PlayerPrefs.SetString("Escolha", "Bb");
                podeLer = true;
                opcoes[6] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[4].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[5].gameObject.SetActive(false);
                Ler();
                break;
            case "AAa":
                PlayerPrefs.SetString("Escolha", "Aaa");
                podeLer = true;
                opcoes[7] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[6].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[7].gameObject.SetActive(false);
                Ler();
                break;
            case "AAb":
                PlayerPrefs.SetString("Escolha", "AAb");
                podeLer = true;
                opcoes[8] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[6].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[7].gameObject.SetActive(false);
                Ler();
                break;
            case "BAa":
                PlayerPrefs.SetString("EscolhaBAa", "BAa");
                podeLer = true;
                opcoes[9] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[8].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[9].gameObject.SetActive(false);
                Ler();
                break;
            case "BAb":
                PlayerPrefs.SetString("Escolha", "BAb");
                podeLer = true;
                opcoes[10] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[8].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[9].gameObject.SetActive(false);
                Ler();
                break;
        }
    }
}
