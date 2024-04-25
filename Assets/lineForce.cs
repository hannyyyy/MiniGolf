using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lineForce : MonoBehaviour
{
    [SerializeField] private float shotPower = 5f;
    [SerializeField] private float stopVelocity = 0.02f;
    [SerializeField] private LineRenderer lineRenderer;
    private bool isIdle;
    private bool isAiming;

    private Rigidbody body;
    public int clickCount;
    public Text s;
    private bool goal = false;
    public Canvas levelOver;

    void FixedUpdate()
    {
        if (body.velocity.magnitude < stopVelocity)
        {
            Stop();
        }
        ProcessAim();
    }
    private void Awake()
    {
        body = GetComponent<Rigidbody>();

        isAiming = false;
        lineRenderer.enabled = false;
    }
    private void ProcessAim()
    {
        if (!isAiming || !isIdle)
        {
            return;
        }
        Vector3? worldPoint = CastMouseClickRay();

        if (!worldPoint.HasValue)
        {
            return;
        }

        DrawLine(worldPoint.Value);


        if(Input.GetMouseButtonDown(0))
        {
            if (!goal)
            {
                clickCount++;
                s.text = clickCount.ToString();
            }
            
            Shoot(worldPoint.Value);
        }
    }
   private void OnMouseDown()
    {
        if (isIdle)
        {
            isAiming = true;
        }
    }
    private void Shoot(Vector3 worldPoint)
    {
        isAiming = false;
        lineRenderer.enabled = false;

        Vector3 horizontalWorldPoint = new Vector3(worldPoint.x, transform.position.y, worldPoint.z);

        Vector3 direction = (horizontalWorldPoint - transform.position).normalized;
        float strength = Vector3.Distance(transform.position, horizontalWorldPoint);

        body.AddForce(direction * strength * shotPower);
        isIdle = true;
    }
    private void DrawLine(Vector3 worldPoint)
    {
        Vector3[] positions = { transform.position, worldPoint };
        lineRenderer.SetPositions(positions);
        lineRenderer.enabled = true;
    }
    private void Stop()
    {
        body.velocity = Vector3.zero;
        body.angularVelocity = Vector3.zero;
        isIdle = true;
    }

    private Vector3? CastMouseClickRay()
    {
        Vector3 screenMousePosFar = new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            Camera.main.farClipPlane);
        Vector3 screenMousePosNear = new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            Camera.main.nearClipPlane);
        Vector3 worldMousePosFar = Camera.main.ScreenToWorldPoint(screenMousePosFar);
        Vector3 worldMousePosNear = Camera.main.ScreenToWorldPoint(screenMousePosNear);
        RaycastHit hit;
        if(Physics.Raycast(worldMousePosNear, worldMousePosFar - worldMousePosNear, out hit, float.PositiveInfinity))
        {
            return hit.point;
        } else
        {
            return null;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            Debug.Log("Goal");
            goal = true;
            levelOver.gameObject.SetActive(true);
            //make level over popup
        }
    }
}
