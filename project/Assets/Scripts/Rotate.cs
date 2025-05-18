using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position = new Vector3(0, transform.position.y + 0.01f, 0);
                
                if (transform.position.y >= 10f)
                    transform.Translate(0, -0.01f, 0);
                else if (transform.position.y < 10)
                    transform.Translate(0, 0.01f, 0);
    }
}
