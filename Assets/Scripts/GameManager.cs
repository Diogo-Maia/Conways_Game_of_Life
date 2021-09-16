using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Conways.Game;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private GameObject cellPrefab;

    private Cell[,] grid;
    private Conway conway;
    private bool play;
    
    void Start()
    {
        grid = new Cell[width, height];
        conway = new Conway(width, height);

        FillMap();

        //Time.timeScale = 0.05f;
    }

    // Update is called once per frame
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
        //grid = conway.Start(grid);
        if(Input.GetKey(KeyCode.Return)) grid = conway.Start(grid);
        /*if(Input.GetKeyUp(KeyCode.Return))
        {
            play = !play;
        }

        if(play) grid = conway.Start(grid);*/
    }

    private void FillMap()
    {
        for(int x = 0; x < width; x++){
            for(int y = 0; y < height; y++){
                GameObject cell = Instantiate(cellPrefab, new Vector3(x + .4f, y + .4f, 0), Quaternion.identity);
                cell.transform.parent = GameObject.Find("Grid").transform;
                grid[x, y] = cell.GetComponent<Cell>();
            }
        }
    }
}
