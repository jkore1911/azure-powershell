// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Extensions;

    /// <summary>The scaling rule.</summary>
    public partial class ScalingRule :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IScalingRule,
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IScalingRuleInternal
    {

        /// <summary>Backing field for <see cref="ActionType" /> property.</summary>
        private string _actionType;

        /// <summary>The action type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string ActionType { get => this._actionType; set => this._actionType = value; }

        /// <summary>Backing field for <see cref="ComparisonRule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IComparisonRule _comparisonRule;

        /// <summary>The comparison rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IComparisonRule ComparisonRule { get => (this._comparisonRule = this._comparisonRule ?? new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ComparisonRule()); set => this._comparisonRule = value; }

        /// <summary>The comparison operator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inlined)]
        public string ComparisonRuleOperator { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IComparisonRuleInternal)ComparisonRule).Operator; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IComparisonRuleInternal)ComparisonRule).Operator = value ; }

        /// <summary>Threshold setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inlined)]
        public float ComparisonRuleThreshold { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IComparisonRuleInternal)ComparisonRule).Threshold; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IComparisonRuleInternal)ComparisonRule).Threshold = value ; }

        /// <summary>Backing field for <see cref="EvaluationCount" /> property.</summary>
        private int _evaluationCount;

        /// <summary>
        /// This is an evaluation count for a scaling condition, the number of times a trigger condition should be successful, before
        /// scaling activity is triggered.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public int EvaluationCount { get => this._evaluationCount; set => this._evaluationCount = value; }

        /// <summary>Internal Acessors for ComparisonRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IComparisonRule Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IScalingRuleInternal.ComparisonRule { get => (this._comparisonRule = this._comparisonRule ?? new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ComparisonRule()); set { {_comparisonRule = value;} } }

        /// <summary>Backing field for <see cref="ScalingMetric" /> property.</summary>
        private string _scalingMetric;

        /// <summary>Metrics name for individual workloads. For example: cpu</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string ScalingMetric { get => this._scalingMetric; set => this._scalingMetric = value; }

        /// <summary>Creates an new <see cref="ScalingRule" /> instance.</summary>
        public ScalingRule()
        {

        }
    }
    /// The scaling rule.
    public partial interface IScalingRule :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IJsonSerializable
    {
        /// <summary>The action type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The action type.",
        SerializedName = @"actionType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PSArgumentCompleterAttribute("scaleup", "scaledown")]
        string ActionType { get; set; }
        /// <summary>The comparison operator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The comparison operator.",
        SerializedName = @"operator",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PSArgumentCompleterAttribute("greaterThan", "greaterThanOrEqual", "lessThan", "lessThanOrEqual")]
        string ComparisonRuleOperator { get; set; }
        /// <summary>Threshold setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Threshold setting.",
        SerializedName = @"threshold",
        PossibleTypes = new [] { typeof(float) })]
        float ComparisonRuleThreshold { get; set; }
        /// <summary>
        /// This is an evaluation count for a scaling condition, the number of times a trigger condition should be successful, before
        /// scaling activity is triggered.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This is an evaluation count for a scaling condition, the number of times a trigger condition should be successful, before scaling activity is triggered.",
        SerializedName = @"evaluationCount",
        PossibleTypes = new [] { typeof(int) })]
        int EvaluationCount { get; set; }
        /// <summary>Metrics name for individual workloads. For example: cpu</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Metrics name for individual workloads. For example: cpu",
        SerializedName = @"scalingMetric",
        PossibleTypes = new [] { typeof(string) })]
        string ScalingMetric { get; set; }

    }
    /// The scaling rule.
    internal partial interface IScalingRuleInternal

    {
        /// <summary>The action type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PSArgumentCompleterAttribute("scaleup", "scaledown")]
        string ActionType { get; set; }
        /// <summary>The comparison rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IComparisonRule ComparisonRule { get; set; }
        /// <summary>The comparison operator.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PSArgumentCompleterAttribute("greaterThan", "greaterThanOrEqual", "lessThan", "lessThanOrEqual")]
        string ComparisonRuleOperator { get; set; }
        /// <summary>Threshold setting.</summary>
        float ComparisonRuleThreshold { get; set; }
        /// <summary>
        /// This is an evaluation count for a scaling condition, the number of times a trigger condition should be successful, before
        /// scaling activity is triggered.
        /// </summary>
        int EvaluationCount { get; set; }
        /// <summary>Metrics name for individual workloads. For example: cpu</summary>
        string ScalingMetric { get; set; }

    }
}