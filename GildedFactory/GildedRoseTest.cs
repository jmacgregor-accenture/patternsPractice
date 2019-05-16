using Xunit;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 24 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }
    }
}