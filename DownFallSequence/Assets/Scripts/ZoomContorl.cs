using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomContorl : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;

    [SerializeField]
    private SpriteRenderer mapRenderer;

    private float mapMinX, mapMaxX, mapMinY, mapMaxY;

    private float temp_value;
    
    public Camera cam;

    private Vector3 dragOrigin;

    private void Awake()
    {
        mapMinX = mapRenderer.transform.position.x - mapRenderer.bounds.size.x / 2f;
        mapMaxX = mapRenderer.transform.position.x + mapRenderer.bounds.size.x / 2f;

        mapMinY = mapRenderer.transform.position.y - mapRenderer.bounds.size.y / 2f;
        mapMaxY = mapRenderer.transform.position.y + mapRenderer.bounds.size.y / 2f;
    }

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //Zoom();
        float scroll = Input.GetAxis("Mouse ScrollWheel") * speed;
        

        if(cam.orthographicSize <= 2.0f && scroll > 0)
        {
            temp_value = cam.orthographicSize;
            cam.orthographicSize = temp_value;
            cam.transform.position = ClmpCamera(cam.transform.position);
        }
        else if(cam.orthographicSize>=5.0f&& scroll < 0)
        {
            temp_value = cam.orthographicSize;
            cam.orthographicSize = temp_value;
            cam.transform.position = ClmpCamera(cam.transform.position);
        }
        else
        {
            cam.orthographicSize -= scroll * 0.5f;
        }
        PanCamera();
    }

    private void PanCamera()
    {
        if(Input.GetMouseButtonDown(0))
        {
            dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);
        }    
        if(Input.GetMouseButton(0))
        {
            Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(Input.mousePosition);

            cam.transform.position = ClmpCamera(cam.transform.position + difference);
            
        }

    }
    
    private Vector3 ClmpCamera(Vector3 targetPosition)
    {
        float camHeight = cam.orthographicSize;
        float camWidth = cam.orthographicSize * cam.aspect;

        float minX = mapMinX + camWidth;
        float maxX = mapMaxX - camWidth;
        float minY = mapMinY + camHeight;
        float maxY = mapMaxY - camHeight;

        float newX = Mathf.Clamp(targetPosition.x, minX, maxX);
        float newY = Mathf.Clamp(targetPosition.y, minY, maxY);

        return new Vector3(newX, newY, targetPosition.z);
    }
}
