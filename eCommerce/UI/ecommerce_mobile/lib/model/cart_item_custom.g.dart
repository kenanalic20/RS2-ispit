// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'cart_item_custom.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

CartItemCustom _$CartItemCustomFromJson(Map<String, dynamic> json) =>
    CartItemCustom(
      id: (json['id'] as num?)?.toInt(),
      cartId: (json['cartId'] as num?)?.toInt(),
      productId: (json['productId'] as num).toInt(),
      quantity: (json['quantity'] as num).toInt(),
      product: json['product'] == null
          ? null
          : Product.fromJson(json['product'] as Map<String, dynamic>),
      addedAt: json['addedAt'] == null
          ? null
          : DateTime.parse(json['addedAt'] as String),
      updatedAt: json['updatedAt'] == null
          ? null
          : DateTime.parse(json['updatedAt'] as String),
    );

Map<String, dynamic> _$CartItemCustomToJson(CartItemCustom instance) =>
    <String, dynamic>{
      'id': instance.id,
      'cartId': instance.cartId,
      'productId': instance.productId,
      'quantity': instance.quantity,
      'product': instance.product?.toJson(),
      'addedAt': instance.addedAt?.toIso8601String(),
      'updatedAt': instance.updatedAt?.toIso8601String(),
    };
