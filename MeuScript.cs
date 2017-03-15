using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class MeuScript : MonoBehaviour {

    [ContextMenuItem("Seta nome original", "SetNameOriginal")]
    [ContextMenuItem("Seta nome","SetName")]
    public string nome;

    public int velocidade;
    public int forca;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void Reset()
    {
        velocidade = 10;
        forca = 100;

    }


    void SetNameOriginal()
    {
        nome = "Eldon";
    }

    void SetName()
    {
        nome = "Pig";
    }

    [MenuItem ("CONTEXT/Rigidbody/Forca * 2")]
    static void ForcaX2(MenuCommand c)
    {
        Debug.Log("Contexto acionado...");

        Rigidbody rd = (Rigidbody)c.context;
        rd.mass = rd.mass * 2; 


    }


    [ContextMenu("Aciona alguma coisa !")]
    void ExecutaContextMenu()
    {
        Debug.Log("Executa alguma coisa");
    }
    
}
