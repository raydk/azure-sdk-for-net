// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The application client details to track the entity creating/updating the managed app resource. </summary>
    public partial class ArmApplicationDetails
    {
        /// <summary> Initializes a new instance of ArmApplicationDetails. </summary>
        internal ArmApplicationDetails()
        {
        }

        /// <summary> Initializes a new instance of ArmApplicationDetails. </summary>
        /// <param name="oid"> The client Oid. </param>
        /// <param name="puid"> The client Puid. </param>
        /// <param name="applicationId"> The client application Id. </param>
        internal ArmApplicationDetails(Guid? oid, string puid, Guid? applicationId)
        {
            Oid = oid;
            Puid = puid;
            ApplicationId = applicationId;
        }

        /// <summary> The client Oid. </summary>
        public Guid? Oid { get; }
        /// <summary> The client Puid. </summary>
        public string Puid { get; }
        /// <summary> The client application Id. </summary>
        public Guid? ApplicationId { get; }
    }
}
