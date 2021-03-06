// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes Advanced Audio Codec (AAC) audio encoding settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.AacAudio")]
    public partial class AacAudio : Audio
    {
        /// <summary>
        /// Initializes a new instance of the AacAudio class.
        /// </summary>
        public AacAudio()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AacAudio class.
        /// </summary>
        /// <param name="label">An optional label for the codec. The label can
        /// be used to control muxing behavior.</param>
        /// <param name="channels">The number of channels in the audio.</param>
        /// <param name="samplingRate">The sampling rate to use for encoding in
        /// hertz.</param>
        /// <param name="bitrate">The bitrate, in bits per second, of the
        /// output encoded audio.</param>
        /// <param name="profile">The encoding profile to be used when encoding
        /// audio with AAC. Possible values include: 'AacLc', 'HeAacV1',
        /// 'HeAacV2'</param>
        public AacAudio(string label = default(string), int? channels = default(int?), int? samplingRate = default(int?), int? bitrate = default(int?), string profile = default(string))
            : base(label, channels, samplingRate, bitrate)
        {
            Profile = profile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the encoding profile to be used when encoding audio
        /// with AAC. Possible values include: 'AacLc', 'HeAacV1', 'HeAacV2'
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public string Profile { get; set; }

    }
}
