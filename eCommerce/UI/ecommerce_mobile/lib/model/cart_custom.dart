import 'package:ecommerce_mobile/model/cart_item_custom.dart';
import 'package:json_annotation/json_annotation.dart';

part 'cart_custom.g.dart';

@JsonSerializable(explicitToJson: true) // Add explicitToJson: true
class CartCustom {
  final int? id;
  final int? userId;
  final DateTime? createdAt;
  final DateTime? updatedAt;
  List<CartItemCustom> cartItems;
  final bool isCheckout;

  CartCustom(
      {this.id,
      this.userId,
      this.createdAt,
      this.updatedAt,
      List<CartItemCustom>? cartItems,
      this.isCheckout = false})
      : cartItems = cartItems ?? [];

  factory CartCustom.fromJson(Map<String, dynamic> json) =>
      _$CartCustomFromJson(json);
  Map<String, dynamic> toJson() => _$CartCustomToJson(this);
}
