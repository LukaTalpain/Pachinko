using UnityEngine;
using UnityEngine.Rendering;

public class BonusCollider : MonoBehaviour
{
    public BonusManager manager;
    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);
        manager.BonusObtained();

    }
}
