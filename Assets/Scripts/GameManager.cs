
using UnityEngine;
using UnityEngine.UI;
using Conways.Game;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private GameObject cellPrefab;
    [SerializeField] private Text text;

    private Cell[,] grid;
    private Conway conway;
    private bool play;
    private int generation;
    
    void Start()
    {
        grid = new Cell[width, height];
        conway = new Conway(width, height);

        generation = 0;

        FillMap();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D cubeHit = Physics2D.Raycast(cubeRay, Vector2.zero);

            if (cubeHit)
            {
                cubeHit.collider.gameObject.GetComponent<Cell>().OnClick();
            }
        }

        if (Input.GetMouseButton(1))
        {
            Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D cubeHit = Physics2D.Raycast(cubeRay, Vector2.zero);

            if (cubeHit)
            {
                cubeHit.collider.gameObject.GetComponent<Cell>().OnClick();
            }
        }
        
        if(Input.GetKey(KeyCode.Return))
        {
            grid = conway.Start(grid);
            generation++;
        } 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            grid = conway.Start(grid);
            generation++;
        } 

        text.text = "Generation -> " + generation;
    }

    private void FillMap()
    {
        for(int x = 0; x < width; x++){
            for(int y = 0; y < height; y++){
                GameObject cell = 
                    Instantiate(cellPrefab, new Vector3(x + .4f, y + .4f, 0), Quaternion.identity);
                    
                cell.transform.parent = GameObject.Find("Grid").transform;
                grid[x, y] = cell.GetComponent<Cell>();
            }
        }
    }
}
