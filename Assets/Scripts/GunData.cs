using UnityEngine;

[CreateAssetMenu(fileName = "GunData1", menuName = "Scriptable Objects/GunData1")]
public class GunData1 : ScriptableObject
{
        public float fireRate = 1f;
    public float damage = 10f;
    public GameObject shootParticlesPrefab;
    public string shootSoundName = "Shoot";
}
