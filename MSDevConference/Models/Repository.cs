using System;
using System.Collections.Generic;

namespace MSDevConference.Models
{
    public static class Repository
    {
        // Allows for respsones to be added to the group of Webinar Invites.
        private static List<WebinarInvites> responses = new List<WebinarInvites>();

        // Allows us to acceess the group of WebinarInvites as a whole.
        public static IEnumerable<WebinarInvites> Responses = responses;

        public static void AddResponse(WebinarInvites response)
        {
            responses.Add(response);
        }
    }
}
