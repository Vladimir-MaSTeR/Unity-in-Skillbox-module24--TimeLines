using UnityEngine;

public class MoveToLadder : MonoBehaviour {

    [SerializeField]
    private Vector3[] points;

    private int current = 0;

    private void Start() {
        current = 0;
    }


    public void MovePlayer_1() {
       // if(current == 0) {
            Debug.Log($"������ ����� = {points[0]}");
            this.gameObject.transform.position = points[0];
            current++;
            Debug.Log($"������� ��������� = {this.gameObject.transform.position}");
       // }

        //if(current == 1) {
        //    Debug.Log($"������ ����� = {points[1]}");
        //    this.gameObject.transform.position = points[1];
        //    current++;
        //    Debug.Log($"������� ��������� = {this.gameObject.transform.position}");
        //}

        //if(current == 2) {
        //    Debug.Log($"������ ����� = {points[2]}");
        //    this.gameObject.transform.position = points[2];
        //    current++;
        //    Debug.Log($"������� ��������� = {this.gameObject.transform.position}");
        //}

        //if(current == 3) {
        //    Debug.Log($"��������� ����� = {points[3]}");
        //    this.gameObject.transform.position = points[3];
        //    current++;
        //    Debug.Log($"������� ��������� = {this.gameObject.transform.position}");
        //}


    }

    public void MovePlayer_2() {
        Debug.Log($"������ ����� = {points[1]}");

        this.gameObject.transform.position = points[1];
        current++;

        Debug.Log($"������� ��������� = {this.gameObject.transform.position}");
        
    }

    public void MovePlayer_3() {
        Debug.Log($"������ ����� = {points[2]}");

        this.gameObject.transform.position = points[2];
        current++;

        Debug.Log($"������� ��������� = {this.gameObject.transform.position}");

    }

    public void MovePlayer_4() {
        Debug.Log($"������ ����� = {points[3]}");

        this.gameObject.transform.position = points[3];
        current++;

        Debug.Log($"������� ��������� = {this.gameObject.transform.position}");

    }

}
