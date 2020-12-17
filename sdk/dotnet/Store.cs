// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Commercetools
{
    public partial class Store : Pulumi.CustomResource
    {
        [Output("distributionChannels")]
        public Output<ImmutableArray<string>> DistributionChannels { get; private set; } = null!;

        [Output("key")]
        public Output<string> Key { get; private set; } = null!;

        [Output("languages")]
        public Output<ImmutableArray<string>> Languages { get; private set; } = null!;

        [Output("name")]
        public Output<ImmutableDictionary<string, object>> Name { get; private set; } = null!;

        [Output("supplyChannels")]
        public Output<ImmutableArray<string>> SupplyChannels { get; private set; } = null!;

        [Output("version")]
        public Output<int> Version { get; private set; } = null!;


        /// <summary>
        /// Create a Store resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Store(string name, StoreArgs args, CustomResourceOptions? options = null)
            : base("commercetools:index/store:Store", name, args ?? new StoreArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Store(string name, Input<string> id, StoreState? state = null, CustomResourceOptions? options = null)
            : base("commercetools:index/store:Store", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Store resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Store Get(string name, Input<string> id, StoreState? state = null, CustomResourceOptions? options = null)
        {
            return new Store(name, id, state, options);
        }
    }

    public sealed class StoreArgs : Pulumi.ResourceArgs
    {
        [Input("distributionChannels")]
        private InputList<string>? _distributionChannels;
        public InputList<string> DistributionChannels
        {
            get => _distributionChannels ?? (_distributionChannels = new InputList<string>());
            set => _distributionChannels = value;
        }

        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("languages")]
        private InputList<string>? _languages;
        public InputList<string> Languages
        {
            get => _languages ?? (_languages = new InputList<string>());
            set => _languages = value;
        }

        [Input("name")]
        private InputMap<object>? _name;
        public InputMap<object> Name
        {
            get => _name ?? (_name = new InputMap<object>());
            set => _name = value;
        }

        [Input("supplyChannels")]
        private InputList<string>? _supplyChannels;
        public InputList<string> SupplyChannels
        {
            get => _supplyChannels ?? (_supplyChannels = new InputList<string>());
            set => _supplyChannels = value;
        }

        public StoreArgs()
        {
        }
    }

    public sealed class StoreState : Pulumi.ResourceArgs
    {
        [Input("distributionChannels")]
        private InputList<string>? _distributionChannels;
        public InputList<string> DistributionChannels
        {
            get => _distributionChannels ?? (_distributionChannels = new InputList<string>());
            set => _distributionChannels = value;
        }

        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("languages")]
        private InputList<string>? _languages;
        public InputList<string> Languages
        {
            get => _languages ?? (_languages = new InputList<string>());
            set => _languages = value;
        }

        [Input("name")]
        private InputMap<object>? _name;
        public InputMap<object> Name
        {
            get => _name ?? (_name = new InputMap<object>());
            set => _name = value;
        }

        [Input("supplyChannels")]
        private InputList<string>? _supplyChannels;
        public InputList<string> SupplyChannels
        {
            get => _supplyChannels ?? (_supplyChannels = new InputList<string>());
            set => _supplyChannels = value;
        }

        [Input("version")]
        public Input<int>? Version { get; set; }

        public StoreState()
        {
        }
    }
}