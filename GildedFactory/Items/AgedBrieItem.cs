namespace csharpcore.Items
{
    public class AgedBrieItem : IncreasingQualityItem
    {
        public override void Update()
        {
            IncreaseQuality();

            SellIn--;

            if (SellIn < 0)
            {
                IncreaseQuality();
            }
        }

        public AgedBrieItem(string itemName, int itemQuality, int itemSellIn) : base(itemName, itemQuality, itemSellIn)
        {
            
        }
    }
}