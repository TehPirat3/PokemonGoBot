/*using AllEnum;
using Google.Protobuf;
using PokemonGoBot.API;
using PokemonGoBot.API.Enums;
using PokemonGoBot.API.GeneratedCode;
using PokemonGoBot.API.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGoBot.Classes
{
    public class Recycle
    {
        private Request.Types.UnknownAuth _unknownAuth;
        public async Task<IEnumerable<Item>> GetItemsToRecycle(ISettings settings, Client client)
        {
            var myItems = await GetItems(client);

            return myItems
                .Where(x => settings.ItemRecycleFilter.Any(f => f.Key == ((ItemId)x.Item_) && x.Count > f.Value))
                .Select(x => new Item { Item_ = x.Item_, Count = x.Count - settings.ItemRecycleFilter.Single(f => f.Key == (AllEnum.ItemId)x.Item_).Value, Unseen = x.Unseen });
        }
        public async Task RecycleItems(Client client, int id)
        {
            var _settings = Main.clientData[id];
            var items = await GetItemsToRecycle(_settings, client);

            foreach (var item in items)
            {
                var transfer = await RecycleItem((AllEnum.ItemId)item.Item_, item.Count);
                Main.Logg(id, Color.DarkCyan, $"[{DateTime.Now.ToString("HH:mm:ss")}] Recycled {item.Count}x {(AllEnum.ItemId)item.Item_}");
                await Task.Delay(500);
            }
            await Task.Delay(_settings.RecycleItemsInterval * 1000);
            RecycleItems(client, id);
        }
        public async Task<Response.Types.Unknown6> RecycleItem(AllEnum.ItemId itemId, int amount)
        {
            var customRequest = new InventoryItemData.RecycleInventoryItem
            {
                ItemId = (AllEnum.ItemId)Enum.Parse(typeof(AllEnum.ItemId), itemId.ToString()),
                Count = amount
            };

            var releasePokemonRequest = RequestBuilder.GetRequest(_unknownAuth, _currentLat, _currentLng, 30,
                new Request.Types.Requests()
                {
                    Type = (int)RequestType.RECYCLE_INVENTORY_ITEM,
                    Message = customRequest.ToByteString()
                });
            return await _httpClient.PostProtoPayload<Request, Response.Types.Unknown6>($"https://{_apiUrl}/rpc", releasePokemonRequest);
        }
        public async Task<IEnumerable<Item>> GetItems(Client client)
        {
            var inventory = await client.GetInventory();
            return inventory.InventoryDelta.InventoryItems
                .Select(i => i.InventoryItemData?.Item)
                .Where(p => p != null);
        }
    }
}
*/