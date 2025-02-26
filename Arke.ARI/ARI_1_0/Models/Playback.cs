/*
   Arke ARI Framework
   Automatically generated file @ 6/23/2023 11:34:36 AM
*/
using System;
using System.Collections.Generic;
using Arke.ARI.Actions;

namespace Arke.ARI.Models
{
    /// <summary>
    /// Object representing the playback of media to a channel
    /// </summary>
    public class Playback
    {


        /// <summary>
        /// ID for this playback operation
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The URI for the media currently being played back.
        /// </summary>
        public string Media_uri { get; set; }

        /// <summary>
        /// If a list of URIs is being played, the next media URI to be played back.
        /// </summary>
        public string Next_media_uri { get; set; }

        /// <summary>
        /// URI for the channel or bridge to play the media on
        /// </summary>
        public string Target_uri { get; set; }

        /// <summary>
        /// For media types that support multiple languages, the language requested for playback.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Current state of the playback operation.
        /// </summary>
        public string State { get; set; }

    }
}
