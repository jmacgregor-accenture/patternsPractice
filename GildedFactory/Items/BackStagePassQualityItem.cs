namespace csharpcore.Items
{
    public class BackStagePassQualityItem : IncreasingQualityItem
    {
        public BackStagePassQualityItem(string itemName, int itemQuality, int itemSellIn) : base(itemName, itemQuality, itemSellIn)
        {
            
        }

        public override void Update()
        {
            IncreaseQuality();

            SellIn--;

            if (SellIn < 10)
            {
                IncreaseQuality();
            }

            if (SellIn < 5)
            {
                IncreaseQuality();
            }

            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
        
    }
}