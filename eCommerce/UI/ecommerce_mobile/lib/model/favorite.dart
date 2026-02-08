import 'package:ecommerce_mobile/model/product.dart';
import 'package:json_annotation/json_annotation.dart';
import 'asset.dart';

part 'favorite.g.dart';

@JsonSerializable()
class FavoriteIB200116 {
  final int id;
  final int? productId;
  final Product? product;
  final int? userId;
  final DateTime? addedAt;

  FavoriteIB200116(
      {this.id = 0, this.productId, this.userId, this.addedAt, this.product});

  factory FavoriteIB200116.fromJson(Map<String, dynamic> json) =>
      _$FavoriteIB200116FromJson(json);

  Map<String, dynamic> toJson() => _$FavoriteIB200116ToJson(this);
}
