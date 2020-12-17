// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package commercetools

import (
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type ProductType struct {
	pulumi.CustomResourceState

	Attributes  ProductTypeAttributeArrayOutput `pulumi:"attributes"`
	Description pulumi.StringPtrOutput          `pulumi:"description"`
	Key         pulumi.StringPtrOutput          `pulumi:"key"`
	Name        pulumi.StringOutput             `pulumi:"name"`
	Version     pulumi.IntOutput                `pulumi:"version"`
}

// NewProductType registers a new resource with the given unique name, arguments, and options.
func NewProductType(ctx *pulumi.Context,
	name string, args *ProductTypeArgs, opts ...pulumi.ResourceOption) (*ProductType, error) {
	if args == nil {
		args = &ProductTypeArgs{}
	}
	var resource ProductType
	err := ctx.RegisterResource("commercetools:index/productType:ProductType", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProductType gets an existing ProductType resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProductType(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ProductTypeState, opts ...pulumi.ResourceOption) (*ProductType, error) {
	var resource ProductType
	err := ctx.ReadResource("commercetools:index/productType:ProductType", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ProductType resources.
type productTypeState struct {
	Attributes  []ProductTypeAttribute `pulumi:"attributes"`
	Description *string                `pulumi:"description"`
	Key         *string                `pulumi:"key"`
	Name        *string                `pulumi:"name"`
	Version     *int                   `pulumi:"version"`
}

type ProductTypeState struct {
	Attributes  ProductTypeAttributeArrayInput
	Description pulumi.StringPtrInput
	Key         pulumi.StringPtrInput
	Name        pulumi.StringPtrInput
	Version     pulumi.IntPtrInput
}

func (ProductTypeState) ElementType() reflect.Type {
	return reflect.TypeOf((*productTypeState)(nil)).Elem()
}

type productTypeArgs struct {
	Attributes  []ProductTypeAttribute `pulumi:"attributes"`
	Description *string                `pulumi:"description"`
	Key         *string                `pulumi:"key"`
	Name        *string                `pulumi:"name"`
}

// The set of arguments for constructing a ProductType resource.
type ProductTypeArgs struct {
	Attributes  ProductTypeAttributeArrayInput
	Description pulumi.StringPtrInput
	Key         pulumi.StringPtrInput
	Name        pulumi.StringPtrInput
}

func (ProductTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*productTypeArgs)(nil)).Elem()
}