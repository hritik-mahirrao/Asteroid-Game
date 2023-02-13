using UnityEngine;

public class ScreenWrapper : MonoBehaviour
{
    private float _screenWidth;
    private float _screenHeight;
    private Vector3 _screenBounds;
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
        _screenWidth = _camera.orthographicSize * _camera.aspect;
        _screenHeight = _camera.orthographicSize;
        _screenBounds = new Vector3(_screenWidth, _screenHeight, 0);
    }

    private void LateUpdate()
    {
        Vector3 viewPos = _camera.WorldToViewportPoint(transform.position);
        Vector3 newPos = transform.position;

        if (viewPos.x > 1)
        {
            newPos.x = -_screenBounds.x;
        }
        else if (viewPos.x < 0)
        {
            newPos.x = _screenBounds.x;
        }

        if (viewPos.y > 1)
        {
            newPos.z = -_screenBounds.y;
        }
        else if (viewPos.y < 0)
        {
            newPos.z = _screenBounds.y;
        }

        transform.position = newPos;
    }
}