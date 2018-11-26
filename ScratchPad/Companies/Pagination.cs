using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Companies
{
    public class Pagination
    {
        public static IList<string> GetDisplay(string[] inputs, int pageSize)
        {
            var places = new List<Place>();
            var display = new List<string>();

            var dict = new Dictionary<int, HashSet<int>>();

            // Parse input into a Place object
            foreach (var input in inputs)
            {
                var parts = input.Split(',');
                places.Add(new Place()
                {
                    HostId = int.Parse(parts[0]),
                    ListingId = int.Parse(parts[1]),
                    Score = decimal.Parse(parts[2]),
                    City = parts[3]
                });
            }

            // Create a mapping between hostId to a set of listing Ids
            foreach (var place in places)
            {
                var hostId = place.HostId;
                var listId = place.ListingId;
                if(!dict.ContainsKey(hostId))
                    dict[hostId] = new HashSet<int>();
                dict[hostId].Add(listId);
            }

            // Loop until all places in the inout list aren't included.
            while (dict.Any(kv => kv.Value.Count != 0))
            {
                var currPage = new HashSet<Place>();
                var duplicatesOnCurrPage = new List<Place>();
                var duplicatesNow = false;

                while (currPage.Count + duplicatesOnCurrPage.Count != pageSize && dict.Any(kv => kv.Value.Count != 0))
                {
                    foreach (var entry in dict)
                    {
                        if (dict[entry.Key].Count == 0)
                            continue;
                        var listingId = dict[entry.Key].First();
                        var thisPlace = places.First(p => p.HostId == entry.Key && p.ListingId == listingId);
                        if(!duplicatesNow)
                            currPage.Add(thisPlace);
                        else
                        {
                            duplicatesOnCurrPage.Add(thisPlace);
                        }

                        dict[entry.Key].Remove(listingId);
                        if (currPage.Count + duplicatesOnCurrPage.Count == pageSize)
                            break;
                    }

                    // Iterated over complete list so might need to include duplicates now.
                    duplicatesNow = true;
                }

                // Sort places based on score.
                foreach (var place in currPage.OrderByDescending(t => t.Score))
                {
                    display.Add(place.ToString());
                }

                // Sort duplicates based on score.
                foreach (var place in duplicatesOnCurrPage.OrderByDescending(t => t.Score))
                {
                    display.Add(place.ToString());
                }
                display.Add(" ");
            }

            display.RemoveAt(display.Count-1);
            return display;
        }

        public class Place
        {
            public int HostId { get; set; }
            public int ListingId { get; set; }
            public decimal Score { get; set; }

            public string City { get; set; }

            public override string ToString()
            {
                return $"{HostId},{ListingId},{Score},{City}";
            }
        }
    }
}
