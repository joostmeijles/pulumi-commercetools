// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class DiscountCode extends pulumi.CustomResource {
    /**
     * Get an existing DiscountCode resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DiscountCodeState, opts?: pulumi.CustomResourceOptions): DiscountCode {
        return new DiscountCode(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'commercetools:index/discountCode:DiscountCode';

    /**
     * Returns true if the given object is an instance of DiscountCode.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DiscountCode {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DiscountCode.__pulumiType;
    }

    /**
     * The referenced matching cart discounts can be applied to the cart once the DiscountCode is added
     */
    public readonly cartDiscounts!: pulumi.Output<string[]>;
    /**
     * Unique identifier of this discount code. This value is added to the cart to enable the related cart discounts in the
     * cart
     */
    public readonly code!: pulumi.Output<string>;
    /**
     * [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
     */
    public readonly description!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * The groups to which this discount code belong
     */
    public readonly groups!: pulumi.Output<string[] | undefined>;
    public readonly isActive!: pulumi.Output<boolean | undefined>;
    /**
     * The discount code can only be applied maxApplications times
     */
    public readonly maxApplications!: pulumi.Output<number | undefined>;
    /**
     * The discount code can only be applied maxApplicationsPerCustomer times per customer
     */
    public readonly maxApplicationsPerCustomer!: pulumi.Output<number | undefined>;
    /**
     * [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
     */
    public readonly name!: pulumi.Output<{[key: string]: any}>;
    /**
     * [Cart Predicate](https://docs.commercetools.com/api/projects/predicates#cart-predicates)
     */
    public readonly predicate!: pulumi.Output<string | undefined>;
    /**
     * The time from which the discount can be applied on a cart. Before that time the code is invalid
     */
    public readonly validFrom!: pulumi.Output<string | undefined>;
    /**
     * The time until the discount can be applied on a cart. After that time the code is invalid
     */
    public readonly validUntil!: pulumi.Output<string | undefined>;
    public /*out*/ readonly version!: pulumi.Output<number>;

    /**
     * Create a DiscountCode resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DiscountCodeArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DiscountCodeArgs | DiscountCodeState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DiscountCodeState | undefined;
            inputs["cartDiscounts"] = state ? state.cartDiscounts : undefined;
            inputs["code"] = state ? state.code : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["groups"] = state ? state.groups : undefined;
            inputs["isActive"] = state ? state.isActive : undefined;
            inputs["maxApplications"] = state ? state.maxApplications : undefined;
            inputs["maxApplicationsPerCustomer"] = state ? state.maxApplicationsPerCustomer : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["predicate"] = state ? state.predicate : undefined;
            inputs["validFrom"] = state ? state.validFrom : undefined;
            inputs["validUntil"] = state ? state.validUntil : undefined;
            inputs["version"] = state ? state.version : undefined;
        } else {
            const args = argsOrState as DiscountCodeArgs | undefined;
            if ((!args || args.cartDiscounts === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cartDiscounts'");
            }
            if ((!args || args.code === undefined) && !opts.urn) {
                throw new Error("Missing required property 'code'");
            }
            inputs["cartDiscounts"] = args ? args.cartDiscounts : undefined;
            inputs["code"] = args ? args.code : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["groups"] = args ? args.groups : undefined;
            inputs["isActive"] = args ? args.isActive : undefined;
            inputs["maxApplications"] = args ? args.maxApplications : undefined;
            inputs["maxApplicationsPerCustomer"] = args ? args.maxApplicationsPerCustomer : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["predicate"] = args ? args.predicate : undefined;
            inputs["validFrom"] = args ? args.validFrom : undefined;
            inputs["validUntil"] = args ? args.validUntil : undefined;
            inputs["version"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(DiscountCode.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DiscountCode resources.
 */
export interface DiscountCodeState {
    /**
     * The referenced matching cart discounts can be applied to the cart once the DiscountCode is added
     */
    cartDiscounts?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Unique identifier of this discount code. This value is added to the cart to enable the related cart discounts in the
     * cart
     */
    code?: pulumi.Input<string>;
    /**
     * [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
     */
    description?: pulumi.Input<{[key: string]: any}>;
    /**
     * The groups to which this discount code belong
     */
    groups?: pulumi.Input<pulumi.Input<string>[]>;
    isActive?: pulumi.Input<boolean>;
    /**
     * The discount code can only be applied maxApplications times
     */
    maxApplications?: pulumi.Input<number>;
    /**
     * The discount code can only be applied maxApplicationsPerCustomer times per customer
     */
    maxApplicationsPerCustomer?: pulumi.Input<number>;
    /**
     * [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
     */
    name?: pulumi.Input<{[key: string]: any}>;
    /**
     * [Cart Predicate](https://docs.commercetools.com/api/projects/predicates#cart-predicates)
     */
    predicate?: pulumi.Input<string>;
    /**
     * The time from which the discount can be applied on a cart. Before that time the code is invalid
     */
    validFrom?: pulumi.Input<string>;
    /**
     * The time until the discount can be applied on a cart. After that time the code is invalid
     */
    validUntil?: pulumi.Input<string>;
    version?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a DiscountCode resource.
 */
export interface DiscountCodeArgs {
    /**
     * The referenced matching cart discounts can be applied to the cart once the DiscountCode is added
     */
    cartDiscounts: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Unique identifier of this discount code. This value is added to the cart to enable the related cart discounts in the
     * cart
     */
    code: pulumi.Input<string>;
    /**
     * [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
     */
    description?: pulumi.Input<{[key: string]: any}>;
    /**
     * The groups to which this discount code belong
     */
    groups?: pulumi.Input<pulumi.Input<string>[]>;
    isActive?: pulumi.Input<boolean>;
    /**
     * The discount code can only be applied maxApplications times
     */
    maxApplications?: pulumi.Input<number>;
    /**
     * The discount code can only be applied maxApplicationsPerCustomer times per customer
     */
    maxApplicationsPerCustomer?: pulumi.Input<number>;
    /**
     * [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
     */
    name?: pulumi.Input<{[key: string]: any}>;
    /**
     * [Cart Predicate](https://docs.commercetools.com/api/projects/predicates#cart-predicates)
     */
    predicate?: pulumi.Input<string>;
    /**
     * The time from which the discount can be applied on a cart. Before that time the code is invalid
     */
    validFrom?: pulumi.Input<string>;
    /**
     * The time until the discount can be applied on a cart. After that time the code is invalid
     */
    validUntil?: pulumi.Input<string>;
}
