using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Camera.main.WorldToScreenPoint(this.transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        // ��ϰ��2
        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 mPosition = Input.mousePosition;
            mPosition.z = 20;// �Լ������
            obj.transform.position = Camera.main.ScreenToWorldPoint(mPosition);


        }
    }
}
