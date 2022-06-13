using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject CubePrefab;
    [SerializeField] GameObject GridParent;
    public ReadInput myScript;
    public int GridSize = 3;
    
    private void Start()
    {
        GridSize = ReadInput.intInput;
        Debug.Log(GridSize);
        GridParent.transform.GetComponent<GridLayoutGroup>().constraintCount = GridSize;

        for (int i = 0; i < GridSize * GridSize; i++)
        {
            var obj = Instantiate(CubePrefab, GridParent.transform);
            obj.SetActive(true);
            
        }

       if (GridSize <= 9) 
        {
            GridParent.transform.GetComponent<GridLayoutGroup>().cellSize = new Vector2(110, 110);
            
            
        }else if ( GridSize >= 10 && GridSize <= 30 )
        {
            float newCellSize = 900 / GridSize;
            
            GridParent.transform.GetComponent<GridLayoutGroup>().cellSize = new Vector2(newCellSize, newCellSize);
        }else
        {
            float newCellSize = 700 / GridSize;
            GridParent.transform.GetComponent<GridLayoutGroup>().cellSize = new Vector2(newCellSize, newCellSize);
        }
    }
}
