// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class ApiExtension extends pulumi.CustomResource {
    /**
     * Get an existing ApiExtension resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ApiExtensionState, opts?: pulumi.CustomResourceOptions): ApiExtension {
        return new ApiExtension(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'commercetools:index/apiExtension:ApiExtension';

    /**
     * Returns true if the given object is an instance of ApiExtension.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ApiExtension {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ApiExtension.__pulumiType;
    }

    public readonly destination!: pulumi.Output<outputs.ApiExtensionDestination>;
    public readonly key!: pulumi.Output<string | undefined>;
    public readonly timeoutInMs!: pulumi.Output<number | undefined>;
    public readonly triggers!: pulumi.Output<outputs.ApiExtensionTrigger[]>;
    public /*out*/ readonly version!: pulumi.Output<number>;

    /**
     * Create a ApiExtension resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApiExtensionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ApiExtensionArgs | ApiExtensionState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ApiExtensionState | undefined;
            inputs["destination"] = state ? state.destination : undefined;
            inputs["key"] = state ? state.key : undefined;
            inputs["timeoutInMs"] = state ? state.timeoutInMs : undefined;
            inputs["triggers"] = state ? state.triggers : undefined;
            inputs["version"] = state ? state.version : undefined;
        } else {
            const args = argsOrState as ApiExtensionArgs | undefined;
            if (!args || args.destination === undefined) {
                throw new Error("Missing required property 'destination'");
            }
            if (!args || args.triggers === undefined) {
                throw new Error("Missing required property 'triggers'");
            }
            inputs["destination"] = args ? args.destination : undefined;
            inputs["key"] = args ? args.key : undefined;
            inputs["timeoutInMs"] = args ? args.timeoutInMs : undefined;
            inputs["triggers"] = args ? args.triggers : undefined;
            inputs["version"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(ApiExtension.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ApiExtension resources.
 */
export interface ApiExtensionState {
    readonly destination?: pulumi.Input<inputs.ApiExtensionDestination>;
    readonly key?: pulumi.Input<string>;
    readonly timeoutInMs?: pulumi.Input<number>;
    readonly triggers?: pulumi.Input<pulumi.Input<inputs.ApiExtensionTrigger>[]>;
    readonly version?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a ApiExtension resource.
 */
export interface ApiExtensionArgs {
    readonly destination: pulumi.Input<inputs.ApiExtensionDestination>;
    readonly key?: pulumi.Input<string>;
    readonly timeoutInMs?: pulumi.Input<number>;
    readonly triggers: pulumi.Input<pulumi.Input<inputs.ApiExtensionTrigger>[]>;
}
