using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource suspenseTrack;
    public AudioSource fightTrack;
    public AudioSource defaultTrack;

    private AudioSource currentTrack;
    private string currentState = "default";
    private float switchCooldown = 1f;
    private float lastSwitchTime = 0f;

    void Start()
    {
        PlayTrack(defaultTrack);
        currentState = "default";
    }

    void Update()
    {
        // Replace with real logic from your game
        bool nearSupplyStore = CheckPlayerNearSupplyStore();
        bool playerShooting = CheckPlayerShooting();

        if (playerShooting && currentState != "fight")
        {
            TrySwitchTrack(fightTrack, "fight");
        }
        else if (nearSupplyStore && currentState != "suspense" && currentState != "fight")
        {
            TrySwitchTrack(suspenseTrack, "suspense");
        }
        else if (!nearSupplyStore && !playerShooting && currentState != "default")
        {
            TrySwitchTrack(defaultTrack, "default");
        }
    }

    void TrySwitchTrack(AudioSource newTrack, string newState)
    {
        if (Time.time - lastSwitchTime < switchCooldown) return;

        PlayTrack(newTrack);
        currentState = newState;
        lastSwitchTime = Time.time;
    }

    void PlayTrack(AudioSource newTrack)
    {
        if (currentTrack != null)
        {
            currentTrack.Stop();
        }

        currentTrack = newTrack;
        currentTrack.Play();
    }

    // === Replace these with your real player logic ===
    bool CheckPlayerNearSupplyStore()
    {
        // For now, just return false
        return false;
    }

    bool CheckPlayerShooting()
    {
        // For now, just return false
        return false;
    }
}
