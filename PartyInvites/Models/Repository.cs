using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();

        public static void AddResponse(GuestResponse response) => responses.Add(response);

        public static List<GuestResponse> GuestResponses() => responses;
    }
}
