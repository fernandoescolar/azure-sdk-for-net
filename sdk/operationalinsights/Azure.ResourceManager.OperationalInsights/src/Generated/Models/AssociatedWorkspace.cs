// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The list of Log Analytics workspaces associated with the cluster. </summary>
    public partial class AssociatedWorkspace
    {
        /// <summary> Initializes a new instance of AssociatedWorkspace. </summary>
        public AssociatedWorkspace()
        {
        }

        /// <summary> Initializes a new instance of AssociatedWorkspace. </summary>
        /// <param name="workspaceId"> The id of the assigned workspace. </param>
        /// <param name="workspaceName"> The name id the assigned workspace. </param>
        /// <param name="resourceId"> The ResourceId id the assigned workspace. </param>
        /// <param name="associateDate"> The time of workspace association. </param>
        internal AssociatedWorkspace(string workspaceId, string workspaceName, string resourceId, string associateDate)
        {
            WorkspaceId = workspaceId;
            WorkspaceName = workspaceName;
            ResourceId = resourceId;
            AssociateDate = associateDate;
        }

        /// <summary> The id of the assigned workspace. </summary>
        public string WorkspaceId { get; }
        /// <summary> The name id the assigned workspace. </summary>
        public string WorkspaceName { get; }
        /// <summary> The ResourceId id the assigned workspace. </summary>
        public string ResourceId { get; }
        /// <summary> The time of workspace association. </summary>
        public string AssociateDate { get; }
    }
}
