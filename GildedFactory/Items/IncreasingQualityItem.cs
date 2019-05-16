namespace csharpcore.Items
{
    public class IncreasingQualityItem : Item
    {
        protected IncreasingQualityItem(string itemName, int itemQuality, int itemSellIn) : base(itemName, itemQuality, itemSellIn)
        {
           
        }

        protected void IncreaseQuality()
        {
            if (Quality < 50)
            {
                Quality += 1;
            }
        }
    }
}