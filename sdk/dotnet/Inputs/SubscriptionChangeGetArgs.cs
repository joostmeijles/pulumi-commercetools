// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Commercetools.Inputs
{

    public sealed class SubscriptionChangeGetArgs : Pulumi.ResourceArgs
    {
        [Input("resourceTypeIds")]
        private InputList<string>? _resourceTypeIds;
        public InputList<string> ResourceTypeIds
        {
            get => _resourceTypeIds ?? (_resourceTypeIds = new InputList<string>());
            set => _resourceTypeIds = value;
        }

        public SubscriptionChangeGetArgs()
        {
        }
    }
}
