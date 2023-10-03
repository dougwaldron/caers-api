//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Caers.Api;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct ReleasePointAppt
{
    /// <summary>
    /// JSON property name for <see cref = "AveragePercentEmissions"/>.
    /// </summary>
    public static ReadOnlySpan<byte> AveragePercentEmissionsUtf8JsonPropertyName => "averagePercentEmissions"u8;

    /// <summary>
    /// JSON property name for <see cref = "AveragePercentEmissions"/>.
    /// </summary>
    public const string AveragePercentEmissionsJsonPropertyName = "averagePercentEmissions";
    /// <summary>
    /// JSON property name for <see cref = "Comment"/>.
    /// </summary>
    public static ReadOnlySpan<byte> CommentUtf8JsonPropertyName => "comment"u8;

    /// <summary>
    /// JSON property name for <see cref = "Comment"/>.
    /// </summary>
    public const string CommentJsonPropertyName = "comment";
    /// <summary>
    /// JSON property name for <see cref = "MainPathIdentification"/>.
    /// </summary>
    public static ReadOnlySpan<byte> MainPathIdentificationUtf8JsonPropertyName => "mainPathIdentification"u8;

    /// <summary>
    /// JSON property name for <see cref = "MainPathIdentification"/>.
    /// </summary>
    public const string MainPathIdentificationJsonPropertyName = "mainPathIdentification";
    /// <summary>
    /// JSON property name for <see cref = "MainReleasePointIdentification"/>.
    /// </summary>
    public static ReadOnlySpan<byte> MainReleasePointIdentificationUtf8JsonPropertyName => "mainReleasePointIdentification"u8;

    /// <summary>
    /// JSON property name for <see cref = "MainReleasePointIdentification"/>.
    /// </summary>
    public const string MainReleasePointIdentificationJsonPropertyName = "mainReleasePointIdentification";
    /// <summary>
    /// JSON property name for <see cref = "PathIdentification"/>.
    /// </summary>
    public static ReadOnlySpan<byte> PathIdentificationUtf8JsonPropertyName => "pathIdentification"u8;

    /// <summary>
    /// JSON property name for <see cref = "PathIdentification"/>.
    /// </summary>
    public const string PathIdentificationJsonPropertyName = "pathIdentification";
    /// <summary>
    /// JSON property name for <see cref = "ReleasePointApportionmentIsUncontrolled"/>.
    /// </summary>
    public static ReadOnlySpan<byte> ReleasePointApportionmentIsUncontrolledUtf8JsonPropertyName => "releasePointApportionmentIsUncontrolled"u8;

    /// <summary>
    /// JSON property name for <see cref = "ReleasePointApportionmentIsUncontrolled"/>.
    /// </summary>
    public const string ReleasePointApportionmentIsUncontrolledJsonPropertyName = "releasePointApportionmentIsUncontrolled";
    /// <summary>
    /// JSON property name for <see cref = "ReleasePointIdentification"/>.
    /// </summary>
    public static ReadOnlySpan<byte> ReleasePointIdentificationUtf8JsonPropertyName => "releasePointIdentification"u8;

    /// <summary>
    /// JSON property name for <see cref = "ReleasePointIdentification"/>.
    /// </summary>
    public const string ReleasePointIdentificationJsonPropertyName = "releasePointIdentification";
    /// <summary>
    /// Gets AveragePercentEmissions.
    /// </summary>
    public Caers.Api.ReleasePointAppt.AveragePercentEmissionsEntity AveragePercentEmissions
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(AveragePercentEmissionsUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.ReleasePointAppt.AveragePercentEmissionsEntity(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(AveragePercentEmissionsJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.ReleasePointAppt.AveragePercentEmissionsEntity>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Comment.
    /// </summary>
    public Caers.Api.ReleasePointAppt.CommentEntity Comment
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(CommentUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.ReleasePointAppt.CommentEntity(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(CommentJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.ReleasePointAppt.CommentEntity>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets MainPathIdentification.
    /// </summary>
    public Caers.Api.Identification MainPathIdentification
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(MainPathIdentificationUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.Identification(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(MainPathIdentificationJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.Identification>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets MainReleasePointIdentification.
    /// </summary>
    public Caers.Api.Identification MainReleasePointIdentification
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(MainReleasePointIdentificationUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.Identification(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(MainReleasePointIdentificationJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.Identification>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets PathIdentification.
    /// </summary>
    public Caers.Api.ReleasePointAppt.IdentificationArray PathIdentification
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(PathIdentificationUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.ReleasePointAppt.IdentificationArray(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(PathIdentificationJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.ReleasePointAppt.IdentificationArray>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets ReleasePointApportionmentIsUncontrolled.
    /// </summary>
    public Corvus.Json.JsonString ReleasePointApportionmentIsUncontrolled
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ReleasePointApportionmentIsUncontrolledUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ReleasePointApportionmentIsUncontrolledJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets ReleasePointIdentification.
    /// </summary>
    public Caers.Api.ReleasePointAppt.ReleasePointIdentificationIdentificationArray ReleasePointIdentification
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ReleasePointIdentificationUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.ReleasePointAppt.ReleasePointIdentificationIdentificationArray(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ReleasePointIdentificationJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.ReleasePointAppt.ReleasePointIdentificationIdentificationArray>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "ReleasePointAppt"/>.
    /// </summary>
    public static ReleasePointAppt Create(Caers.Api.ReleasePointAppt.AveragePercentEmissionsEntity averagePercentEmissions, Caers.Api.ReleasePointAppt.CommentEntity? comment = null, Caers.Api.Identification? mainPathIdentification = null, Caers.Api.Identification? mainReleasePointIdentification = null, Caers.Api.ReleasePointAppt.IdentificationArray? pathIdentification = null, Corvus.Json.JsonString? releasePointApportionmentIsUncontrolled = null, Caers.Api.ReleasePointAppt.ReleasePointIdentificationIdentificationArray? releasePointIdentification = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        builder.Add(AveragePercentEmissionsJsonPropertyName, averagePercentEmissions.AsAny);
        if (comment is Caers.Api.ReleasePointAppt.CommentEntity comment__)
        {
            builder.Add(CommentJsonPropertyName, comment__.AsAny);
        }

        if (mainPathIdentification is Caers.Api.Identification mainPathIdentification__)
        {
            builder.Add(MainPathIdentificationJsonPropertyName, mainPathIdentification__.AsAny);
        }

        if (mainReleasePointIdentification is Caers.Api.Identification mainReleasePointIdentification__)
        {
            builder.Add(MainReleasePointIdentificationJsonPropertyName, mainReleasePointIdentification__.AsAny);
        }

        if (pathIdentification is Caers.Api.ReleasePointAppt.IdentificationArray pathIdentification__)
        {
            builder.Add(PathIdentificationJsonPropertyName, pathIdentification__.AsAny);
        }

        if (releasePointApportionmentIsUncontrolled is Corvus.Json.JsonString releasePointApportionmentIsUncontrolled__)
        {
            builder.Add(ReleasePointApportionmentIsUncontrolledJsonPropertyName, releasePointApportionmentIsUncontrolled__.AsAny);
        }

        if (releasePointIdentification is Caers.Api.ReleasePointAppt.ReleasePointIdentificationIdentificationArray releasePointIdentification__)
        {
            builder.Add(ReleasePointIdentificationJsonPropertyName, releasePointIdentification__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets averagePercentEmissions.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ReleasePointAppt WithAveragePercentEmissions(in Caers.Api.ReleasePointAppt.AveragePercentEmissionsEntity value)
    {
        return this.SetProperty(AveragePercentEmissionsJsonPropertyName, value);
    }

    /// <summary>
    /// Sets comment.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ReleasePointAppt WithComment(in Caers.Api.ReleasePointAppt.CommentEntity value)
    {
        return this.SetProperty(CommentJsonPropertyName, value);
    }

    /// <summary>
    /// Sets mainPathIdentification.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ReleasePointAppt WithMainPathIdentification(in Caers.Api.Identification value)
    {
        return this.SetProperty(MainPathIdentificationJsonPropertyName, value);
    }

    /// <summary>
    /// Sets mainReleasePointIdentification.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ReleasePointAppt WithMainReleasePointIdentification(in Caers.Api.Identification value)
    {
        return this.SetProperty(MainReleasePointIdentificationJsonPropertyName, value);
    }

    /// <summary>
    /// Sets pathIdentification.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ReleasePointAppt WithPathIdentification(in Caers.Api.ReleasePointAppt.IdentificationArray value)
    {
        return this.SetProperty(PathIdentificationJsonPropertyName, value);
    }

    /// <summary>
    /// Sets releasePointApportionmentIsUncontrolled.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ReleasePointAppt WithReleasePointApportionmentIsUncontrolled(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(ReleasePointApportionmentIsUncontrolledJsonPropertyName, value);
    }

    /// <summary>
    /// Sets releasePointIdentification.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ReleasePointAppt WithReleasePointIdentification(in Caers.Api.ReleasePointAppt.ReleasePointIdentificationIdentificationArray value)
    {
        return this.SetProperty(ReleasePointIdentificationJsonPropertyName, value);
    }

    private static ValidationContext __CorvusValidateAveragePercentEmissions(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.ReleasePointAppt.AveragePercentEmissionsEntity>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateReleasePointIdentification(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.ReleasePointAppt.ReleasePointIdentificationIdentificationArray>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidatePathIdentification(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.ReleasePointAppt.IdentificationArray>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateComment(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.ReleasePointAppt.CommentEntity>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateReleasePointApportionmentIsUncontrolled(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateMainPathIdentification(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.Identification>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateMainReleasePointIdentification(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.Identification>().Validate(validationContext, level);
    }

    /// <summary>
    /// Tries to get the validator for the given property.
    /// </summary>
    /// <param name = "property">The property for which to get the validator.</param>
    /// <param name = "hasJsonElementBacking"><c>True</c> if the object containing the property has a JsonElement backing.</param>
    /// <param name = "propertyValidator">The validator for the property, if provided by this schema.</param>
    /// <returns><c>True</c> if the validator was found.</returns>
    private bool __TryGetCorvusLocalPropertiesValidator(in JsonObjectProperty property, bool hasJsonElementBacking, [NotNullWhen(true)] out ObjectPropertyValidator? propertyValidator)
    {
        if (hasJsonElementBacking)
        {
            if (property.NameEquals(AveragePercentEmissionsUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateAveragePercentEmissions;
                return true;
            }
            else if (property.NameEquals(ReleasePointIdentificationUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateReleasePointIdentification;
                return true;
            }
            else if (property.NameEquals(PathIdentificationUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidatePathIdentification;
                return true;
            }
            else if (property.NameEquals(CommentUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateComment;
                return true;
            }
            else if (property.NameEquals(ReleasePointApportionmentIsUncontrolledUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateReleasePointApportionmentIsUncontrolled;
                return true;
            }
            else if (property.NameEquals(MainPathIdentificationUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateMainPathIdentification;
                return true;
            }
            else if (property.NameEquals(MainReleasePointIdentificationUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateMainReleasePointIdentification;
                return true;
            }
        }
        else
        {
            if (property.NameEquals(AveragePercentEmissionsJsonPropertyName))
            {
                propertyValidator = __CorvusValidateAveragePercentEmissions;
                return true;
            }
            else if (property.NameEquals(ReleasePointIdentificationJsonPropertyName))
            {
                propertyValidator = __CorvusValidateReleasePointIdentification;
                return true;
            }
            else if (property.NameEquals(PathIdentificationJsonPropertyName))
            {
                propertyValidator = __CorvusValidatePathIdentification;
                return true;
            }
            else if (property.NameEquals(CommentJsonPropertyName))
            {
                propertyValidator = __CorvusValidateComment;
                return true;
            }
            else if (property.NameEquals(ReleasePointApportionmentIsUncontrolledJsonPropertyName))
            {
                propertyValidator = __CorvusValidateReleasePointApportionmentIsUncontrolled;
                return true;
            }
            else if (property.NameEquals(MainPathIdentificationJsonPropertyName))
            {
                propertyValidator = __CorvusValidateMainPathIdentification;
                return true;
            }
            else if (property.NameEquals(MainReleasePointIdentificationJsonPropertyName))
            {
                propertyValidator = __CorvusValidateMainReleasePointIdentification;
                return true;
            }
        }

        propertyValidator = null;
        return false;
    }
}