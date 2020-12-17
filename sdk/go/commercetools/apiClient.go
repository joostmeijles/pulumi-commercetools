// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package commercetools

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type ApiClient struct {
	pulumi.CustomResourceState

	Name   pulumi.StringOutput      `pulumi:"name"`
	Scopes pulumi.StringArrayOutput `pulumi:"scopes"`
	Secret pulumi.StringOutput      `pulumi:"secret"`
}

// NewApiClient registers a new resource with the given unique name, arguments, and options.
func NewApiClient(ctx *pulumi.Context,
	name string, args *ApiClientArgs, opts ...pulumi.ResourceOption) (*ApiClient, error) {
	if args == nil || args.Scopes == nil {
		return nil, errors.New("missing required argument 'Scopes'")
	}
	if args == nil {
		args = &ApiClientArgs{}
	}
	var resource ApiClient
	err := ctx.RegisterResource("commercetools:index/apiClient:ApiClient", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApiClient gets an existing ApiClient resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApiClient(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApiClientState, opts ...pulumi.ResourceOption) (*ApiClient, error) {
	var resource ApiClient
	err := ctx.ReadResource("commercetools:index/apiClient:ApiClient", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ApiClient resources.
type apiClientState struct {
	Name   *string  `pulumi:"name"`
	Scopes []string `pulumi:"scopes"`
	Secret *string  `pulumi:"secret"`
}

type ApiClientState struct {
	Name   pulumi.StringPtrInput
	Scopes pulumi.StringArrayInput
	Secret pulumi.StringPtrInput
}

func (ApiClientState) ElementType() reflect.Type {
	return reflect.TypeOf((*apiClientState)(nil)).Elem()
}

type apiClientArgs struct {
	Name   *string  `pulumi:"name"`
	Scopes []string `pulumi:"scopes"`
}

// The set of arguments for constructing a ApiClient resource.
type ApiClientArgs struct {
	Name   pulumi.StringPtrInput
	Scopes pulumi.StringArrayInput
}

func (ApiClientArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*apiClientArgs)(nil)).Elem()
}
