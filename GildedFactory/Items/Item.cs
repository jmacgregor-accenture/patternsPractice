namespace csharpcore.Items
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        
        public Item() {}
        
        public Item(string itemName, int itemQuality, int itemSellIn)
        {
            Name = itemName;
            SellIn = itemSellIn;
            Quality = itemQuality;
        }
        
        public virtual void Update()
        {
            SellIn--;
            DecreaseQuality();

            if (SellIn < 0)
            {
                DecreaseQuality();
            }
        }

        private void DecreaseQuality()
        {
            if (Quality > 0)
            {
                Quality--;
            }
        }
    }
}
