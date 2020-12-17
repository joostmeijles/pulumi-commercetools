// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Commercetools
{
    public partial class ApiExtension : Pulumi.CustomResource
    {
        [Output("destination")]
        public Output<Outputs.ApiExtensionDestination> Destination { get; private set; } = null!;

        [Output("key")]
        public Output<string?> Key { get; private set; } = null!;

        [Output("timeoutInMs")]
        public Output<int?> TimeoutInMs { get; private set; } = null!;

        [Output("triggers")]
        public Output<ImmutableArray<Outputs.ApiExtensionTrigger>> Triggers { get; private set; } = null!;

        [Output("version")]
        public Output<int> Version { get; private set; } = null!;


        /// <summary>
        /// Create a ApiExtension resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ApiExtension(string name, ApiExtensionArgs args, CustomResourceOptions? options = null)
            : base("commercetools:index/apiExtension:ApiExtension", name, args ?? new ApiExtensionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ApiExtension(string name, Input<string> id, ApiExtensionState? state = null, CustomResourceOptions? options = null)
            : base("commercetools:index/apiExtension:ApiExtension", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ApiExtension resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ApiExtension Get(string name, Input<string> id, ApiExtensionState? state = null, CustomResourceOptions? options = null)
        {
            return new ApiExtension(name, id, state, options);
        }
    }

    public sealed class ApiExtensionArgs : Pulumi.ResourceArgs
    {
        [Input("destination", required: true)]
        public Input<Inputs.ApiExtensionDestinationArgs> Destination { get; set; } = null!;

        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("timeoutInMs")]
        public Input<int>? TimeoutInMs { get; set; }

        [Input("triggers", required: true)]
        private InputList<Inputs.ApiExtensionTriggerArgs>? _triggers;
        public InputList<Inputs.ApiExtensionTriggerArgs> Triggers
        {
            get => _triggers ?? (_triggers = new InputList<Inputs.ApiExtensionTriggerArgs>());
            set => _triggers = value;
        }

        public ApiExtensionArgs()
        {
        }
    }

    public sealed class ApiExtensionState : Pulumi.ResourceArgs
    {
        [Input("destination")]
        public Input<Inputs.ApiExtensionDestinationGetArgs>? Destination { get; set; }

        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("timeoutInMs")]
        public Input<int>? TimeoutInMs { get; set; }

        [Input("triggers")]
        private InputList<Inputs.ApiExtensionTriggerGetArgs>? _triggers;
        public InputList<Inputs.ApiExtensionTriggerGetArgs> Triggers
        {
            get => _triggers ?? (_triggers = new InputList<Inputs.ApiExtensionTriggerGetArgs>());
            set => _triggers = value;
        }

        [Input("version")]
        public Input<int>? Version { get; set; }

        public ApiExtensionState()
        {
        }
    }
}