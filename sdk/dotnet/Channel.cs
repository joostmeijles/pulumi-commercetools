// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Commercetools
{
    [CommercetoolsResourceType("commercetools:index/channel:Channel")]
    public partial class Channel : Pulumi.CustomResource
    {
        /// <summary>
        /// [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
        /// </summary>
        [Output("description")]
        public Output<ImmutableDictionary<string, object>?> Description { get; private set; } = null!;

        /// <summary>
        /// Any arbitrary string key that uniquely identifies this channel within the project
        /// </summary>
        [Output("key")]
        public Output<string> Key { get; private set; } = null!;

        /// <summary>
        /// [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
        /// </summary>
        [Output("name")]
        public Output<ImmutableDictionary<string, object>> Name { get; private set; } = null!;

        /// <summary>
        /// The [roles](https://docs.commercetools.com/api/projects/channels#channelroleenum) of this channel. Each channel must
        /// have at least one role
        /// </summary>
        [Output("roles")]
        public Output<ImmutableArray<string>> Roles { get; private set; } = null!;

        [Output("version")]
        public Output<int> Version { get; private set; } = null!;


        /// <summary>
        /// Create a Channel resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Channel(string name, ChannelArgs args, CustomResourceOptions? options = null)
            : base("commercetools:index/channel:Channel", name, args ?? new ChannelArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Channel(string name, Input<string> id, ChannelState? state = null, CustomResourceOptions? options = null)
            : base("commercetools:index/channel:Channel", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Channel resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Channel Get(string name, Input<string> id, ChannelState? state = null, CustomResourceOptions? options = null)
        {
            return new Channel(name, id, state, options);
        }
    }

    public sealed class ChannelArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        private InputMap<object>? _description;

        /// <summary>
        /// [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
        /// </summary>
        public InputMap<object> Description
        {
            get => _description ?? (_description = new InputMap<object>());
            set => _description = value;
        }

        /// <summary>
        /// Any arbitrary string key that uniquely identifies this channel within the project
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("name")]
        private InputMap<object>? _name;

        /// <summary>
        /// [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
        /// </summary>
        public InputMap<object> Name
        {
            get => _name ?? (_name = new InputMap<object>());
            set => _name = value;
        }

        [Input("roles", required: true)]
        private InputList<string>? _roles;

        /// <summary>
        /// The [roles](https://docs.commercetools.com/api/projects/channels#channelroleenum) of this channel. Each channel must
        /// have at least one role
        /// </summary>
        public InputList<string> Roles
        {
            get => _roles ?? (_roles = new InputList<string>());
            set => _roles = value;
        }

        public ChannelArgs()
        {
        }
    }

    public sealed class ChannelState : Pulumi.ResourceArgs
    {
        [Input("description")]
        private InputMap<object>? _description;

        /// <summary>
        /// [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
        /// </summary>
        public InputMap<object> Description
        {
            get => _description ?? (_description = new InputMap<object>());
            set => _description = value;
        }

        /// <summary>
        /// Any arbitrary string key that uniquely identifies this channel within the project
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("name")]
        private InputMap<object>? _name;

        /// <summary>
        /// [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
        /// </summary>
        public InputMap<object> Name
        {
            get => _name ?? (_name = new InputMap<object>());
            set => _name = value;
        }

        [Input("roles")]
        private InputList<string>? _roles;

        /// <summary>
        /// The [roles](https://docs.commercetools.com/api/projects/channels#channelroleenum) of this channel. Each channel must
        /// have at least one role
        /// </summary>
        public InputList<string> Roles
        {
            get => _roles ?? (_roles = new InputList<string>());
            set => _roles = value;
        }

        [Input("version")]
        public Input<int>? Version { get; set; }

        public ChannelState()
        {
        }
    }
}
