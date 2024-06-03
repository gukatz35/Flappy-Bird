using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorDeObstaculo : MonoBehaviour
{
    // Start is called before the first frame update

    //Como criar obstaculos
    // onde criar? Na posição do gerador
    // Quando criar? tempo

    [SerializeField]
    private float tempoParaGerar = 3;

    private float cronometro;

    [SerializeField]
    private GameObject modeloObstaculo;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }

    // Update is called once per frame
    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.modeloObstaculo, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
}
