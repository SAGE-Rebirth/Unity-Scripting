using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RaycastManager : MonoBehaviour
{
    public TMP_Text objName;
    RaycastHit hit;
    Vector3 fwd;

    GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        sphere.GetComponent<SphereCollider>().enabled = false; //to enable or disable the sphere
        //Destroy(sphere.GetComponent<SphereCollider>()); //to destroy the sphere collider completely
    }

    // Update is called once per frame
    void Update()
    {
        CheckForHit();
    }

    public void CheckForHit()
    {
        fwd = transform.forward;

        if (Physics.Raycast(transform.position, fwd, out hit, 150))
        {
            Debug.Log(hit.transform.gameObject.name);
            Debug.DrawRay(transform.position, fwd * 50, Color.green);

            objName.text = hit.transform.gameObject.name;
        }

        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, transform.position);    
        lineRenderer.SetPosition(1, transform.position + fwd * 150);

        sphere.transform.position = hit.point;
    }
}
