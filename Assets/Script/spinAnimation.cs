using DG.Tweening;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class spinAnimation : MonoBehaviour
{
    void Start()
    {
        transform.DORotate(new Vector3(0, 360, 0), 2f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
    }
}
