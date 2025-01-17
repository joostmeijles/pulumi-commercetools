// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Commercetools
{
    [CommercetoolsResourceType("commercetools:index/apiClient:ApiClient")]
    public partial class ApiClient : Pulumi.CustomResource
    {
        /// <summary>
        /// Name of the API client
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A list of the [OAuth scopes](https://docs.commercetools.com/http-api-authorization.html#scopes)
        /// </summary>
        [Output("scopes")]
        public Output<ImmutableArray<string>> Scopes { get; private set; } = null!;

        [Output("secret")]
        public Output<string> Secret { get; private set; } = null!;


        /// <summary>
        /// Create a ApiClient resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ApiClient(string name, ApiClientArgs args, CustomResourceOptions? options = null)
            : base("commercetools:index/apiClient:ApiClient", name, args ?? new ApiClientArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ApiClient(string name, Input<string> id, ApiClientState? state = null, CustomResourceOptions? options = null)
            : base("commercetools:index/apiClient:ApiClient", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ApiClient resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ApiClient Get(string name, Input<string> id, ApiClientState? state = null, CustomResourceOptions? options = null)
        {
            return new ApiClient(name, id, state, options);
        }
    }

    public sealed class ApiClientArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the API client
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("scopes", required: true)]
        private InputList<string>? _scopes;

        /// <summary>
        /// A list of the [OAuth scopes](https://docs.commercetools.com/http-api-authorization.html#scopes)
        /// </summary>
        public InputList<string> Scopes
        {
            get => _scopes ?? (_scopes = new InputList<string>());
            set => _scopes = value;
        }

        public ApiClientArgs()
        {
        }
    }

    public sealed class ApiClientState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the API client
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("scopes")]
        private InputList<string>? _scopes;

        /// <summary>
        /// A list of the [OAuth scopes](https://docs.commercetools.com/http-api-authorization.html#scopes)
        /// </summary>
        public InputList<string> Scopes
        {
            get => _scopes ?? (_scopes = new InputList<string>());
            set => _scopes = value;
        }

        [Input("secret")]
        public Input<string>? Secret { get; set; }

        public ApiClientState()
        {
        }
    }
}
