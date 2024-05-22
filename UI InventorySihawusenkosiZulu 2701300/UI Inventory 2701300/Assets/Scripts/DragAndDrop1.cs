using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
   



    private bool isDragging = false;
    private Vector3 offset;
    private Vector2 initialPosition;

    // Define the snapping area
    public Rect snappingArea;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                // Calculate the offset between the object's position and the mouse position
                offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
                isDragging = true;
                initialPosition = transform.position;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (isDragging)
            {
                isDragging = false;
                SnapToNearestObject();
            }
        }

        if (isDragging)
        {
            // Convert the mouse position to world position and add the offset
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;

            // Restrict the newPosition within the snapping area
            newPosition.x = Mathf.Clamp(newPosition.x, snappingArea.xMin, snappingArea.xMax);
            newPosition.y = Mathf.Clamp(newPosition.y, snappingArea.yMin, snappingArea.yMax);

            // Update the object's position
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
        }
    }

    private void SnapToNearestObject()
    {
        GameObject[] snapTargets = GameObject.FindGameObjectsWithTag("SnapTarget");

        float minDistance = Mathf.Infinity;
        GameObject nearestSnapTarget = null;

        foreach (GameObject target in snapTargets)
        {
            // Check if the target is within the snapping area
            if (snappingArea.Contains(target.transform.position))
            {
                float distance = Vector2.Distance(transform.position, target.transform.position);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestSnapTarget = target;
                }
            }
        }

        if (nearestSnapTarget != null)
        {
            transform.position = nearestSnapTarget.transform.position;
        }
        else
        {
            transform.position = initialPosition;
        }
    }
}


  