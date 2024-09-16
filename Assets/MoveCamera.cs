using UnityEngine;

public class MoveCamera : MonoBehaviour
{
   Vector3 targetPosition;
   public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        //detect a click
        if (Input.GetMouseButtonDown(0))
        {
            //get the position of the click
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //set the z position to -10 so the camera can see the click
            clickPosition.z = -10;
            //move the camera to the click position
            targetPosition = clickPosition;
        }

        //move the camera towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
