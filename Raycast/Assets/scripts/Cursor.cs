using UnityEngine;

public class Cursor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(rayo, out hit);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(rayo, out hit))
            {
                Destroy(hit.collider.gameObject);
            }
        }

    }
}
