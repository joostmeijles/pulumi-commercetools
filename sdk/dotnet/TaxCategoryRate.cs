// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Commercetools
{
    public partial class TaxCategoryRate : Pulumi.CustomResource
    {
        [Output("amount")]
        public Output<double?> Amount { get; private set; } = null!;

        [Output("country")]
        public Output<string> Country { get; private set; } = null!;

        [Output("includedInPrice")]
        public Output<bool> IncludedInPrice { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("state")]
        public Output<string?> State { get; private set; } = null!;

        [Output("subRates")]
        public Output<ImmutableArray<Outputs.TaxCategoryRateSubRate>> SubRates { get; private set; } = null!;

        [Output("taxCategoryId")]
        public Output<string> TaxCategoryId { get; private set; } = null!;


        /// <summary>
        /// Create a TaxCategoryRate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TaxCategoryRate(string name, TaxCategoryRateArgs args, CustomResourceOptions? options = null)
            : base("commercetools:index/taxCategoryRate:TaxCategoryRate", name, args ?? new TaxCategoryRateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TaxCategoryRate(string name, Input<string> id, TaxCategoryRateState? state = null, CustomResourceOptions? options = null)
            : base("commercetools:index/taxCategoryRate:TaxCategoryRate", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing TaxCategoryRate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TaxCategoryRate Get(string name, Input<string> id, TaxCategoryRateState? state = null, CustomResourceOptions? options = null)
        {
            return new TaxCategoryRate(name, id, state, options);
        }
    }

    public sealed class TaxCategoryRateArgs : Pulumi.ResourceArgs
    {
        [Input("amount")]
        public Input<double>? Amount { get; set; }

        [Input("country", required: true)]
        public Input<string> Country { get; set; } = null!;

        [Input("includedInPrice", required: true)]
        public Input<bool> IncludedInPrice { get; set; } = null!;

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("state")]
        public Input<string>? State { get; set; }

        [Input("subRates")]
        private InputList<Inputs.TaxCategoryRateSubRateArgs>? _subRates;
        public InputList<Inputs.TaxCategoryRateSubRateArgs> SubRates
        {
            get => _subRates ?? (_subRates = new InputList<Inputs.TaxCategoryRateSubRateArgs>());
            set => _subRates = value;
        }

        [Input("taxCategoryId", required: true)]
        public Input<string> TaxCategoryId { get; set; } = null!;

        public TaxCategoryRateArgs()
        {
        }
    }

    public sealed class TaxCategoryRateState : Pulumi.ResourceArgs
    {
        [Input("amount")]
        public Input<double>? Amount { get; set; }

        [Input("country")]
        public Input<string>? Country { get; set; }

        [Input("includedInPrice")]
        public Input<bool>? IncludedInPrice { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("state")]
        public Input<string>? State { get; set; }

        [Input("subRates")]
        private InputList<Inputs.TaxCategoryRateSubRateGetArgs>? _subRates;
        public InputList<Inputs.TaxCategoryRateSubRateGetArgs> SubRates
        {
            get => _subRates ?? (_subRates = new InputList<Inputs.TaxCategoryRateSubRateGetArgs>());
            set => _subRates = value;
        }

        [Input("taxCategoryId")]
        public Input<string>? TaxCategoryId { get; set; }

        public TaxCategoryRateState()
        {
        }
    }
}
