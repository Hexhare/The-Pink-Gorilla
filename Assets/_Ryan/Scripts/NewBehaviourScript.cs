using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab_redSquare, prefab_blackSquare;

    public GameObject[][] boardtiles;

    int height = 8, width = 8
        
    

    // Update is called once per frame
    public void GenerateBoard()
    {
        boardtiles = new GameObject(height)[];
        
    }
}
