// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Commercetools
{
    [CommercetoolsResourceType("commercetools:index/shippingZone:ShippingZone")]
    public partial class ShippingZone : Pulumi.CustomResource
    {
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// User-specific unique identifier for a zone. Must be unique across a project
        /// </summary>
        [Output("key")]
        public Output<string?> Key { get; private set; } = null!;

        /// <summary>
        /// [Location](https://docs.commercetools.com/api/projects/zones#location)
        /// </summary>
        [Output("locations")]
        public Output<ImmutableArray<Outputs.ShippingZoneLocation>> Locations { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("version")]
        public Output<int> Version { get; private set; } = null!;


        /// <summary>
        /// Create a ShippingZone resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ShippingZone(string name, ShippingZoneArgs? args = null, CustomResourceOptions? options = null)
            : base("commercetools:index/shippingZone:ShippingZone", name, args ?? new ShippingZoneArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ShippingZone(string name, Input<string> id, ShippingZoneState? state = null, CustomResourceOptions? options = null)
            : base("commercetools:index/shippingZone:ShippingZone", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ShippingZone resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ShippingZone Get(string name, Input<string> id, ShippingZoneState? state = null, CustomResourceOptions? options = null)
        {
            return new ShippingZone(name, id, state, options);
        }
    }

    public sealed class ShippingZoneArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// User-specific unique identifier for a zone. Must be unique across a project
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("locations")]
        private InputList<Inputs.ShippingZoneLocationArgs>? _locations;

        /// <summary>
        /// [Location](https://docs.commercetools.com/api/projects/zones#location)
        /// </summary>
        public InputList<Inputs.ShippingZoneLocationArgs> Locations
        {
            get => _locations ?? (_locations = new InputList<Inputs.ShippingZoneLocationArgs>());
            set => _locations = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        public ShippingZoneArgs()
        {
        }
    }

    public sealed class ShippingZoneState : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// User-specific unique identifier for a zone. Must be unique across a project
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("locations")]
        private InputList<Inputs.ShippingZoneLocationGetArgs>? _locations;

        /// <summary>
        /// [Location](https://docs.commercetools.com/api/projects/zones#location)
        /// </summary>
        public InputList<Inputs.ShippingZoneLocationGetArgs> Locations
        {
            get => _locations ?? (_locations = new InputList<Inputs.ShippingZoneLocationGetArgs>());
            set => _locations = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("version")]
        public Input<int>? Version { get; set; }

        public ShippingZoneState()
        {
        }
    }
}
