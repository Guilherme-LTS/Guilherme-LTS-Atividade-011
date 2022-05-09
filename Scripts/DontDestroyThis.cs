using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyThis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Este m�todo impede que o objeto 
        // atual seja destruido durante o carregamento.
        DontDestroyOnLoad(gameObject);
    }
}
