using UnityEngine;
using UnityEngine.LowLevelPhysics;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private RawImage brain_texture_0;
    [SerializeField] private float _x, _y;

    // Update is called once per frame
    void Update()
    {
        brain_texture_0.uvRect = new Rect(brain_texture_0.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, brain_texture_0.uvRect.size);

    }
}
