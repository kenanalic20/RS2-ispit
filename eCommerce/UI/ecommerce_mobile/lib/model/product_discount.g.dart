// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'product_discount.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

ProductDiscount _$ProductDiscountFromJson(Map<String, dynamic> json) =>
    ProductDiscount(
      id: (json['id'] as num?)?.toInt() ?? 0,
      productId: (json['productId'] as num?)?.toInt(),
      product: json['product'] == null
          ? null
          : Product.fromJson(json['product'] as Map<String, dynamic>),
      discount: (json['discount'] as num?)?.toDouble() ?? 0.0,
      beganAt: json['beganAt'] == null
          ? null
          : DateTime.parse(json['beganAt'] as String),
      validUntil: json['validUntil'] == null
          ? null
          : DateTime.parse(json['validUntil'] as String),
    );

Map<String, dynamic> _$ProductDiscountToJson(ProductDiscount instance) =>
    <String, dynamic>{
      'id': instance.id,
      'productId': instance.productId,
      'product': instance.product,
      'discount': instance.discount,
      'beganAt': instance.beganAt?.toIso8601String(),
      'validUntil': instance.validUntil?.toIso8601String(),
    };
