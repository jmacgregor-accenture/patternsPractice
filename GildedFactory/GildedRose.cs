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
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0)
                    {
                        DecreaseQuality(i);
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            HandleBackStagePass(i);
                        }
                    }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Aged Brie")
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Quality > 0)
                            {
                                DecreaseQuality(i);
                            }
                        }
                        else
                        {
                            Items[i].Quality = 0;
                        }
                    }
                    else
                    {
                        IncreaseQuality(i);
                    }
                }
            }
        }

        private void HandleBackStagePass(int i)
        {
            if (Items[i].SellIn < 11)
            {
                IncreaseQuality(i);
            }

            if (Items[i].SellIn < 6)
            {
                IncreaseQuality(i);
            }
        }

        private void DecreaseQuality(int i)
        {
            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            {
                Items[i].Quality = Items[i].Quality - 1;
            }
        }

        private void IncreaseQuality(int i)
        {
            if (Items[i].Quality < 50)
            {
                Items[i].Quality = Items[i].Quality + 1;
            }
        }
    }
}
