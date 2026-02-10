// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'cart_custom.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

CartCustom _$CartCustomFromJson(Map<String, dynamic> json) => CartCustom(
      id: (json['id'] as num?)?.toInt(),
      userId: (json['userId'] as num?)?.toInt(),
      createdAt: json['createdAt'] == null
          ? null
          : DateTime.parse(json['createdAt'] as String),
      updatedAt: json['updatedAt'] == null
          ? null
          : DateTime.parse(json['updatedAt'] as String),
      cartItems: (json['cartItems'] as List<dynamic>?)
          ?.map((e) => CartItemCustom.fromJson(e as Map<String, dynamic>))
          .toList(),
    );

Map<String, dynamic> _$CartCustomToJson(CartCustom instance) =>
    <String, dynamic>{
      'id': instance.id,
      'userId': instance.userId,
      'createdAt': instance.createdAt?.toIso8601String(),
      'updatedAt': instance.updatedAt?.toIso8601String(),
      'cartItems': instance.cartItems.map((e) => e.toJson()).toList(),
    };
