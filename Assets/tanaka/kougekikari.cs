        using System.Collections;
        using System.Collections.Generic;
        using UnityEngine;
        using UnityEngine.UI; 

public class kougekikari : MonoBehaviour
    {
        Rigidbody2D rd; //Rigidbody�I�u�W�F�N�g
       // float attspeed = 6.0f;  //�I�u�W�F�N�g�ړ��X�s�[�h

        // ���x
         public float Speed;

        // �p�x
         public float Angle;

        // �ړ��x�N�g��
        Vector3 vec;

       private float limit;

        void Start()
        {
            rd = GetComponent<Rigidbody2D>();   //Rigidbody�R���|�[�l���g�擾

            limit = 1.0f;

            float rad = Angle * Mathf.Deg2Rad;

            Vector3 direction = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad), 0);

            vec = direction * Speed * Time.deltaTime;


        }

        void Update()
        {
        if (Input.GetKeyDown(KeyCode.Space))//�U���J�n��(Space�L�[�������ƍU���J�n)
        {
            transform.position += vec;

            limit -= Time.deltaTime;
            if (limit <= 0)
            {
                Destroy(gameObject);    //�U���I�u�W�F�N�g�̔j��
            }

            
        }
             //rd.velocity = new Vector2(0, attspeed); //�X�s�[�h�����čU���I�u�W�F�N�g���ړ�
        }

       

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(gameObject);    //�U���I�u�W�F�N�g�̔j��
        }
    }
