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
                    continue;
                }

                if (name != "Backstage passes to a TAFKAL80ETC concert" &&
                    name != "Aged Brie" &&
                    name != "Sulfuras, Hand of Ragnaros")
                {
                    item.Update();
                    continue;
                }

                if (name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    HandleBackStagePass(item);
                    continue;
                }

                IncreaseQuality(item);

                Items[i].SellIn = Items[i].SellIn - 1;

                if (item.SellIn < 0)
                {
                    IncreaseQuality(item);
                }
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

        private void DecreaseQuality(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.Quality -= 1;
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