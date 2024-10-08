// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>scale settings for AML Compute</summary>
    public partial class ScaleSettings :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScaleSettings,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScaleSettingsInternal
    {

        /// <summary>Backing field for <see cref="MaxNodeCount" /> property.</summary>
        private int _maxNodeCount;

        /// <summary>Max number of nodes to use</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int MaxNodeCount { get => this._maxNodeCount; set => this._maxNodeCount = value; }

        /// <summary>Backing field for <see cref="MinNodeCount" /> property.</summary>
        private int? _minNodeCount;

        /// <summary>Min number of nodes to use</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? MinNodeCount { get => this._minNodeCount; set => this._minNodeCount = value; }

        /// <summary>Backing field for <see cref="NodeIdleTimeBeforeScaleDown" /> property.</summary>
        private global::System.TimeSpan? _nodeIdleTimeBeforeScaleDown;

        /// <summary>
        /// Node Idle Time before scaling down amlCompute. This string needs to be in the RFC Format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public global::System.TimeSpan? NodeIdleTimeBeforeScaleDown { get => this._nodeIdleTimeBeforeScaleDown; set => this._nodeIdleTimeBeforeScaleDown = value; }

        /// <summary>Creates an new <see cref="ScaleSettings" /> instance.</summary>
        public ScaleSettings()
        {

        }
    }
    /// scale settings for AML Compute
    public partial interface IScaleSettings :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Max number of nodes to use</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Max number of nodes to use",
        SerializedName = @"maxNodeCount",
        PossibleTypes = new [] { typeof(int) })]
        int MaxNodeCount { get; set; }
        /// <summary>Min number of nodes to use</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Min number of nodes to use",
        SerializedName = @"minNodeCount",
        PossibleTypes = new [] { typeof(int) })]
        int? MinNodeCount { get; set; }
        /// <summary>
        /// Node Idle Time before scaling down amlCompute. This string needs to be in the RFC Format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Node Idle Time before scaling down amlCompute. This string needs to be in the RFC Format.",
        SerializedName = @"nodeIdleTimeBeforeScaleDown",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? NodeIdleTimeBeforeScaleDown { get; set; }

    }
    /// scale settings for AML Compute
    internal partial interface IScaleSettingsInternal

    {
        /// <summary>Max number of nodes to use</summary>
        int MaxNodeCount { get; set; }
        /// <summary>Min number of nodes to use</summary>
        int? MinNodeCount { get; set; }
        /// <summary>
        /// Node Idle Time before scaling down amlCompute. This string needs to be in the RFC Format.
        /// </summary>
        global::System.TimeSpan? NodeIdleTimeBeforeScaleDown { get; set; }

    }
}