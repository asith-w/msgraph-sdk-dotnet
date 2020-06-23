// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Photo.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Photo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Photo"/> class.
        /// </summary>
        public Photo()
        {
            this.ODataType = "microsoft.graph.photo";
        }

        /// <summary>
        /// Gets or sets cameraMake.
        /// Camera manufacturer. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cameraMake", Required = Newtonsoft.Json.Required.Default)]
        public string CameraMake { get; set; }
    
        /// <summary>
        /// Gets or sets cameraModel.
        /// Camera model. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cameraModel", Required = Newtonsoft.Json.Required.Default)]
        public string CameraModel { get; set; }
    
        /// <summary>
        /// Gets or sets exposureDenominator.
        /// The denominator for the exposure time fraction from the camera. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exposureDenominator", Required = Newtonsoft.Json.Required.Default)]
        public double? ExposureDenominator { get; set; }
    
        /// <summary>
        /// Gets or sets exposureNumerator.
        /// The numerator for the exposure time fraction from the camera. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exposureNumerator", Required = Newtonsoft.Json.Required.Default)]
        public double? ExposureNumerator { get; set; }
    
        /// <summary>
        /// Gets or sets fNumber.
        /// The F-stop value from the camera. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fNumber", Required = Newtonsoft.Json.Required.Default)]
        public double? FNumber { get; set; }
    
        /// <summary>
        /// Gets or sets focalLength.
        /// The focal length from the camera. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "focalLength", Required = Newtonsoft.Json.Required.Default)]
        public double? FocalLength { get; set; }
    
        /// <summary>
        /// Gets or sets iso.
        /// The ISO value from the camera. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iso", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Iso { get; set; }
    
        /// <summary>
        /// Gets or sets orientation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "orientation", Required = Newtonsoft.Json.Required.Default)]
        public Int16? Orientation { get; set; }
    
        /// <summary>
        /// Gets or sets takenDateTime.
        /// Represents the date and time the photo was taken. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "takenDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? TakenDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
