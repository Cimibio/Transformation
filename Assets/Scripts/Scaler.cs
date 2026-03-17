using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _scaleMultiplier = 2f;
    private Vector3 _originalScale;
    private Vector3 _targetScale;
    private bool _isGrowing = true;

    private void Start()
    {
        _originalScale = transform.localScale;
        _targetScale = _originalScale * _scaleMultiplier;
    }

    private void Update()
    {
        float step = _scaleSpeed * Time.deltaTime;

        Rescale(step);
    }

    private void Rescale(float step)
    {
        if (_isGrowing && transform.localScale.x >= _targetScale.x)
            _isGrowing = false;
        else if (_isGrowing == false && transform.localScale.x <= _originalScale.x)
            _isGrowing = true;

        Vector3 direction = _isGrowing ? Vector3.one : -Vector3.one;
        transform.localScale += direction * step;
    }
}
