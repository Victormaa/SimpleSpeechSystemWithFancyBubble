using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facing2Camera : MonoBehaviour
{
    private Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (_camera == null) return;
        var speechBubbleRect = this.transform.parent.parent;
        Vector3 targetPos = speechBubbleRect.position + _camera.transform.rotation * Vector3.forward;
        Vector3 up = _camera.transform.rotation * Vector3.up;
        speechBubbleRect.LookAt(targetPos, up);
    }
}
