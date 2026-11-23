using UnityEngine;

public class Jump : MonoBehaviour
{

    [SerializeField] float fuerzaSalto = 10f;
    float distancia = 1.2f;
    bool tocandoHierba = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tocandoHierba = Physics.Raycast(transform.position, Vector3.down, distancia);
        Debug.DrawRay(transform.position, Vector3.down * distancia, tocandoHierba ? Color.green : Color.red);

        if (Input.GetKeyDown(KeyCode.Space) && tocandoHierba == true)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }
}
