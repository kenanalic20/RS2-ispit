// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'favorite.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

FavoriteIB200116 _$FavoriteIB200116FromJson(Map<String, dynamic> json) =>
    FavoriteIB200116(
      id: (json['id'] as num?)?.toInt() ?? 0,
      productId: (json['productId'] as num?)?.toInt(),
      userId: (json['userId'] as num?)?.toInt(),
      addedAt: json['addedAt'] == null
          ? null
          : DateTime.parse(json['addedAt'] as String),
      product: json['product'] == null
          ? null
          : Product.fromJson(json['product'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$FavoriteIB200116ToJson(FavoriteIB200116 instance) =>
    <String, dynamic>{
      'id': instance.id,
      'productId': instance.productId,
      'product': instance.product,
      'userId': instance.userId,
      'addedAt': instance.addedAt?.toIso8601String(),
    };
