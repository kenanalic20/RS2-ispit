// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'cart_event.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

CartEvent _$CartEventFromJson(Map<String, dynamic> json) => CartEvent(
      id: (json['id'] as num?)?.toInt() ?? 0,
      cartId: (json['cartId'] as num?)?.toInt(),
      eventType: json['eventType'] as String?,
      cartItemId: (json['cartItemId'] as num?)?.toInt(),
      createdAt: json['createdAt'] == null
          ? null
          : DateTime.parse(json['createdAt'] as String),
      productPrice: (json['productPrice'] as num?)?.toDouble(),
      productName: json['productName'] as String?,
      newQuantity: (json['newQuantity'] as num?)?.toInt(),
    );

Map<String, dynamic> _$CartEventToJson(CartEvent instance) => <String, dynamic>{
      'id': instance.id,
      'cartId': instance.cartId,
      'eventType': instance.eventType,
      'cartItemId': instance.cartItemId,
      'createdAt': instance.createdAt?.toIso8601String(),
      'productPrice': instance.productPrice,
      'productName': instance.productName,
      'newQuantity': instance.newQuantity,
    };
