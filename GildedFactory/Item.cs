namespace csharpcore
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update()
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
