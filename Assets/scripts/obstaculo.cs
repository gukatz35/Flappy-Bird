using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 2f;

    [SerializeField]
    private float variacaoposicaoY;
    private Vector3 posicaoPassaro;
    private UIController controladorUI;
    private bool pontuei;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(variacaoposicaoY, variacaoposicaoY));
    }

    private void Start()
    {
        this.posicaoPassaro = GameObject.FindObjectOfType<passaro>().transform.position;
        this.controladorUI = GameObject.FindObjectOfType<UIController>();
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime );
        if(!this.pontuei && this.transform.position.x < this.posicaoPassaro.x)
        {
            this.controladorUI.adicionarPontos();
            this.pontuei = true;  
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }

    private void Destruir()
    {
        Destroy(this.gameObject);
    }

}
