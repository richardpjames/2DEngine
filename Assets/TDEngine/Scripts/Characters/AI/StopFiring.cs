using UnityEngine;

namespace richardpjames.com.TDEngine.Characters.AI
{
    [AddComponentMenu("TD Engine/Characters/AI Actions/Stop Firing")]

    public class StopFiring : CharacterAIAction, IAction
    {
        public override void Perform()
        {
            // Get the character weapon, and return if not present
            CharacterWeaponSlot weaponSlot = GetComponent<CharacterWeaponSlot>();
            if (weaponSlot == null) return;
            // Stop firing
            weaponSlot.SetFiring(false);
        }
    }
}