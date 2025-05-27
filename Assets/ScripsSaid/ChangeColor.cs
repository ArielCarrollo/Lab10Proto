using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ChangeColor : MonoBehaviour
{

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
       _propBlock= new MaterialPropertyBlock();

    }

    //void Update()
    //{
    //    _renderer.material.SetColor(name:"Color", value: GetRandomColor());
    //}
    private void Update()
    {
       
        _renderer.GetPropertyBlock(_propBlock);

        _propBlock.SetColor("_BaseColor", GetRandomColor());
        _renderer.SetPropertyBlock(_propBlock);
    }
    private Color GetRandomColor()
    {
        return new Color(
            Random.Range(0f, 1f),
             Random.Range(0f, 1f),
              Random.Range(0f, 1f));
    }
    private MaterialPropertyBlock _propBlock;
}
