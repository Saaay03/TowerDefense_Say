using UnityEngine;

[CreateAssetMenu(fileName = "NewScriptableObjectScript", menuName = "Scriptable Objects/NewScriptableObjectScript")]
public class NewScriptableObjectScript : ScriptableObject
{
    public float fireRate = 1f;
    public float damage = 10f;
    public GameObject shootParticlesPrefab;
    public string shootSoundName = "Shoot";
}
