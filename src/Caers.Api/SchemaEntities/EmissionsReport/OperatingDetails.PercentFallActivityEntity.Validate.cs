//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Text.Json;
using Corvus.Json;

namespace Caers.Api.SchemaEntities;
public readonly partial struct OperatingDetails
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct PercentFallActivityEntity
    {
        /// <inheritdoc/>
        public ValidationContext Validate(in ValidationContext validationContext, ValidationLevel level = ValidationLevel.Flag)
        {
            ValidationContext result = validationContext;
            if (level > ValidationLevel.Flag)
            {
                result = result.UsingResults();
            }

            if (level > ValidationLevel.Basic)
            {
                result = result.UsingStack();
                result = result.PushSchemaLocation("D:/projects/caers-api/src/Caers.Api/SchemaEntities/caers-report-openapi.json#/components/schemas/OperatingDetails/properties/percentFallActivity");
            }

            JsonValueKind valueKind = this.ValueKind;
            result = this.ValidateType(valueKind, result, level);
            if (level == ValidationLevel.Flag && !result.IsValid)
            {
                return result;
            }

            result = Corvus.Json.Validate.ValidateNumber(this, result, level, null, 100.0, null, null, null);
            if (level == ValidationLevel.Flag && !result.IsValid)
            {
                return result;
            }

            if (level != ValidationLevel.Flag)
            {
                result = result.PopLocation();
            }

            return result;
        }
    }
}