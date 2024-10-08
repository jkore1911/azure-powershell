// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support
{

    /// <summary>State of provisioning of the SAP monitor.</summary>
    public partial struct WorkloadMonitorProvisioningState :
        System.IEquatable<WorkloadMonitorProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.WorkloadMonitorProvisioningState Accepted = @"Accepted";

        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.WorkloadMonitorProvisioningState Creating = @"Creating";

        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.WorkloadMonitorProvisioningState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.WorkloadMonitorProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.WorkloadMonitorProvisioningState Migrating = @"Migrating";

        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.WorkloadMonitorProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.WorkloadMonitorProvisioningState Updating = @"Updating";

        /// <summary>
        /// the value for an instance of the <see cref="WorkloadMonitorProvisioningState" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to WorkloadMonitorProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WorkloadMonitorProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new WorkloadMonitorProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type WorkloadMonitorProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.WorkloadMonitorProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type WorkloadMonitorProvisioningState (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is WorkloadMonitorProvisioningState && Equals((WorkloadMonitorProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum WorkloadMonitorProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for WorkloadMonitorProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>
        /// Creates an instance of the <see cref="WorkloadMonitorProvisioningState"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private WorkloadMonitorProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to WorkloadMonitorProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WorkloadMonitorProvisioningState" />.</param>

        public static implicit operator WorkloadMonitorProvisioningState(string value)
        {
            return new WorkloadMonitorProvisioningState(value);
        }

        /// <summary>Implicit operator to convert WorkloadMonitorProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="WorkloadMonitorProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.WorkloadMonitorProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum WorkloadMonitorProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.WorkloadMonitorProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.WorkloadMonitorProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum WorkloadMonitorProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.WorkloadMonitorProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.WorkloadMonitorProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}