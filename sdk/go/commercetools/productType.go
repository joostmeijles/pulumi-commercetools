// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package commercetools

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type ProductType struct {
	pulumi.CustomResourceState

	// [Product attribute fefinition](https://docs.commercetools.com/api/projects/productTypes#attributedefinition)
	Attributes  ProductTypeAttributeArrayOutput `pulumi:"attributes"`
	Description pulumi.StringPtrOutput          `pulumi:"description"`
	// User-specific unique identifier for the product type (max. 256 characters)
	Key     pulumi.StringPtrOutput `pulumi:"key"`
	Name    pulumi.StringOutput    `pulumi:"name"`
	Version pulumi.IntOutput       `pulumi:"version"`
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
	// [Product attribute fefinition](https://docs.commercetools.com/api/projects/productTypes#attributedefinition)
	Attributes  []ProductTypeAttribute `pulumi:"attributes"`
	Description *string                `pulumi:"description"`
	// User-specific unique identifier for the product type (max. 256 characters)
	Key     *string `pulumi:"key"`
	Name    *string `pulumi:"name"`
	Version *int    `pulumi:"version"`
}

type ProductTypeState struct {
	// [Product attribute fefinition](https://docs.commercetools.com/api/projects/productTypes#attributedefinition)
	Attributes  ProductTypeAttributeArrayInput
	Description pulumi.StringPtrInput
	// User-specific unique identifier for the product type (max. 256 characters)
	Key     pulumi.StringPtrInput
	Name    pulumi.StringPtrInput
	Version pulumi.IntPtrInput
}

func (ProductTypeState) ElementType() reflect.Type {
	return reflect.TypeOf((*productTypeState)(nil)).Elem()
}

type productTypeArgs struct {
	// [Product attribute fefinition](https://docs.commercetools.com/api/projects/productTypes#attributedefinition)
	Attributes  []ProductTypeAttribute `pulumi:"attributes"`
	Description *string                `pulumi:"description"`
	// User-specific unique identifier for the product type (max. 256 characters)
	Key  *string `pulumi:"key"`
	Name *string `pulumi:"name"`
}

// The set of arguments for constructing a ProductType resource.
type ProductTypeArgs struct {
	// [Product attribute fefinition](https://docs.commercetools.com/api/projects/productTypes#attributedefinition)
	Attributes  ProductTypeAttributeArrayInput
	Description pulumi.StringPtrInput
	// User-specific unique identifier for the product type (max. 256 characters)
	Key  pulumi.StringPtrInput
	Name pulumi.StringPtrInput
}

func (ProductTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*productTypeArgs)(nil)).Elem()
}

type ProductTypeInput interface {
	pulumi.Input

	ToProductTypeOutput() ProductTypeOutput
	ToProductTypeOutputWithContext(ctx context.Context) ProductTypeOutput
}

func (*ProductType) ElementType() reflect.Type {
	return reflect.TypeOf((*ProductType)(nil))
}

func (i *ProductType) ToProductTypeOutput() ProductTypeOutput {
	return i.ToProductTypeOutputWithContext(context.Background())
}

func (i *ProductType) ToProductTypeOutputWithContext(ctx context.Context) ProductTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProductTypeOutput)
}

func (i *ProductType) ToProductTypePtrOutput() ProductTypePtrOutput {
	return i.ToProductTypePtrOutputWithContext(context.Background())
}

func (i *ProductType) ToProductTypePtrOutputWithContext(ctx context.Context) ProductTypePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProductTypePtrOutput)
}

type ProductTypePtrInput interface {
	pulumi.Input

	ToProductTypePtrOutput() ProductTypePtrOutput
	ToProductTypePtrOutputWithContext(ctx context.Context) ProductTypePtrOutput
}

type productTypePtrType ProductTypeArgs

func (*productTypePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ProductType)(nil))
}

func (i *productTypePtrType) ToProductTypePtrOutput() ProductTypePtrOutput {
	return i.ToProductTypePtrOutputWithContext(context.Background())
}

func (i *productTypePtrType) ToProductTypePtrOutputWithContext(ctx context.Context) ProductTypePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProductTypePtrOutput)
}

// ProductTypeArrayInput is an input type that accepts ProductTypeArray and ProductTypeArrayOutput values.
// You can construct a concrete instance of `ProductTypeArrayInput` via:
//
//          ProductTypeArray{ ProductTypeArgs{...} }
type ProductTypeArrayInput interface {
	pulumi.Input

	ToProductTypeArrayOutput() ProductTypeArrayOutput
	ToProductTypeArrayOutputWithContext(context.Context) ProductTypeArrayOutput
}

type ProductTypeArray []ProductTypeInput

func (ProductTypeArray) ElementType() reflect.Type {
	return reflect.TypeOf(([]*ProductType)(nil))
}

func (i ProductTypeArray) ToProductTypeArrayOutput() ProductTypeArrayOutput {
	return i.ToProductTypeArrayOutputWithContext(context.Background())
}

func (i ProductTypeArray) ToProductTypeArrayOutputWithContext(ctx context.Context) ProductTypeArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProductTypeArrayOutput)
}

// ProductTypeMapInput is an input type that accepts ProductTypeMap and ProductTypeMapOutput values.
// You can construct a concrete instance of `ProductTypeMapInput` via:
//
//          ProductTypeMap{ "key": ProductTypeArgs{...} }
type ProductTypeMapInput interface {
	pulumi.Input

	ToProductTypeMapOutput() ProductTypeMapOutput
	ToProductTypeMapOutputWithContext(context.Context) ProductTypeMapOutput
}

type ProductTypeMap map[string]ProductTypeInput

func (ProductTypeMap) ElementType() reflect.Type {
	return reflect.TypeOf((map[string]*ProductType)(nil))
}

func (i ProductTypeMap) ToProductTypeMapOutput() ProductTypeMapOutput {
	return i.ToProductTypeMapOutputWithContext(context.Background())
}

func (i ProductTypeMap) ToProductTypeMapOutputWithContext(ctx context.Context) ProductTypeMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProductTypeMapOutput)
}

type ProductTypeOutput struct {
	*pulumi.OutputState
}

func (ProductTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ProductType)(nil))
}

func (o ProductTypeOutput) ToProductTypeOutput() ProductTypeOutput {
	return o
}

func (o ProductTypeOutput) ToProductTypeOutputWithContext(ctx context.Context) ProductTypeOutput {
	return o
}

func (o ProductTypeOutput) ToProductTypePtrOutput() ProductTypePtrOutput {
	return o.ToProductTypePtrOutputWithContext(context.Background())
}

func (o ProductTypeOutput) ToProductTypePtrOutputWithContext(ctx context.Context) ProductTypePtrOutput {
	return o.ApplyT(func(v ProductType) *ProductType {
		return &v
	}).(ProductTypePtrOutput)
}

type ProductTypePtrOutput struct {
	*pulumi.OutputState
}

func (ProductTypePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ProductType)(nil))
}

func (o ProductTypePtrOutput) ToProductTypePtrOutput() ProductTypePtrOutput {
	return o
}

func (o ProductTypePtrOutput) ToProductTypePtrOutputWithContext(ctx context.Context) ProductTypePtrOutput {
	return o
}

type ProductTypeArrayOutput struct{ *pulumi.OutputState }

func (ProductTypeArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ProductType)(nil))
}

func (o ProductTypeArrayOutput) ToProductTypeArrayOutput() ProductTypeArrayOutput {
	return o
}

func (o ProductTypeArrayOutput) ToProductTypeArrayOutputWithContext(ctx context.Context) ProductTypeArrayOutput {
	return o
}

func (o ProductTypeArrayOutput) Index(i pulumi.IntInput) ProductTypeOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ProductType {
		return vs[0].([]ProductType)[vs[1].(int)]
	}).(ProductTypeOutput)
}

type ProductTypeMapOutput struct{ *pulumi.OutputState }

func (ProductTypeMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]ProductType)(nil))
}

func (o ProductTypeMapOutput) ToProductTypeMapOutput() ProductTypeMapOutput {
	return o
}

func (o ProductTypeMapOutput) ToProductTypeMapOutputWithContext(ctx context.Context) ProductTypeMapOutput {
	return o
}

func (o ProductTypeMapOutput) MapIndex(k pulumi.StringInput) ProductTypeOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) ProductType {
		return vs[0].(map[string]ProductType)[vs[1].(string)]
	}).(ProductTypeOutput)
}

func init() {
	pulumi.RegisterOutputType(ProductTypeOutput{})
	pulumi.RegisterOutputType(ProductTypePtrOutput{})
	pulumi.RegisterOutputType(ProductTypeArrayOutput{})
	pulumi.RegisterOutputType(ProductTypeMapOutput{})
}
