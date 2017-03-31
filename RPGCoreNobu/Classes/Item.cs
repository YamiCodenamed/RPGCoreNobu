using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCoreNobu.Classes
{
    class Item
    {
        private int itemID;
        private string itemName;
        private string itemDescription;

        public string ItemName { get => itemName; set => itemName = value; }
        public string ItemDescription { get => itemDescription; set => itemDescription = value; }
        public int ItemID { get => itemID; set => itemID = value; }

        public override string ToString()
        {
            return this.ItemName + Environment.NewLine + this.itemDescription;
        }

        public virtual void UseItem()
        {
            //The stock item class does not have a use function, while its children classes do
            return;
        }

        // Just a stock constructor, no need to se the name or description becase the controller does that
        public Item() { }
    }
    class OwnedItem : Item
    {
        private int ownerID;
        public int OwnerID { get => ownerID; set => ownerID = value; }
    }

    class UsableItem : OwnedItem
    {
        private int itemSpellID;

        public int ItemSpellID { get => itemSpellID; set => itemSpellID = value; }

        public override void UseItem()
        {
            //Waiting for implementation of the SpellController
        }
    }
    class EquipmentItem : OwnedItem
    {
        private int itemEquipSlot;
        private List<int> itemSpellEffects;

        public int ItemEquipSlot { get => itemEquipSlot; set => itemEquipSlot = value; }
        public List<int> ItemSpellEffects { get => itemSpellEffects; set => itemSpellEffects = value; }
    }
}
