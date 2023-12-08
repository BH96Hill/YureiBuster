using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{

    // ���������Őؒf����ꍇ
    private Vector3 prePos = Vector3.zero;
    private Vector3 prePos2 = Vector3.zero;

    public static int score = 0;

    void FixedUpdate()
    {
        prePos = prePos2;
        prePos2 = transform.position;
    }

    // ���̃R���|�[�l���g��t�����I�u�W�F�N�g��Collider.IsTrigger��ON�ɂ���
    void OnTriggerEnter(Collider other)
    {
        var meshCut = other.gameObject.GetComponent<MeshCut>();
        var newMeshCut = other.gameObject.GetComponent<NewMeshCut>();
        if (meshCut == null) { return; }
        //������݂̂Őؒf������@�A�����ɂ��Ă͓K�X�ύX
        var cutPlane = new Plane(transform.right, transform.position);
        //�����Őؒf����ꍇ
        //var cutPlane = new Plane (Vector3.Cross(transform.forward.normalized, prePos - transform.position).normalized, transform.position);
        meshCut.Cut(cutPlane);

        string yourTag = other.gameObject.tag;

        if (yourTag == "Enemy")
        {
            AddScore();
        }
        if (yourTag == "NotEnemy")
        {
            SubScore();
        }

    }

    public void AddScore()
    {
        score++;
        Debug.Log("score="+score);
    }

    public void SubScore()
    {
        score --;
        if (score <= 0)
        {
            score = 0;
        }
    }
}