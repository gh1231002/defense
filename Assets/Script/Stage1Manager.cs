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
        

        //���콺 ����Ŭ���� Ŀ�� �Ⱥ��̰�, ���콺 �����̸� ī�޶� ���� ������
        if (Input.GetKeyDown(KeyCode.Mouse0))//�ε巴�� ���������ʰ� ������� ������
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
