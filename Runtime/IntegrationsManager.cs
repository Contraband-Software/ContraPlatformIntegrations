using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntegrationsManager : MonoBehaviour
{
    [Header("Integration Controllers")]
    [SerializeField] AdvertisementsManager advertisementsManager;
#if UNITY_ANALYTICS
    [SerializeField] DataPrivacyHandler dataPrivacyHandler;
    public DataPrivacyHandler GetDataPrivacy() { return dataPrivacyHandler; }
#endif

    public AdvertisementsManager GetAdvertisements() { return advertisementsManager; }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
