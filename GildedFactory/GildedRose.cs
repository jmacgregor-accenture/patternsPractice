using System.Collections.Generic;
using csharpcore.Items;

namespace csharpcore
{
    public class GildedRose
    {
        public IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = new List<Item>();

            foreach (var item in Items)
            {
                this.Items.Add(ItemFactory(item.Name, item.Quality, item.SellIn));
            }
        }

        private Item ItemFactory(string name, int quality, int sellin)
        {
            switch (name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryItem(name, quality, sellin);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackStagePassQualityItem(name, quality, sellin);
                default:
                    return new Item(name, quality, sellin);
            }
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item.Name == "Aged Brie")
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