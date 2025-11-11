using UnityEngine;

public class GamerProfileDisplay : MonoBehaviour
{
    void Start()
    {
        // "Loading" effect
        Debug.Log("Loading gamer data...");
        Debug.Log("Connecting to Steam servers...");
        Debug.Log("Profile found! Loading details...\n");

        // Gaming profiel informatie
        Debug.Log("=== GAMING PROFILE ===");
        Debug.Log("Gamer Tag: NikitaP");
        Debug.Log("Favorite Game: Cyberpunk 2077");
        Debug.Log("Gaming Platform: PC (Steam)");
        Debug.Log("Hours Played Today: 4");
        Debug.Log("Current Level: 27");
        Debug.Log("Achievement Unlocked: Script Master 🧠");

        // Extra info
        Debug.Log("Top 3 Favorite Games: ");
        Debug.Log("1. Cyberpunk 2077");
        Debug.Log("2. Red Dead Redemption 2");
        Debug.Log("3. Minecraft");

        Debug.Log("Gaming Setup:");
        Debug.Log("🎧 Headset: Logitech G Pro X");
        Debug.Log("🖱️ Mouse: Razer Basilisk V3");
        Debug.Log("⌨️ Keyboard: Keychron K6 RGB");

        Debug.Log(@"
        ╔════════════════════╗
        ║   LEVEL UP! 🚀     ║
        ║   KEEP GAMING!     ║
        ╚════════════════════╝
        ");

        Debug.Log("==================");
    }
}

