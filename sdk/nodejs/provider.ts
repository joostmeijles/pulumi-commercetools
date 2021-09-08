// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * The provider type for the commercetools package. By default, resources use package-wide configuration
 * settings, however an explicit `Provider` instance may be created and passed during resource
 * construction to achieve fine-grained programmatic control over provider settings. See the
 * [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
 */
export class Provider extends pulumi.ProviderResource {
    /** @internal */
    public static readonly __pulumiType = 'commercetools';

    /**
     * Returns true if the given object is an instance of Provider.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Provider {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Provider.__pulumiType;
    }

    /**
     * The API URL of the commercetools platform. https://docs.commercetools.com/http-api
     */
    public readonly apiUrl!: pulumi.Output<string>;
    /**
     * The OAuth Client ID for a commercetools platform project. https://docs.commercetools.com/http-api-authorization
     */
    public readonly clientId!: pulumi.Output<string>;
    /**
     * The OAuth Client Secret for a commercetools platform project. https://docs.commercetools.com/http-api-authorization
     */
    public readonly clientSecret!: pulumi.Output<string>;
    /**
     * The project key of commercetools platform project. https://docs.commercetools.com/getting-started
     */
    public readonly projectKey!: pulumi.Output<string>;
    /**
     * A list as string of OAuth scopes assigned to a project key, to access resources in a commercetools platform project.
     * https://docs.commercetools.com/http-api-authorization
     */
    public readonly scopes!: pulumi.Output<string>;
    /**
     * The authentication URL of the commercetools platform. https://docs.commercetools.com/http-api-authorization
     */
    public readonly tokenUrl!: pulumi.Output<string>;

    /**
     * Create a Provider resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ProviderArgs, opts?: pulumi.ResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        {
            if ((!args || args.apiUrl === undefined) && !opts.urn) {
                throw new Error("Missing required property 'apiUrl'");
            }
            if ((!args || args.clientId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clientId'");
            }
            if ((!args || args.clientSecret === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clientSecret'");
            }
            if ((!args || args.projectKey === undefined) && !opts.urn) {
                throw new Error("Missing required property 'projectKey'");
            }
            if ((!args || args.scopes === undefined) && !opts.urn) {
                throw new Error("Missing required property 'scopes'");
            }
            if ((!args || args.tokenUrl === undefined) && !opts.urn) {
                throw new Error("Missing required property 'tokenUrl'");
            }
            inputs["apiUrl"] = args ? args.apiUrl : undefined;
            inputs["clientId"] = args ? args.clientId : undefined;
            inputs["clientSecret"] = args ? args.clientSecret : undefined;
            inputs["projectKey"] = args ? args.projectKey : undefined;
            inputs["scopes"] = args ? args.scopes : undefined;
            inputs["tokenUrl"] = args ? args.tokenUrl : undefined;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Provider.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Provider resource.
 */
export interface ProviderArgs {
    /**
     * The API URL of the commercetools platform. https://docs.commercetools.com/http-api
     */
    apiUrl: pulumi.Input<string>;
    /**
     * The OAuth Client ID for a commercetools platform project. https://docs.commercetools.com/http-api-authorization
     */
    clientId: pulumi.Input<string>;
    /**
     * The OAuth Client Secret for a commercetools platform project. https://docs.commercetools.com/http-api-authorization
     */
    clientSecret: pulumi.Input<string>;
    /**
     * The project key of commercetools platform project. https://docs.commercetools.com/getting-started
     */
    projectKey: pulumi.Input<string>;
    /**
     * A list as string of OAuth scopes assigned to a project key, to access resources in a commercetools platform project.
     * https://docs.commercetools.com/http-api-authorization
     */
    scopes: pulumi.Input<string>;
    /**
     * The authentication URL of the commercetools platform. https://docs.commercetools.com/http-api-authorization
     */
    tokenUrl: pulumi.Input<string>;
}
