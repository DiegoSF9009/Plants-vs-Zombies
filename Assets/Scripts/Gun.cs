using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
   
    [SerializeField]

    private Health health;
    [SerializeField]

    private GunData gunData;
    [SerializeField]

    private InstantiatePoolObjects bulletPool;
    [SerializeField]

    private Transform bulletPivot;
    private Coroutine shootCoroutine;
    private void OnEnable()
    {
        health.InitializeHealth(100f);
        SoundManager.instance.Play(gunData.appearSoundName);
        shootCoroutine = StartCoroutine(ShootRoutine());
    }

    private IEnumerator ShootRoutine()
    {
        Animator animator = GetComponent();
        while (true)
        {
            bulletPool.InstantiateObject(bulletPivot);
            SoundManager.instace.Play(gunData.shootSoundName);
            yield return new WaitForSeconds(gunData.fireRate);

        }
    }
     
     public void Die()
    {
        if (shootCoroutine != null)
        {
            stopCoroutine(shootCoroutine);
        }
        SoundManager.instance.Play(gunData.dieShootName);
        gameObject.SetActive(false);
    }
}
