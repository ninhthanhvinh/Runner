using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnterRotate : MonoBehaviour
{
    public float angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Rotate");
        //other.transform.Rotate(angle * Vector3.up);
        StartCoroutine(SmoothRotate(other.transform, Vector3.up * angle, .4f)); 
    }

    IEnumerator SmoothRotate(Transform _transform ,Vector3 byAngles, float inTime)
    {
        var fromAngle = _transform.rotation;
        var toAngle = Quaternion.Euler(_transform.eulerAngles + byAngles);
        for (var t = 0f; t < 1; t += Time.deltaTime / inTime)
        {
            _transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
            yield return null;
        }
    }
}
