// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Commercetools.Outputs
{

    [OutputType]
    public sealed class TypeFieldTypeLocalizedValue
    {
        public readonly string Key;
        public readonly ImmutableDictionary<string, object> Label;

        [OutputConstructor]
        private TypeFieldTypeLocalizedValue(
            string key,

            ImmutableDictionary<string, object> label)
        {
            Key = key;
            Label = label;
        }
    }
}
