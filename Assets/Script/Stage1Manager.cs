using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stage1Manager : MonoBehaviour
{
    Camera maincam;
    Vector3 movePostion;
    [SerializeField]float moveSpeed;

    void Start()
    {
        maincam = Camera.main;
        maincam.transform.position = new Vector3(8, -5, -10);
        Cursor.visible = true;
        movePostion = maincam.transform.position;
    }

    void Update()
    {
        
        float moveMouseX = Input.GetAxis("Mouse X");
        float moveMouseY = Input.GetAxis("Mouse Y");
        

        //마우스 왼쪽클릭시 커서 안보이고, 마우스 움직이면 카메라도 같이 움직임
        if (Input.GetKeyDown(KeyCode.Mouse0))//부드럽게 움직이지않고 끊기듯이 움직임
        {
            Cursor.visible = false;
            movePostion.x -= moveMouseX * moveSpeed;
            movePostion.y -= moveMouseY * moveSpeed;
            maincam.transform.position = movePostion;
        }
        
        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            Cursor.visible = true;
        }
        
    }
}
