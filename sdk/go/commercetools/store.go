// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package commercetools

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type Store struct {
	pulumi.CustomResourceState

	DistributionChannels pulumi.StringArrayOutput `pulumi:"distributionChannels"`
	Key                  pulumi.StringOutput      `pulumi:"key"`
	Languages            pulumi.StringArrayOutput `pulumi:"languages"`
	Name                 pulumi.MapOutput         `pulumi:"name"`
	SupplyChannels       pulumi.StringArrayOutput `pulumi:"supplyChannels"`
	Version              pulumi.IntOutput         `pulumi:"version"`
}

// NewStore registers a new resource with the given unique name, arguments, and options.
func NewStore(ctx *pulumi.Context,
	name string, args *StoreArgs, opts ...pulumi.ResourceOption) (*Store, error) {
	if args == nil || args.Key == nil {
		return nil, errors.New("missing required argument 'Key'")
	}
	if args == nil {
		args = &StoreArgs{}
	}
	var resource Store
	err := ctx.RegisterResource("commercetools:index/store:Store", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStore gets an existing Store resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStore(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StoreState, opts ...pulumi.ResourceOption) (*Store, error) {
	var resource Store
	err := ctx.ReadResource("commercetools:index/store:Store", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Store resources.
type storeState struct {
	DistributionChannels []string               `pulumi:"distributionChannels"`
	Key                  *string                `pulumi:"key"`
	Languages            []string               `pulumi:"languages"`
	Name                 map[string]interface{} `pulumi:"name"`
	SupplyChannels       []string               `pulumi:"supplyChannels"`
	Version              *int                   `pulumi:"version"`
}

type StoreState struct {
	DistributionChannels pulumi.StringArrayInput
	Key                  pulumi.StringPtrInput
	Languages            pulumi.StringArrayInput
	Name                 pulumi.MapInput
	SupplyChannels       pulumi.StringArrayInput
	Version              pulumi.IntPtrInput
}

func (StoreState) ElementType() reflect.Type {
	return reflect.TypeOf((*storeState)(nil)).Elem()
}

type storeArgs struct {
	DistributionChannels []string               `pulumi:"distributionChannels"`
	Key                  string                 `pulumi:"key"`
	Languages            []string               `pulumi:"languages"`
	Name                 map[string]interface{} `pulumi:"name"`
	SupplyChannels       []string               `pulumi:"supplyChannels"`
}

// The set of arguments for constructing a Store resource.
type StoreArgs struct {
	DistributionChannels pulumi.StringArrayInput
	Key                  pulumi.StringInput
	Languages            pulumi.StringArrayInput
	Name                 pulumi.MapInput
	SupplyChannels       pulumi.StringArrayInput
}

func (StoreArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*storeArgs)(nil)).Elem()
}
