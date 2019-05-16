using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                var item = Items[i];
                var name = item.Name;

                if (name == "Sulfuras, Hand of Ragnaros")
                {
                    item = new LegendaryItem(item.Name, item.Quality, item.SellIn);
                }
                
                if (name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    HandleBackStagePass(item);
                    continue;
                }

                if (name == "Aged Brie")
                {
                    HandleBrie(item);
                    continue;
                }
                
                item.Update();
            }
        }

        private void HandleBrie(Item item)
        {
            IncreaseQuality(item);

            item.SellIn--;

            if (item.SellIn < 0)
            {
                IncreaseQuality(item);
            }
        }

        private void HandleBackStagePass(Item item)
        {
            IncreaseQuality(item);

            item.SellIn--;

            if (item.SellIn < 10)
            {
                IncreaseQuality(item);
            }

            if (item.SellIn < 5)
            {
                IncreaseQuality(item);
            }

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }

        private void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality += 1;
            }
        }
    }
}