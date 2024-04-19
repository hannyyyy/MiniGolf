
using UnityEngine;

public class arrow : MonoBehaviour
{
    /*public float arrowheadSize;
    Vector3 startPosition, mouseWorld;
    GameObject arrow;
    LineRenderer arrowLine;

    void Start()
    {

        arrow = GameObject.FindGameObjectWithTag(“Arrow”);
        arrowLine = arrow.GetComponentInChildren<LineRenderer>();
        mouseWorld = new Vector3();
        arrowheadSize = 0.02f;
    }

    void OnMouseDown()
    {

        mouseWorld = Camera.main.ScreenToWorldPoint(

        new Vector3(Input.mousePosition.x,
        Input.mousePosition.y,
        Camera.main.nearClipPlane
        ));
        startPosition = mouseWorld;

    }

    void OnMouseDrag()
    {

        //Turn on the arrow
        arrowLine.enabled = true;
        DrawArrow();
    }

    void DrawArrow()
    {

        mouseWorld = Camera.main.ScreenToWorldPoint(

        new Vector3(Input.mousePosition.x,
        Input.mousePosition.y,
        Camera.main.nearClipPlane
        ));
        //The longer the line gets, the smaller relative to the entire line the arrowhead should be
        float percentSize = (float)(arrowheadSize / Vector3.Distance(startPosition, mouseWorld));
        //h/t ShawnFeatherly (http://answers.unity.com/answers/1330338/view.html)
        arrowLine.SetPosition(0, startPosition);
        arrowLine.SetPosition(1, Vector3.Lerp(startPosition, mouseWorld, 0.999f – percentSize));
        arrowLine.SetPosition(2, Vector3.Lerp(startPosition, mouseWorld, 1 – percentSize));
        arrowLine.SetPosition(3, mouseWorld);
        arrowLine.widthCurve = new AnimationCurve(

        new Keyframe(0, 0.4f),
        new Keyframe(0.999f – percentSize, 0.4f),
        new Keyframe(1 – percentSize, 1f),
        new Keyframe(1 – percentSize, 1f),
        new Keyframe(1, 0f));
    }

    void OnMouseUp()
    {

        //Turn off the arrow
        arrowLine.enabled = false;
        RaycastHit hit;
        Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100);
        transform.position = new Vector3(hit.point.x, transform.position.y, hit.point.z);
    }
    */
}
