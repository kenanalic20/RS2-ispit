import 'package:ecommerce_mobile/model/product.dart';
import 'package:json_annotation/json_annotation.dart';

part 'cart_item_custom.g.dart'; // Must have this

@JsonSerializable(explicitToJson: true) // Add explicitToJson: true
class CartItemCustom {
  final int? id;
  final int? cartId;
  final int productId;
  final int quantity;
  final Product? product;
  final DateTime? addedAt;
  final DateTime? updatedAt;

  CartItemCustom({
    this.id,
    this.cartId,
    required this.productId,
    required this.quantity,
    this.product,
    this.addedAt,
    this.updatedAt,
  });

  int get count => quantity;

  factory CartItemCustom.fromJson(Map<String, dynamic> json) =>
      _$CartItemCustomFromJson(json);
  Map<String, dynamic> toJson() => _$CartItemCustomToJson(this);
}
