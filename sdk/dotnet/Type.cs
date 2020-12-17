// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Commercetools
{
    public partial class Type : Pulumi.CustomResource
    {
        [Output("description")]
        public Output<ImmutableDictionary<string, object>?> Description { get; private set; } = null!;

        [Output("fields")]
        public Output<ImmutableArray<Outputs.TypeField>> Fields { get; private set; } = null!;

        [Output("key")]
        public Output<string> Key { get; private set; } = null!;

        [Output("name")]
        public Output<ImmutableDictionary<string, object>> Name { get; private set; } = null!;

        [Output("resourceTypeIds")]
        public Output<ImmutableArray<string>> ResourceTypeIds { get; private set; } = null!;

        [Output("version")]
        public Output<int> Version { get; private set; } = null!;


        /// <summary>
        /// Create a Type resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Type(string name, TypeArgs args, CustomResourceOptions? options = null)
            : base("commercetools:index/type:Type", name, args ?? new TypeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Type(string name, Input<string> id, TypeState? state = null, CustomResourceOptions? options = null)
            : base("commercetools:index/type:Type", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Type resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Type Get(string name, Input<string> id, TypeState? state = null, CustomResourceOptions? options = null)
        {
            return new Type(name, id, state, options);
        }
    }

    public sealed class TypeArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        private InputMap<object>? _description;
        public InputMap<object> Description
        {
            get => _description ?? (_description = new InputMap<object>());
            set => _description = value;
        }

        [Input("fields")]
        private InputList<Inputs.TypeFieldArgs>? _fields;
        public InputList<Inputs.TypeFieldArgs> Fields
        {
            get => _fields ?? (_fields = new InputList<Inputs.TypeFieldArgs>());
            set => _fields = value;
        }

        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("name")]
        private InputMap<object>? _name;
        public InputMap<object> Name
        {
            get => _name ?? (_name = new InputMap<object>());
            set => _name = value;
        }

        [Input("resourceTypeIds", required: true)]
        private InputList<string>? _resourceTypeIds;
        public InputList<string> ResourceTypeIds
        {
            get => _resourceTypeIds ?? (_resourceTypeIds = new InputList<string>());
            set => _resourceTypeIds = value;
        }

        public TypeArgs()
        {
        }
    }

    public sealed class TypeState : Pulumi.ResourceArgs
    {
        [Input("description")]
        private InputMap<object>? _description;
        public InputMap<object> Description
        {
            get => _description ?? (_description = new InputMap<object>());
            set => _description = value;
        }

        [Input("fields")]
        private InputList<Inputs.TypeFieldGetArgs>? _fields;
        public InputList<Inputs.TypeFieldGetArgs> Fields
        {
            get => _fields ?? (_fields = new InputList<Inputs.TypeFieldGetArgs>());
            set => _fields = value;
        }

        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("name")]
        private InputMap<object>? _name;
        public InputMap<object> Name
        {
            get => _name ?? (_name = new InputMap<object>());
            set => _name = value;
        }

        [Input("resourceTypeIds")]
        private InputList<string>? _resourceTypeIds;
        public InputList<string> ResourceTypeIds
        {
            get => _resourceTypeIds ?? (_resourceTypeIds = new InputList<string>());
            set => _resourceTypeIds = value;
        }

        [Input("version")]
        public Input<int>? Version { get; set; }

        public TypeState()
        {
        }
    }
}
