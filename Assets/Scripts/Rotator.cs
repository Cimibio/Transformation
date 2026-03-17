using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationDireñtion;

    private void Update()
    {
        transform.Rotate(_rotationDireñtion);
    }
}
