// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.PowerShell;

    /// <summary>The validation result for a Linker.</summary>
    [System.ComponentModel.TypeConverter(typeof(ValidateResultTypeConverter))]
    public partial class ValidateResult
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ValidateResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResult"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResult DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ValidateResult(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ValidateResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResult"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResult DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ValidateResult(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ValidateResult" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ValidateResult" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResult FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ValidateResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ValidateResult(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LinkerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).LinkerName = (string) content.GetValueForProperty("LinkerName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).LinkerName, global::System.Convert.ToString);
            }
            if (content.Contains("IsConnectionAvailable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).IsConnectionAvailable = (bool?) content.GetValueForProperty("IsConnectionAvailable",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).IsConnectionAvailable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReportStartTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).ReportStartTimeUtc = (global::System.DateTime?) content.GetValueForProperty("ReportStartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).ReportStartTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ReportEndTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).ReportEndTimeUtc = (global::System.DateTime?) content.GetValueForProperty("ReportEndTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).ReportEndTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).SourceId = (string) content.GetValueForProperty("SourceId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).SourceId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).TargetId = (string) content.GetValueForProperty("TargetId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).TargetId, global::System.Convert.ToString);
            }
            if (content.Contains("AuthType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).AuthType = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AuthType?) content.GetValueForProperty("AuthType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).AuthType, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AuthType.CreateFrom);
            }
            if (content.Contains("ValidationDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).ValidationDetail = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidationResultItem[]) content.GetValueForProperty("ValidationDetail",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).ValidationDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidationResultItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ValidationResultItemTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ValidateResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ValidateResult(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LinkerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).LinkerName = (string) content.GetValueForProperty("LinkerName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).LinkerName, global::System.Convert.ToString);
            }
            if (content.Contains("IsConnectionAvailable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).IsConnectionAvailable = (bool?) content.GetValueForProperty("IsConnectionAvailable",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).IsConnectionAvailable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReportStartTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).ReportStartTimeUtc = (global::System.DateTime?) content.GetValueForProperty("ReportStartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).ReportStartTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ReportEndTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).ReportEndTimeUtc = (global::System.DateTime?) content.GetValueForProperty("ReportEndTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).ReportEndTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).SourceId = (string) content.GetValueForProperty("SourceId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).SourceId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).TargetId = (string) content.GetValueForProperty("TargetId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).TargetId, global::System.Convert.ToString);
            }
            if (content.Contains("AuthType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).AuthType = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AuthType?) content.GetValueForProperty("AuthType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).AuthType, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AuthType.CreateFrom);
            }
            if (content.Contains("ValidationDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).ValidationDetail = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidationResultItem[]) content.GetValueForProperty("ValidationDetail",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidateResultInternal)this).ValidationDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IValidationResultItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ValidationResultItemTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// The validation result for a Linker.
    [System.ComponentModel.TypeConverter(typeof(ValidateResultTypeConverter))]
    public partial interface IValidateResult

    {

    }
}