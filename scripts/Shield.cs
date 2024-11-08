using UnityEngine;

public class Shield : MonoBehaviour
{
    public float radius = 1f;   
    public int segments = 50;

    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = segments + 1;
        lineRenderer.loop = true;
        DrawCircle();
    }

    void DrawCircle()
    {
        float angle = 0f;

        for (int i = 0; i <= segments; i++)
        {
            float x = Mathf.Cos(angle) * radius;
            float y = Mathf.Sin(angle) * radius;

            lineRenderer.SetPosition(i, new Vector3(x, y, 0) + transform.position);

            angle += 2 * Mathf.PI / segments;
        }
    }

    void Update()
    {
        DrawCircle();
    }
}
