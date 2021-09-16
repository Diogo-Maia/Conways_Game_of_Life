using UnityEngine;

public class MouseController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(cubeRay, Vector2.zero);

            if (hit)
            {
                hit.collider.gameObject.GetComponent<Cell>().OnClick();
                Debug.Log(hit.collider.gameObject.name);
            }
        }

        if (Input.GetMouseButton(1))
        {
            Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(cubeRay, Vector2.zero);

            if (hit)
            {
                hit.collider.gameObject.GetComponent<Cell>().OnClick();
            }
        }
    }
}
